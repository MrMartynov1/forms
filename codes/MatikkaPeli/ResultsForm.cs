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
    public partial class ResultsForm : Form
    {
        int sumpisteet;
        int eropisteet;
        int tulpisteet;
        int osapisteet;
        int sumSaavutus;
        int eroSaavutus;
        int tulSaavutus;
        int osaSaavutus;

        public ResultsForm(int pistsumma, int pistero, int pistulo, int pistosa, int achsumma, int achero, int achtulo, int achosa)
        {
            InitializeComponent();

            sumpisteet = pistsumma;
            eropisteet = pistero;
            tulpisteet = pistulo;
            osapisteet = pistosa;
            sumSaavutus = achsumma;
            eroSaavutus = achero;
            tulSaavutus = achtulo;
            osaSaavutus = achosa;

            lbres7.Text = "" + sumpisteet;
            lbres8.Text = "" + eropisteet;
            lbres9.Text = "" + tulpisteet;
            lbres10.Text = "" + osapisteet;
            lbres12.Text = "" + achsumma;
            lbres13.Text = "" + achero;
            lbres14.Text = "" + achtulo;
            lbres15.Text = "" + achosa;


        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnResBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
