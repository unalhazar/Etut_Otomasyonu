namespace Etut_Automation
{
    partial class RehberlikGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RehberlikGiris));
            this.mskdTc_No = new System.Windows.Forms.MaskedTextBox();
            this.Btn_GirisYap = new System.Windows.Forms.Button();
            this.TxtOgretmen_Sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mskdTc_No
            // 
            this.mskdTc_No.Location = new System.Drawing.Point(213, 67);
            this.mskdTc_No.Mask = "00000000000";
            this.mskdTc_No.Name = "mskdTc_No";
            this.mskdTc_No.Size = new System.Drawing.Size(100, 26);
            this.mskdTc_No.TabIndex = 0;
            this.mskdTc_No.ValidatingType = typeof(int);
            // 
            // Btn_GirisYap
            // 
            this.Btn_GirisYap.Location = new System.Drawing.Point(213, 154);
            this.Btn_GirisYap.Name = "Btn_GirisYap";
            this.Btn_GirisYap.Size = new System.Drawing.Size(100, 30);
            this.Btn_GirisYap.TabIndex = 17;
            this.Btn_GirisYap.Text = "Giriş Yap";
            this.Btn_GirisYap.UseVisualStyleBackColor = true;
            this.Btn_GirisYap.Click += new System.EventHandler(this.Btn_GirisYap_Click);
            // 
            // TxtOgretmen_Sifre
            // 
            this.TxtOgretmen_Sifre.Location = new System.Drawing.Point(213, 113);
            this.TxtOgretmen_Sifre.Name = "TxtOgretmen_Sifre";
            this.TxtOgretmen_Sifre.PasswordChar = '*';
            this.TxtOgretmen_Sifre.Size = new System.Drawing.Size(100, 26);
            this.TxtOgretmen_Sifre.TabIndex = 1;
            this.TxtOgretmen_Sifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rehberlik Giriş Paneli";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Etut_Automation.Properties.Resources.lock_152879_960_720;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // RehberlikGiris
            // 
            this.AcceptButton = this.Btn_GirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(386, 215);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mskdTc_No);
            this.Controls.Add(this.Btn_GirisYap);
            this.Controls.Add(this.TxtOgretmen_Sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RehberlikGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rehberlik Girişi";
            this.Load += new System.EventHandler(this.RehberlikGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskdTc_No;
        private System.Windows.Forms.Button Btn_GirisYap;
        private System.Windows.Forms.TextBox TxtOgretmen_Sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}