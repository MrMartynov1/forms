namespace MatikkaPeli
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnAchiev = new System.Windows.Forms.Button();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.gbDifficulty = new System.Windows.Forms.GroupBox();
            this.rbdiff3 = new System.Windows.Forms.RadioButton();
            this.rbdiff2 = new System.Windows.Forms.RadioButton();
            this.rbdiff1 = new System.Windows.Forms.RadioButton();
            this.gbDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(193, 41);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(394, 78);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "MatikkaPeli";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(290, 150);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(203, 65);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Pelaa";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(290, 453);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(203, 65);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Lopeta";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(290, 311);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(203, 65);
            this.btnRes.TabIndex = 3;
            this.btnRes.Text = "Tulokset";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnAchiev
            // 
            this.btnAchiev.Location = new System.Drawing.Point(290, 382);
            this.btnAchiev.Name = "btnAchiev";
            this.btnAchiev.Size = new System.Drawing.Size(203, 65);
            this.btnAchiev.TabIndex = 4;
            this.btnAchiev.Text = "Saavutukset";
            this.btnAchiev.UseVisualStyleBackColor = true;
            this.btnAchiev.Click += new System.EventHandler(this.btnAchiev_Click);
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lbCopyright.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopyright.Location = new System.Drawing.Point(12, 530);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(240, 26);
            this.lbCopyright.TabIndex = 5;
            this.lbCopyright.Text = "©2019 Artturi Martynov";
            // 
            // gbDifficulty
            // 
            this.gbDifficulty.Controls.Add(this.rbdiff3);
            this.gbDifficulty.Controls.Add(this.rbdiff2);
            this.gbDifficulty.Controls.Add(this.rbdiff1);
            this.gbDifficulty.Location = new System.Drawing.Point(290, 221);
            this.gbDifficulty.Name = "gbDifficulty";
            this.gbDifficulty.Size = new System.Drawing.Size(202, 84);
            this.gbDifficulty.TabIndex = 7;
            this.gbDifficulty.TabStop = false;
            this.gbDifficulty.Text = "Vaikeus";
            // 
            // rbdiff3
            // 
            this.rbdiff3.AutoSize = true;
            this.rbdiff3.Location = new System.Drawing.Point(6, 61);
            this.rbdiff3.Name = "rbdiff3";
            this.rbdiff3.Size = new System.Drawing.Size(183, 17);
            this.rbdiff3.TabIndex = 2;
            this.rbdiff3.TabStop = true;
            this.rbdiff3.Text = "Vaikea (Luvut arvotaan 1000:sta)";
            this.rbdiff3.UseVisualStyleBackColor = true;
            this.rbdiff3.CheckedChanged += new System.EventHandler(this.radiochecker);
            // 
            // rbdiff2
            // 
            this.rbdiff2.AutoSize = true;
            this.rbdiff2.Checked = true;
            this.rbdiff2.Location = new System.Drawing.Point(6, 38);
            this.rbdiff2.Name = "rbdiff2";
            this.rbdiff2.Size = new System.Drawing.Size(185, 17);
            this.rbdiff2.TabIndex = 1;
            this.rbdiff2.TabStop = true;
            this.rbdiff2.Text = "Normaali (Luvut arvotaan 100:sta)";
            this.rbdiff2.UseVisualStyleBackColor = true;
            this.rbdiff2.CheckedChanged += new System.EventHandler(this.radiochecker);
            // 
            // rbdiff1
            // 
            this.rbdiff1.AutoSize = true;
            this.rbdiff1.Location = new System.Drawing.Point(6, 15);
            this.rbdiff1.Name = "rbdiff1";
            this.rbdiff1.Size = new System.Drawing.Size(172, 17);
            this.rbdiff1.TabIndex = 0;
            this.rbdiff1.TabStop = true;
            this.rbdiff1.Text = "Helppo (Luvut arvotaan 10:sta)";
            this.rbdiff1.UseVisualStyleBackColor = true;
            this.rbdiff1.CheckedChanged += new System.EventHandler(this.radiochecker);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MatikkaPeli.Properties.Resources.mathgame;
            this.ClientSize = new System.Drawing.Size(780, 565);
            this.Controls.Add(this.gbDifficulty);
            this.Controls.Add(this.lbCopyright);
            this.Controls.Add(this.btnAchiev);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(796, 604);
            this.Name = "MainMenuForm";
            this.Text = "MatikkaPeli";
            this.gbDifficulty.ResumeLayout(false);
            this.gbDifficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnAchiev;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.GroupBox gbDifficulty;
        private System.Windows.Forms.RadioButton rbdiff3;
        private System.Windows.Forms.RadioButton rbdiff2;
        private System.Windows.Forms.RadioButton rbdiff1;
    }
}

