using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMouseForm
{
    public partial class Form1 : Form
    {
        // MainFrom:n alkuun määritellään koordinaattipiste(x,y), joka on käytössä koko lomakkeella.
        //Tällä pisteellä määritämme mistä aloitamme piirtämisen. Formin vasen ylänurkka on 0,0
        //piste  
        Point piste = new Point(0, 0);
        // Talletetaan grafiikkaobjekti. Grafiikkaobjekti tarvitaan 
        // grafikan piirtämiseksi näytölle.
        private void PaintMouseForm_Paint(object sender, PaintEventArgs e)

        {

            Graphics Graf = e.Graphics;

            // - Pää
            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);
            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            // - Selkä
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41,
            piste.X + 21, piste.Y + 131);

            // - Kädet
            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60,
            piste.X + 70, piste.Y + 60);

            // - Jalat
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,
            piste.X - 30, piste.Y + 181);
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,
            piste.X + 70, piste.Y + 181);

            // Kutsutaan DrawCoordinates()-metodia.
            DrawCordinates(Graf);

        }

        // DrawCoordinates() -metodi PIIRTÄÄ pisteen koordinaatit lomakkeelle.
        private void DrawCordinates(Graphics Graf)

        {
            // Piirretään piikoordinaattien arvot näytölle.
            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",
            new Font("Arial", 14, System.Drawing.FontStyle.Regular),
            new SolidBrush(Color.Black), 8, 30);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)

        {
            if (e.Button == MouseButtons.Left)
            {
                // Talletetaan hiiren klikkauskohdan koordinaatit. Piste (0, 0) 
                // on formin työalueen vasemmassa ylä nurkassa 
                piste = e.Location;

                // Merkitään formin työalue epäkelvoksi, jolloin saadaan aikaiseksi 
                // paint-eventin signalointi ja tämän jälkeen Paint()-metodin kutsu.
                Invalidate();
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tb1.Text != "")
            {
                if (tb2.Text != "")
                {
                    Invalidate();
                    piste = new Point(int.Parse(tb1.Text), int.Parse(tb2.Text));
                }
                else
                {
                    tb2.Text = "";
                    MessageBox.Show("Syöte on tyhjä!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tb1.Text = "";
                MessageBox.Show("Syöte on tyhjä!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PaintMouseForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)

        {
            if (e.KeyCode == Keys.S)
            {
                Invalidate();
                piste.Y++;
            }
            else if (e.KeyCode == Keys.A)
            {
                Invalidate();
                piste.X--;
            }
            else if (e.KeyCode == Keys.W)
            {
                Invalidate();
                piste.Y--;
            }
            else if (e.KeyCode == Keys.D)
            {
                Invalidate();
                piste.X++;
            }

        }

        private void PaintMouseForm_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)

        {
                //Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
