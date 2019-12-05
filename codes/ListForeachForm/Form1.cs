using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListForeachForm
{
    public partial class Form1 : Form
    {
        List<string> asioita;
        //int x;
        public Form1()
        {
            InitializeComponent();
        }

        private void listb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            asioita = new List<string>();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb1.Text != "")
                {
                    asioita.Add(tb1.Text);

                }
                else
                {
                    tb1.Text = "";
                    MessageBox.Show("Syöte on tyhjä!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                tb1.Text = "";
                MessageBox.Show("Taulukkoa  ei ole luotu!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            foreach (string tamanain in asioita)
            {
                cb1.Items.Add(tamanain);
            }
        }

        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
