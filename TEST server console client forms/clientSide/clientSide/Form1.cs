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
using System.Threading;
using System.Media;

namespace clientSide
{
    public partial class Form1 : Form
    {

        int count,val;
        string emo = null;
        SoundPlayer zumb = new SoundPlayer("C:/Users/Diego/Documents/base de datos proyect/emtes trye/emtes trye/zumbido.wav");

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;
        bool first = false;
        string status = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            val = 1;
            Emojis.createicons();
          
            comboEstado.Items.Add("Disponible");
            comboEstado.Items.Add("Ausente");
            comboEstado.Items.Add("Ocupado");
            
            
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
                if (first && !returndata.Contains("Joined"))
                {
                    int inicio = returndata.IndexOf(":") + 1;
                    int fin = returndata.IndexOf("*") - inicio;


                    returndata = returndata.Substring(inicio, fin);
                    returndata = CryptoEngine.Decrypt(returndata, true);


                    readData = "" + returndata;
                    msg();
                }

                else if(returndata.Contains("estado"))
                {
                   
                }

                
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
            {
                //conversation.AppendText(conversation.Text + Environment.NewLine + " >> " + readData);
                Emojis.pegaricono(readData, conversation);
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {

            string text_to_send = CryptoEngine.Encrypt(textToSend_txt.Text, true);

            text_to_send += "*";

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(text_to_send + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            textToSend_txt.Clear();
            //textToSend_txt2.Clear();
            //conversation.ScrollToCaret();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readData = "Conected to Chat Server ... \n";
            clientSocket.Connect("25.7.179.51", 2014);
            //clientSocket.Connect("192.168.1.242", 2014);
            //clientSocket.Connect("127.0.0.1", 2014);
            label1.Text = "Client Socket Program - Server Connected ...";

            msg();
            first = true;

            serverStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(nickname.Text + "$");
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
        
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(comboEstado.Text + "&");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            
        }

        private void comboEstado_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void zumbido_Click(object sender, EventArgs e)
        {
            while (count < 700)
            {
                switch (val)
                {
                    case 1:
                        this.Location = new Point(this.Location.X - 20, this.Location.Y + 20);
                        val++;
                        break;
                    case 2:
                        this.Location = new Point(this.Location.X + 20, this.Location.Y - 20);
                        val++;
                        break;
                    case 3:
                        this.Location = new Point(this.Location.X - 20, this.Location.Y + 20);
                        val++;
                        break;
                    case 4:
                        this.Location = new Point(this.Location.X + 20, this.Location.Y - 20);
                        val++;
                        break;
                    case 5:
                        this.Location = new Point(this.Location.X - 20, this.Location.Y + 20);
                        val++;
                        break;
                    case 6:
                        this.Location = new Point(this.Location.X + 20, this.Location.Y - 20);
                        val++;
                        break;
                    case 7:
                        this.Location = new Point(this.Location.X - 20, this.Location.Y + 20);
                        val++;
                        break;
                    case 8:
                        this.Location = new Point(this.Location.X + 20, this.Location.Y - 20);
                        val++;
                        val = 1;
                        break;

                }
                count++;


            }
            count = 0;
            zumb.Play();
        }

        //iconos botones

        private void kappa_Click(object sender, EventArgs e)
        {
            emo = "kappa";
            Emojis.cambioaemojis(emo,textToSend_txt2,textToSend_txt);
            emotesmenu.Visible = false;
            //textToSend_txt.Text += "Kappa";

            //textToSend_txt2.Text = textToSend_txt.Text;
            //textToSend_txt.Text = textToSend_txt.Text.Substring(0, (textToSend_txt.TextLength - 1));
            
            //emotesmenu.Visible = false;
           
        }
        private void smile_Click(object sender, EventArgs e)
        {
            
            

            emo = ":)";
            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
 
           
        }
        private void sad_Click(object sender, EventArgs e)
        {
            
            emo= ":(";

            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
            
        }

        private void happy_Click(object sender, EventArgs e)
        {
            
           emo= ":D";

            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
            
        }

        private void cring_Click(object sender, EventArgs e)
        {
           
            emo= "T.T";

            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
            

        }

        private void me_Click(object sender, EventArgs e)
        {
           
            emo= "¬.¬";
            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
           
        }

        private void scream_Click(object sender, EventArgs e)
        {
            
            emo= ">.<";

            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
            
        }

        private void whut_Click(object sender, EventArgs e)
        {
            
           emo= "._.";

            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
          

        }

        private void wow_Click(object sender, EventArgs e)
        {
            
            emo= "O_O";

            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
        }

        private void wink_Click(object sender, EventArgs e)
        {
          
            emo= ";)";
            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
            
        }

        private void smush_Click(object sender, EventArgs e)
        {
          emo= "^<^";

            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
            
        }

        private void like_Click(object sender, EventArgs e)
        {
            
            emo= "Like";

            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
            
        }

        private void heart_Click(object sender, EventArgs e)
        {
            
            emo= "<3";

            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
            
        }

        private void faiñ_Click(object sender, EventArgs e)
        {
            emo= "Fail";
            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
            
        }

        private void sleepi_Click(object sender, EventArgs e)
        {
            
            emo= "Zzz";

            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
          
        }

        private void bcwarior_Click(object sender, EventArgs e)
        {
            
            emo= "Pink";
            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
           
        }

        private void death_Click(object sender, EventArgs e)
        {
            
            emo= ":#X";
            Emojis.cambioaemojis(emo, textToSend_txt2, textToSend_txt);
            emotesmenu.Visible = false;
            
        }



        //iconos botones 

        private void emotes_Click(object sender, EventArgs e)
        {
            emotesmenu.Visible = true;
        }

        private void textToSend_txt2_TextChanged(object sender, EventArgs e)
        {
            string lastchar = textToSend_txt2.Text;
            if (lastchar != "")
            {
                textToSend_txt.Text += lastchar.Substring(lastchar.Length - 1, 1);

            }
            Emojis.pegaricono2(textToSend_txt2);
        }



       
    }
}
