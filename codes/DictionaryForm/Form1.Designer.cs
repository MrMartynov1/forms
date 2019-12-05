namespace DictionaryForm
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(75, 37);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(109, 13);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "LUODAAN Dictionary";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(62, 111);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(139, 13);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "LISÄTÄÄN ELEMENTTEJÄ";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(62, 226);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(138, 13);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "HAETAAN ELEMENTTEJÄ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(338, 24);
            this.menuStrip1.TabIndex = 5;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(81, 68);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(98, 24);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Luo Dictionary";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lisää";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 20);
            this.button3.TabIndex = 8;
            this.button3.Text = "Hae";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb8.Location = new System.Drawing.Point(61, 301);
            this.lb8.MaximumSize = new System.Drawing.Size(123, 45);
            this.lb8.MinimumSize = new System.Drawing.Size(123, 45);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(123, 45);
            this.lb8.TabIndex = 27;
            this.lb8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(20, 153);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(28, 13);
            this.lb4.TabIndex = 28;
            this.lb4.Text = "Key:";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(61, 150);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(123, 20);
            this.tb1.TabIndex = 29;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(61, 185);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(123, 20);
            this.tb2.TabIndex = 30;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(61, 265);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(123, 20);
            this.tb3.TabIndex = 31;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(20, 188);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(37, 13);
            this.lb5.TabIndex = 32;
            this.lb5.Text = "Value:";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(20, 268);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(28, 13);
            this.lb6.TabIndex = 33;
            this.lb6.Text = "Key:";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Location = new System.Drawing.Point(20, 303);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(37, 13);
            this.lb7.TabIndex = 34;
            this.lb7.Text = "Value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 370);
            this.Controls.Add(this.lb7);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
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

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb7;
    }
}

