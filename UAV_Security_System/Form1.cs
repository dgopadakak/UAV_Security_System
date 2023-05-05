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
        private string inStringSensor= "";

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
                    serialPortServer.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    Thread.Sleep(1000);
                    serialPortServer.Write("{\"type\":\"get_all_sensors\"}#");
                    comboBox1.Visible = false;
                    button_update_com1.Visible = false;
                    button_accept_com.Visible = false;
                    listBox1.Visible = true;
                    button1.Visible = true;
                    label_selected_com.Visible = true;
                    groupBox_new_sensor.Visible = true;
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

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            inStringServer += sp.ReadExisting();
            Parse_data();
        }

        private void Parse_data()
        {
            if (inStringServer.IndexOf("#") != -1)
            {
                String command = inStringServer.Substring(0, inStringServer.IndexOf("#"));
                inStringServer = inStringServer.Substring(inStringServer.IndexOf("#") + 1);

                if (command.IndexOf("$") != -1)         // Пришли данные о датчиках
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
            button_add_sensor.Enabled = false;
            comboBox_sensor_com.Visible = true;
            button_update_com2.Visible = true;
            button_accept_sensor_com.Visible = true;
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
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Выберите COM порт!");
            }
        }

        private void button_cancel_connect_sensor_Click(object sender, EventArgs e)
        {

        }
    }
}