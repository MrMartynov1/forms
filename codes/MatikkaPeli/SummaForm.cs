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
    public partial class GameForm1 : Form
    {
        Random rng1 = new Random(Guid.NewGuid().GetHashCode());
        Random rng2 = new Random(Guid.NewGuid().GetHashCode());
        int tulos;
        public int oikein1 = 0;
        public int saavutus1 = 0;
        public int maxnum1;

        public GameForm1(int max1)
        {
            InitializeComponent();
            maxnum1 = max1;
            Gamelogic();
        }

        public void Gamelogic()
        {
            
            int h = rng1.Next(maxnum1);
            int g = rng2.Next(maxnum1);
            
            if (h > g)
            {
                lbnum1.Text = "" + g;
                lbnum2.Text = "" + h;
                tulos = h - g;
            }
            else
            {
                lbnum1.Text = "" + h;
                lbnum2.Text = "" + g;
                tulos = g - h;
            }

            
        }

        private void btnCheck1_Click(object sender, EventArgs e)
        {
            int k;
            Int32.TryParse(tbnum1.Text, out k);
            if (tbnum1.Text != "")
            {
                if (tulos == k)
                {
                    oikein1++;
                    MessageBox.Show("Lasku oikein!", "Oikein", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (oikein1 == 10)
                    {
                        MessageBox.Show("Sait 10 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus1++;
                    }
                    else if (oikein1 == 50)
                    {
                        MessageBox.Show("Sait 50 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus1++;
                    }
                    else if (oikein1 == 100)
                    {
                        MessageBox.Show("Sait 100 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus1++;
                    }
                    else if (oikein1 == 150)
                    {
                        MessageBox.Show("Sait 150 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus1++;
                    }
                    else if (oikein1 == 200)
                    {
                        MessageBox.Show("Sait 200 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus1++;
                    }
                    else if (oikein1 == 300)
                    {
                        MessageBox.Show("Sait 300 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus1++;
                    }
                    else if (oikein1 == 400)
                    {
                        MessageBox.Show("Sait 400 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus1++;
                    }
                    else if (oikein1 == 500)
                    {
                        MessageBox.Show("Sait 500 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus1++;
                    }
                    else if (oikein1 == 750)
                    {
                        MessageBox.Show("Sait 750 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus1++;
                    }
                    else if (oikein1 == 1000)
                    {
                        MessageBox.Show("Sait 1000 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus1++;
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
            tbnum1.Text = "";
        }

        private void GameForm1_Load(object sender, EventArgs e)
        {

        }

        private void btnSumBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
