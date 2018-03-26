using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace UDPClientConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = textBox1.Text;
            int port = (int)numericUpDown1.Value;
            try
            {
                UdpClient client = new UdpClient(host, port);
                Byte[] data = Encoding.ASCII.GetBytes(textBox2.Text);
                client.Send(data, data.Length);
                listBox1.Items.Add("Sending message to host" + host + " : " + port);
                client.Close();
            }

            catch(Exception ex)
            {
                listBox1.Items.Add("Error: sending message failed");
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
