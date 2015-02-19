using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace serpientesYescaleras
{
    public partial class Form1 : Form
    {
        int turno = 1;
        int[] posJugador;
        List<PictureBox> fichasJugadores;
        int[] posOriginal;
        public Form1()
        {
            InitializeComponent();

            posJugador = new int[3];
            posJugador[0] = 1;
            posJugador[1] = 1;
            posJugador[2] = 1;

            fichasJugadores = new List<PictureBox>();
            fichasJugadores.Add(player1_image);
            fichasJugadores.Add(player2_image);
            fichasJugadores.Add(player3_image);

            posOriginal = new int[6];
            posOriginal[0] = player1_image.Location.X;
            posOriginal[1] = player1_image.Location.Y;
            posOriginal[2] = player2_image.Location.X;
            posOriginal[3] = player2_image.Location.Y;
            posOriginal[4] = player3_image.Location.X;
            posOriginal[5] = player3_image.Location.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 6);
            dice_image.Image = diceList_image.Images[randomNumber];

            for (int dice = 0; dice < (randomNumber + 1); dice++)
            {
                if (posJugador[turno - 1] != 63)
                {
                    if (posJugador[turno - 1] % 8 == 0)
                    {
                        serpiente_escalera(0,-1);
                    }
                    else if ((posJugador[turno - 1] > 8 && posJugador[turno - 1] < 16) ||
                        (posJugador[turno - 1] > 24 && posJugador[turno - 1] < 32) ||
                        (posJugador[turno - 1] > 40 && posJugador[turno - 1] < 48) ||
                        (posJugador[turno - 1] > 56 && posJugador[turno - 1] < 63))
                    {
                        serpiente_escalera(-1,0);
                    }
                    else
                    {
                        serpiente_escalera(1,0);
                    }

                    posJugador[turno - 1]++;
                }
            }

            //////escaleras
            if (posJugador[turno - 1] == 3 || posJugador[turno - 1] == 24)
            {
                serpiente_escalera(-1, -2);
                posJugador[turno - 1]+= 15;
            }
            else if (posJugador[turno - 1] == 29)
            {
                serpiente_escalera(1, -3);
                posJugador[turno - 1] += 24;
            }
            else if (posJugador[turno - 1] == 48)
            {
                serpiente_escalera(1, -2);
                posJugador[turno - 1] += 15;
            }

            //////serpientes
            if (posJugador[turno - 1] == 19)
            {
                serpiente_escalera(2, 2);
                posJugador[turno - 1] -= 14;
            }
            else if (posJugador[turno - 1] == 27)
            {
                serpiente_escalera(2, 3);
                posJugador[turno - 1] -= 19;
            }
            else if (posJugador[turno - 1] == 58)
            {
                serpiente_escalera(1, 2);
                posJugador[turno - 1] -= 17;
            }
            else if (posJugador[turno - 1] == 62)
            {
                serpiente_escalera(-2, 4);
                posJugador[turno - 1] -= 30;
            }

            turno++;
            if (turno == 4)
                turno = 1;
            turno_label.Text = "Turno: Jugador " + turno;
            
        }

        private void serpiente_escalera(int movX, int movY)
        {
            for (int i = 0; i < 50; i++)
            {
                fichasJugadores[turno - 1].Location = new Point(fichasJugadores[turno - 1].Location.X + movX,
                            fichasJugadores[turno - 1].Location.Y + movY);
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            player1_image.Location = new Point(posOriginal[0], posOriginal[1]);
            player2_image.Location = new Point(posOriginal[2], posOriginal[3]);
            player3_image.Location = new Point(posOriginal[4], posOriginal[5]);

            turno = 1;

            posJugador[0] = 1;
            posJugador[1] = 1;
            posJugador[2] = 1;
        }
    }
}
