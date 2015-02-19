using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;

namespace WebCamWindowsClient
{
    public partial class Form1 : Form
    {
        private WebCamService.WebCamServiceClient client;
        //private WebCamService.WebCamServiceClient client;
        private int counter;

        public Form1()
        {
            InitializeComponent();
            counter = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new WebCamService.WebCamServiceClient();
            //client = new LocalWebCamService.WebCamServiceClient();
            client.Record();

            System.Threading.Thread.Sleep(3000);

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            try
            {
                Stream imageStream = client.getWebCamImage();
                pictureBox1.Image = Bitmap.FromStream(imageStream);
                System.Diagnostics.Debug.WriteLine(counter);
            }
            catch (System.ServiceModel.CommunicationException ex)
            {
                if (ex.InnerException is System.ServiceModel.QuotaExceededException)
                {
                    // null
                    string s = "foobar";
                }
                else
                {


                    throw ex;
                }

            }
            catch (System.Exception ex)
            {
                // zilch
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client = null;
        }

   

    }
}

