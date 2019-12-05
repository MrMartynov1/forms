namespace MatikkaPeli
{
    partial class GameForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm3));
            this.tbnum3 = new System.Windows.Forms.TextBox();
            this.btnCheck3 = new System.Windows.Forms.Button();
            this.lbDefiner5 = new System.Windows.Forms.Label();
            this.lbDefiner6 = new System.Windows.Forms.Label();
            this.lbnum6 = new System.Windows.Forms.Label();
            this.lbnum5 = new System.Windows.Forms.Label();
            this.btnTulBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbnum3
            // 
            this.tbnum3.Location = new System.Drawing.Point(28, 54);
            this.tbnum3.Name = "tbnum3";
            this.tbnum3.Size = new System.Drawing.Size(95, 20);
            this.tbnum3.TabIndex = 13;
            // 
            // btnCheck3
            // 
            this.btnCheck3.Location = new System.Drawing.Point(175, 122);
            this.btnCheck3.Name = "btnCheck3";
            this.btnCheck3.Size = new System.Drawing.Size(100, 44);
            this.btnCheck3.TabIndex = 12;
            this.btnCheck3.Text = "Tarkista";
            this.btnCheck3.UseVisualStyleBackColor = true;
            this.btnCheck3.Click += new System.EventHandler(this.btnCheck3_Click);
            // 
            // lbDefiner5
            // 
            this.lbDefiner5.AutoSize = true;
            this.lbDefiner5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDefiner5.Location = new System.Drawing.Point(129, 34);
            this.lbDefiner5.MaximumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner5.MinimumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner5.Name = "lbDefiner5";
            this.lbDefiner5.Size = new System.Drawing.Size(40, 60);
            this.lbDefiner5.TabIndex = 11;
            this.lbDefiner5.Text = "*";
            this.lbDefiner5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDefiner6
            // 
            this.lbDefiner6.AutoSize = true;
            this.lbDefiner6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDefiner6.Location = new System.Drawing.Point(281, 34);
            this.lbDefiner6.MaximumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner6.MinimumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner6.Name = "lbDefiner6";
            this.lbDefiner6.Size = new System.Drawing.Size(40, 60);
            this.lbDefiner6.TabIndex = 10;
            this.lbDefiner6.Text = "=";
            this.lbDefiner6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum6
            // 
            this.lbnum6.AutoSize = true;
            this.lbnum6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbnum6.Location = new System.Drawing.Point(327, 34);
            this.lbnum6.MaximumSize = new System.Drawing.Size(100, 60);
            this.lbnum6.MinimumSize = new System.Drawing.Size(100, 60);
            this.lbnum6.Name = "lbnum6";
            this.lbnum6.Size = new System.Drawing.Size(100, 60);
            this.lbnum6.TabIndex = 9;
            this.lbnum6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum5
            // 
            this.lbnum5.AutoSize = true;
            this.lbnum5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbnum5.Location = new System.Drawing.Point(175, 34);
            this.lbnum5.MaximumSize = new System.Drawing.Size(100, 60);
            this.lbnum5.MinimumSize = new System.Drawing.Size(100, 60);
            this.lbnum5.Name = "lbnum5";
            this.lbnum5.Size = new System.Drawing.Size(100, 60);
            this.lbnum5.TabIndex = 8;
            this.lbnum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTulBack
            // 
            this.btnTulBack.Location = new System.Drawing.Point(423, 270);
            this.btnTulBack.Name = "btnTulBack";
            this.btnTulBack.Size = new System.Drawing.Size(28, 27);
            this.btnTulBack.TabIndex = 14;
            this.btnTulBack.Text = "X";
            this.btnTulBack.UseVisualStyleBackColor = true;
            this.btnTulBack.Click += new System.EventHandler(this.btnTulBack_Click);
            // 
            // GameForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MatikkaPeli.Properties.Resources.mathgame;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.btnTulBack);
            this.Controls.Add(this.tbnum3);
            this.Controls.Add(this.btnCheck3);
            this.Controls.Add(this.lbDefiner5);
            this.Controls.Add(this.lbDefiner6);
            this.Controls.Add(this.lbnum6);
            this.Controls.Add(this.lbnum5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(479, 348);
            this.Name = "GameForm3";
            this.Text = "MatikkaPeli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnum3;
        private System.Windows.Forms.Button btnCheck3;
        private System.Windows.Forms.Label lbDefiner5;
        private System.Windows.Forms.Label lbDefiner6;
        private System.Windows.Forms.Label lbnum6;
        private System.Windows.Forms.Label lbnum5;
        private System.Windows.Forms.Button btnTulBack;
    }
}