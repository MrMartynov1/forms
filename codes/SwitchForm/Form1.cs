using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button painettuNappi = sender as Button;
            
            switch (painettuNappi.Name)
            {
                case "btn1":
                    MessageBox.Show("painoit 1 nappia");
                    break;
                case "btn2":
                    MessageBox.Show("painoit 2 nappia");
                    break;
                case "btn3":
                    MessageBox.Show("painoit 3 nappia");
                    break;
                case "btn4":
                    MessageBox.Show("painoit 4 nappia");
                    break;
                default:
                    MessageBox.Show("painoit defaulttia");
                    break;
            }
        }
    }
}
