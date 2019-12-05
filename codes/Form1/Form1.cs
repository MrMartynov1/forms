using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Elokuvasovellus : Form
    {
        int num = 0;
        int x = 0;
        public Elokuvasovellus()
        {
            InitializeComponent();
            tbID.Text = "0";
            tbNimi.Text = "[Syötä Elokuvan nimi]";
            tbVuosi.Text = DateTime.Now.Year.ToString();
            tbKesto.Text = "0";
            rtbArvio.Text = "[Kirjoita arvio tähän]";
            numudArvio1.Minimum = 0;
            numudArvio1.Maximum = 10;
            numudArvio2.Minimum = 0;
            
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
   
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tietojaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© Artturi Martynov 2019", "Tietoja",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnEdellinen_Click(object sender, EventArgs e)
        {

        }
        
        private void btnUusi_Click(object sender, EventArgs e)
        {
            num++;
            tbID.Text = ""+num;
            tbNimi.Text = "[Syötä Elokuvan nimi]";
            tbVuosi.Text = DateTime.Now.Year.ToString();
            tbKesto.Text = "0";
            rtbArvio.Text = "[Kirjoita arvio tähän]";
            numudArvio1.Value = 0;
            numudArvio2.Value = 0;
        }

        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numudArvio2_ValueChanged(object sender, EventArgs e)
        {
            if (numudArvio1.Value == 10)
            {
                numudArvio2.Maximum = 0;
            }
            else
            {
                numudArvio2.Maximum = 9;
            }
        }

        private void tbNimi_Enter(object sender, EventArgs e)
        {
            tbNimi.Text = "";
        }

        private void tbVuosi_Enter(object sender, EventArgs e)
        {
            tbVuosi.Text = "";
        }

        private void tbKesto_Enter(object sender, EventArgs e)
        {
            tbKesto.Text = "";
        }

        private void rtbArvio_Enter(object sender, EventArgs e)
        {
            rtbArvio.Text = "";
        }

        private void tbKesto_Leave(object sender, EventArgs e)
        {
            tbKesto.Text = "0";
        }

        private void tbVuosi_Leave(object sender, EventArgs e)
        {
            tbVuosi.Text = DateTime.Now.Year.ToString();
        }

        private void tbNimi_Leave(object sender, EventArgs e)
        {
            tbNimi.Text = "[Syötä Elokuvan nimi]";
        }

        private void rtbArvio_Leave(object sender, EventArgs e)
        {
            //rtbArvio.Text = "[Kirjoita arvio tähän]";
            if (rtbArvio.Text != "[Kirjoita arvio tähän]")
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            if (tbNimi.Text == "" | tbNimi.Text == "[Syötä Elokuvan nimi]")
            {
                MessageBox.Show("Et ole antanut elokuvan nimeä!", "Tallenna", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbVuosi.Text == "" | tbVuosi.Text == "0")
            {
                MessageBox.Show("Et ole asettanut vuotta!", "Tallenna", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbKesto.Text == "" | tbKesto.Text == "0")
            {
                MessageBox.Show("Et ole asettanut elokuvan kestoa!", "Tallenna", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rtbArvio.Text == "")
            {
                MessageBox.Show("Et ole syöttänut arviota!", "Tallenna", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(tbVuosi.Text, out x))
            {
                MessageBox.Show("Vuosi ei ole vain numeroita!", "Tallenna", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(tbKesto.Text, out x))
            {
                MessageBox.Show("Kesto ei ole vain numeroita!", "Tallenna", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                //Tallentaa - Lisää jotain tänne.
                MessageBox.Show("Tiedot tallennettu", "Tallenna", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSeuraava_Click(object sender, EventArgs e)
        {

        }
    }
}
