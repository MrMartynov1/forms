using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileForm
{
    public partial class Form1 : Form
    {
        private String EditorFileName = "Untitled";

        public Form1()
        {
            InitializeComponent();
            Text = "Not Notepad";
            SetFormTitleText();
        }

        private void SetFormTitleText()

        {
            FileInfo fileinfo = new FileInfo(EditorFileName);
            Text = fileinfo.Name + " - Not Notepad";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorFileName = "Untitled";
            rtb1.Clear();
            SetFormTitleText();
        }

        private void ReadFile()
        {
            try

            {
                // Luodaan StreamReader objekti ja luetaan tiedosto.
                using (StreamReader Reader = new StreamReader(EditorFileName))
                {
                    rtb1.Clear();
                    rtb1.Text = Reader.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Open File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SaveFile()
        {
            try
            {
                using (StreamWriter StrWriter = new StreamWriter(EditorFileName))
                {
                    StrWriter.Write(rtb1.Text);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDlg = new OpenFileDialog();
            OpenFileDlg.Title = "Open";
            OpenFileDlg.ShowReadOnly = true;
            OpenFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";
            
            // Avataan windowsin standardi avausdialogi.
            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                // Talletetaan tiedoston nimi ja polku lukemista varten.
                EditorFileName = OpenFileDlg.FileName;
                // Luetaan tiedosotn sisältö ja tuodaan se näytölle.
                ReadFile();
                SetFormTitleText();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EditorFileName == "Untitled")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                SaveFile();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDlg = new SaveFileDialog();
            SaveFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";

            // Avataan windowsin standardi talletusdialogi.
            if (SaveFileDlg.ShowDialog() == DialogResult.OK)
            {
                // Talletetaan tiedoston nimi ja polku talletusta varten.
                EditorFileName = SaveFileDlg.FileName;
                SaveFile();
                SetFormTitleText();
            }
        }
    }
}
