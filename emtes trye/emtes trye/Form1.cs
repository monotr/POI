using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace emtes_trye
{
    
    public partial class Form1 : Form
    {
        //bool send;
        string textsend;
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
            emotions.Add("O.O", emtes_trye.Properties.Resources.wow);
            emotions.Add(":D", emtes_trye.Properties.Resources.happy);
            emotions.Add("¬.¬", emtes_trye.Properties.Resources.me);
            emotions.Add("?-?", emtes_trye.Properties.Resources.what);
            emotions.Add(";)", emtes_trye.Properties.Resources.wink);
            emotions.Add(":'(", emtes_trye.Properties.Resources.sad);
            emotions.Add(">_<", emtes_trye.Properties.Resources.scream);
            emotions.Add("<3", emtes_trye.Properties.Resources.heart);
            emotions.Add(":#X", emtes_trye.Properties.Resources.dead);
            emotions.Add("Hambre", emtes_trye.Properties.Resources.hungry);
            emotions.Add("Zzz", emtes_trye.Properties.Resources.boring);
            emotions.Add("Like", emtes_trye.Properties.Resources.like);
           


        }

        void pegaricono ()
        {
            richTextBox2.AppendText(textBox2.Text+"\n");
            foreach (String emote in emotions.Keys)
            {
                while (richTextBox2.Text.Contains(emote))
                {
                    
                   int ind = richTextBox2.Text.IndexOf(emote);
                    richTextBox2.Select(ind,emote.Length);
                    Clipboard.SetImage((Image)emotions[emote]);
                    richTextBox2.Paste();

                    textBox2.Clear();
                
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
            
            createicons();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pegaricono();
            textBox2.Clear();
            
            //string richText = new TextRange(richTextBox2.Document.ContentStart, richTextBox2.Document.ContentEnd).Text;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
            
       
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textsend = textBox2.Text;
        }
       }
    }

