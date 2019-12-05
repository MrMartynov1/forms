namespace MatikkaPeli
{
    partial class FormMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMode));
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btntimes = new System.Windows.Forms.Button();
            this.btndivid = new System.Windows.Forms.Button();
            this.btnModeBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(142, 25);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(195, 61);
            this.btnplus.TabIndex = 0;
            this.btnplus.Text = "Summa (+)";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(142, 103);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(195, 61);
            this.btnminus.TabIndex = 1;
            this.btnminus.Text = "Erotus (-)";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btntimes
            // 
            this.btntimes.Location = new System.Drawing.Point(142, 181);
            this.btntimes.Name = "btntimes";
            this.btntimes.Size = new System.Drawing.Size(195, 61);
            this.btntimes.TabIndex = 2;
            this.btntimes.Text = "Tulo (*)";
            this.btntimes.UseVisualStyleBackColor = true;
            this.btntimes.Click += new System.EventHandler(this.btntimes_Click);
            // 
            // btndivid
            // 
            this.btndivid.Location = new System.Drawing.Point(142, 261);
            this.btndivid.Name = "btndivid";
            this.btndivid.Size = new System.Drawing.Size(195, 61);
            this.btndivid.TabIndex = 3;
            this.btndivid.Text = "Osamäärä (/)";
            this.btndivid.UseVisualStyleBackColor = true;
            this.btndivid.Click += new System.EventHandler(this.btndivid_Click);
            // 
            // btnModeBack
            // 
            this.btnModeBack.Location = new System.Drawing.Point(142, 339);
            this.btnModeBack.Name = "btnModeBack";
            this.btnModeBack.Size = new System.Drawing.Size(202, 37);
            this.btnModeBack.TabIndex = 4;
            this.btnModeBack.Text = "Takaisin";
            this.btnModeBack.UseVisualStyleBackColor = true;
            this.btnModeBack.Click += new System.EventHandler(this.btnModeBack_Click);
            // 
            // FormMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MatikkaPeli.Properties.Resources.mathgame;
            this.ClientSize = new System.Drawing.Size(485, 388);
            this.Controls.Add(this.btnModeBack);
            this.Controls.Add(this.btndivid);
            this.Controls.Add(this.btntimes);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(501, 427);
            this.Name = "FormMode";
            this.Text = "MatikkaPeli";
            this.Load += new System.EventHandler(this.FormMode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btntimes;
        private System.Windows.Forms.Button btndivid;
        private System.Windows.Forms.Button btnModeBack;
    }
}