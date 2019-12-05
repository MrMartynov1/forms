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
    public partial class AchievementForm : Form
    {
        int sumSaavutus;
        int eroSaavutus;
        int tulSaavutus;
        int osaSaavutus;
        public AchievementForm(int summa, int erotus, int tulo, int osa)
        {
            InitializeComponent();
            sumSaavutus = summa;
            eroSaavutus = erotus;
            tulSaavutus = tulo;
            osaSaavutus = osa;
            CheckSumma();
            CheckErotus();
            CheckTulo();
            CheckOsamaara();

            int i = 0;
            foreach (CheckBox c in this.Controls.OfType<CheckBox>())
            {
                if (c.Checked)
                {
                    i++;
                    //MessageBox.Show("Onnittelut, sinulla ei ole elämää! Lisää pelejä osoitteessa coolmathgames.com", "Kaikki saavutukset avattu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (i >= 40)
                {
                    
                    MessageBox.Show("Onnittelut, sinulla ei ole elämää! Lisää pelejä osoitteessa coolmathgames.com", "Kaikki saavutukset avattu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        public void CheckSumma()
        {
            int merkit1 = 0;
            foreach (CheckBox cb in gb1.Controls.OfType<CheckBox>().OrderBy(c => c.TabIndex))
            {
                if (sumSaavutus > merkit1)
                {
                    cb.Checked = true;
                    merkit1++;
                }
            }

            //if (sumSaavutus == 1)
            //{
            //    cbs1.Checked = true;
            //}
            //else if (sumSaavutus == 2)
            //{
            //    cbs1.Checked = true;
            //    cbs2.Checked = true;
            //}
            //else if (sumSaavutus == 3)
            //{
            //    cbs1.Checked = true;
            //    cbs2.Checked = true;
            //    cbs3.Checked = true;
            //}
            //else if (sumSaavutus == 4)
            //{
            //    cbs1.Checked = true;
            //    cbs2.Checked = true;
            //    cbs3.Checked = true;
            //    cbs4.Checked = true;
            //}
            //else if (sumSaavutus == 5)
            //{
            //    cbs1.Checked = true;
            //    cbs2.Checked = true;
            //    cbs3.Checked = true;
            //    cbs4.Checked = true;
            //    cbs5.Checked = true;
            //}
            //else if (sumSaavutus == 6)
            //{
            //    cbs1.Checked = true;
            //    cbs2.Checked = true;
            //    cbs3.Checked = true;
            //    cbs4.Checked = true;
            //    cbs5.Checked = true;
            //    cbs6.Checked = true;
            //}
            //else if (sumSaavutus == 7)
            //{
            //    cbs1.Checked = true;
            //    cbs2.Checked = true;
            //    cbs3.Checked = true;
            //    cbs4.Checked = true;
            //    cbs5.Checked = true;
            //    cbs6.Checked = true;
            //    cbs7.Checked = true;
            //}
            //else if (sumSaavutus == 8)
            //{
            //    cbs1.Checked = true;
            //    cbs2.Checked = true;
            //    cbs3.Checked = true;
            //    cbs4.Checked = true;
            //    cbs5.Checked = true;
            //    cbs6.Checked = true;
            //    cbs7.Checked = true;
            //    cbs8.Checked = true;
            //}
            //else if (sumSaavutus == 9)
            //{
            //    cbs1.Checked = true;
            //    cbs2.Checked = true;
            //    cbs3.Checked = true;
            //    cbs4.Checked = true;
            //    cbs5.Checked = true;
            //    cbs6.Checked = true;
            //    cbs7.Checked = true;
            //    cbs8.Checked = true;
            //    cbs9.Checked = true;
            //}
            //else if (sumSaavutus == 10)
            //{
            //    cbs1.Checked = true;
            //    cbs2.Checked = true;
            //    cbs3.Checked = true;
            //    cbs4.Checked = true;
            //    cbs5.Checked = true;
            //    cbs6.Checked = true;
            //    cbs7.Checked = true;
            //    cbs8.Checked = true;
            //    cbs9.Checked = true;
            //    cbs10.Checked = true;
            //}
            //else
            //{

            //}
        }

        public void CheckErotus()
        {
            int merkit2 = 0;
            foreach (CheckBox cb in gb2.Controls.OfType<CheckBox>().OrderBy(c => c.TabIndex))
            {
                if (eroSaavutus > merkit2)
                {
                    cb.Checked = true;
                    merkit2++;
                }
            }

            //if (eroSaavutus == 1)
            //{
            //    cbe1.Checked = true;
            //}
            //else if (eroSaavutus == 2)
            //{
            //    cbe1.Checked = true;
            //    cbe2.Checked = true;
            //}
            //else if (eroSaavutus == 3)
            //{
            //    cbe1.Checked = true;
            //    cbe2.Checked = true;
            //    cbe3.Checked = true;
            //}
            //else if (eroSaavutus == 4)
            //{
            //    cbe1.Checked = true;
            //    cbe2.Checked = true;
            //    cbe3.Checked = true;
            //    cbe4.Checked = true;
            //}
            //else if (eroSaavutus == 5)
            //{
            //    cbe1.Checked = true;
            //    cbe2.Checked = true;
            //    cbe3.Checked = true;
            //    cbe4.Checked = true;
            //    cbe5.Checked = true;
            //}
            //else if (eroSaavutus == 6)
            //{
            //    cbe1.Checked = true;
            //    cbe2.Checked = true;
            //    cbe3.Checked = true;
            //    cbe4.Checked = true;
            //    cbe5.Checked = true;
            //    cbe6.Checked = true;
            //}
            //else if (eroSaavutus == 7)
            //{
            //    cbe1.Checked = true;
            //    cbe2.Checked = true;
            //    cbe3.Checked = true;
            //    cbe4.Checked = true;
            //    cbe5.Checked = true;
            //    cbe6.Checked = true;
            //    cbe7.Checked = true;
            //}
            //else if (eroSaavutus == 8)
            //{
            //    cbe1.Checked = true;
            //    cbe2.Checked = true;
            //    cbe3.Checked = true;
            //    cbe4.Checked = true;
            //    cbe5.Checked = true;
            //    cbe6.Checked = true;
            //    cbe7.Checked = true;
            //    cbe8.Checked = true;
            //}
            //else if (eroSaavutus == 9)
            //{
            //    cbe1.Checked = true;
            //    cbe2.Checked = true;
            //    cbe3.Checked = true;
            //    cbe4.Checked = true;
            //    cbe5.Checked = true;
            //    cbe6.Checked = true;
            //    cbe7.Checked = true;
            //    cbe8.Checked = true;
            //    cbe9.Checked = true;
            //}
            //else if (eroSaavutus == 10)
            //{
            //    cbe1.Checked = true;
            //    cbe2.Checked = true;
            //    cbe3.Checked = true;
            //    cbe4.Checked = true;
            //    cbe5.Checked = true;
            //    cbe6.Checked = true;
            //    cbe7.Checked = true;
            //    cbe8.Checked = true;
            //    cbe9.Checked = true;
            //    cbe10.Checked = true;
            //}
            //else
            //{

            //}
        }

        public void CheckTulo()
        {
            int merkit3 = 0;
            foreach (CheckBox cb in gb3.Controls.OfType<CheckBox>().OrderBy(c => c.TabIndex))
            {
                if (tulSaavutus > merkit3)
                {
                    cb.Checked = true;
                    merkit3++;
                }
            }

            //if (tulSaavutus == 1)
            //{
            //    cbt1.Checked = true;
            //}
            //else if (tulSaavutus == 2)
            //{
            //    cbt1.Checked = true;
            //    cbt2.Checked = true;
            //}
            //else if (tulSaavutus == 3)
            //{
            //    cbt1.Checked = true;
            //    cbt2.Checked = true;
            //    cbt3.Checked = true;
            //}
            //else if (tulSaavutus == 4)
            //{
            //    cbt1.Checked = true;
            //    cbt2.Checked = true;
            //    cbt3.Checked = true;
            //    cbt4.Checked = true;
            //}
            //else if (tulSaavutus == 5)
            //{
            //    cbt1.Checked = true;
            //    cbt2.Checked = true;
            //    cbt3.Checked = true;
            //    cbt4.Checked = true;
            //    cbt5.Checked = true;
            //}
            //else if (tulSaavutus == 6)
            //{
            //    cbt1.Checked = true;
            //    cbt2.Checked = true;
            //    cbt3.Checked = true;
            //    cbt4.Checked = true;
            //    cbt5.Checked = true;
            //    cbt6.Checked = true;
            //}
            //else if (tulSaavutus == 7)
            //{
            //    cbt1.Checked = true;
            //    cbt2.Checked = true;
            //    cbt3.Checked = true;
            //    cbt4.Checked = true;
            //    cbt5.Checked = true;
            //    cbt6.Checked = true;
            //    cbt7.Checked = true;
            //}
            //else if (tulSaavutus == 8)
            //{
            //    cbt1.Checked = true;
            //    cbt2.Checked = true;
            //    cbt3.Checked = true;
            //    cbt4.Checked = true;
            //    cbt5.Checked = true;
            //    cbt6.Checked = true;
            //    cbt7.Checked = true;
            //    cbt8.Checked = true;
            //}
            //else if (tulSaavutus == 9)
            //{
            //    cbt1.Checked = true;
            //    cbt2.Checked = true;
            //    cbt3.Checked = true;
            //    cbt4.Checked = true;
            //    cbt5.Checked = true;
            //    cbt6.Checked = true;
            //    cbt7.Checked = true;
            //    cbt8.Checked = true;
            //    cbt9.Checked = true;
            //}
            //else if (tulSaavutus == 10)
            //{
            //    cbt1.Checked = true;
            //    cbt2.Checked = true;
            //    cbt3.Checked = true;
            //    cbt4.Checked = true;
            //    cbt5.Checked = true;
            //    cbt6.Checked = true;
            //    cbt7.Checked = true;
            //    cbt8.Checked = true;
            //    cbt9.Checked = true;
            //    cbt10.Checked = true;
            //}
            //else
            //{

            //}
        }

        public void CheckOsamaara()
        {
            int merkit4 = 0;
            foreach(CheckBox cb in gb4.Controls.OfType<CheckBox>().OrderBy(c => c.TabIndex))
            {
                if (osaSaavutus > merkit4)
                {
                    cb.Checked = true;
                    merkit4++;
                }
            }
            //if (osaSaavutus == 1)
            //{
            //    cbs1.Checked = true;
            //}
            //else if (osaSaavutus == 2)
            //{
            //   // cbo1.Checked = true;
            //    cbo2.Checked = true;
            //}
            //else if (osaSaavutus == 3)
            //{
            //    cbo1.Checked = true;
            //    cbo2.Checked = true;
            //    cbo3.Checked = true;
            //}
            //else if (osaSaavutus == 4)
            //{
            //    cbo1.Checked = true;
            //    cbo2.Checked = true;
            //    cbo3.Checked = true;
            //    cbo4.Checked = true;
            //}
            //else if (osaSaavutus == 5)
            //{
            //    cbo1.Checked = true;
            //    cbo2.Checked = true;
            //    cbo3.Checked = true;
            //    cbo4.Checked = true;
            //    cbo5.Checked = true;
            //}
            //else if (osaSaavutus == 6)
            //{
            //    cbo1.Checked = true;
            //    cbo2.Checked = true;
            //    cbo3.Checked = true;
            //    cbo4.Checked = true;
            //    cbo5.Checked = true;
            //    cbo6.Checked = true;
            //}
            //else if (osaSaavutus == 7)
            //{
            //    cbo1.Checked = true;
            //    cbo2.Checked = true;
            //    cbo3.Checked = true;
            //    cbo4.Checked = true;
            //    cbo5.Checked = true;
            //    cbo6.Checked = true;
            //    cbo7.Checked = true;
            //}
            //else if (osaSaavutus == 8)
            //{
            //    cbo1.Checked = true;
            //    cbo2.Checked = true;
            //    cbo3.Checked = true;
            //    cbo4.Checked = true;
            //    cbo5.Checked = true;
            //    cbo6.Checked = true;
            //    cbo7.Checked = true;
            //    cbo8.Checked = true;
            //}
            //else if (osaSaavutus == 9)
            //{
            //    cbo1.Checked = true;
            //    cbo2.Checked = true;
            //    cbo3.Checked = true;
            //    cbo4.Checked = true;
            //    cbo5.Checked = true;
            //    cbo6.Checked = true;
            //    cbo7.Checked = true;
            //    cbo8.Checked = true;
            //    cbo9.Checked = true;
            //}
            //else if (osaSaavutus == 10)
            //{
            //    cbo1.Checked = true;
            //    cbo2.Checked = true;
            //    cbo3.Checked = true;
            //    cbo4.Checked = true;
            //    cbo5.Checked = true;
            //    cbo6.Checked = true;
            //    cbo7.Checked = true;
            //    cbo8.Checked = true;
            //    cbo9.Checked = true;
            //    cbo10.Checked = true;
            //}
            //else
            //{

            //}
        }

        private void AchievementForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAchBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
