namespace Etut_Automation
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnOgrenciGirisi = new System.Windows.Forms.Button();
            this.BtnOgretmenGirisi = new System.Windows.Forms.Button();
            this.BtnRehberlikGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOgrenciGirisi
            // 
            this.BtnOgrenciGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOgrenciGirisi.BackgroundImage")));
            this.BtnOgrenciGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOgrenciGirisi.Location = new System.Drawing.Point(181, 91);
            this.BtnOgrenciGirisi.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOgrenciGirisi.Name = "BtnOgrenciGirisi";
            this.BtnOgrenciGirisi.Size = new System.Drawing.Size(100, 96);
            this.BtnOgrenciGirisi.TabIndex = 0;
            this.BtnOgrenciGirisi.UseVisualStyleBackColor = true;
            this.BtnOgrenciGirisi.Click += new System.EventHandler(this.BtnOgrenciGirisi_Click);
            // 
            // BtnOgretmenGirisi
            // 
            this.BtnOgretmenGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOgretmenGirisi.BackgroundImage")));
            this.BtnOgretmenGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOgretmenGirisi.Location = new System.Drawing.Point(319, 91);
            this.BtnOgretmenGirisi.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOgretmenGirisi.Name = "BtnOgretmenGirisi";
            this.BtnOgretmenGirisi.Size = new System.Drawing.Size(100, 96);
            this.BtnOgretmenGirisi.TabIndex = 1;
            this.BtnOgretmenGirisi.UseVisualStyleBackColor = true;
            this.BtnOgretmenGirisi.Click += new System.EventHandler(this.BtnOgretmenGirisi_Click);
            // 
            // BtnRehberlikGirisi
            // 
            this.BtnRehberlikGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRehberlikGirisi.BackgroundImage")));
            this.BtnRehberlikGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRehberlikGirisi.Location = new System.Drawing.Point(461, 91);
            this.BtnRehberlikGirisi.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRehberlikGirisi.Name = "BtnRehberlikGirisi";
            this.BtnRehberlikGirisi.Size = new System.Drawing.Size(100, 96);
            this.BtnRehberlikGirisi.TabIndex = 2;
            this.BtnRehberlikGirisi.UseVisualStyleBackColor = true;
            this.BtnRehberlikGirisi.Click += new System.EventHandler(this.BtnRehberlikGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(201, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(330, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğretmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(447, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rehberlik Öğretmeni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(146, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(522, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Etüt Otomasyonu Giriş Paneli              ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 50);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Etut_Automation.Properties.Resources._003__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRehberlikGirisi);
            this.Controls.Add(this.BtnOgretmenGirisi);
            this.Controls.Add(this.BtnOgrenciGirisi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etüt Otomasyon Girişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOgrenciGirisi;
        private System.Windows.Forms.Button BtnOgretmenGirisi;
        private System.Windows.Forms.Button BtnRehberlikGirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}

