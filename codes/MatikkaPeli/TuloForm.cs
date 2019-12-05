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
    public partial class GameForm3 : Form
    {
        Random rng5 = new Random(Guid.NewGuid().GetHashCode());
        Random rng6 = new Random(Guid.NewGuid().GetHashCode());
        int tulos;
        public int oikein3 = 0;
        public int saavutus3 = 0;
        public int maxnum3;

        public GameForm3(int max3)
        {
            InitializeComponent();
            maxnum3 = max3;
            Gamelogic();
        }

        public void Gamelogic()
        {
            while (true)
            {
                int f = rng5.Next(1,maxnum3);
                int d = rng6.Next(1,maxnum3);
                if (f > d)
                {
                    if (f % d == 0)
                    {
                        lbnum5.Text = "" + d;
                        lbnum6.Text = "" + f;
                        tulos = f / d;
                        break;
                    }
                    
                }
                else
                {
                    if (d % f == 0)
                    {
                        lbnum5.Text = "" + f;
                        lbnum6.Text = "" + d;
                        tulos = d / f;
                        break;
                    }
                }
            }

        }



        private void btnCheck3_Click(object sender, EventArgs e)
        {
            int n;
            Int32.TryParse(tbnum3.Text, out n);
            if (tbnum3.Text != "")
            {
                if (tulos == n)
                {
                    oikein3++;
                    MessageBox.Show("Lasku oikein!", "Oikein", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (oikein3 == 10)
                    {
                        MessageBox.Show("Sait 10 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus3++;
                    }
                    else if (oikein3 == 50)
                    {
                        MessageBox.Show("Sait 50 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus3++;
                    }
                    else if (oikein3 == 100)
                    {
                        MessageBox.Show("Sait 100 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus3++;
                    }
                    else if (oikein3 == 150)
                    {
                        MessageBox.Show("Sait 150 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus3++;
                    }
                    else if (oikein3 == 200)
                    {
                        MessageBox.Show("Sait 200 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus3++;
                    }
                    else if (oikein3 == 300)
                    {
                        MessageBox.Show("Sait 300 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus3++;
                    }
                    else if (oikein3 == 400)
                    {
                        MessageBox.Show("Sait 400 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus3++;
                    }
                    else if (oikein3 == 500)
                    {
                        MessageBox.Show("Sait 500 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus3++;
                    }
                    else if (oikein3 == 750)
                    {
                        MessageBox.Show("Sait 750 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus3++;
                    }
                    else if (oikein3 == 1000)
                    {
                        MessageBox.Show("Sait 1000 laskua oikein!", "Saavutus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        saavutus3++;
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
            tbnum3.Text = "";
        }

        private void btnTulBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
