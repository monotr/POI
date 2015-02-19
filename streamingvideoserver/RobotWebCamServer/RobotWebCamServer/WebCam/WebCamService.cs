using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing;
using System.IO;

namespace RobotWebCamServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebCamService" in both code and config file together.
    public class WebCamService : IWebCamService, IDisposable
    {
        private string camName;
        private VideoCaptureDevice videoSource = null;

        private Bitmap latestImage;
        private Bitmap newImage;


        //toggle start and stop button
        public void Record()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            try
            {
                FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    throw new ApplicationException("no webcams");
                }
                else
                {
                    camName = videoDevices[0].MonikerString;
                }
            }
            catch (ApplicationException)
            {
                throw new ApplicationException("failed web cams initialize");
            }

            videoSource = new VideoCaptureDevice(camName);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            //videoSource.DesiredFrameSize = new Size(160, 120);
            videoSource.DesiredFrameRate = 15;
            videoSource.Start();
        }


        public void stop_record()
        {

            if (!(videoSource == null))
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
        }


        //eventhandler if new frame is ready
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {


                newImage = (Bitmap)eventArgs.Frame.Clone();

                latestImage = (Bitmap)newImage.Clone();
                //do processing here
                // i.e. send impulse to spine
                latestImage.Save(@"c:\temp\" + Guid.NewGuid().ToString() + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            catch (Exception ex)
            {
                // do nill;
            }
        }



        public void Dispose()
        {
            stop_record();
        }


        System.IO.Stream IWebCamService.getWebCamImage()
        {
            MemoryStream ms = new MemoryStream();
            if (newImage != null)
            {
                lock (newImage)
                {
                    newImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                ms.Position = 0;
                //WebOperationContext.Current.OutgoingResponse.ContentType = "image/jpeg";
                return ms;

            }
            else
            {
                return null;
            }

        }
    }
}
