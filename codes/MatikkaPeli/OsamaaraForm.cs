using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatikkaPeli
{
    public partial class GameForm4 : Form
    {
        Random rng7 = new Random(Guid.NewGuid().GetHashCode());
        Random rng8 = new Random(Guid.NewGuid().GetHashCode());
        int tulos;
        public int oikein4 = 0;
        public int saavutus4 = 0;
        public int maxnum4;

        public GameForm4(int max4)
        {
            InitializeComponent();
            maxnum4 = max4;
            Gamelogic();
        }

        public void Gamelogic()
        {
            
            int v = rng7.Next(maxnum4);
            int b = rng8.Next(maxnum4);

            if (v > b)
            {
                lbnum7.Text = "" + b;
                lbnum8.Text = "" + v;
                tulos = v * b;
            }
            else
            {
                lbnum7.Text = "" + v;
                lbnum8.Text = "" + b;
                tulos = b * v;
            }

        }



        private void btnCheck4_Click(object sender, EventArgs e)
        {
            int p;
            Int32.TryParse(tbnum4.Text, out p);
            if (tbnum4.Text != "")
            {
                if (tulos == p)
                {
                    oikein4++;
                    MessageBox.Show("Lasku oikein!", "Oikein", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (oikein4 == 10)
                    {
                        MessageBox.Show("Sait 10 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus4++;
                    }
                    else if (oikein4 == 50)
                    {
                        MessageBox.Show("Sait 50 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus4++;
                    }
                    else if (oikein4 == 100)
                    {
                        MessageBox.Show("Sait 100 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus4++;
                    }
                    else if (oikein4 == 150)
                    {
                        MessageBox.Show("Sait 150 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus4++;
                    }
                    else if (oikein4 == 200)
                    {
                        MessageBox.Show("Sait 200 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus4++;
                    }
                    else if (oikein4 == 300)
                    {
                        MessageBox.Show("Sait 300 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus4++;
                    }
                    else if (oikein4 == 400)
                    {
                        MessageBox.Show("Sait 400 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus4++;
                    }
                    else if (oikein4 == 500)
                    {
                        MessageBox.Show("Sait 500 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus4++;
                    }
                    else if (oikein4 == 750)
                    {
                        MessageBox.Show("Sait 750 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus4++;
                    }
                    else if (oikein4 == 1000)
                    {
                        MessageBox.Show("Sait 1000 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus4++;
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Lasku väärin!", "Väärin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Syötä luku!", "Tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Gamelogic();
            tbnum4.Text = "";
        }

        private void GameForm4_Load(object sender, EventArgs e)
        {

        }

        private void btnOsaBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
