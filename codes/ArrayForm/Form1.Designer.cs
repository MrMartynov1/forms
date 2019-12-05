namespace ArrayForm
{
    partial class Form1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTaulukko = new System.Windows.Forms.Label();
            this.lbTlKoko = new System.Windows.Forms.Label();
            this.tbTaulukko = new System.Windows.Forms.TextBox();
            this.btnTaulukko = new System.Windows.Forms.Button();
            this.btnTalleta = new System.Windows.Forms.Button();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.lbTNum = new System.Windows.Forms.Label();
            this.lbTallenna = new System.Windows.Forms.Label();
            this.tIndex1 = new System.Windows.Forms.TextBox();
            this.lbIndex1 = new System.Windows.Forms.Label();
            this.btnHaku = new System.Windows.Forms.Button();
            this.tbIndex2 = new System.Windows.Forms.TextBox();
            this.lbIndex2 = new System.Windows.Forms.Label();
            this.lbHaku = new System.Windows.Forms.Label();
            this.lbFinal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(366, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lbTaulukko
            // 
            this.lbTaulukko.AutoSize = true;
            this.lbTaulukko.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaulukko.Location = new System.Drawing.Point(66, 43);
            this.lbTaulukko.Name = "lbTaulukko";
            this.lbTaulukko.Size = new System.Drawing.Size(228, 30);
            this.lbTaulukko.TabIndex = 1;
            this.lbTaulukko.Text = "TAULUKON LUONTI";
            // 
            // lbTlKoko
            // 
            this.lbTlKoko.AutoSize = true;
            this.lbTlKoko.Location = new System.Drawing.Point(22, 99);
            this.lbTlKoko.Name = "lbTlKoko";
            this.lbTlKoko.Size = new System.Drawing.Size(82, 13);
            this.lbTlKoko.TabIndex = 2;
            this.lbTlKoko.Text = "Taulukon koko:";
            // 
            // tbTaulukko
            // 
            this.tbTaulukko.Location = new System.Drawing.Point(140, 96);
            this.tbTaulukko.Name = "tbTaulukko";
            this.tbTaulukko.Size = new System.Drawing.Size(97, 20);
            this.tbTaulukko.TabIndex = 3;
            this.tbTaulukko.Enter += new System.EventHandler(this.tbTaulukko_Enter);
            this.tbTaulukko.Leave += new System.EventHandler(this.tbTaulukko_Leave);
            // 
            // btnTaulukko
            // 
            this.btnTaulukko.Location = new System.Drawing.Point(247, 94);
            this.btnTaulukko.Name = "btnTaulukko";
            this.btnTaulukko.Size = new System.Drawing.Size(102, 23);
            this.btnTaulukko.TabIndex = 4;
            this.btnTaulukko.Text = "Luo taulukko";
            this.btnTaulukko.UseVisualStyleBackColor = true;
            this.btnTaulukko.Click += new System.EventHandler(this.btnTaulukko_Click);
            // 
            // btnTalleta
            // 
            this.btnTalleta.Location = new System.Drawing.Point(247, 226);
            this.btnTalleta.Name = "btnTalleta";
            this.btnTalleta.Size = new System.Drawing.Size(102, 23);
            this.btnTalleta.TabIndex = 9;
            this.btnTalleta.Text = "Talleta";
            this.btnTalleta.UseVisualStyleBackColor = true;
            this.btnTalleta.Click += new System.EventHandler(this.btnTalleta_Click);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(140, 190);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(97, 20);
            this.tbNum.TabIndex = 8;
            this.tbNum.Enter += new System.EventHandler(this.tbNum_Enter);
            this.tbNum.Leave += new System.EventHandler(this.tbNum_Leave);
            // 
            // lbTNum
            // 
            this.lbTNum.AutoSize = true;
            this.lbTNum.Location = new System.Drawing.Point(22, 193);
            this.lbTNum.Name = "lbTNum";
            this.lbTNum.Size = new System.Drawing.Size(104, 13);
            this.lbTNum.TabIndex = 7;
            this.lbTNum.Text = "Talletettava numero:";
            // 
            // lbTallenna
            // 
            this.lbTallenna.AutoSize = true;
            this.lbTallenna.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTallenna.Location = new System.Drawing.Point(105, 139);
            this.lbTallenna.Name = "lbTallenna";
            this.lbTallenna.Size = new System.Drawing.Size(144, 30);
            this.lbTallenna.TabIndex = 6;
            this.lbTallenna.Text = "TALLENNUS";
            // 
            // tIndex1
            // 
            this.tIndex1.Location = new System.Drawing.Point(140, 228);
            this.tIndex1.Name = "tIndex1";
            this.tIndex1.Size = new System.Drawing.Size(97, 20);
            this.tIndex1.TabIndex = 11;
            this.tIndex1.Enter += new System.EventHandler(this.tIndex1_Enter);
            this.tIndex1.Leave += new System.EventHandler(this.tIndex1_Leave);
            // 
            // lbIndex1
            // 
            this.lbIndex1.AutoSize = true;
            this.lbIndex1.Location = new System.Drawing.Point(22, 231);
            this.lbIndex1.Name = "lbIndex1";
            this.lbIndex1.Size = new System.Drawing.Size(115, 13);
            this.lbIndex1.TabIndex = 10;
            this.lbIndex1.Text = "Talletuspaikan indeksi:";
            // 
            // btnHaku
            // 
            this.btnHaku.Location = new System.Drawing.Point(247, 322);
            this.btnHaku.Name = "btnHaku";
            this.btnHaku.Size = new System.Drawing.Size(102, 23);
            this.btnHaku.TabIndex = 15;
            this.btnHaku.Text = "Haku";
            this.btnHaku.UseVisualStyleBackColor = true;
            this.btnHaku.Click += new System.EventHandler(this.btnHaku_Click);
            // 
            // tbIndex2
            // 
            this.tbIndex2.Location = new System.Drawing.Point(140, 325);
            this.tbIndex2.Name = "tbIndex2";
            this.tbIndex2.Size = new System.Drawing.Size(97, 20);
            this.tbIndex2.TabIndex = 14;
            this.tbIndex2.Enter += new System.EventHandler(this.tbIndex2_Enter);
            this.tbIndex2.Leave += new System.EventHandler(this.tbIndex2_Leave);
            // 
            // lbIndex2
            // 
            this.lbIndex2.AutoSize = true;
            this.lbIndex2.Location = new System.Drawing.Point(22, 327);
            this.lbIndex2.Name = "lbIndex2";
            this.lbIndex2.Size = new System.Drawing.Size(115, 13);
            this.lbIndex2.TabIndex = 13;
            this.lbIndex2.Text = "Talletuspaikan indeksi:";
            // 
            // lbHaku
            // 
            this.lbHaku.AutoSize = true;
            this.lbHaku.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHaku.Location = new System.Drawing.Point(135, 274);
            this.lbHaku.Name = "lbHaku";
            this.lbHaku.Size = new System.Drawing.Size(72, 30);
            this.lbHaku.TabIndex = 12;
            this.lbHaku.Text = "HAKU";
            // 
            // lbFinal
            // 
            this.lbFinal.AutoSize = true;
            this.lbFinal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbFinal.Location = new System.Drawing.Point(140, 374);
            this.lbFinal.MaximumSize = new System.Drawing.Size(97, 43);
            this.lbFinal.MinimumSize = new System.Drawing.Size(97, 43);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(97, 43);
            this.lbFinal.TabIndex = 17;
            this.lbFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 449);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.btnHaku);
            this.Controls.Add(this.tbIndex2);
            this.Controls.Add(this.lbIndex2);
            this.Controls.Add(this.lbHaku);
            this.Controls.Add(this.tIndex1);
            this.Controls.Add(this.lbIndex1);
            this.Controls.Add(this.btnTalleta);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.lbTNum);
            this.Controls.Add(this.lbTallenna);
            this.Controls.Add(this.btnTaulukko);
            this.Controls.Add(this.tbTaulukko);
            this.Controls.Add(this.lbTlKoko);
            this.Controls.Add(this.lbTaulukko);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbTaulukko;
        private System.Windows.Forms.Label lbTlKoko;
        private System.Windows.Forms.TextBox tbTaulukko;
        private System.Windows.Forms.Button btnTaulukko;
        private System.Windows.Forms.Button btnTalleta;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label lbTNum;
        private System.Windows.Forms.Label lbTallenna;
        private System.Windows.Forms.TextBox tIndex1;
        private System.Windows.Forms.Label lbIndex1;
        private System.Windows.Forms.Button btnHaku;
        private System.Windows.Forms.TextBox tbIndex2;
        private System.Windows.Forms.Label lbIndex2;
        private System.Windows.Forms.Label lbHaku;
        private System.Windows.Forms.Label lbFinal;
    }
}

