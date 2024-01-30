namespace ARABA_YARIŞI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.carpma = new System.Windows.Forms.PictureBox();
            this.bizimaraba = new System.Windows.Forms.PictureBox();
            this.araba2 = new System.Windows.Forms.PictureBox();
            this.araba1 = new System.Windows.Forms.PictureBox();
            this.yol = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_oyunubaslat = new System.Windows.Forms.Button();
            this.lbl_kazanilanpuan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_yuksekskor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizimaraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.carpma);
            this.panel1.Controls.Add(this.bizimaraba);
            this.panel1.Controls.Add(this.araba2);
            this.panel1.Controls.Add(this.araba1);
            this.panel1.Controls.Add(this.yol);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // carpma
            // 
            this.carpma.Image = global::ARABA_YARIŞI.Properties.Resources.explosion;
            this.carpma.Location = new System.Drawing.Point(294, 281);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(69, 47);
            this.carpma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carpma.TabIndex = 1;
            this.carpma.TabStop = false;
            // 
            // bizimaraba
            // 
            this.bizimaraba.Image = global::ARABA_YARIŞI.Properties.Resources.araba4;
            this.bizimaraba.Location = new System.Drawing.Point(219, 315);
            this.bizimaraba.Name = "bizimaraba";
            this.bizimaraba.Size = new System.Drawing.Size(69, 134);
            this.bizimaraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bizimaraba.TabIndex = 1;
            this.bizimaraba.TabStop = false;
            // 
            // araba2
            // 
            this.araba2.Image = global::ARABA_YARIŞI.Properties.Resources.araba3;
            this.araba2.Location = new System.Drawing.Point(341, 63);
            this.araba2.Name = "araba2";
            this.araba2.Size = new System.Drawing.Size(69, 134);
            this.araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba2.TabIndex = 1;
            this.araba2.TabStop = false;
            // 
            // araba1
            // 
            this.araba1.Image = global::ARABA_YARIŞI.Properties.Resources.araba5;
            this.araba1.Location = new System.Drawing.Point(92, 63);
            this.araba1.Name = "araba1";
            this.araba1.Size = new System.Drawing.Size(69, 134);
            this.araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba1.TabIndex = 1;
            this.araba1.TabStop = false;
            // 
            // yol
            // 
            this.yol.Image = global::ARABA_YARIŞI.Properties.Resources.yol;
            this.yol.Location = new System.Drawing.Point(-9, -255);
            this.yol.Name = "yol";
            this.yol.Size = new System.Drawing.Size(513, 775);
            this.yol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol.TabIndex = 0;
            this.yol.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(390, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PUAN:";
            // 
            // btn_oyunubaslat
            // 
            this.btn_oyunubaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyunubaslat.Location = new System.Drawing.Point(11, 614);
            this.btn_oyunubaslat.Name = "btn_oyunubaslat";
            this.btn_oyunubaslat.Size = new System.Drawing.Size(504, 50);
            this.btn_oyunubaslat.TabIndex = 2;
            this.btn_oyunubaslat.Text = "OYUNU BAŞLAT";
            this.btn_oyunubaslat.UseVisualStyleBackColor = true;
            this.btn_oyunubaslat.Click += new System.EventHandler(this.btn_oyunubaslat_Click);
            // 
            // lbl_kazanilanpuan
            // 
            this.lbl_kazanilanpuan.AutoSize = true;
            this.lbl_kazanilanpuan.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kazanilanpuan.Location = new System.Drawing.Point(463, 568);
            this.lbl_kazanilanpuan.Name = "lbl_kazanilanpuan";
            this.lbl_kazanilanpuan.Size = new System.Drawing.Size(21, 24);
            this.lbl_kazanilanpuan.TabIndex = 1;
            this.lbl_kazanilanpuan.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "YÜKSEK SKOR:";
            // 
            // lbl_yuksekskor
            // 
            this.lbl_yuksekskor.AutoSize = true;
            this.lbl_yuksekskor.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yuksekskor.Location = new System.Drawing.Point(179, 568);
            this.lbl_yuksekskor.Name = "lbl_yuksekskor";
            this.lbl_yuksekskor.Size = new System.Drawing.Size(21, 24);
            this.lbl_yuksekskor.TabIndex = 1;
            this.lbl_yuksekskor.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 685);
            this.Controls.Add(this.btn_oyunubaslat);
            this.Controls.Add(this.lbl_yuksekskor);
            this.Controls.Add(this.lbl_kazanilanpuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Araba yarışı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizimaraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox yol;
        private System.Windows.Forms.PictureBox bizimaraba;
        private System.Windows.Forms.PictureBox araba2;
        private System.Windows.Forms.PictureBox araba1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_oyunubaslat;
        private System.Windows.Forms.Label lbl_kazanilanpuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_yuksekskor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox carpma;
    }
}

