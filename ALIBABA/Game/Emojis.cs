using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace Game
{
    class Emojis
    {
        public static Hashtable emotions;
        public static void createicons()
        {
            emotions = new Hashtable(1);
            emotions.Add(":)", Game.Properties.Resources.smile);
            emotions.Add("Kappa", Game.Properties.Resources.kappa);
            emotions.Add("Pink", Game.Properties.Resources.pink);
            emotions.Add("Fail", Game.Properties.Resources.fail);
            emotions.Add("T.T", Game.Properties.Resources.cry);
            emotions.Add("^<^", Game.Properties.Resources.smush);
            emotions.Add("<3.<3", Game.Properties.Resources.love);
            emotions.Add("O.O", Game.Properties.Resources.wow);
            emotions.Add(":D", Game.Properties.Resources.happy);
            emotions.Add("¬.¬", Game.Properties.Resources.me);
            emotions.Add("?-?", Game.Properties.Resources.what);
            emotions.Add(";)", Game.Properties.Resources.wink);
            emotions.Add(":'(", Game.Properties.Resources.sad);
            emotions.Add(">_<", Game.Properties.Resources.scream);
            emotions.Add("<3", Game.Properties.Resources.heart);
            emotions.Add(":#X", Game.Properties.Resources.dead);
            emotions.Add("Hambre", Game.Properties.Resources.hungry);
            emotions.Add("Zzz", Game.Properties.Resources.boring);
            emotions.Add("Like", Game.Properties.Resources.like);
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
