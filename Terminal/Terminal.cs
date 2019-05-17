using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Terminal
{
    public partial class Terminal : Form
    {
        string data_received;

        public Terminal()
        {
            InitializeComponent();
        }

        private void Com_port_combo_box_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            com_port_combo_box.Items.Clear();
            com_port_combo_box.Items.AddRange(ports);
        }

        private void Open_com_port_button_Click(object sender, EventArgs e)
        {
            try
            {
                serial_port.PortName = com_port_combo_box.Text;
                serial_port.BaudRate = Convert.ToInt32(baud_rate_combo_box.Text);
                serial_port.DataBits = Convert.ToInt32(data_bits_combo_box.Text);
                serial_port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stop_bits_combo_box.Text);
                serial_port.Parity = (Parity)Enum.Parse(typeof(Parity), parity_bits_combo_box.Text);

                serial_port.Open();
                open_com_port_button.ForeColor = Color.FromArgb(0, 100, 0);
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Close_com_port_button_Click(object sender, EventArgs e)
        {
            if (serial_port.IsOpen)
            {
                serial_port.Close();
                open_com_port_button.ForeColor = Color.Black;
            }
        }

        private void Send_data_text_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                serial_port.Write(send_data_text_box.Text + "\n");
                send_data_text_box.Text = "";
            }
        }

        private void Serial_port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data_received = serial_port.ReadExisting();

            this.BeginInvoke(new EventHandler(data_received_event_handler));
        }

        private void data_received_event_handler(object sender, EventArgs e)
        {
            receive_data_rich_text_box.Text += data_received;
        }

        private void Settings_Enter(object sender, EventArgs e)
        {

        }
    }
}
