using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Media;

namespace emtes_trye
{
    
    public partial class Form1 : Form
    {
        //bool send;
        string textsend;
        int count, val;
        SoundPlayer zumbido = new SoundPlayer("C:/Users/Diego/Documents/base de datos proyect/emtes trye/emtes trye/zumbido.wav");
        Hashtable emotions;
        
        void createicons()
        {
            emotions = new Hashtable(1);
            emotions.Add(":)", emtes_trye.Properties.Resources.smile);
            emotions.Add("Kappa", emtes_trye.Properties.Resources.kappa);
            emotions.Add("Pink", emtes_trye.Properties.Resources.pink);
            emotions.Add("Fail", emtes_trye.Properties.Resources.fail);
            emotions.Add("T.T", emtes_trye.Properties.Resources.cry);
            emotions.Add("^<^", emtes_trye.Properties.Resources.smush);
            emotions.Add("<3.<3", emtes_trye.Properties.Resources.love);
            emotions.Add("O_O", emtes_trye.Properties.Resources.wow);
            emotions.Add(":D", emtes_trye.Properties.Resources.happy);
            emotions.Add("¬.¬", emtes_trye.Properties.Resources.me);
            emotions.Add("'._.", emtes_trye.Properties.Resources.what);
            emotions.Add(";)", emtes_trye.Properties.Resources.wink);
            emotions.Add(":(", emtes_trye.Properties.Resources.sad);
            emotions.Add(">.<", emtes_trye.Properties.Resources.scream);
            emotions.Add("<3", emtes_trye.Properties.Resources.heart);
            emotions.Add(":#X", emtes_trye.Properties.Resources.dead);
            emotions.Add("Hambre", emtes_trye.Properties.Resources.hungry);
            emotions.Add("Zzz", emtes_trye.Properties.Resources.boring);
            emotions.Add("Like", emtes_trye.Properties.Resources.like);
           


        }

        void pegaricono (RichTextBox cajadetexto)
        {
            
            foreach (String emote in emotions.Keys)
            {
                while (cajadetexto.Text.Contains(emote))
                {
                    
                   int ind = cajadetexto.Text.IndexOf(emote);
                    cajadetexto.Select(ind,emote.Length);
                    Clipboard.SetImage((Image)emotions[emote]);
                    cajadetexto.Paste();

                    
                
                }
            }
            
        }

        void pasatexto()
        {
            Clipboard.SetText(richTextBox2.Rtf, TextDataFormat.Rtf);

            textBox2.Select(richTextBox2.TextLength - 1, 1);

        
        }
    
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            val = 1;
            
            createicons();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.AppendText(textBox2.Text + "\n");
           
            pegaricono(richTextBox2);
            textBox2.Clear();
            richTextBox1.Clear();
            richTextBox2.ScrollToCaret();
            
            //string richText = new TextRange(richTextBox2.Document.ContentStart, richTextBox2.Document.ContentEnd).Text;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
            
       
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textsend = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.AppendText(">.< ____________________User te envio un zumbido________________ >.<" + "\n");
            pegaricono(richTextBox2);
            richTextBox2.ScrollToCaret();
            while (count < 700)
            {
                switch (val)
                {
                    case 1:
                        this.Location = new Point(this.Location.X - 20, this.Location.Y+20);
                        val++;
                        break;
                    case 2:
                        this.Location = new Point(this.Location.X + 20, this.Location.Y-20);
                        val++;
                        break;
                    case 3:
                        this.Location = new Point(this.Location.X-20, this.Location.Y + 20);
                        val++;
                        break;
                    case 4:
                        this.Location = new Point(this.Location.X+20, this.Location.Y - 20);
                        val++;
                        break;
                    case 5:
                        this.Location = new Point(this.Location.X - 20, this.Location.Y+20);
                        val++;
                        break;
                    case 6:
                        this.Location = new Point(this.Location.X + 20, this.Location.Y-20);
                        val++;
                        break;
                    case 7:
                        this.Location = new Point(this.Location.X-20, this.Location.Y + 20);
                        val++;
                        break;
                    case 8:
                        this.Location = new Point(this.Location.X+20, this.Location.Y - 20);
                        val++;
                        val = 1;
                        break;

                }
                count++;
              

            }
            count = 0;
            zumbido.Play();
            

            
         
        }

        private void button17_Click(object sender, EventArgs e)
        {
            emotesmenu.Visible=true;
        }

        private void kappa_Click(object sender, EventArgs e)
        {
            string emote = "Kappa";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void smile_Click(object sender, EventArgs e)
        {
            string emote = ":)";
            textBox2.Text += emote;
            
            richTextBox1.Text = textBox2.Text;
            //richTextBox1.Text = richTextBox1.Text + ")";
            //richTextBox1.Text +=":";
            //richTextBox1.Text += ")";
            //textBox2.Text += ":)";

            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void sad_Click(object sender, EventArgs e)
        {
            string emote= ":(";
            textBox2.Text += emote;
            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void happy_Click(object sender, EventArgs e)
        {
            string emote = ":D";
            textBox2.Text += emote;
            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void cring_Click(object sender, EventArgs e)
        {
            string emote = "T.T";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";

        }

        private void me_Click(object sender, EventArgs e)
        {
            string emote = "¬.¬";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void scream_Click(object sender, EventArgs e)
        {
            string emote = ">.<";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void whut_Click(object sender, EventArgs e)
        {
            string emote = "'._.";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";

        }

        private void wow_Click(object sender, EventArgs e)
        {
            string emote = "O_O";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void wink_Click(object sender, EventArgs e)
        {
            string emote = ";)";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void smush_Click(object sender, EventArgs e)
        {
            string emote = "^<^";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void like_Click(object sender, EventArgs e)
        {
            string emote = "Like";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void heart_Click(object sender, EventArgs e)
        {
            string emote = "<3";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void faiñ_Click(object sender, EventArgs e)
        {
            string emote = "Fail";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void sleepi_Click(object sender, EventArgs e)
        {
            string emote = "Zzz";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void bcwarior_Click(object sender, EventArgs e)
        {
            string emote = "Pink";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void death_Click(object sender, EventArgs e)
        {
            string emote = ":#X";
            textBox2.Text += emote;

            richTextBox1.Text = textBox2.Text;
            textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            emotesmenu.Visible = false;
            emote = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string lastchar = richTextBox1.Text;
            if(lastchar!="")
            {
                textBox2.Text += lastchar.Substring(lastchar.Length - 1, 1);
                
            }
            pegaricono(richTextBox1);
            
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            
          
        }
       }
    }

