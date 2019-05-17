namespace Terminal
{
    partial class Terminal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.receive_data_rich_text_box = new System.Windows.Forms.RichTextBox();
            this.open_com_port_button = new System.Windows.Forms.Button();
            this.close_com_port_button = new System.Windows.Forms.Button();
            this.serial_port = new System.IO.Ports.SerialPort(this.components);
            this.send_data_text_box = new System.Windows.Forms.TextBox();
            this.parity_bits_combo_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stop_bits_combo_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baud_rate_combo_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.data_bits_combo_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.com_port_combo_box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // receive_data_rich_text_box
            // 
            this.receive_data_rich_text_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.receive_data_rich_text_box.Location = new System.Drawing.Point(12, 188);
            this.receive_data_rich_text_box.Name = "receive_data_rich_text_box";
            this.receive_data_rich_text_box.Size = new System.Drawing.Size(541, 289);
            this.receive_data_rich_text_box.TabIndex = 11;
            this.receive_data_rich_text_box.Text = "";
            // 
            // open_com_port_button
            // 
            this.open_com_port_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_com_port_button.Location = new System.Drawing.Point(478, 136);
            this.open_com_port_button.Name = "open_com_port_button";
            this.open_com_port_button.Size = new System.Drawing.Size(75, 23);
            this.open_com_port_button.TabIndex = 9;
            this.open_com_port_button.Text = "OPEN";
            this.open_com_port_button.UseVisualStyleBackColor = true;
            this.open_com_port_button.Click += new System.EventHandler(this.Open_com_port_button_Click);
            // 
            // close_com_port_button
            // 
            this.close_com_port_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_com_port_button.Location = new System.Drawing.Point(478, 161);
            this.close_com_port_button.Name = "close_com_port_button";
            this.close_com_port_button.Size = new System.Drawing.Size(75, 23);
            this.close_com_port_button.TabIndex = 7;
            this.close_com_port_button.Text = "CLOSE";
            this.close_com_port_button.UseVisualStyleBackColor = true;
            this.close_com_port_button.Click += new System.EventHandler(this.Close_com_port_button_Click);
            // 
            // serial_port
            // 
            this.serial_port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Serial_port_DataReceived);
            // 
            // send_data_text_box
            // 
            this.send_data_text_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.send_data_text_box.Location = new System.Drawing.Point(12, 483);
            this.send_data_text_box.Name = "send_data_text_box";
            this.send_data_text_box.Size = new System.Drawing.Size(541, 20);
            this.send_data_text_box.TabIndex = 12;
            this.send_data_text_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Send_data_text_box_KeyDown);
            // 
            // parity_bits_combo_box
            // 
            this.parity_bits_combo_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parity_bits_combo_box.FormattingEnabled = true;
            this.parity_bits_combo_box.Items.AddRange(new object[] {
            "Odd",
            "Even",
            "None"});
            this.parity_bits_combo_box.Location = new System.Drawing.Point(376, 161);
            this.parity_bits_combo_box.Name = "parity_bits_combo_box";
            this.parity_bits_combo_box.Size = new System.Drawing.Size(85, 21);
            this.parity_bits_combo_box.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            // 
            // stop_bits_combo_box
            // 
            this.stop_bits_combo_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stop_bits_combo_box.FormattingEnabled = true;
            this.stop_bits_combo_box.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.stop_bits_combo_box.Location = new System.Drawing.Point(285, 161);
            this.stop_bits_combo_box.Name = "stop_bits_combo_box";
            this.stop_bits_combo_box.Size = new System.Drawing.Size(85, 21);
            this.stop_bits_combo_box.TabIndex = 3;
            this.stop_bits_combo_box.Text = "One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // baud_rate_combo_box
            // 
            this.baud_rate_combo_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.baud_rate_combo_box.FormattingEnabled = true;
            this.baud_rate_combo_box.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baud_rate_combo_box.Location = new System.Drawing.Point(103, 161);
            this.baud_rate_combo_box.Name = "baud_rate_combo_box";
            this.baud_rate_combo_box.Size = new System.Drawing.Size(85, 21);
            this.baud_rate_combo_box.TabIndex = 2;
            this.baud_rate_combo_box.Text = "57600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // data_bits_combo_box
            // 
            this.data_bits_combo_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.data_bits_combo_box.FormattingEnabled = true;
            this.data_bits_combo_box.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.data_bits_combo_box.Location = new System.Drawing.Point(194, 161);
            this.data_bits_combo_box.Name = "data_bits_combo_box";
            this.data_bits_combo_box.Size = new System.Drawing.Size(85, 21);
            this.data_bits_combo_box.TabIndex = 1;
            this.data_bits_combo_box.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // com_port_combo_box
            // 
            this.com_port_combo_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.com_port_combo_box.FormattingEnabled = true;
            this.com_port_combo_box.Location = new System.Drawing.Point(12, 161);
            this.com_port_combo_box.Name = "com_port_combo_box";
            this.com_port_combo_box.Size = new System.Drawing.Size(85, 21);
            this.com_port_combo_box.TabIndex = 0;
            this.com_port_combo_box.DropDown += new System.EventHandler(this.Com_port_combo_box_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Terminal.Properties.Resources.eagle;
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(563, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.send_data_text_box);
            this.Controls.Add(this.com_port_combo_box);
            this.Controls.Add(this.receive_data_rich_text_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.open_com_port_button);
            this.Controls.Add(this.data_bits_combo_box);
            this.Controls.Add(this.close_com_port_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baud_rate_combo_box);
            this.Controls.Add(this.stop_bits_combo_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parity_bits_combo_box);
            this.Controls.Add(this.label1);
            this.Name = "Terminal";
            this.Text = "Terminal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox receive_data_rich_text_box;
        private System.Windows.Forms.Button open_com_port_button;
        private System.Windows.Forms.Button close_com_port_button;
        private System.IO.Ports.SerialPort serial_port;
        private System.Windows.Forms.TextBox send_data_text_box;
        private System.Windows.Forms.ComboBox parity_bits_combo_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stop_bits_combo_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox baud_rate_combo_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox data_bits_combo_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox com_port_combo_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}