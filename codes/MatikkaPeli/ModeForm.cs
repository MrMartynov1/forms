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
    public partial class FormMode : Form
    {
        public int saavutus1;
        public int saavutus2;
        public int saavutus3;
        public int saavutus4;
        public int oikein1;
        public int oikein2;
        public int oikein3;
        public int oikein4;
        public int maxnum;

        public FormMode(int max1)
        {
            InitializeComponent();
            maxnum = max1;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            GameForm1 GameForm1 = new GameForm1(maxnum);
            this.Hide();
            GameForm1.ShowDialog();
            saavutus1 = GameForm1.saavutus1;
            oikein1 = GameForm1.oikein1;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            GameForm2 GameForm2 = new GameForm2(maxnum);
            this.Hide();
            GameForm2.ShowDialog();
            saavutus2 = GameForm2.saavutus2;
            oikein2 = GameForm2.oikein2;
        }

        private void btntimes_Click(object sender, EventArgs e)
        {
            GameForm3 GameForm3 = new GameForm3(maxnum);
            this.Hide();
            GameForm3.ShowDialog();
            saavutus3 = GameForm3.saavutus3;
            oikein3 = GameForm3.oikein3;
        }

        private void btndivid_Click(object sender, EventArgs e)
        {
            GameForm4 GameForm4 = new GameForm4(maxnum);
            this.Hide();
            GameForm4.ShowDialog();
            saavutus4 = GameForm4.saavutus4;
            oikein4 = GameForm4.oikein4;
        }

        private void FormMode_Load(object sender, EventArgs e)
        {

        }

        private void btnModeBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
