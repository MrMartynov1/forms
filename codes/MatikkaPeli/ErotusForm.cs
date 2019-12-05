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
    public partial class GameForm2 : Form
    {
        Random rng3 = new Random(Guid.NewGuid().GetHashCode());
        Random rng4 = new Random(Guid.NewGuid().GetHashCode());
        int tulos;
        public int oikein2 = 0;
        public int saavutus2 = 0;
        public int maxnum2;

        public GameForm2(int max2)
        {
            InitializeComponent();
            maxnum2 = max2;
            Gamelogic();
        }

        public void Gamelogic()
        {
            
            int j = rng3.Next(maxnum2);
            int k = rng4.Next(maxnum2);

            if (j > k)
            {
                lbnum3.Text = "" + k;
                lbnum4.Text = "" + j;
                tulos = j + k;
            }
            else
            {
                lbnum3.Text = "" + j;
                lbnum4.Text = "" + k;
                tulos = k + j;
            }

        }



        private void btnCheck2_Click(object sender, EventArgs e)
        {
            int m;
            Int32.TryParse(tbnum2.Text, out m);
            if (tbnum2.Text != "")
            {
                if (tulos == m)
                {
                    oikein2++;
                    MessageBox.Show("Lasku oikein!", "Oikein", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (oikein2 == 10)
                    {
                        MessageBox.Show("Sait 10 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus2++;
                    }
                    else if (oikein2 == 50)
                    {
                        MessageBox.Show("Sait 50 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus2++;
                    }
                    else if (oikein2 == 100)
                    {
                        MessageBox.Show("Sait 100 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus2++;
                    }
                    else if (oikein2 == 150)
                    {
                        MessageBox.Show("Sait 150 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus2++;
                    }
                    else if (oikein2 == 200)
                    {
                        MessageBox.Show("Sait 200 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus2++;
                    }
                    else if (oikein2 == 300)
                    {
                        MessageBox.Show("Sait 300 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus2++;
                    }
                    else if (oikein2 == 400)
                    {
                        MessageBox.Show("Sait 400 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus2++;
                    }
                    else if (oikein2 == 500)
                    {
                        MessageBox.Show("Sait 500 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus2++;
                    }
                    else if (oikein2 == 750)
                    {
                        MessageBox.Show("Sait 750 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus2++;
                    }
                    else if (oikein2 == 1000)
                    {
                        MessageBox.Show("Sait 1000 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus2++;
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
            tbnum2.Text = "";
        }

        private void GameForm2_Load(object sender, EventArgs e)
        {

        }

        private void btnEroBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
