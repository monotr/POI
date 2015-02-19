using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace documentcrea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify a name for your top-level folder.
            string folderName = @"c:\Top-Level Folder";

            string pathString = System.IO.Path.Combine(folderName, "SubFolder");

            System.IO.Directory.CreateDirectory(pathString);

            // Create a file name for the file you want to create. 
            string fileName = "Chat.txt";

            // This example uses a random string for the name, but you also can specify
            // a particular name.
            //string fileName = "MyNewFile.txt";

            // Use Combine again to add the file name to the path.
            pathString = System.IO.Path.Combine(pathString, fileName);

            // Verify the path that you have constructed.
            Console.WriteLine("Path to my file: {0}\n", pathString);

            // Check that the file doesn't already exist. If it doesn't exist, create
            // the file and write integers 0 - 99 to it.
            // DANGER: System.IO.File.Create will overwrite the file if it already exists.
            // This could happen even with random file names, although it is unlikely.
            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.StreamWriter fs = new StreamWriter(pathString,true))
                {
                   
                    for (byte i = 0; i < 100; i++)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(i.ToString());
                        fs.WriteAsync(sb.ToString());
                        //fs.WriteByte(i);
                        
                    }
                }
            }
            else
            {
                using (System.IO.StreamWriter fs = new StreamWriter(pathString, true))
                {

                    System.IO.StringReader fr = new StringReader(pathString);
                    string antes = fr.ReadToEnd();
                    StringBuilder sb2 = new StringBuilder();
                    sb2.AppendLine(antes);
                    for (byte i = 0; i < 100; i++)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(i.ToString());
                        fs.WriteAsync(sb.ToString());
                        //fs.WriteByte(i);

                    }
                }
            }

            // Read and display the data from your file.

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
        

   }
    
}
