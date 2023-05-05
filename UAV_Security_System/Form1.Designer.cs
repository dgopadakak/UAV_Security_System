namespace UAV_Security_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            button_update_com1 = new Button();
            button_accept_com = new Button();
            label_selected_com = new Label();
            button_add_sensor = new Button();
            comboBox_sensor_com = new ComboBox();
            button_update_com2 = new Button();
            button_accept_sensor_com = new Button();
            button_cancel_connect_sensor = new Button();
            groupBox_new_sensor = new GroupBox();
            button_new_sensor_done = new Button();
            label_num_of_new_sensor = new Label();
            label_lon = new Label();
            label_lat = new Label();
            textBox_lon = new TextBox();
            textBox_lat = new TextBox();
            label_sensor_loading_warning = new Label();
            label_new_sensor_vol = new Label();
            label_new_sensor_name = new Label();
            toolTip1 = new ToolTip(components);
            groupBox_new_sensor.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(310, 441);
            button1.Name = "button1";
            button1.Size = new Size(245, 23);
            button1.TabIndex = 0;
            button1.Text = "Запросить датчики";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(310, 101);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(245, 334);
            listBox1.TabIndex = 1;
            listBox1.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Выберите COM порт";
            // 
            // button_update_com1
            // 
            button_update_com1.Location = new Point(160, 12);
            button_update_com1.Name = "button_update_com1";
            button_update_com1.Size = new Size(75, 23);
            button_update_com1.TabIndex = 3;
            button_update_com1.Text = "Обновить";
            button_update_com1.UseVisualStyleBackColor = true;
            button_update_com1.Click += button_update_com_Click;
            // 
            // button_accept_com
            // 
            button_accept_com.Location = new Point(12, 41);
            button_accept_com.Name = "button_accept_com";
            button_accept_com.Size = new Size(142, 23);
            button_accept_com.TabIndex = 4;
            button_accept_com.Text = "Подтвердить";
            button_accept_com.UseVisualStyleBackColor = true;
            button_accept_com.Click += button_accept_com_Click;
            // 
            // label_selected_com
            // 
            label_selected_com.AutoSize = true;
            label_selected_com.Location = new Point(12, 16);
            label_selected_com.Name = "label_selected_com";
            label_selected_com.Size = new Size(31, 15);
            label_selected_com.TabIndex = 5;
            label_selected_com.Text = "com";
            label_selected_com.Visible = false;
            // 
            // button_add_sensor
            // 
            button_add_sensor.Location = new Point(730, 16);
            button_add_sensor.Name = "button_add_sensor";
            button_add_sensor.Size = new Size(142, 23);
            button_add_sensor.TabIndex = 6;
            button_add_sensor.Text = "Добавить АУО";
            button_add_sensor.UseVisualStyleBackColor = true;
            button_add_sensor.Visible = false;
            button_add_sensor.Click += button_add_sensor_Click;
            // 
            // comboBox_sensor_com
            // 
            comboBox_sensor_com.FormattingEnabled = true;
            comboBox_sensor_com.Location = new Point(102, 23);
            comboBox_sensor_com.Name = "comboBox_sensor_com";
            comboBox_sensor_com.Size = new Size(142, 23);
            comboBox_sensor_com.TabIndex = 7;
            comboBox_sensor_com.Text = "Выберите COM порт";
            // 
            // button_update_com2
            // 
            button_update_com2.Location = new Point(21, 23);
            button_update_com2.Name = "button_update_com2";
            button_update_com2.Size = new Size(75, 23);
            button_update_com2.TabIndex = 8;
            button_update_com2.Text = "Обновить";
            button_update_com2.UseVisualStyleBackColor = true;
            button_update_com2.Click += button_update_com_Click;
            // 
            // button_accept_sensor_com
            // 
            button_accept_sensor_com.Location = new Point(102, 52);
            button_accept_sensor_com.Name = "button_accept_sensor_com";
            button_accept_sensor_com.Size = new Size(142, 23);
            button_accept_sensor_com.TabIndex = 9;
            button_accept_sensor_com.Text = "Подтвердить";
            button_accept_sensor_com.UseVisualStyleBackColor = true;
            button_accept_sensor_com.Click += button_accept_sensor_com_Click;
            // 
            // button_cancel_connect_sensor
            // 
            button_cancel_connect_sensor.Location = new Point(102, 211);
            button_cancel_connect_sensor.Name = "button_cancel_connect_sensor";
            button_cancel_connect_sensor.Size = new Size(142, 23);
            button_cancel_connect_sensor.TabIndex = 10;
            button_cancel_connect_sensor.Text = "Отмена";
            button_cancel_connect_sensor.UseVisualStyleBackColor = true;
            button_cancel_connect_sensor.Visible = false;
            button_cancel_connect_sensor.Click += button_cancel_connect_sensor_Click;
            // 
            // groupBox_new_sensor
            // 
            groupBox_new_sensor.Controls.Add(button_new_sensor_done);
            groupBox_new_sensor.Controls.Add(label_num_of_new_sensor);
            groupBox_new_sensor.Controls.Add(label_lon);
            groupBox_new_sensor.Controls.Add(label_lat);
            groupBox_new_sensor.Controls.Add(textBox_lon);
            groupBox_new_sensor.Controls.Add(textBox_lat);
            groupBox_new_sensor.Controls.Add(label_sensor_loading_warning);
            groupBox_new_sensor.Controls.Add(label_new_sensor_vol);
            groupBox_new_sensor.Controls.Add(label_new_sensor_name);
            groupBox_new_sensor.Controls.Add(button_cancel_connect_sensor);
            groupBox_new_sensor.Controls.Add(comboBox_sensor_com);
            groupBox_new_sensor.Controls.Add(button_accept_sensor_com);
            groupBox_new_sensor.Controls.Add(button_update_com2);
            groupBox_new_sensor.Location = new Point(606, 12);
            groupBox_new_sensor.Name = "groupBox_new_sensor";
            groupBox_new_sensor.Size = new Size(266, 243);
            groupBox_new_sensor.TabIndex = 11;
            groupBox_new_sensor.TabStop = false;
            groupBox_new_sensor.Text = "Добавление АУО";
            groupBox_new_sensor.Visible = false;
            // 
            // button_new_sensor_done
            // 
            button_new_sensor_done.Location = new Point(102, 182);
            button_new_sensor_done.Name = "button_new_sensor_done";
            button_new_sensor_done.Size = new Size(142, 23);
            button_new_sensor_done.TabIndex = 12;
            button_new_sensor_done.Text = "Готово";
            button_new_sensor_done.UseVisualStyleBackColor = true;
            button_new_sensor_done.Visible = false;
            button_new_sensor_done.Click += button_new_sensor_done_Click;
            // 
            // label_num_of_new_sensor
            // 
            label_num_of_new_sensor.AutoSize = true;
            label_num_of_new_sensor.Location = new Point(102, 93);
            label_num_of_new_sensor.Name = "label_num_of_new_sensor";
            label_num_of_new_sensor.Size = new Size(32, 15);
            label_num_of_new_sensor.TabIndex = 16;
            label_num_of_new_sensor.Text = "num";
            label_num_of_new_sensor.Visible = false;
            label_num_of_new_sensor.MouseEnter += LabelMouseEnter;
            // 
            // label_lon
            // 
            label_lon.AutoSize = true;
            label_lon.Location = new Point(102, 156);
            label_lon.Name = "label_lon";
            label_lon.Size = new Size(27, 15);
            label_lon.TabIndex = 15;
            label_lon.Text = "lon:";
            label_lon.Visible = false;
            // 
            // label_lat
            // 
            label_lat.AutoSize = true;
            label_lat.Location = new Point(102, 129);
            label_lat.Name = "label_lat";
            label_lat.Size = new Size(23, 15);
            label_lat.TabIndex = 14;
            label_lat.Text = "lat:";
            label_lat.Visible = false;
            // 
            // textBox_lon
            // 
            textBox_lon.Location = new Point(131, 153);
            textBox_lon.Name = "textBox_lon";
            textBox_lon.Size = new Size(113, 23);
            textBox_lon.TabIndex = 12;
            textBox_lon.Visible = false;
            // 
            // textBox_lat
            // 
            textBox_lat.Location = new Point(131, 126);
            textBox_lat.Name = "textBox_lat";
            textBox_lat.Size = new Size(113, 23);
            textBox_lat.TabIndex = 12;
            textBox_lat.Visible = false;
            // 
            // label_sensor_loading_warning
            // 
            label_sensor_loading_warning.Location = new Point(102, 108);
            label_sensor_loading_warning.Name = "label_sensor_loading_warning";
            label_sensor_loading_warning.Size = new Size(142, 68);
            label_sensor_loading_warning.TabIndex = 13;
            label_sensor_loading_warning.Text = "Если загрузка занимает много времени - нажмите \"Отмена\" и попробуйте еще раз";
            label_sensor_loading_warning.TextAlign = ContentAlignment.TopCenter;
            label_sensor_loading_warning.Visible = false;
            // 
            // label_new_sensor_vol
            // 
            label_new_sensor_vol.AutoSize = true;
            label_new_sensor_vol.Location = new Point(102, 108);
            label_new_sensor_vol.Name = "label_new_sensor_vol";
            label_new_sensor_vol.Size = new Size(23, 15);
            label_new_sensor_vol.TabIndex = 12;
            label_new_sensor_vol.Text = "vol";
            label_new_sensor_vol.Visible = false;
            // 
            // label_new_sensor_name
            // 
            label_new_sensor_name.AutoSize = true;
            label_new_sensor_name.Location = new Point(102, 78);
            label_new_sensor_name.Name = "label_new_sensor_name";
            label_new_sensor_name.Size = new Size(37, 15);
            label_new_sensor_name.TabIndex = 11;
            label_new_sensor_name.Text = "name";
            label_new_sensor_name.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(groupBox_new_sensor);
            Controls.Add(label_selected_com);
            Controls.Add(button_accept_com);
            Controls.Add(button_update_com1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(button_add_sensor);
            Name = "Form1";
            Text = "Управляющая программа";
            FormClosing += Form1_FormClosing;
            groupBox_new_sensor.ResumeLayout(false);
            groupBox_new_sensor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Button button_update_com1;
        private Button button_accept_com;
        private Label label_selected_com;
        private Button button_add_sensor;
        private ComboBox comboBox_sensor_com;
        private Button button_update_com2;
        private Button button_accept_sensor_com;
        private Button button_cancel_connect_sensor;
        private GroupBox groupBox_new_sensor;
        private Label label_new_sensor_vol;
        private Label label_new_sensor_name;
        private Label label_sensor_loading_warning;
        private TextBox textBox_lat;
        private TextBox textBox_lon;
        private Label label_lon;
        private Label label_lat;
        private Label label_num_of_new_sensor;
        private ToolTip toolTip1;

        void LabelMouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label_num_of_new_sensor, "Номер генерируется автоматически, опираясь на номера уже добавленных АУО");
        }

        private Button button_new_sensor_done;
    }
}