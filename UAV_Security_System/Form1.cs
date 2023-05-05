using System;
using System.IO.Ports;
using System.Threading;
using System.Text.Json;
using Newtonsoft.Json;

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
        }

        private void button_accept_com_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                try
                {
                    string? selected_com_port = comboBox1.SelectedItem.ToString();
                    label_selected_com.Text = "Выбранный порт: " + selected_com_port;
                    serialPortServer = new SerialPort(selected_com_port, 9600);
                    serialPortServer.Open();
                    serialPortServer.DataReceived += new SerialDataReceivedEventHandler(ServerDataReceivedHandler);
                    Thread.Sleep(1100);
                    serialPortServer.Write("{\"type\":\"get_all_sensors\"}#");

                    comboBox1.Visible = false;
                    button_update_com1.Visible = false;
                    button_accept_com.Visible = false;
                    listBox1.Visible = true;
                    button1.Visible = true;
                    label_selected_com.Visible = true;
                    button_add_sensor.Visible = true;
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
            if (inStringServer.IndexOf("#") != -1)
            {
                String command = inStringServer.Substring(0, inStringServer.IndexOf("#"));
                inStringServer = inStringServer.Substring(inStringServer.IndexOf("#") + 1);

                if (command.IndexOf("$") != -1)         // Пришли данные о всех датчиках
                {
                    int num = Int32.Parse(command.Substring(0, command.IndexOf("$")));
                    command = command.Substring(command.IndexOf("$") + 1);
                    listBox1.Invoke(listBox1.Items.Clear);
                    for (int i = 0; i < num; i++)
                    {
                        string json_doc = command.Substring(0, command.IndexOf("$"));
                        json_doc = json_doc.Replace("\u0001", "");
                        sensorsList.Add(JsonConvert.DeserializeObject<Sensor>(json_doc));
                        command = command.Substring(command.IndexOf("$") + 1);

                        listBox1.Invoke(() => listBox1.Items.Add(sensorsList[i].getString()));
                    }
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
        }

        private void button_add_sensor_Click(object sender, EventArgs e)
        {
            update_com_ports();
            button_add_sensor.Visible = false;
            groupBox_new_sensor.Visible = true;
            button_cancel_connect_sensor.Visible = true;
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
            if (inStringSensor.IndexOf("#") != -1)
            {
                String command = inStringSensor.Substring(0, inStringSensor.IndexOf("#"));
                inStringSensor = inStringSensor.Substring(inStringSensor.IndexOf("#") + 1);

                if (command.IndexOf("$") != -1)         // Пришли данные имени и напряжения датчика
                {
                    tempName = command.Substring(0, command.IndexOf("$"));
                    command = command.Substring(command.IndexOf("$") + 1);
                    command = command.Replace(".", ",");
                    tempVol = float.Parse(command.Substring(0, command.IndexOf("$")));

                    bool numFound = false;
                    int num = 0;
                    while (!numFound)
                    {
                        numFound = true;
                        num++;
                        for (int i = 0; i < sensorsList.Count; i++)
                        {
                            if (sensorsList[i].getNum() == num)
                            {
                                numFound = false;
                            }
                        }
                    }

                    label_new_sensor_name.Invoke(() => label_new_sensor_name.Text = "Имя: " + tempName);
                    label_num_of_new_sensor.Invoke(() => label_num_of_new_sensor.Text = "Номер: " + num);
                    label_new_sensor_vol.Invoke(() => label_new_sensor_vol.Text = "Напряжение: " + tempVol.ToString());
                    label_new_sensor_name.Invoke(() => label_new_sensor_name.Visible = true);
                    label_num_of_new_sensor.Invoke(() => label_num_of_new_sensor.Visible = true);
                    label_new_sensor_vol.Invoke(() => label_new_sensor_vol.Visible = true);

                    label_sensor_loading_warning.Invoke(() => label_sensor_loading_warning.Visible = false);

                    label_lat.Invoke(() => label_lat.Visible = true);
                    label_lon.Invoke(() => label_lon.Visible = true);
                    textBox_lat.Invoke(() => textBox_lat.Visible = true);
                    textBox_lon.Invoke(() => textBox_lon.Visible = true);

                    button_new_sensor_done.Invoke(() => button_new_sensor_done.Visible = true);
                }
            }
        }

        private void button_new_sensor_done_Click(object sender, EventArgs e)
        {

        }

        private void button_cancel_connect_sensor_Click(object sender, EventArgs e)
        {
            if (serialPortSensor != null)
            {
                if (serialPortSensor.IsOpen)
                {
                    serialPortSensor.Close();
                }
            }

        }
    }
}