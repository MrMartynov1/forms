using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DialogResult Answer = DialogResult.No;
            do
            {
                Answer = MessageBox.Show("Valitse YES jatkaaksesi tai NO lopettaaksesi.", "While", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            while (Answer == DialogResult.Yes);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
