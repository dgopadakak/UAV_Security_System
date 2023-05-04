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
            button1 = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            button_update_com = new Button();
            button_accept_com = new Button();
            label_selected_com = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(330, 443);
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
            listBox1.Location = new Point(330, 103);
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
            // button_update_com
            // 
            button_update_com.Location = new Point(160, 12);
            button_update_com.Name = "button_update_com";
            button_update_com.Size = new Size(75, 23);
            button_update_com.TabIndex = 3;
            button_update_com.Text = "Обновить";
            button_update_com.UseVisualStyleBackColor = true;
            button_update_com.Click += button_update_com_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(label_selected_com);
            Controls.Add(button_accept_com);
            Controls.Add(button_update_com);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Управляющая программа";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Button button_update_com;
        private Button button_accept_com;
        private Label label_selected_com;
    }
}