namespace WFA191122
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGomb = new System.Windows.Forms.Button();
            this.tbSzoveg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "szöveg:";
            // 
            // btnGomb
            // 
            this.btnGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGomb.Location = new System.Drawing.Point(18, 88);
            this.btnGomb.Name = "btnGomb";
            this.btnGomb.Size = new System.Drawing.Size(358, 47);
            this.btnGomb.TabIndex = 1;
            this.btnGomb.Text = "Gomb";
            this.btnGomb.UseVisualStyleBackColor = true;
            this.btnGomb.Click += new System.EventHandler(this.btnGomb_Click);
            // 
            // tbSzoveg
            // 
            this.tbSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSzoveg.Location = new System.Drawing.Point(157, 21);
            this.tbSzoveg.Name = "tbSzoveg";
            this.tbSzoveg.Size = new System.Drawing.Size(219, 38);
            this.tbSzoveg.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 160);
            this.Controls.Add(this.tbSzoveg);
            this.Controls.Add(this.btnGomb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGomb;
        private System.Windows.Forms.TextBox tbSzoveg;
    }
}

