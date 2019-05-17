namespace Terminal
{
    partial class Form1
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
            this.Settings = new System.Windows.Forms.GroupBox();
            this.com_port_combo_box = new System.Windows.Forms.ComboBox();
            this.data_bits_combo_box = new System.Windows.Forms.ComboBox();
            this.baud_rate_combo_box = new System.Windows.Forms.ComboBox();
            this.stop_bits_combo_box = new System.Windows.Forms.ComboBox();
            this.parity_bits_combo_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.close_com_port_button = new System.Windows.Forms.Button();
            this.send_data_button = new System.Windows.Forms.Button();
            this.open_com_port_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.send_data_rich_text_box = new System.Windows.Forms.RichTextBox();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.label5);
            this.Settings.Controls.Add(this.com_port_combo_box);
            this.Settings.Controls.Add(this.label4);
            this.Settings.Controls.Add(this.data_bits_combo_box);
            this.Settings.Controls.Add(this.label3);
            this.Settings.Controls.Add(this.baud_rate_combo_box);
            this.Settings.Controls.Add(this.label2);
            this.Settings.Controls.Add(this.stop_bits_combo_box);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Controls.Add(this.parity_bits_combo_box);
            this.Settings.Location = new System.Drawing.Point(41, 36);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(287, 216);
            this.Settings.TabIndex = 0;
            this.Settings.TabStop = false;
            this.Settings.Text = "Settings";
            // 
            // com_port_combo_box
            // 
            this.com_port_combo_box.FormattingEnabled = true;
            this.com_port_combo_box.Location = new System.Drawing.Point(113, 53);
            this.com_port_combo_box.Name = "com_port_combo_box";
            this.com_port_combo_box.Size = new System.Drawing.Size(121, 21);
            this.com_port_combo_box.TabIndex = 0;
            // 
            // data_bits_combo_box
            // 
            this.data_bits_combo_box.FormattingEnabled = true;
            this.data_bits_combo_box.Location = new System.Drawing.Point(113, 107);
            this.data_bits_combo_box.Name = "data_bits_combo_box";
            this.data_bits_combo_box.Size = new System.Drawing.Size(121, 21);
            this.data_bits_combo_box.TabIndex = 1;
            // 
            // baud_rate_combo_box
            // 
            this.baud_rate_combo_box.FormattingEnabled = true;
            this.baud_rate_combo_box.Location = new System.Drawing.Point(113, 80);
            this.baud_rate_combo_box.Name = "baud_rate_combo_box";
            this.baud_rate_combo_box.Size = new System.Drawing.Size(121, 21);
            this.baud_rate_combo_box.TabIndex = 2;
            // 
            // stop_bits_combo_box
            // 
            this.stop_bits_combo_box.FormattingEnabled = true;
            this.stop_bits_combo_box.Location = new System.Drawing.Point(113, 134);
            this.stop_bits_combo_box.Name = "stop_bits_combo_box";
            this.stop_bits_combo_box.Size = new System.Drawing.Size(121, 21);
            this.stop_bits_combo_box.TabIndex = 3;
            // 
            // parity_bits_combo_box
            // 
            this.parity_bits_combo_box.FormattingEnabled = true;
            this.parity_bits_combo_box.Location = new System.Drawing.Point(113, 162);
            this.parity_bits_combo_box.Name = "parity_bits_combo_box";
            this.parity_bits_combo_box.Size = new System.Drawing.Size(121, 21);
            this.parity_bits_combo_box.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // close_com_port_button
            // 
            this.close_com_port_button.Location = new System.Drawing.Point(122, 271);
            this.close_com_port_button.Name = "close_com_port_button";
            this.close_com_port_button.Size = new System.Drawing.Size(75, 23);
            this.close_com_port_button.TabIndex = 1;
            this.close_com_port_button.Text = "CLOSE";
            this.close_com_port_button.UseVisualStyleBackColor = true;
            // 
            // send_data_button
            // 
            this.send_data_button.Location = new System.Drawing.Point(228, 271);
            this.send_data_button.Name = "send_data_button";
            this.send_data_button.Size = new System.Drawing.Size(100, 61);
            this.send_data_button.TabIndex = 2;
            this.send_data_button.Text = "SEND DATA";
            this.send_data_button.UseVisualStyleBackColor = true;
            // 
            // open_com_port_button
            // 
            this.open_com_port_button.Location = new System.Drawing.Point(41, 271);
            this.open_com_port_button.Name = "open_com_port_button";
            this.open_com_port_button.Size = new System.Drawing.Size(75, 23);
            this.open_com_port_button.TabIndex = 3;
            this.open_com_port_button.Text = "OPEN";
            this.open_com_port_button.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 309);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(156, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // send_data_rich_text_box
            // 
            this.send_data_rich_text_box.Location = new System.Drawing.Point(334, 39);
            this.send_data_rich_text_box.Name = "send_data_rich_text_box";
            this.send_data_rich_text_box.Size = new System.Drawing.Size(227, 213);
            this.send_data_rich_text_box.TabIndex = 5;
            this.send_data_rich_text_box.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 346);
            this.Controls.Add(this.send_data_rich_text_box);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.open_com_port_button);
            this.Controls.Add(this.send_data_button);
            this.Controls.Add(this.close_com_port_button);
            this.Controls.Add(this.Settings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox com_port_combo_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox data_bits_combo_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox baud_rate_combo_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stop_bits_combo_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox parity_bits_combo_box;
        private System.Windows.Forms.Button close_com_port_button;
        private System.Windows.Forms.Button send_data_button;
        private System.Windows.Forms.Button open_com_port_button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox send_data_rich_text_box;
    }
}

