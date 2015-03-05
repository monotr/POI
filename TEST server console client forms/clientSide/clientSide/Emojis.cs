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
            emotions.Add("O.O", clientSide.Properties.Resources.wow);
            emotions.Add(":D", clientSide.Properties.Resources.happy);
            emotions.Add("¬.¬", clientSide.Properties.Resources.me);
            emotions.Add("?-?", clientSide.Properties.Resources.what);
            emotions.Add(";)", clientSide.Properties.Resources.wink);
            emotions.Add(":'(", clientSide.Properties.Resources.sad);
            emotions.Add(">_<", clientSide.Properties.Resources.scream);
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

        public static void pasatexto(TextBox texto1, RichTextBox textoRico)
        {
            Clipboard.SetText(textoRico.Rtf, TextDataFormat.Rtf);
            texto1.Select(textoRico.TextLength - 1, 1);
        }
    }
}
