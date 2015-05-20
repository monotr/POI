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
using System.Net.Mail;
using System.IO;

namespace clientSide
{


    public partial class Correo : Form
    {
        string to, from, subobject, body, file_path, file_text, path;
        string contraseña;
        DialogResult file_result;

        public Correo ()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void file_Click(object sender, EventArgs e)
        {
        }

        private void send_Click(object sender, EventArgs e)
        {
        }

        private void file_Click_1(object sender, EventArgs e)
        {
            file_result = openFileDialog1.ShowDialog();
            if (file_result == System.Windows.Forms.DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                try
                {
                    file_text = File.ReadAllText(file_path);
                }
                catch (IOException)
                {

                }

            }
            path_texbox.Text = file_path;

        }

        private void send_Click_1(object sender, EventArgs e)
        {

            to = To.Text;
            from = from_textbox.Text;
            subobject = subobject_textbox.Text;
            body = body_textbox.Text;
            contraseña = txtcontra.Text;


            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");
            mail.From = new MailAddress(from);
            mail.To.Add(to);
            mail.Subject = subobject;
            mail.Body = body;

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(file_path);
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(from, contraseña);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);


        }

    }
}
