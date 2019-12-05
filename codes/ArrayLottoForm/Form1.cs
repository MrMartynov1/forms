using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayLottoForm
{
    public partial class Form1 : Form
    {
        Random rng = new Random(Guid.NewGuid().GetHashCode());
        int f = 40;
        List<int> numerot = new List<int>();
        List<int> veikkaus = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            numerot.Clear();
            for (int i = 0; i < 10; i++)
            {
                int g = rng.Next(f);
                if (numerot.Contains(g))
                {
                    i--;
                }
                else
                {
                    numerot.Add(g);
                }
                
            }

            //järjestä luvut
            numerot.Sort();
            //tulosta luvut
            int vuoro = numerot.Count()-1;
            foreach (Label luku in Controls.OfType<Label>())
            {
                if(luku.Name != ("label1") && luku.Name != ("lbKuinkaMonta"))
                {
                    luku.Text = numerot[vuoro].ToString();
                    vuoro--;
                }
            }

       

        }

        private void btnTarkista_Click(object sender, EventArgs e)
        {
            
            int b;
            foreach (TextBox arvaus in Controls.OfType<TextBox>())
            {
                bool muunnos = Int32.TryParse(arvaus.Text, out b);
                
                if (muunnos)
                {
                    if (b <= 40)
                    {
                        veikkaus.Add(b);
                        var jotaintesti = veikkaus.Except(numerot).ToList();
                        lbKuinkaMonta.Text = jotaintesti.Count.ToString();
                        //
                        //
                    }
                    else
                    {
                        arvaus.BackColor = Color.Red;
                        MessageBox.Show("Numero ei saa olla yli 40!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    arvaus.BackColor = Color.Red;
                    MessageBox.Show("Tarkistettava saa olla vain numero!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            /*

            if (lb1.Text != "" | lb1.Text != null)
            {
                try
                {
                    if (muunnos)
                    {
                        int y = numerot[b];
                        lbKuinkaMonta.Text = y.ToString();
                    }
                    else
                    {
                        tbP1.Text = "";
                        MessageBox.Show("Syöttö saa olla vain numeroita!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    tbP1.Text = "";
                    MessageBox.Show("Näin suurta numeroa ei sallita!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tbP1.Text = "";
                MessageBox.Show("Ylemmässä osassa ei olla vielä arvottu mitään!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
            //tbstä veikkaus-listaan
            //For-loop
            //tbP1.Text = "";
            

            //var jotaintesti = veikkaus.Except(numerot).ToList();
            //lbKuinkaMonta.Text = jotaintesti.Count.ToString();

        }

        private void tbP1_Enter(object sender, EventArgs e)
        {
            tbP1.BackColor= Color.White;
        }

        private void tbP2_Enter(object sender, EventArgs e)
        {
            tbP2.BackColor = Color.White;
        }

        private void tbP3_Enter(object sender, EventArgs e)
        {
            tbP3.BackColor = Color.White;
        }

        private void tbP4_Enter(object sender, EventArgs e)
        {
            tbP4.BackColor = Color.White;
        }

        private void tbP5_Enter(object sender, EventArgs e)
        {
            tbP5.BackColor = Color.White;
        }

        private void tbP6_Enter(object sender, EventArgs e)
        {
            tbP6.BackColor = Color.White;
        }

        private void tbP7_Enter(object sender, EventArgs e)
        {
            tbP7.BackColor = Color.White;
        }

        private void tbP8_Enter(object sender, EventArgs e)
        {
            tbP8.BackColor = Color.White;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
