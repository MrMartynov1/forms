namespace MatikkaPeli
{
    partial class GameForm4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm4));
            this.tbnum4 = new System.Windows.Forms.TextBox();
            this.btnCheck4 = new System.Windows.Forms.Button();
            this.lbDefiner7 = new System.Windows.Forms.Label();
            this.lbDefiner8 = new System.Windows.Forms.Label();
            this.lbnum8 = new System.Windows.Forms.Label();
            this.lbnum7 = new System.Windows.Forms.Label();
            this.btnOsaBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbnum4
            // 
            this.tbnum4.Location = new System.Drawing.Point(29, 54);
            this.tbnum4.Name = "tbnum4";
            this.tbnum4.Size = new System.Drawing.Size(95, 20);
            this.tbnum4.TabIndex = 13;
            // 
            // btnCheck4
            // 
            this.btnCheck4.Location = new System.Drawing.Point(176, 122);
            this.btnCheck4.Name = "btnCheck4";
            this.btnCheck4.Size = new System.Drawing.Size(100, 44);
            this.btnCheck4.TabIndex = 12;
            this.btnCheck4.Text = "Tarkista";
            this.btnCheck4.UseVisualStyleBackColor = true;
            this.btnCheck4.Click += new System.EventHandler(this.btnCheck4_Click);
            // 
            // lbDefiner7
            // 
            this.lbDefiner7.AutoSize = true;
            this.lbDefiner7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDefiner7.Location = new System.Drawing.Point(130, 34);
            this.lbDefiner7.MaximumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner7.MinimumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner7.Name = "lbDefiner7";
            this.lbDefiner7.Size = new System.Drawing.Size(40, 60);
            this.lbDefiner7.TabIndex = 11;
            this.lbDefiner7.Text = "/";
            this.lbDefiner7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDefiner8
            // 
            this.lbDefiner8.AutoSize = true;
            this.lbDefiner8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDefiner8.Location = new System.Drawing.Point(282, 34);
            this.lbDefiner8.MaximumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner8.MinimumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner8.Name = "lbDefiner8";
            this.lbDefiner8.Size = new System.Drawing.Size(40, 60);
            this.lbDefiner8.TabIndex = 10;
            this.lbDefiner8.Text = "=";
            this.lbDefiner8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum8
            // 
            this.lbnum8.AutoSize = true;
            this.lbnum8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbnum8.Location = new System.Drawing.Point(328, 34);
            this.lbnum8.MaximumSize = new System.Drawing.Size(100, 60);
            this.lbnum8.MinimumSize = new System.Drawing.Size(100, 60);
            this.lbnum8.Name = "lbnum8";
            this.lbnum8.Size = new System.Drawing.Size(100, 60);
            this.lbnum8.TabIndex = 9;
            this.lbnum8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum7
            // 
            this.lbnum7.AutoSize = true;
            this.lbnum7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbnum7.Location = new System.Drawing.Point(176, 34);
            this.lbnum7.MaximumSize = new System.Drawing.Size(100, 60);
            this.lbnum7.MinimumSize = new System.Drawing.Size(100, 60);
            this.lbnum7.Name = "lbnum7";
            this.lbnum7.Size = new System.Drawing.Size(100, 60);
            this.lbnum7.TabIndex = 8;
            this.lbnum7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOsaBack
            // 
            this.btnOsaBack.Location = new System.Drawing.Point(423, 270);
            this.btnOsaBack.Name = "btnOsaBack";
            this.btnOsaBack.Size = new System.Drawing.Size(28, 27);
            this.btnOsaBack.TabIndex = 14;
            this.btnOsaBack.Text = "X";
            this.btnOsaBack.UseVisualStyleBackColor = true;
            this.btnOsaBack.Click += new System.EventHandler(this.btnOsaBack_Click);
            // 
            // GameForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MatikkaPeli.Properties.Resources.mathgame;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.btnOsaBack);
            this.Controls.Add(this.tbnum4);
            this.Controls.Add(this.btnCheck4);
            this.Controls.Add(this.lbDefiner7);
            this.Controls.Add(this.lbDefiner8);
            this.Controls.Add(this.lbnum8);
            this.Controls.Add(this.lbnum7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(479, 348);
            this.Name = "GameForm4";
            this.Text = "MatikkaPeli";
            this.Load += new System.EventHandler(this.GameForm4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnum4;
        private System.Windows.Forms.Button btnCheck4;
        private System.Windows.Forms.Label lbDefiner7;
        private System.Windows.Forms.Label lbDefiner8;
        private System.Windows.Forms.Label lbnum8;
        private System.Windows.Forms.Label lbnum7;
        private System.Windows.Forms.Button btnOsaBack;
    }
}