using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace SendFiles
{
    public partial class Form1 : Form
    {
        public string SendingFilePath = string.Empty;
        private const int BufferSize = 1024;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible=true;
            progressBar1.Minimum=1;
            progressBar1.Value=1;
            progressBar1.Step=1;
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "All Files (*.*)|*.*";
            Dlg.CheckFileExists = true;
            Dlg.Title = "Choose a File";
            Dlg.InitialDirectory = @"C:\";
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                SendingFilePath = Dlg.FileName;
                
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (SendingFilePath != string.Empty)
            {   
                SendTCP(SendingFilePath, txtIP.Text, Int32.Parse(txtPort.Text));
            }
            else
                MessageBox.Show("Select a file","Warning");
        }
        public void SendTCP(string FileName, string Host, int Port)
        {
            byte[] SendingBuffer = null;
            TcpClient client = null;
            NetworkStream netstream = null;
            try
            {
                client = new TcpClient(Host, Port);

                netstream = client.GetStream();
                FileStream Fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                int NoOfPackets = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Fs.Length) / Convert.ToDouble(1024)));
                //progressBar1.Maximum = NoOfPackets;
                int TotalLength = (int)Fs.Length, CurrentPacketLength, counter = 0;
                for (int i = 0; i < NoOfPackets; i++)
                {
                    if (TotalLength > 1024)
                    {
                        CurrentPacketLength = 1024;
                        TotalLength = TotalLength - CurrentPacketLength;
                    }
                    else
                        CurrentPacketLength = TotalLength;
                    SendingBuffer = new byte[CurrentPacketLength];
                    Fs.Read(SendingBuffer, 0, CurrentPacketLength);
                    netstream.Write(SendingBuffer, 0, (int)SendingBuffer.Length);
                    //if (progressBar1.Value >= progressBar1.Maximum)
                    //     progressBar1.Value = progressBar1.Minimum;
                    //progressBar1.PerformStep();
                }
                Fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                netstream.Close();
                client.Close();
            }
        }
        
      
    }
}