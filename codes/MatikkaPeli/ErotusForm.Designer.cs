namespace MatikkaPeli
{
    partial class GameForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm2));
            this.tbnum2 = new System.Windows.Forms.TextBox();
            this.btnCheck2 = new System.Windows.Forms.Button();
            this.lbDefiner3 = new System.Windows.Forms.Label();
            this.lbDefiner4 = new System.Windows.Forms.Label();
            this.lbnum4 = new System.Windows.Forms.Label();
            this.lbnum3 = new System.Windows.Forms.Label();
            this.btnEroBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbnum2
            // 
            this.tbnum2.Location = new System.Drawing.Point(29, 55);
            this.tbnum2.Name = "tbnum2";
            this.tbnum2.Size = new System.Drawing.Size(95, 20);
            this.tbnum2.TabIndex = 13;
            // 
            // btnCheck2
            // 
            this.btnCheck2.Location = new System.Drawing.Point(176, 123);
            this.btnCheck2.Name = "btnCheck2";
            this.btnCheck2.Size = new System.Drawing.Size(100, 44);
            this.btnCheck2.TabIndex = 12;
            this.btnCheck2.TabStop = false;
            this.btnCheck2.Text = "Tarkista";
            this.btnCheck2.UseVisualStyleBackColor = true;
            this.btnCheck2.Click += new System.EventHandler(this.btnCheck2_Click);
            // 
            // lbDefiner3
            // 
            this.lbDefiner3.AutoSize = true;
            this.lbDefiner3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDefiner3.Location = new System.Drawing.Point(130, 35);
            this.lbDefiner3.MaximumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner3.MinimumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner3.Name = "lbDefiner3";
            this.lbDefiner3.Size = new System.Drawing.Size(40, 60);
            this.lbDefiner3.TabIndex = 11;
            this.lbDefiner3.Text = "-";
            this.lbDefiner3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDefiner4
            // 
            this.lbDefiner4.AutoSize = true;
            this.lbDefiner4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDefiner4.Location = new System.Drawing.Point(282, 35);
            this.lbDefiner4.MaximumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner4.MinimumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner4.Name = "lbDefiner4";
            this.lbDefiner4.Size = new System.Drawing.Size(40, 60);
            this.lbDefiner4.TabIndex = 10;
            this.lbDefiner4.Text = "=";
            this.lbDefiner4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum4
            // 
            this.lbnum4.AutoSize = true;
            this.lbnum4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbnum4.Location = new System.Drawing.Point(328, 35);
            this.lbnum4.MaximumSize = new System.Drawing.Size(100, 60);
            this.lbnum4.MinimumSize = new System.Drawing.Size(100, 60);
            this.lbnum4.Name = "lbnum4";
            this.lbnum4.Size = new System.Drawing.Size(100, 60);
            this.lbnum4.TabIndex = 9;
            this.lbnum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum3
            // 
            this.lbnum3.AutoSize = true;
            this.lbnum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbnum3.Location = new System.Drawing.Point(176, 35);
            this.lbnum3.MaximumSize = new System.Drawing.Size(100, 60);
            this.lbnum3.MinimumSize = new System.Drawing.Size(100, 60);
            this.lbnum3.Name = "lbnum3";
            this.lbnum3.Size = new System.Drawing.Size(100, 60);
            this.lbnum3.TabIndex = 8;
            this.lbnum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEroBack
            // 
            this.btnEroBack.Location = new System.Drawing.Point(423, 270);
            this.btnEroBack.Name = "btnEroBack";
            this.btnEroBack.Size = new System.Drawing.Size(28, 27);
            this.btnEroBack.TabIndex = 14;
            this.btnEroBack.Text = "X";
            this.btnEroBack.UseVisualStyleBackColor = true;
            this.btnEroBack.Click += new System.EventHandler(this.btnEroBack_Click);
            // 
            // GameForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MatikkaPeli.Properties.Resources.mathgame;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.btnEroBack);
            this.Controls.Add(this.tbnum2);
            this.Controls.Add(this.btnCheck2);
            this.Controls.Add(this.lbDefiner3);
            this.Controls.Add(this.lbDefiner4);
            this.Controls.Add(this.lbnum4);
            this.Controls.Add(this.lbnum3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(479, 348);
            this.Name = "GameForm2";
            this.Text = "MatikkaPeli";
            this.Load += new System.EventHandler(this.GameForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnum2;
        private System.Windows.Forms.Button btnCheck2;
        private System.Windows.Forms.Label lbDefiner3;
        private System.Windows.Forms.Label lbDefiner4;
        private System.Windows.Forms.Label lbnum4;
        private System.Windows.Forms.Label lbnum3;
        private System.Windows.Forms.Button btnEroBack;
    }
}