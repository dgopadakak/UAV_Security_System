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
            dataGridViewSensors = new DataGridView();
            ColumnNUM = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnIsSleeping = new DataGridViewTextBoxColumn();
            ColumnLat = new DataGridViewTextBoxColumn();
            ColumnLon = new DataGridViewTextBoxColumn();
            ColumnVol = new DataGridViewTextBoxColumn();
            ColumnBatteryFlag = new DataGridViewTextBoxColumn();
            ColumnConnectionFlag = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button_del_sensor = new Button();
            button_edit_sensor = new Button();
            button_del_all_sensors = new Button();
            groupBox_new_sensor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSensors).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 523);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 0;
            button1.Text = "Обновить список";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
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
            button_add_sensor.Location = new Point(571, 12);
            button_add_sensor.Name = "button_add_sensor";
            button_add_sensor.Size = new Size(96, 23);
            button_add_sensor.TabIndex = 6;
            button_add_sensor.Text = "Добавить АУО";
            button_add_sensor.UseVisualStyleBackColor = true;
            button_add_sensor.Visible = false;
            button_add_sensor.Click += button_add_sensor_Click;
            // 
            // comboBox_sensor_com
            // 
            comboBox_sensor_com.FormattingEnabled = true;
            comboBox_sensor_com.Location = new Point(87, 22);
            comboBox_sensor_com.Name = "comboBox_sensor_com";
            comboBox_sensor_com.Size = new Size(142, 23);
            comboBox_sensor_com.TabIndex = 7;
            comboBox_sensor_com.Text = "Выберите COM порт";
            // 
            // button_update_com2
            // 
            button_update_com2.Location = new Point(6, 22);
            button_update_com2.Name = "button_update_com2";
            button_update_com2.Size = new Size(75, 23);
            button_update_com2.TabIndex = 8;
            button_update_com2.Text = "Обновить";
            button_update_com2.UseVisualStyleBackColor = true;
            button_update_com2.Click += button_update_com_Click;
            // 
            // button_accept_sensor_com
            // 
            button_accept_sensor_com.Location = new Point(87, 51);
            button_accept_sensor_com.Name = "button_accept_sensor_com";
            button_accept_sensor_com.Size = new Size(142, 23);
            button_accept_sensor_com.TabIndex = 9;
            button_accept_sensor_com.Text = "Подтвердить";
            button_accept_sensor_com.UseVisualStyleBackColor = true;
            button_accept_sensor_com.Click += button_accept_sensor_com_Click;
            // 
            // button_cancel_connect_sensor
            // 
            button_cancel_connect_sensor.Location = new Point(87, 210);
            button_cancel_connect_sensor.Name = "button_cancel_connect_sensor";
            button_cancel_connect_sensor.Size = new Size(142, 23);
            button_cancel_connect_sensor.TabIndex = 10;
            button_cancel_connect_sensor.Text = "Отмена";
            button_cancel_connect_sensor.UseVisualStyleBackColor = true;
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
            groupBox_new_sensor.Location = new Point(723, 12);
            groupBox_new_sensor.Name = "groupBox_new_sensor";
            groupBox_new_sensor.Size = new Size(239, 244);
            groupBox_new_sensor.TabIndex = 11;
            groupBox_new_sensor.TabStop = false;
            groupBox_new_sensor.Text = "Добавление АУО";
            groupBox_new_sensor.Visible = false;
            // 
            // button_new_sensor_done
            // 
            button_new_sensor_done.Location = new Point(87, 181);
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
            label_num_of_new_sensor.Location = new Point(87, 92);
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
            label_lon.Location = new Point(87, 155);
            label_lon.Name = "label_lon";
            label_lon.Size = new Size(27, 15);
            label_lon.TabIndex = 15;
            label_lon.Text = "lon:";
            label_lon.Visible = false;
            // 
            // label_lat
            // 
            label_lat.AutoSize = true;
            label_lat.Location = new Point(87, 128);
            label_lat.Name = "label_lat";
            label_lat.Size = new Size(23, 15);
            label_lat.TabIndex = 14;
            label_lat.Text = "lat:";
            label_lat.Visible = false;
            // 
            // textBox_lon
            // 
            textBox_lon.Location = new Point(116, 152);
            textBox_lon.Name = "textBox_lon";
            textBox_lon.Size = new Size(113, 23);
            textBox_lon.TabIndex = 12;
            textBox_lon.Visible = false;
            // 
            // textBox_lat
            // 
            textBox_lat.Location = new Point(116, 125);
            textBox_lat.Name = "textBox_lat";
            textBox_lat.Size = new Size(113, 23);
            textBox_lat.TabIndex = 12;
            textBox_lat.Visible = false;
            // 
            // label_sensor_loading_warning
            // 
            label_sensor_loading_warning.Location = new Point(87, 107);
            label_sensor_loading_warning.Name = "label_sensor_loading_warning";
            label_sensor_loading_warning.Size = new Size(142, 80);
            label_sensor_loading_warning.TabIndex = 13;
            label_sensor_loading_warning.Text = "Если загрузка занимает много времени или произошла ошибка - нажмите \"Отмена\" и попробуйте еще раз";
            label_sensor_loading_warning.TextAlign = ContentAlignment.TopCenter;
            label_sensor_loading_warning.Visible = false;
            // 
            // label_new_sensor_vol
            // 
            label_new_sensor_vol.AutoSize = true;
            label_new_sensor_vol.Location = new Point(87, 107);
            label_new_sensor_vol.Name = "label_new_sensor_vol";
            label_new_sensor_vol.Size = new Size(23, 15);
            label_new_sensor_vol.TabIndex = 12;
            label_new_sensor_vol.Text = "vol";
            label_new_sensor_vol.Visible = false;
            // 
            // label_new_sensor_name
            // 
            label_new_sensor_name.AutoSize = true;
            label_new_sensor_name.Location = new Point(87, 77);
            label_new_sensor_name.Name = "label_new_sensor_name";
            label_new_sensor_name.Size = new Size(37, 15);
            label_new_sensor_name.TabIndex = 11;
            label_new_sensor_name.Text = "name";
            label_new_sensor_name.Visible = false;
            // 
            // dataGridViewSensors
            // 
            dataGridViewSensors.AllowUserToAddRows = false;
            dataGridViewSensors.AllowUserToDeleteRows = false;
            dataGridViewSensors.AllowUserToOrderColumns = true;
            dataGridViewSensors.AllowUserToResizeColumns = false;
            dataGridViewSensors.AllowUserToResizeRows = false;
            dataGridViewSensors.BackgroundColor = SystemColors.Control;
            dataGridViewSensors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSensors.Columns.AddRange(new DataGridViewColumn[] { ColumnNUM, ColumnName, ColumnIsSleeping, ColumnLat, ColumnLon, ColumnVol, ColumnBatteryFlag, ColumnConnectionFlag });
            dataGridViewSensors.Location = new Point(12, 41);
            dataGridViewSensors.MultiSelect = false;
            dataGridViewSensors.Name = "dataGridViewSensors";
            dataGridViewSensors.RowHeadersVisible = false;
            dataGridViewSensors.RowTemplate.Height = 25;
            dataGridViewSensors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSensors.Size = new Size(655, 476);
            dataGridViewSensors.TabIndex = 12;
            dataGridViewSensors.Visible = false;
            dataGridViewSensors.SelectionChanged += dataGridViewSensors_SelectionChanged;
            // 
            // ColumnNUM
            // 
            ColumnNUM.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnNUM.HeaderText = "№";
            ColumnNUM.Name = "ColumnNUM";
            ColumnNUM.ReadOnly = true;
            ColumnNUM.Resizable = DataGridViewTriState.False;
            ColumnNUM.Width = 45;
            // 
            // ColumnName
            // 
            ColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnName.HeaderText = "Имя";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Resizable = DataGridViewTriState.False;
            ColumnName.Width = 56;
            // 
            // ColumnIsSleeping
            // 
            ColumnIsSleeping.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnIsSleeping.HeaderText = "Спящий режим";
            ColumnIsSleeping.Name = "ColumnIsSleeping";
            ColumnIsSleeping.ReadOnly = true;
            ColumnIsSleeping.Resizable = DataGridViewTriState.False;
            ColumnIsSleeping.Width = 109;
            // 
            // ColumnLat
            // 
            ColumnLat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnLat.HeaderText = "lat";
            ColumnLat.Name = "ColumnLat";
            ColumnLat.ReadOnly = true;
            ColumnLat.Resizable = DataGridViewTriState.False;
            ColumnLat.Width = 45;
            // 
            // ColumnLon
            // 
            ColumnLon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnLon.HeaderText = "lon";
            ColumnLon.Name = "ColumnLon";
            ColumnLon.ReadOnly = true;
            ColumnLon.Resizable = DataGridViewTriState.False;
            ColumnLon.Width = 49;
            // 
            // ColumnVol
            // 
            ColumnVol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnVol.HeaderText = "Напряжение";
            ColumnVol.Name = "ColumnVol";
            ColumnVol.ReadOnly = true;
            ColumnVol.Resizable = DataGridViewTriState.False;
            ColumnVol.Width = 102;
            // 
            // ColumnBatteryFlag
            // 
            ColumnBatteryFlag.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnBatteryFlag.HeaderText = "Аккумулятор";
            ColumnBatteryFlag.Name = "ColumnBatteryFlag";
            ColumnBatteryFlag.ReadOnly = true;
            ColumnBatteryFlag.Resizable = DataGridViewTriState.False;
            ColumnBatteryFlag.Width = 105;
            // 
            // ColumnConnectionFlag
            // 
            ColumnConnectionFlag.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnConnectionFlag.HeaderText = "Связь";
            ColumnConnectionFlag.Name = "ColumnConnectionFlag";
            ColumnConnectionFlag.ReadOnly = true;
            ColumnConnectionFlag.Resizable = DataGridViewTriState.False;
            ColumnConnectionFlag.Width = 63;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(723, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 153);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button_del_sensor
            // 
            button_del_sensor.Enabled = false;
            button_del_sensor.Location = new Point(318, 523);
            button_del_sensor.Name = "button_del_sensor";
            button_del_sensor.Size = new Size(168, 23);
            button_del_sensor.TabIndex = 14;
            button_del_sensor.Text = "Удалить выделенное АУО";
            button_del_sensor.UseVisualStyleBackColor = true;
            button_del_sensor.Visible = false;
            button_del_sensor.Click += button_del_sensor_Click;
            // 
            // button_edit_sensor
            // 
            button_edit_sensor.Enabled = false;
            button_edit_sensor.Location = new Point(137, 523);
            button_edit_sensor.Name = "button_edit_sensor";
            button_edit_sensor.Size = new Size(175, 23);
            button_edit_sensor.TabIndex = 15;
            button_edit_sensor.Text = "Изменить выделенное АУО";
            button_edit_sensor.UseVisualStyleBackColor = true;
            button_edit_sensor.Visible = false;
            button_edit_sensor.Click += button_edit_sensor_Click;
            // 
            // button_del_all_sensors
            // 
            button_del_all_sensors.Location = new Point(492, 523);
            button_del_all_sensors.Name = "button_del_all_sensors";
            button_del_all_sensors.Size = new Size(175, 23);
            button_del_all_sensors.TabIndex = 16;
            button_del_all_sensors.Text = "Удалить все АУО";
            button_del_all_sensors.UseVisualStyleBackColor = true;
            button_del_all_sensors.Visible = false;
            button_del_all_sensors.Click += button_del_all_sensors_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 621);
            Controls.Add(button_del_all_sensors);
            Controls.Add(button_edit_sensor);
            Controls.Add(button_del_sensor);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewSensors);
            Controls.Add(groupBox_new_sensor);
            Controls.Add(label_selected_com);
            Controls.Add(button_accept_com);
            Controls.Add(button_update_com1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(button_add_sensor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Управляющая программа";
            FormClosing += Form1_FormClosing;
            groupBox_new_sensor.ResumeLayout(false);
            groupBox_new_sensor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSensors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
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
        private DataGridView dataGridViewSensors;
        private GroupBox groupBox1;
        private Button button_del_sensor;
        private Button button_edit_sensor;
        private Button button_del_all_sensors;
        private DataGridViewTextBoxColumn ColumnNUM;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnIsSleeping;
        private DataGridViewTextBoxColumn ColumnLat;
        private DataGridViewTextBoxColumn ColumnLon;
        private DataGridViewTextBoxColumn ColumnVol;
        private DataGridViewTextBoxColumn ColumnBatteryFlag;
        private DataGridViewTextBoxColumn ColumnConnectionFlag;
    }
}