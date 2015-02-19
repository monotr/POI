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

namespace UPD_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(textBox1.Text, 8080);
            Byte[] senddata = Encoding.ASCII.GetBytes(textikawaii.Text);
            udpClient.Send(senddata, senddata.Length);
        }
    }
}
