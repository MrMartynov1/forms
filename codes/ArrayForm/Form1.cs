using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayForm
{
    public partial class Form1 : Form
    {
        int[] luvut;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTaulukko_Click(object sender, EventArgs e)
        {
            int x;
            if(Int32.TryParse(tbTaulukko.Text, out x))
            {
                luvut = new int[x];
            }
            else
            {
                tbTaulukko.Text = "";
                MessageBox.Show("Taulukon suuruus saa olla vain numeroita!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTalleta_Click(object sender, EventArgs e)
        {
            int y;
            int z;
            if(Int32.TryParse(tbNum.Text , out y))
            {
                if(Int32.TryParse(tIndex1.Text, out z))
                {
                    luvut[z] = y;
                }
                else
                {
                    tIndex1.Text = "";
                    MessageBox.Show("Indeksi saa olla vain numeroita!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
            else
            {
                tbNum.Text = "";
                MessageBox.Show("Vain numerot sallittuja!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnHaku_Click(object sender, EventArgs e)
        {
            int b;
            bool muunnos= Int32.TryParse(tbIndex2.Text, out b);
            try
            {
                if (muunnos)
                {
                    int y = luvut[b];
                    lbFinal.Text = y.ToString();
                }
                else
                {
                    tIndex1.Text = "";
                    MessageBox.Show("Indeksi saa olla vain numeroita!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                tbIndex2.Text = "";
                MessageBox.Show("Taulukko ei ole niin suuri!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbTaulukko_Enter(object sender, EventArgs e)
        {

        }

        private void tbTaulukko_Leave(object sender, EventArgs e)
        {

        }

        private void tbNum_Enter(object sender, EventArgs e)
        {

        }

        private void tbNum_Leave(object sender, EventArgs e)
        {

        }

        private void tIndex1_Enter(object sender, EventArgs e)
        {

        }

        private void tIndex1_Leave(object sender, EventArgs e)
        {

        }

        private void tbIndex2_Enter(object sender, EventArgs e)
        {

        }

        private void tbIndex2_Leave(object sender, EventArgs e)
        {

        }
        
    }
}
