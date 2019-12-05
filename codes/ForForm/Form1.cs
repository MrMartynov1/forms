using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbINT.Text = "Anna numero";
            
        }

        private void tbINT_Enter(object sender, EventArgs e)
        {
            tbINT.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //if (int.TryParse(tbINT.Text, out x))
            //{
            //    tbINT.Text = "Anna numero";
            //}
            //else
            //{
            Thread OmaSaie;
            // Luodaan toissijainen säie ja käynnistetään se Start()-metodilla.

            OmaSaie = new Thread(new ThreadStart(this.SaieProceduuri));
            OmaSaie.Start();
            //}
        }

        private void SaieProceduuri()
            {
                int g;
                Int32.TryParse(tbINT.Text, out g);

                for (int i = 1; i<=g; i++)
                {
                    AsetaTeksti(i.ToString());
                    System.Threading.Thread.Sleep(100);
                }
            }
        delegate void StringArgReturningVoidDelegate(string texti);

        private void AsetaTeksti(string texti)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.   
            if (this.lbINT.InvokeRequired)
            {   //Herätetään alkuperäinen säie
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(AsetaTeksti);
                this.Invoke(d, new object[] { texti });
            }

            else
            {   //Jos on alkupeäinen säie laitetaan se ´muuttamaan teksti 
                lbINT.Text = texti;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

