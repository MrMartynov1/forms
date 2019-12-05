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
    public partial class MainMenuForm : Form
    {
        public int saavutus1;
        public int saavutus2;
        public int saavutus3;
        public int saavutus4;
        public int oikein1;
        public int oikein2;
        public int oikein3;
        public int oikein4;
        public int maxnum = 100;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            FormMode FormMode = new FormMode(maxnum);
            FormMode.ShowDialog();
            this.Show();
            saavutus1 = saavutus1 + FormMode.saavutus1;
            oikein1 = oikein1 + FormMode.oikein1;

            saavutus2 = saavutus2 + FormMode.saavutus2;
            oikein2 = oikein2 + FormMode.oikein2;

            saavutus3 = saavutus3 + FormMode.saavutus3;
            oikein3 = oikein3 + FormMode.oikein3;

            saavutus4 = saavutus4 + FormMode.saavutus4;
            oikein4 = oikein4 + FormMode.oikein4;


        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            ResultsForm ResultsForm = new ResultsForm(oikein1, oikein2, oikein3, oikein4,saavutus1,saavutus2,saavutus3,saavutus4);
            //this.Hide();
            ResultsForm.ShowDialog();
            this.Show();
        }

        private void btnAchiev_Click(object sender, EventArgs e)
        {
            AchievementForm AchievementForm = new AchievementForm(saavutus1,saavutus2,saavutus3,saavutus4);
            //this.Hide();
            AchievementForm.ShowDialog();
            this.Show();
        }

        public void radiochecker(object sender, EventArgs e)
        {
            if (rbdiff1.Checked)
            {
                maxnum = 10;
            }
            else if (rbdiff2.Checked)
            {
                maxnum = 100;
            }
            else if (rbdiff3.Checked)
            {
                maxnum = 1000;
            }
            else
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }


}
