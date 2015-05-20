using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace clientSide
{
    public partial class Privado : Form
    {
        public IPAddress[] localIP;
        public IPAddress myIP;

        Thread thdUDPServer;
        UdpClient udpClient;
        public IPAddress[] serverIP;
        string ipserver;

        string nickname1, nickname2, ip1, ip2;
        bool dos = false;
        public Privado()
        {
           
        }

        public Privado(string nick1, string nick2, string ipe1, string ipe2)
        {
            InitializeComponent();

            serverIP = Dns.GetHostAddresses("Cabrera");
            //ipserver = serverIP[0].ToString();
            ipserver = "192.168.1.123";
      

            thdUDPServer = new Thread(new ThreadStart(receiveThread));
            thdUDPServer.Start();

            this.nickname1 = nick1;
            this.nickname2 = nick2;
            this.ip1 = ipe1;
            this.ip2 = ipe2;

            localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    myIP = address;
                }
            }

            if (ipe2.Equals(myIP.ToString()))
            {
                Send_Bytes("$," + nick1 + "," + nick2 + "," + ipe1 + "," + ipe2 + ",NADA");
                dos = true;
            }
            else
                dos = false;
        }

        private void addGrid1()
        {
            if (clientes_grid.InvokeRequired)
                clientes_grid.Invoke(new Action(() => clientes_grid.Rows.Add(nickname1, ip1)));
            else
                clientes_grid.Rows.Add(nickname1, ip1);
        }

        private void addGrid2()
        {
            if (clientes_grid.InvokeRequired)
                clientes_grid.Invoke(new Action(() => clientes_grid.Rows.Add(nickname2, ip2)));
            else
                clientes_grid.Rows.Add(nickname2, ip2);
        }

         private void Send_Bytes(string action)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(action);
            try
            {
                UdpClient udpClient = new UdpClient();
                udpClient.Connect(ipserver, 5421);
                udpClient.Send(outStream, outStream.Length);
            }
            catch { }
        }

         public void receiveThread()
         {
             udpClient = new UdpClient(5421);

             while (true)
             {
                 IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Parse(ipserver), 0);
                 Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                 string returndata = System.Text.Encoding.ASCII.GetString(receiveBytes);

                 if (returndata.Substring(0, 1) == "$")
                 {
                     addGrid1();
                     addGrid2();
                 }
                 else if (returndata.Substring(0, 1) == "%")
                 {
                     string[] partes = returndata.Split(',');
                     partes[2] = CryptoEngine.Decrypt(partes[2], true);
                     conversation.AppendText("\n" + partes[1] + " >> " + partes[2]);
                 }
                 /*else if (returndata.Substring(0, 1) == "!")
                 {
                     int privad = Convert.ToInt32(returndata.Substring(0,1));
                     diceBut.Invoke(new Action(() => diceBut.Enabled = false));
                 }
                 else if (returndata.Substring(0, 1) =="q")
                 {
                     int privad = Convert.ToInt32(returndata.Substring(0,1));
                     diceBut.Invoke(new Action(() => diceBut.Enabled = false));
                 }
                 //else if (returndata.Contains('('))
                 //{
                 //    diceBut.Invoke(new Action(() => diceBut.Enabled = false));
                 //}
                 //else if (returndata.Contains(')'))
                 //{
                 //    diceBut.Invoke(new Action(() => diceBut.Enabled = true));
                 //}*/
             }
         }

         private void button1_Click(object sender, EventArgs e)
         {
             string text_to_send = "," + CryptoEngine.Encrypt(textToSend_txt.Text, true) + ",]";
             if (dos)
                 text_to_send = "%," + nickname2 + text_to_send;
             else
                 text_to_send = "%," + nickname1 + text_to_send;

             Send_Bytes(text_to_send);

             textToSend_txt.Clear();
         }

         private void btncorreo_Click(object sender, EventArgs e)
         {
             Correo correo = new Correo();
             correo.Show();
         }
    }
}
