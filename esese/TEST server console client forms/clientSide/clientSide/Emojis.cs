using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;





namespace clientSide
{
    class Emojis
    {
        public static Hashtable emotions;
        public static void createicons()
        {
            emotions = new Hashtable(1);
            emotions.Add(":)", clientSide.Properties.Resources.smile);
            emotions.Add("Kappa", clientSide.Properties.Resources.kappa);
            emotions.Add("Pink", clientSide.Properties.Resources.pink);
            emotions.Add("Fail", clientSide.Properties.Resources.fail);
            emotions.Add("T.T", clientSide.Properties.Resources.cry);
            emotions.Add("^<^", clientSide.Properties.Resources.smush);
            emotions.Add("<3.<3", clientSide.Properties.Resources.love);
            emotions.Add("O_O", clientSide.Properties.Resources.wow);
            emotions.Add(":D", clientSide.Properties.Resources.happy);
            emotions.Add("¬.¬", clientSide.Properties.Resources.me);
            emotions.Add("._.", clientSide.Properties.Resources.what);
            emotions.Add(";)", clientSide.Properties.Resources.wink);
            emotions.Add(":(", clientSide.Properties.Resources.sad);
            emotions.Add(">.<", clientSide.Properties.Resources.scream);
            emotions.Add("<3", clientSide.Properties.Resources.heart);
            emotions.Add(":#X", clientSide.Properties.Resources.dead);
            emotions.Add("Hambre", clientSide.Properties.Resources.hungry);
            emotions.Add("Zzz", clientSide.Properties.Resources.boring);
            emotions.Add("Like", clientSide.Properties.Resources.like);
        }

        public static void pegaricono(string texto1, RichTextBox textoRico)
        {
            textoRico.AppendText("\n" + " >> " + texto1);
            foreach (String emote in emotions.Keys)
            {
                while (textoRico.Text.Contains(emote))
                {
                    int ind = textoRico.Text.IndexOf(emote);
                    textoRico.Select(ind, emote.Length);
                    Clipboard.SetImage((Image)emotions[emote]);
                    textoRico.Paste();
                }
            }
        }

        public static void pegaricono2(RichTextBox cajadetexto)
        {

            foreach (String emote in emotions.Keys)
            {
                while (cajadetexto.Text.Contains(emote))
                {

                    int ind = cajadetexto.Text.IndexOf(emote);
                    cajadetexto.Select(ind, emote.Length);
                    Clipboard.SetImage((Image)emotions[emote]);
                    cajadetexto.Paste();



                }
            }
        }

        public static void pasatexto(TextBox texto1, RichTextBox textoRico)
        {
            Clipboard.SetText(textoRico.Rtf, TextDataFormat.Rtf);
            texto1.Select(textoRico.TextLength - 1, 1);
        }

        public static string cambioaemojis (string emoji,RichTextBox ricotex, TextBox tex)
        {
            string chain="";
            switch(emoji)
            {
                case "kappa":
                    chain = "Kappa";
            
                break;

                case ":)":
                chain = ":)";
                    break;

                case ":(":
                    chain = ":(";
                    break;

                case ":D" :
                    chain= ":D";
                    break;

                case "T.T":
                    chain= "T.T";
                    break;

                case  "¬.¬":
                    chain=  "¬.¬";
                    break;

                 case ">.<":
                    chain= ">.<";
                    break;

                 case"._." :
                    chain="._." ;
                    break;

                 case"O_O" :
                    chain= "O_O";
                    break;

                 case";)" :
                    chain = ";)";
                    break;

                 case "^<^":
                    chain = "^<^";
                    break;

                 case "Like":
                    chain = "Like";
                    break;

                 case "<3":
                    chain = "<3";
                    break;

                 case "Fail":
                    chain = "Fail";
                    break;

                 case "Zzz":
                    chain = "Zzz";
                    break;

                 case "Pink":
                    chain = "Pink";
                    break;


                 case ":#X":
                    chain = ":#X";
                    break;

            }
            tex.Text += chain;

            //ricotex.Text = tex.Text;
            //tex.Text = tex.Text.Substring(0, (tex.TextLength - 1));
            
            return "";
        }
    }
}
