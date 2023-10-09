namespace form23
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
            this.rbRenk1 = new System.Windows.Forms.RadioButton();
            this.rbRenk2 = new System.Windows.Forms.RadioButton();
            this.rbRenk3 = new System.Windows.Forms.RadioButton();
            this.rbRenk4 = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbRenk1
            // 
            this.rbRenk1.AutoSize = true;
            this.rbRenk1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRenk1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rbRenk1.Location = new System.Drawing.Point(29, 40);
            this.rbRenk1.Name = "rbRenk1";
            this.rbRenk1.Size = new System.Drawing.Size(67, 19);
            this.rbRenk1.TabIndex = 0;
            this.rbRenk1.TabStop = true;
            this.rbRenk1.Text = "Black";
            this.rbRenk1.UseVisualStyleBackColor = true;
            // 
            // rbRenk2
            // 
            this.rbRenk2.AutoSize = true;
            this.rbRenk2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRenk2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rbRenk2.Location = new System.Drawing.Point(29, 88);
            this.rbRenk2.Name = "rbRenk2";
            this.rbRenk2.Size = new System.Drawing.Size(91, 19);
            this.rbRenk2.TabIndex = 1;
            this.rbRenk2.TabStop = true;
            this.rbRenk2.Text = "Darkblue";
            this.rbRenk2.UseVisualStyleBackColor = true;
            // 
            // rbRenk3
            // 
            this.rbRenk3.AutoSize = true;
            this.rbRenk3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRenk3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rbRenk3.Location = new System.Drawing.Point(29, 139);
            this.rbRenk3.Name = "rbRenk3";
            this.rbRenk3.Size = new System.Drawing.Size(111, 19);
            this.rbRenk3.TabIndex = 2;
            this.rbRenk3.TabStop = true;
            this.rbRenk3.Text = "Darkorange";
            this.rbRenk3.UseVisualStyleBackColor = true;
            // 
            // rbRenk4
            // 
            this.rbRenk4.AutoSize = true;
            this.rbRenk4.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRenk4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rbRenk4.Location = new System.Drawing.Point(29, 189);
            this.rbRenk4.Name = "rbRenk4";
            this.rbRenk4.Size = new System.Drawing.Size(95, 19);
            this.rbRenk4.TabIndex = 3;
            this.rbRenk4.TabStop = true;
            this.rbRenk4.Text = "Darkgray";
            this.rbRenk4.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnHesapla.Location = new System.Drawing.Point(29, 248);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(108, 41);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 362);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.rbRenk4);
            this.Controls.Add(this.rbRenk3);
            this.Controls.Add(this.rbRenk2);
            this.Controls.Add(this.rbRenk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRenk1;
        private System.Windows.Forms.RadioButton rbRenk2;
        private System.Windows.Forms.RadioButton rbRenk3;
        private System.Windows.Forms.RadioButton rbRenk4;
        private System.Windows.Forms.Button btnHesapla;
    }
}

