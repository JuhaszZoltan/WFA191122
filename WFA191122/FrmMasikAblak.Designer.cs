namespace WFA191122
{
    partial class FrmMasikAblak
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
            this.lblMasikSzoveg = new System.Windows.Forms.Label();
            this.cdSzinvalaszto = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMasikSzoveg
            // 
            this.lblMasikSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMasikSzoveg.Location = new System.Drawing.Point(12, 9);
            this.lblMasikSzoveg.Name = "lblMasikSzoveg";
            this.lblMasikSzoveg.Size = new System.Drawing.Size(533, 96);
            this.lblMasikSzoveg.TabIndex = 0;
            this.lblMasikSzoveg.Text = "Másik, középre igazított label";
            this.lblMasikSzoveg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(533, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Másik Gomb";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMasikAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 204);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMasikSzoveg);
            this.Name = "FrmMasikAblak";
            this.Text = "FrmMasikAblak";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMasikAblak_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMasikSzoveg;
        private System.Windows.Forms.ColorDialog cdSzinvalaszto;
        private System.Windows.Forms.Button button1;
    }
}