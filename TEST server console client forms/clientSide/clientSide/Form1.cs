using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace clientSide
{
    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        
        string readData = null;
        bool first = false;
        string nombreCliente;
        string estado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Emojis.createicons();
          
            comboEstado.Items.Add("Disponible");
            comboEstado.Items.Add("Ausente");
            comboEstado.Items.Add("Ocupado");

            comboEstado.SelectedIndex = 0;
        }

        private void getMessage()
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[100025];
                buffSize = clientSocket.ReceiveBufferSize;
                serverStream.Read(inStream, 0, buffSize);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                if (returndata.Contains("%"))
                {
                    readData = returndata.Substring(0, returndata.IndexOf("%"));
                    msg();
                    int finNombre = returndata.IndexOf("|") - 1;
                    string nombreUpdate = returndata.Substring(0, finNombre);
                    int inicioEstado = returndata.IndexOf(")") + 1;
                    string estadoUpdate = returndata.Substring(inicioEstado, returndata.IndexOf("%") - 1);
                    List <string>  clientesconect = new List<string>();
                    int i=0;

                    foreach (var itemu in contactos_list.Items)
                    {
                        clientesconect.Add(itemu.ToString());
                        if (clientesconect.Contains(nombreUpdate))
                        {
                            contactos_list.Items[i] = nombreUpdate + "\n" + estadoUpdate;                                            
                        }
                        i++;
                    }
                }
                else if (!returndata.Contains("Joined") && returndata.IndexOf("^") < 0 && returndata.IndexOf("#") < 0)
                {
                    int inicio = returndata.IndexOf(":");
                    int fin = returndata.IndexOf("*") - inicio;

                    string nameUser = returndata.Substring(0, inicio);

                    nombreCliente = returndata.Substring(0, inicio - 1);
                    returndata = returndata.Substring(inicio, fin);
                    returndata = CryptoEngine.Decrypt(returndata, true);
                    readData = nameUser + ": " + returndata;
                    msg();
                }
                else if (returndata.IndexOf("^") > 0)
                {
                    int inicio2 = returndata.IndexOf("^");
                    nombreCliente = returndata.Substring(0, inicio2);
                    string actualName = nickname.Text + " ";
                    estado = returndata.Substring(returndata.IndexOf("{")+1, returndata.IndexOf("}")-1);
                    this.Invoke(new MethodInvoker(limpiaListBox)); ///
                    readData = nombreCliente + " joined the chat room";
                    msg();
                }
                else if (returndata.IndexOf("#") > 0)
                {
                    int inicio2 = returndata.IndexOf("#");
                    nombreCliente = returndata.Substring(0, inicio2);
                    string estado = returndata.Substring(returndata.IndexOf("#") + 1, returndata.IndexOf(";") - 1);

                    this.Invoke(new MethodInvoker(addToList));//
                    
                } 
            }
        }

        private void addToList()
        {
            if (nickname.Text == nombreCliente)
                contactos_list.Items.Add("You\t" + comboEstado.Text);
            else
                contactos_list.Items.Add(nombreCliente + "\t" + estado);
        }

        private void limpiaListBox()
        {
            contactos_list.Items.Clear();
        }

        private void msg()
        {
            this.Invoke(new MethodInvoker(msg2));
            /*else
            {
                //conversation.AppendText(conversation.Text + Environment.NewLine + " >> " + readData);
                Emojis.pegaricono(readData, conversation);
            }*/
        }

        private void msg2()
        {
            Emojis.pegaricono(readData, conversation);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string text_to_send = CryptoEngine.Encrypt(textToSend_txt.Text, true);

            text_to_send += "*";

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(text_to_send + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            textToSend_txt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readData = "Conected to Chat Server ... \n";
            IPAddress myIP = IPAddress.Parse("127.0.0.1");

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    myIP = address;
                }
            }
            clientSocket.Connect(myIP, 9050);
            //clientSocket.Connect("192.168.1.242", 2014);
            //clientSocket.Connect("127.0.0.1", 2014);
            label1.Text = "Client Socket Program - Server Connected ...";

            msg();
            first = true;

            serverStream = clientSocket.GetStream();


            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(nickname.Text + "$" + comboEstado.Text + "{");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
        }

        private void conversation_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(first){
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(comboEstado.Text + "&estado");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                //contactos_list.SetSelected(0, true);
                contactos_list.Items[0] = "You\t" + comboEstado.Text;
            }   
        }

        private void comboEstado_ValueMemberChanged(object sender, EventArgs e)
        {
            
        } 
    }
}
