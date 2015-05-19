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

        Thread thdUDPServer;
        UdpClient udpClient;
        IPAddress serverIP;

        string nickname1, nickname2, ip1, ip2;
        public Privado()
        {
           
        }

        public Privado(string nick1, string nick2, string ipe1, string ipe2)
        {
            InitializeComponent();

            serverIP = IPAddress.Parse("192.168.1.242");
      
            thdUDPServer = new Thread(new ThreadStart(receiveThread));
            thdUDPServer.Start();
            this.nickname1 = nick1;
            this.nickname2 = nick2;
            this.ip1 = ipe1;
            this.ip2 = ipe2;

            clientes_grid.Invoke(new Action(() => clientes_grid.Rows.Add(nickname1, ip1)));
            clientes_grid.Invoke(new Action(() => clientes_grid.Rows.Add(nickname2, ip2)));

            if(ipe1 == Dns.GetHostAddresses(Dns.GetHostName()).ToString())
                Send_Bytes("$,"+ nick1 + ","+ nick2 + "," + ipe1 + ","+ ipe2);


        }

         private void Send_Bytes(string action)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(action);
            try
            {
                UdpClient udpClient = new UdpClient();
                udpClient.Connect(serverIP, 5420);
                udpClient.Send(outStream, outStream.Length);
            }
            catch { }
        }

        public void receiveThread()
        {
           udpClient = new UdpClient(5420);

            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(serverIP, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returndata = System.Text.Encoding.ASCII.GetString(receiveBytes);

                //if (returndata.Contains('|'))
                //{
                //    playerList.Invoke(new Action(() => playerList.Items.Clear()));
                //}
                //else if (returndata.Contains('&'))
                //{
                //    playerList.Invoke(new Action(() => playerList.Items.Add(returndata.Substring(1, returndata.Length-1))));
                //}
                //else if (returndata.Contains('/'))
                //{
                //    diceBut.Invoke(new Action(() => diceBut.Enabled = true));
                //    turno_label.Invoke(new Action(() => turno_label.Enabled = true));
                //}
                if (returndata.Substring(0, 1) == "$")
                {
                    int privad = Convert.ToInt32(returndata.Substring(1,1));
                    moveFicha(dice);
                }
                else if (returndata.Substring(0, 1) == "%")
                {
                    int privad = Convert.ToInt32(returndata.Substring(0,1));
                    diceBut.Invoke(new Action(() => diceBut.Enabled = false));
                }
                else if (returndata.Substring(0, 1) == "!")
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
                //}
            }
    }
}
