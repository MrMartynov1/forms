using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryForm
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> jotain;
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
            jotain = new Dictionary<string, string>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb1.Text.Length != 2 && tb1.Text != "")
                {
                    //
                    if (tb2.Text != "")
                    {
                        jotain.Add(tb1.Text,tb2.Text);
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
                    MessageBox.Show("Syöte hyväksyy vain yhtä kirjainta tai on tyhjä!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                tb1.Text = "";
                tb2.Text = "";
                MessageBox.Show("Dictionarya ei ole luotu tai kyseinen kirjain on jo asetettu!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jotain.ContainsKey(tb1.Text))
            {
                lb8.Text = jotain[tb1.Text];
            }
            else
            {
                tb3.Text = "";
                MessageBox.Show("Kyseiselle kirjaimelle / avaimelle ei ole asetettu arvoa!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
