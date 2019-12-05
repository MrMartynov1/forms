namespace Form1
{
    partial class Elokuvasovellus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.btnUusi = new System.Windows.Forms.Button();
            this.btnEdellinen = new System.Windows.Forms.Button();
            this.btnSeuraava = new System.Windows.Forms.Button();
            this.tbKesto = new System.Windows.Forms.TextBox();
            this.lbKesto = new System.Windows.Forms.Label();
            this.tbVuosi = new System.Windows.Forms.TextBox();
            this.lbVuosi = new System.Windows.Forms.Label();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.lbNimi = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.gbArvio = new System.Windows.Forms.GroupBox();
            this.lbArvosana = new System.Windows.Forms.Label();
            this.rtbArvio = new System.Windows.Forms.RichTextBox();
            this.numudArvio1 = new System.Windows.Forms.NumericUpDown();
            this.numudArvio2 = new System.Windows.Forms.NumericUpDown();
            this.gbToiminnallisuus = new System.Windows.Forms.GroupBox();
            this.gbTiedot = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.gbArvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudArvio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudArvio2)).BeginInit();
            this.gbToiminnallisuus.SuspendLayout();
            this.gbTiedot.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.tietojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suljeToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // suljeToolStripMenuItem
            // 
            this.suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            this.suljeToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.suljeToolStripMenuItem.Text = "Sulje";
            this.suljeToolStripMenuItem.Click += new System.EventHandler(this.suljeToolStripMenuItem_Click);
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttäToolStripMenuItem,
            this.tietojaToolStripMenuItem1});
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            this.testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            this.testaaTietokantayhteyttäToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            // 
            // tietojaToolStripMenuItem1
            // 
            this.tietojaToolStripMenuItem1.Name = "tietojaToolStripMenuItem1";
            this.tietojaToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.tietojaToolStripMenuItem1.Text = "Tietoja";
            this.tietojaToolStripMenuItem1.Click += new System.EventHandler(this.tietojaToolStripMenuItem1_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.BackColor = System.Drawing.Color.Crimson;
            this.btnPoista.Location = new System.Drawing.Point(31, 200);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(277, 61);
            this.btnPoista.TabIndex = 2;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = false;
            // 
            // btnTallenna
            // 
            this.btnTallenna.BackColor = System.Drawing.Color.Lime;
            this.btnTallenna.Location = new System.Drawing.Point(31, 121);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(277, 61);
            this.btnTallenna.TabIndex = 1;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = false;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // btnUusi
            // 
            this.btnUusi.Location = new System.Drawing.Point(31, 40);
            this.btnUusi.Name = "btnUusi";
            this.btnUusi.Size = new System.Drawing.Size(277, 61);
            this.btnUusi.TabIndex = 0;
            this.btnUusi.Text = "Uusi tietue";
            this.btnUusi.UseVisualStyleBackColor = true;
            this.btnUusi.Click += new System.EventHandler(this.btnUusi_Click);
            // 
            // btnEdellinen
            // 
            this.btnEdellinen.Location = new System.Drawing.Point(29, 200);
            this.btnEdellinen.Name = "btnEdellinen";
            this.btnEdellinen.Size = new System.Drawing.Size(150, 61);
            this.btnEdellinen.TabIndex = 0;
            this.btnEdellinen.Text = "Edellinen";
            this.btnEdellinen.UseVisualStyleBackColor = true;
            this.btnEdellinen.Click += new System.EventHandler(this.btnEdellinen_Click);
            // 
            // btnSeuraava
            // 
            this.btnSeuraava.Location = new System.Drawing.Point(217, 200);
            this.btnSeuraava.Name = "btnSeuraava";
            this.btnSeuraava.Size = new System.Drawing.Size(150, 61);
            this.btnSeuraava.TabIndex = 1;
            this.btnSeuraava.Text = "Seuraava";
            this.btnSeuraava.UseVisualStyleBackColor = true;
            this.btnSeuraava.Click += new System.EventHandler(this.btnSeuraava_Click);
            // 
            // tbKesto
            // 
            this.tbKesto.Location = new System.Drawing.Point(217, 159);
            this.tbKesto.Name = "tbKesto";
            this.tbKesto.Size = new System.Drawing.Size(150, 20);
            this.tbKesto.TabIndex = 2;
            this.tbKesto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbKesto.Enter += new System.EventHandler(this.tbKesto_Enter);
            this.tbKesto.Leave += new System.EventHandler(this.tbKesto_Leave);
            // 
            // lbKesto
            // 
            this.lbKesto.AutoSize = true;
            this.lbKesto.Location = new System.Drawing.Point(26, 162);
            this.lbKesto.Name = "lbKesto";
            this.lbKesto.Size = new System.Drawing.Size(62, 13);
            this.lbKesto.TabIndex = 3;
            this.lbKesto.Text = "Kesto (min):";
            this.lbKesto.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbVuosi
            // 
            this.tbVuosi.Location = new System.Drawing.Point(217, 118);
            this.tbVuosi.Name = "tbVuosi";
            this.tbVuosi.Size = new System.Drawing.Size(150, 20);
            this.tbVuosi.TabIndex = 4;
            this.tbVuosi.Enter += new System.EventHandler(this.tbVuosi_Enter);
            this.tbVuosi.Leave += new System.EventHandler(this.tbVuosi_Leave);
            // 
            // lbVuosi
            // 
            this.lbVuosi.AutoSize = true;
            this.lbVuosi.Location = new System.Drawing.Point(26, 121);
            this.lbVuosi.Name = "lbVuosi";
            this.lbVuosi.Size = new System.Drawing.Size(73, 13);
            this.lbVuosi.TabIndex = 5;
            this.lbVuosi.Text = "Julkaisuvuosi:";
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(115, 78);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(252, 20);
            this.tbNimi.TabIndex = 6;
            this.tbNimi.Enter += new System.EventHandler(this.tbNimi_Enter);
            this.tbNimi.Leave += new System.EventHandler(this.tbNimi_Leave);
            // 
            // lbNimi
            // 
            this.lbNimi.AutoSize = true;
            this.lbNimi.Location = new System.Drawing.Point(26, 81);
            this.lbNimi.Name = "lbNimi";
            this.lbNimi.Size = new System.Drawing.Size(30, 13);
            this.lbNimi.TabIndex = 7;
            this.lbNimi.Text = "Nimi:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(217, 37);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(150, 20);
            this.tbID.TabIndex = 8;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(26, 40);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 9;
            this.lbID.Text = "ID:";
            // 
            // gbArvio
            // 
            this.gbArvio.Controls.Add(this.lbArvosana);
            this.gbArvio.Controls.Add(this.rtbArvio);
            this.gbArvio.Controls.Add(this.numudArvio1);
            this.gbArvio.Controls.Add(this.numudArvio2);
            this.gbArvio.Location = new System.Drawing.Point(12, 316);
            this.gbArvio.Name = "gbArvio";
            this.gbArvio.Size = new System.Drawing.Size(390, 234);
            this.gbArvio.TabIndex = 6;
            this.gbArvio.TabStop = false;
            this.gbArvio.Text = "Arvio";
            this.gbArvio.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbArvosana
            // 
            this.lbArvosana.AutoSize = true;
            this.lbArvosana.Location = new System.Drawing.Point(33, 189);
            this.lbArvosana.Name = "lbArvosana";
            this.lbArvosana.Size = new System.Drawing.Size(55, 13);
            this.lbArvosana.TabIndex = 4;
            this.lbArvosana.Text = "Arvosana:";
            // 
            // rtbArvio
            // 
            this.rtbArvio.Location = new System.Drawing.Point(29, 30);
            this.rtbArvio.Name = "rtbArvio";
            this.rtbArvio.Size = new System.Drawing.Size(338, 142);
            this.rtbArvio.TabIndex = 5;
            this.rtbArvio.Text = "";
            this.rtbArvio.Enter += new System.EventHandler(this.rtbArvio_Enter);
            this.rtbArvio.Leave += new System.EventHandler(this.rtbArvio_Leave);
            // 
            // numudArvio1
            // 
            this.numudArvio1.Location = new System.Drawing.Point(153, 187);
            this.numudArvio1.Name = "numudArvio1";
            this.numudArvio1.Size = new System.Drawing.Size(42, 20);
            this.numudArvio1.TabIndex = 1;
            this.numudArvio1.ValueChanged += new System.EventHandler(this.numudArvio2_ValueChanged);
            // 
            // numudArvio2
            // 
            this.numudArvio2.Location = new System.Drawing.Point(217, 187);
            this.numudArvio2.Name = "numudArvio2";
            this.numudArvio2.Size = new System.Drawing.Size(42, 20);
            this.numudArvio2.TabIndex = 2;
            // 
            // gbToiminnallisuus
            // 
            this.gbToiminnallisuus.Controls.Add(this.btnPoista);
            this.gbToiminnallisuus.Controls.Add(this.btnUusi);
            this.gbToiminnallisuus.Controls.Add(this.btnTallenna);
            this.gbToiminnallisuus.Location = new System.Drawing.Point(414, 27);
            this.gbToiminnallisuus.Name = "gbToiminnallisuus";
            this.gbToiminnallisuus.Size = new System.Drawing.Size(339, 523);
            this.gbToiminnallisuus.TabIndex = 3;
            this.gbToiminnallisuus.TabStop = false;
            this.gbToiminnallisuus.Text = "Toiminnallisuus";
            // 
            // gbTiedot
            // 
            this.gbTiedot.Controls.Add(this.lbID);
            this.gbTiedot.Controls.Add(this.btnSeuraava);
            this.gbTiedot.Controls.Add(this.tbKesto);
            this.gbTiedot.Controls.Add(this.tbID);
            this.gbTiedot.Controls.Add(this.lbKesto);
            this.gbTiedot.Controls.Add(this.lbNimi);
            this.gbTiedot.Controls.Add(this.tbVuosi);
            this.gbTiedot.Controls.Add(this.btnEdellinen);
            this.gbTiedot.Controls.Add(this.tbNimi);
            this.gbTiedot.Controls.Add(this.lbVuosi);
            this.gbTiedot.Location = new System.Drawing.Point(12, 27);
            this.gbTiedot.Name = "gbTiedot";
            this.gbTiedot.Size = new System.Drawing.Size(389, 289);
            this.gbTiedot.TabIndex = 7;
            this.gbTiedot.TabStop = false;
            this.gbTiedot.Text = "Elokuvan tiedot";
            // 
            // Elokuvasovellus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 556);
            this.Controls.Add(this.gbTiedot);
            this.Controls.Add(this.gbToiminnallisuus);
            this.Controls.Add(this.gbArvio);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Elokuvasovellus";
            this.Text = "Elokuvasovellus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbArvio.ResumeLayout(false);
            this.gbArvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudArvio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudArvio2)).EndInit();
            this.gbToiminnallisuus.ResumeLayout(false);
            this.gbTiedot.ResumeLayout(false);
            this.gbTiedot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suljeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem1;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Button btnUusi;
        private System.Windows.Forms.Button btnEdellinen;
        private System.Windows.Forms.Button btnSeuraava;
        private System.Windows.Forms.TextBox tbKesto;
        private System.Windows.Forms.Label lbKesto;
        private System.Windows.Forms.TextBox tbVuosi;
        private System.Windows.Forms.Label lbVuosi;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.Label lbNimi;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.GroupBox gbArvio;
        private System.Windows.Forms.Label lbArvosana;
        private System.Windows.Forms.RichTextBox rtbArvio;
        private System.Windows.Forms.NumericUpDown numudArvio1;
        private System.Windows.Forms.NumericUpDown numudArvio2;
        private System.Windows.Forms.GroupBox gbToiminnallisuus;
        private System.Windows.Forms.GroupBox gbTiedot;
    }
}

