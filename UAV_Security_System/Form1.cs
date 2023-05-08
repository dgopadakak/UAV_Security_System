using System;
using System.IO.Ports;
using System.Threading;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace UAV_Security_System
{
    public partial class Form1 : Form
    {
        private SerialPort? serialPortServer;
        private SerialPort? serialPortSensor;
        private List<Sensor?> sensorsList = new List<Sensor?>();
        private string inStringServer = "";
        private string inStringSensor = "";
        private string tempName;
        private float tempVol;
        private int tempNum;
        private int selectedSensorNum = -1;

        public Form1()
        {
            InitializeComponent();

            update_com_ports();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPortServer.Write("{\"type\":\"get_all_sensors\"}#");
        }

        private void button_update_com_Click(object sender, EventArgs e)
        {
            update_com_ports();
        }

        private void update_com_ports()
        {
            comboBox1.Items.Clear();
            comboBox_sensor_com.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                comboBox_sensor_com.Items.Add(port);
            }
            comboBox_sensor_com.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox_sensor_com.Text = "Выберите COM порт";
            comboBox1.Text = "Выберите COM порт";
        }

        private void button_accept_com_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                try
                {
                    string? selected_com_port = comboBox1.SelectedItem.ToString();
                    label_selected_com.Text = "Выбранный порт: " + selected_com_port;
                    serialPortServer = new SerialPort(selected_com_port, 115200);
                    serialPortServer.Open();
                    serialPortServer.DataReceived += new SerialDataReceivedEventHandler(ServerDataReceivedHandler);
                    Thread.Sleep(1100);
                    serialPortServer.Write("{\"type\":\"get_all_sensors\"}#");

                    comboBox1.Visible = false;
                    button_update_com1.Visible = false;
                    button_accept_com.Visible = false;
                    dataGridViewSensors.Visible = true;
                    button1.Visible = true;
                    label_selected_com.Visible = true;
                    button_del_sensor.Visible = true;
                    button_del_all_sensors.Visible = true;
                    button_edit_sensor.Visible = true;
                    button_add_sensor.Visible = true;
                    button_go_sleep_unsleep.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Неполадки с выбранным портом!");
                }
            }
            else
            {
                MessageBox.Show("Выберите COM порт!");
            }
        }

        private void ServerDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            inStringServer += sp.ReadExisting();
            Parse_server_data();
        }

        private void Parse_server_data()
        {
            while (inStringServer.IndexOf("#") != -1)
            {
                String command = inStringServer.Substring(0, inStringServer.IndexOf("#"));
                inStringServer = inStringServer.Substring(inStringServer.IndexOf("#") + 1);

                if (command.IndexOf("$") != -1)         // Пришли данные о всех датчиках
                {
                    int num = Int32.Parse(command.Substring(0, command.IndexOf("$")));
                    command = command.Substring(command.IndexOf("$") + 1);
                    dataGridViewSensors.Invoke(() => dataGridViewSensors.Rows.Clear());
                    sensorsList.Clear();
                    for (int i = 0; i < num; i++)
                    {
                        string json_doc = command.Substring(0, command.IndexOf("$"));
                        json_doc = Regex.Replace(json_doc, @"[\u0000-\u0008\u000A-\u001F\u0100-\uFFFF]", "");
                        sensorsList.Add(JsonConvert.DeserializeObject<Sensor>(json_doc));
                        command = command.Substring(command.IndexOf("$") + 1);

                        dataGridViewSensors.Invoke(() => dataGridViewSensors.Rows.Add(sensorsList[i].getDataForDataGrid()));
                        dataGridViewSensors.Invoke(() => dataGridViewSensors.Rows[i].Cells[6].Style.BackColor = sensorsList[i].GetColorForBatteryFlag());
                        dataGridViewSensors.Invoke(() => dataGridViewSensors.Rows[i].Cells[7].Style.BackColor = sensorsList[i].GetColorForConnectionFlag());
                    }
                }

                if (command == "OK+ADD")     // Пришел ответ о добавлении датчика
                {
                    do_info_toast("АУО успешно добавлено!", "Осталось вывести его из спящего режима");
                    serialPortServer.Write("{\"type\":\"get_all_sensors\"}#");
                }

                if (command == "OK+DEL")
                {
                    do_info_toast("АУО успешно удалено!", "Теперь его можно добавить заново");
                }

                if (command == "OK+DELALL")
                {
                    do_info_toast("Все АУО успешно удалены!", "Теперь можно добавить новые");
                }

                if (command == "OK+EDIT")
                {
                    do_info_toast("АУО успешно изменено!", "Теперь при его срабатывании БПЛА полетит по новым координатам");
                }

                if (command.IndexOf("WARNING+") != -1)
                {
                    string name_of_warning_sensor = command.Substring(command.IndexOf("+") + 1);
                    int num_of_warning_sensor = -1;
                    int index_of_warning_sensor = -1;
                    for (int i = 0; i < sensorsList.Count; i++)
                    {
                        if (sensorsList[i].getName() == name_of_warning_sensor)
                        {
                            num_of_warning_sensor = sensorsList[i].getNum();
                            index_of_warning_sensor = i;
                            break;
                        }
                    }
                    dataGridViewSensors.Rows[index_of_warning_sensor].Selected = true;
                    do_warning_toast("Внимание! Сработало АУО!", "Сработало АУО под номером " + num_of_warning_sensor + ". Координаты цели загружены в БПЛА");
                    MessageBox.Show("Внимание! Сработало АУО под номером " + num_of_warning_sensor + ". Координаты цели загружены в БПЛА. Произведите взлет и переключите БПЛА в режим полета по точкам.");
                }

                if (command.IndexOf("WARNINGERROR+") != -1)
                {
                    string name_of_warning_sensor = command.Substring(command.IndexOf("+") + 1);
                    int num_of_warning_sensor = -1;
                    int index_of_warning_sensor = -1;
                    for (int i = 0; i < sensorsList.Count; i++)
                    {
                        if (sensorsList[i].getName() == name_of_warning_sensor)
                        {
                            num_of_warning_sensor = sensorsList[i].getNum();
                            index_of_warning_sensor = i;
                            break;
                        }
                    }
                    dataGridViewSensors.Rows[index_of_warning_sensor].Selected = true;
                    do_error_toast("Внимание! Ошибка загрузки координат цели!", "Сработало АУО под номером " + num_of_warning_sensor + ", но координаты цели НЕ загружены в БПЛА");
                    MessageBox.Show("Внимание! Ошибка загрузки координат цели! Сработало АУО под номером " + num_of_warning_sensor + ", но координаты цели НЕ загружены в БПЛА. Произведите попытку взлета и полета к цели в ручном режиме.");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPortServer != null)
            {
                if (serialPortServer.IsOpen)
                {
                    serialPortServer.Close();
                }
            }
            if (serialPortSensor != null)
            {
                if (serialPortSensor.IsOpen)
                {
                    serialPortSensor.Close();
                }
            }
        }

        private void button_add_sensor_Click(object sender, EventArgs e)
        {
            update_com_ports();
            button_add_sensor.Visible = false;
            groupBox_new_sensor.Visible = true;
        }

        private void button_accept_sensor_com_Click(object sender, EventArgs e)
        {
            if (comboBox_sensor_com.SelectedIndex != -1)
            {
                try
                {
                    comboBox_sensor_com.Enabled = false;
                    button_update_com2.Enabled = false;
                    button_accept_sensor_com.Enabled = false;
                    label_sensor_loading_warning.Visible = true;

                    serialPortSensor = new SerialPort(comboBox_sensor_com.SelectedItem.ToString(), 9600);
                    serialPortSensor.Open();
                    serialPortSensor.DataReceived += new SerialDataReceivedEventHandler(SensorDataReceivedHandler);
                    Thread.Sleep(1500);
                    serialPortSensor.Write("{\"type\":\"get_data_for_connect\"}#");
                }
                catch
                {
                    MessageBox.Show("Неполадки с выбранным портом!");
                }
            }
            else
            {
                MessageBox.Show("Выберите COM порт!");
            }
        }

        private void SensorDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            inStringSensor += sp.ReadExisting();
            Parse_sensor_data();
        }

        private void Parse_sensor_data()
        {
            while (inStringSensor.IndexOf("#") != -1)
            {
                String command = inStringSensor.Substring(0, inStringSensor.IndexOf("#"));
                inStringSensor = inStringSensor.Substring(inStringSensor.IndexOf("#") + 1);

                if (command.IndexOf("$") != -1)         // Пришли данные имени и напряжения датчика
                {
                    tempName = command.Substring(0, command.IndexOf("$"));
                    command = command.Substring(command.IndexOf("$") + 1);
                    command = command.Replace(".", ",");
                    tempVol = float.Parse(command.Substring(0, command.IndexOf("$")));

                    bool isSensorExists = false;
                    for (int i = 0; i < sensorsList.Count; i++)
                    {
                        if (sensorsList[i].getName() == tempName.Substring(0, 7))
                        {
                            isSensorExists = true;
                            break;
                        }
                    }

                    if (!isSensorExists)
                    {
                        bool numFound = false;
                        tempNum = 0;
                        while (!numFound)
                        {
                            numFound = true;
                            tempNum++;
                            for (int i = 0; i < sensorsList.Count; i++)
                            {
                                if (sensorsList[i].getNum() == tempNum)
                                {
                                    numFound = false;
                                }
                            }
                        }

                        label_new_sensor_name.Invoke(() => label_new_sensor_name.Text = "Имя: " + tempName.Substring(0, 7) + "; Версия: " + tempName.Substring(7));
                        label_num_of_new_sensor.Invoke(() => label_num_of_new_sensor.Text = "Номер: " + tempNum);
                        label_new_sensor_vol.Invoke(() => label_new_sensor_vol.Text = "Напряжение: " + tempVol.ToString() + "В");
                        label_new_sensor_name.Invoke(() => label_new_sensor_name.Visible = true);
                        label_num_of_new_sensor.Invoke(() => label_num_of_new_sensor.Visible = true);
                        label_new_sensor_vol.Invoke(() => label_new_sensor_vol.Visible = true);

                        label_sensor_loading_warning.Invoke(() => label_sensor_loading_warning.Visible = false);

                        label_lat_new.Invoke(() => label_lat_new.Visible = true);
                        label_lon_new.Invoke(() => label_lon_new.Visible = true);
                        textBox_lat_new.Invoke(() => textBox_lat_new.Visible = true);
                        textBox_lon_new.Invoke(() => textBox_lon_new.Visible = true);

                        button_new_sensor_done.Invoke(() => button_new_sensor_done.Visible = true);

                        //tempName = tempName.Substring(0, 7);
                    }
                    else
                    {
                        MessageBox.Show("Это АУО уже есть в системе! Для изменения его параметров используйте соответствующий функционал!");
                    }
                }

                if (command.IndexOf("OK+") != -1)     // Пришел ответ на установку номера
                {
                    if (command == "OK+" + tempNum)
                    {
                        do_info_toast("Установка номера АУО прошла успешно!", "Теперь АУО готово к общению");
                    }
                }
            }
        }

        private void button_new_sensor_done_Click(object sender, EventArgs e)
        {
            try
            {
                float lat_float = float.Parse(textBox_lat_new.Text);
                float lon_float = float.Parse(textBox_lon_new.Text);
                long lat_long = (long)(lat_float * 10000000);
                long lon_long = (long)(lon_float * 10000000);
                if (lat_float >= -90 && lat_float <= 90 && lon_float >= -180 && lon_float <= 180)
                {
                    serialPortSensor.Write("{\"type\":\"sleep\",\"name\":\"" + tempName + "\"}#");
                    serialPortSensor.Write("{\"type\":\"set_num\",\"num\":" + tempNum + "}#");
                    Sensor tempSensor = new Sensor(tempName, tempNum, lat_long, lon_long, true, tempVol, 0, 0);
                    serialPortServer.Write("{\"type\":\"add_sensor\"," + tempSensor.getStringForAdd() + "}#");
                    Clear_the_add_sensor_form();
                }
                else
                {
                    MessageBox.Show("lat может принимать значения от -90 до 90; lon - от -180 до 180!");
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка добавления! Проверьте введенные данные!");
            }
        }

        private void button_cancel_connect_sensor_Click(object sender, EventArgs e)
        {
            Clear_the_add_sensor_form();
        }

        private void Clear_the_add_sensor_form()
        {
            if (serialPortSensor != null)
            {
                if (serialPortSensor.IsOpen)
                {
                    serialPortSensor.Close();
                }
            }
            comboBox_sensor_com.SelectedIndex = -1;
            comboBox_sensor_com.Text = "Выберите COM порт";
            button_add_sensor.Visible = true;
            groupBox_new_sensor.Visible = false;
            comboBox_sensor_com.Enabled = true;
            button_update_com2.Enabled = true;
            button_accept_sensor_com.Enabled = true;
            label_sensor_loading_warning.Visible = false;
            label_new_sensor_name.Visible = false;
            label_num_of_new_sensor.Visible = false;
            label_new_sensor_vol.Visible = false;
            label_lat_new.Visible = false;
            label_lon_new.Visible = false;
            textBox_lat_new.Visible = false;
            textBox_lon_new.Visible = false;
            button_new_sensor_done.Visible = false;
        }

        private void dataGridViewSensors_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSensors.SelectedRows.Count > 0)
            {
                button_del_sensor.Enabled = true;
                button_edit_sensor.Enabled = true;
            }
            else
            {
                button_del_sensor.Enabled = false;
                button_edit_sensor.Enabled = false;
            }
        }

        private void button_del_sensor_Click(object sender, EventArgs e)
        {
            if (dataGridViewSensors.SelectedRows.Count > 0)
            {
                int selectedSensorNum = Int32.Parse(dataGridViewSensors.CurrentRow.Cells[0].Value.ToString());
                serialPortServer.Write("{\"type\":\"del_sensor\",\"num\":" + selectedSensorNum + "}#");
                serialPortServer.Write("{\"type\":\"get_all_sensors\"}#");
            }
        }

        private void button_edit_sensor_Click(object sender, EventArgs e)
        {
            if (dataGridViewSensors.SelectedRows.Count > 0)
            {
                selectedSensorNum = Int32.Parse(dataGridViewSensors.CurrentRow.Cells[0].Value.ToString());
                Sensor tempSensor = sensorsList[0];
                for (int i = 0; i < sensorsList.Count; i++)
                {
                    if (sensorsList[i].getNum() == selectedSensorNum)
                    {
                        tempSensor = sensorsList[i];
                        break;
                    }
                }
                label_edit_sensor_name.Text = "Имя: " + tempSensor.getName();
                label_edit_sensor_num.Text = "Номер: " + tempSensor.getNum();
                textBox_lat_edit.Text = (tempSensor.getLat() / 10000000f).ToString("##.################");
                textBox_lon_edit.Text = (tempSensor.getLon() / 10000000f).ToString("###.################");
                groupBox_edit_sensor.Visible = true;
                button_edit_sensor.Enabled = false;
                button_del_sensor.Enabled = false;
                button_del_all_sensors.Enabled = false;
            }
        }

        private void button_edit_sensor_done_Click(object sender, EventArgs e)
        {
            float lat_float = float.Parse(textBox_lat_edit.Text);
            float lon_float = float.Parse(textBox_lon_edit.Text);
            long lat_long = (long)(lat_float * 10000000);
            long lon_long = (long)(lon_float * 10000000);
            if (lat_float >= -90 && lat_float <= 90 && lon_float >= -180 && lon_float <= 180)
            {
                serialPortServer.Write("{\"type\":\"edit_sensor\",\"num\":" + selectedSensorNum + ",\"lat\":" + lat_long + ",\"lon\":" + lon_long + "}#");
                serialPortServer.Write("{\"type\":\"get_all_sensors\"}#");

                groupBox_edit_sensor.Visible = false;
                button_edit_sensor.Enabled = true;
                button_del_sensor.Enabled = true;
                button_del_all_sensors.Enabled = true;
            }
            else
            {
                MessageBox.Show("lat может принимать значения от -90 до 90; lon - от -180 до 180!");
            }
        }

        private void button_cancel_edit_sensor_Click(object sender, EventArgs e)
        {
            groupBox_edit_sensor.Visible = false;
            button_edit_sensor.Enabled = true;
            button_del_sensor.Enabled = true;
            button_del_all_sensors.Enabled = true;
        }

        private void button_del_all_sensors_Click(object sender, EventArgs e)
        {
            serialPortServer.Write("{\"type\":\"del_all_sensors\"}#");
            serialPortServer.Write("{\"type\":\"get_all_sensors\"}#");

        }

        private void do_info_toast(string title, string text)
        {
            NotifyIcon NI = new NotifyIcon();
            NI.BalloonTipText = text;
            NI.BalloonTipTitle = title;
            NI.BalloonTipIcon = ToolTipIcon.Info;
            NI.Icon = Icon;
            NI.Visible = true;
            NI.ShowBalloonTip(2);
        }

        private void do_warning_toast(string title, string text)
        {
            NotifyIcon NI = new NotifyIcon();
            NI.BalloonTipText = text;
            NI.BalloonTipTitle = title;
            NI.BalloonTipIcon= ToolTipIcon.Warning;
            NI.Icon = Icon;
            NI.Visible = true;
            NI.ShowBalloonTip(2);
        }

        private void do_error_toast(string title, string text)
        {
            NotifyIcon NI = new NotifyIcon();
            NI.BalloonTipText = text;
            NI.BalloonTipTitle = title;
            NI.BalloonTipIcon = ToolTipIcon.Error;
            NI.Icon = Icon;
            NI.Visible = true;
            NI.ShowBalloonTip(2);
        }
    }
}