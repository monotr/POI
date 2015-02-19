using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Drawing;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Threading;

namespace RobotWebCamServer
{
    class Program
    {
  
        static void Main(string[] args)
        {
            ServiceHost webcamServiceHost = null;

            try
            {
                // service host takes care of web cam streaming
                webcamServiceHost = new ServiceHost(typeof(RobotWebCamServer.WebCamService));
                webcamServiceHost.Open();
            }
            catch (CommunicationException ce)
            {
                webcamServiceHost.Abort();
                //if (ce is System.ServiceModel.AddressAlreadyInUseException)
                //throw ce;
            }
            catch (Exception ex)
            {
                throw ex;
            }



            Console.WriteLine("Server is running...");
            Console.ReadKey();


            webcamServiceHost.Close();

        }
    }

}
