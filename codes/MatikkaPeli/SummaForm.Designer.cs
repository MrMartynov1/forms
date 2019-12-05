namespace MatikkaPeli
{
    partial class GameForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm1));
            this.lbnum1 = new System.Windows.Forms.Label();
            this.lbnum2 = new System.Windows.Forms.Label();
            this.lbDefiner2 = new System.Windows.Forms.Label();
            this.lbDefiner1 = new System.Windows.Forms.Label();
            this.btnCheck1 = new System.Windows.Forms.Button();
            this.tbnum1 = new System.Windows.Forms.TextBox();
            this.btnSumBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbnum1
            // 
            this.lbnum1.AutoSize = true;
            this.lbnum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbnum1.Location = new System.Drawing.Point(176, 34);
            this.lbnum1.MaximumSize = new System.Drawing.Size(100, 60);
            this.lbnum1.MinimumSize = new System.Drawing.Size(100, 60);
            this.lbnum1.Name = "lbnum1";
            this.lbnum1.Size = new System.Drawing.Size(100, 60);
            this.lbnum1.TabIndex = 0;
            this.lbnum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum2
            // 
            this.lbnum2.AutoSize = true;
            this.lbnum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbnum2.Location = new System.Drawing.Point(328, 34);
            this.lbnum2.MaximumSize = new System.Drawing.Size(100, 60);
            this.lbnum2.MinimumSize = new System.Drawing.Size(100, 60);
            this.lbnum2.Name = "lbnum2";
            this.lbnum2.Size = new System.Drawing.Size(100, 60);
            this.lbnum2.TabIndex = 1;
            this.lbnum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDefiner2
            // 
            this.lbDefiner2.AutoSize = true;
            this.lbDefiner2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDefiner2.Location = new System.Drawing.Point(282, 34);
            this.lbDefiner2.MaximumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner2.MinimumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner2.Name = "lbDefiner2";
            this.lbDefiner2.Size = new System.Drawing.Size(40, 60);
            this.lbDefiner2.TabIndex = 2;
            this.lbDefiner2.Text = "=";
            this.lbDefiner2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDefiner1
            // 
            this.lbDefiner1.AutoSize = true;
            this.lbDefiner1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDefiner1.Location = new System.Drawing.Point(130, 34);
            this.lbDefiner1.MaximumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner1.MinimumSize = new System.Drawing.Size(40, 60);
            this.lbDefiner1.Name = "lbDefiner1";
            this.lbDefiner1.Size = new System.Drawing.Size(40, 60);
            this.lbDefiner1.TabIndex = 3;
            this.lbDefiner1.Text = "+";
            this.lbDefiner1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck1
            // 
            this.btnCheck1.Location = new System.Drawing.Point(176, 122);
            this.btnCheck1.Name = "btnCheck1";
            this.btnCheck1.Size = new System.Drawing.Size(100, 44);
            this.btnCheck1.TabIndex = 6;
            this.btnCheck1.TabStop = false;
            this.btnCheck1.Text = "Tarkista";
            this.btnCheck1.UseVisualStyleBackColor = true;
            this.btnCheck1.Click += new System.EventHandler(this.btnCheck1_Click);
            // 
            // tbnum1
            // 
            this.tbnum1.Location = new System.Drawing.Point(29, 54);
            this.tbnum1.Name = "tbnum1";
            this.tbnum1.Size = new System.Drawing.Size(95, 20);
            this.tbnum1.TabIndex = 7;
            // 
            // btnSumBack
            // 
            this.btnSumBack.Location = new System.Drawing.Point(423, 270);
            this.btnSumBack.Name = "btnSumBack";
            this.btnSumBack.Size = new System.Drawing.Size(28, 27);
            this.btnSumBack.TabIndex = 8;
            this.btnSumBack.Text = "X";
            this.btnSumBack.UseVisualStyleBackColor = true;
            this.btnSumBack.Click += new System.EventHandler(this.btnSumBack_Click);
            // 
            // GameForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MatikkaPeli.Properties.Resources.mathgame;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.btnSumBack);
            this.Controls.Add(this.tbnum1);
            this.Controls.Add(this.btnCheck1);
            this.Controls.Add(this.lbDefiner1);
            this.Controls.Add(this.lbDefiner2);
            this.Controls.Add(this.lbnum2);
            this.Controls.Add(this.lbnum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(479, 348);
            this.Name = "GameForm1";
            this.Text = "MatikkaPeli";
            this.Load += new System.EventHandler(this.GameForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnum1;
        private System.Windows.Forms.Label lbnum2;
        private System.Windows.Forms.Label lbDefiner2;
        private System.Windows.Forms.Label lbDefiner1;
        private System.Windows.Forms.Button btnCheck1;
        private System.Windows.Forms.TextBox tbnum1;
        private System.Windows.Forms.Button btnSumBack;
    }
}