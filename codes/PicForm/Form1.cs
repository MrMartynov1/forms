using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicForm
{
    public partial class Form1 : Form
    {
        Point piste = new Point(0, 0);
        Bitmap hessu = new Bitmap(Properties.Resources.HessuHopo);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PaintMouseForm_Paint(object sender, PaintEventArgs e)

        {
            //Bitmap Graf = hessu;
            //Graphics Box = e.Graphics;
            //Rectangle mainrect = new Rectangle(50,50,177,335);

            // Kutsutaan DrawCoordinates()-metodia.
            //bool Control.DoubleBuffered(true);
            hessu.MakeTransparent();
            e.Graphics.DrawImage(hessu, piste.X, piste.Y);
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
    }
}
