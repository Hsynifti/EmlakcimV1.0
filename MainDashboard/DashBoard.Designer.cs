namespace MainDashboard
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblKullanici = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Hesap = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Satislar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_MulkiyetEkle = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Mulkiyetler = new Guna.UI2.WinForms.Guna2Button();
            this.btn_MusteriIslemleri = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AnaSayfa = new Guna.UI2.WinForms.Guna2Button();
            this.panelDashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSize = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.lblKullanici);
            this.guna2Panel1.Controls.Add(this.btn_Logout);
            this.guna2Panel1.Controls.Add(this.btn_Hesap);
            this.guna2Panel1.Controls.Add(this.btn_Satislar);
            this.guna2Panel1.Controls.Add(this.btn_MulkiyetEkle);
            this.guna2Panel1.Controls.Add(this.btn_Mulkiyetler);
            this.guna2Panel1.Controls.Add(this.btn_MusteriIslemleri);
            this.guna2Panel1.Controls.Add(this.btn_AnaSayfa);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(218, 801);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(54, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(130, 83);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblKullanici
            // 
            this.lblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(74, 101);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(76, 21);
            this.lblKullanici.TabIndex = 9;
            this.lblKullanici.Text = "Kullanici Adi";
            this.lblKullanici.Click += new System.EventHandler(this.lblKullanici_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Animated = true;
            this.btn_Logout.AnimatedGIF = true;
            this.btn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.BorderRadius = 10;
            this.btn_Logout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Logout.FillColor = System.Drawing.Color.Transparent;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btn_Logout.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Logout.Location = new System.Drawing.Point(35, 726);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(180, 45);
            this.btn_Logout.TabIndex = 8;
            this.btn_Logout.Text = "Çıkış";
            this.btn_Logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Logout.TextOffset = new System.Drawing.Point(25, 0);
            this.btn_Logout.UseTransparentBackground = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Hesap
            // 
            this.btn_Hesap.Animated = true;
            this.btn_Hesap.AnimatedGIF = true;
            this.btn_Hesap.AutoRoundedCorners = true;
            this.btn_Hesap.BackColor = System.Drawing.Color.Transparent;
            this.btn_Hesap.BorderRadius = 21;
            this.btn_Hesap.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Hesap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Hesap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Hesap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Hesap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Hesap.FillColor = System.Drawing.Color.Transparent;
            this.btn_Hesap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Hesap.ForeColor = System.Drawing.Color.Black;
            this.btn_Hesap.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btn_Hesap.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Hesap.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hesap.Image")));
            this.btn_Hesap.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Hesap.IndicateFocus = true;
            this.btn_Hesap.Location = new System.Drawing.Point(32, 414);
            this.btn_Hesap.Name = "btn_Hesap";
            this.btn_Hesap.Size = new System.Drawing.Size(180, 45);
            this.btn_Hesap.TabIndex = 7;
            this.btn_Hesap.Text = "Hesap";
            this.btn_Hesap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Hesap.TextOffset = new System.Drawing.Point(25, 0);
            this.btn_Hesap.Click += new System.EventHandler(this.btn_Hesap_Click);
            // 
            // btn_Satislar
            // 
            this.btn_Satislar.Animated = true;
            this.btn_Satislar.AnimatedGIF = true;
            this.btn_Satislar.AutoRoundedCorners = true;
            this.btn_Satislar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Satislar.BorderRadius = 21;
            this.btn_Satislar.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Satislar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Satislar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Satislar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Satislar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Satislar.FillColor = System.Drawing.Color.Transparent;
            this.btn_Satislar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Satislar.ForeColor = System.Drawing.Color.Black;
            this.btn_Satislar.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btn_Satislar.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Satislar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Satislar.Image")));
            this.btn_Satislar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Satislar.Location = new System.Drawing.Point(32, 312);
            this.btn_Satislar.Name = "btn_Satislar";
            this.btn_Satislar.Size = new System.Drawing.Size(180, 45);
            this.btn_Satislar.TabIndex = 6;
            this.btn_Satislar.Text = "Satışlar";
            this.btn_Satislar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Satislar.TextOffset = new System.Drawing.Point(25, 0);
            this.btn_Satislar.UseTransparentBackground = true;
            this.btn_Satislar.Click += new System.EventHandler(this.btn_Satislar_Click);
            // 
            // btn_MulkiyetEkle
            // 
            this.btn_MulkiyetEkle.Animated = true;
            this.btn_MulkiyetEkle.AnimatedGIF = true;
            this.btn_MulkiyetEkle.AutoRoundedCorners = true;
            this.btn_MulkiyetEkle.BackColor = System.Drawing.Color.Transparent;
            this.btn_MulkiyetEkle.BorderRadius = 21;
            this.btn_MulkiyetEkle.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_MulkiyetEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_MulkiyetEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_MulkiyetEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_MulkiyetEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_MulkiyetEkle.FillColor = System.Drawing.Color.Transparent;
            this.btn_MulkiyetEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_MulkiyetEkle.ForeColor = System.Drawing.Color.Black;
            this.btn_MulkiyetEkle.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btn_MulkiyetEkle.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btn_MulkiyetEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_MulkiyetEkle.Image")));
            this.btn_MulkiyetEkle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_MulkiyetEkle.Location = new System.Drawing.Point(35, 210);
            this.btn_MulkiyetEkle.Name = "btn_MulkiyetEkle";
            this.btn_MulkiyetEkle.Size = new System.Drawing.Size(180, 45);
            this.btn_MulkiyetEkle.TabIndex = 4;
            this.btn_MulkiyetEkle.Text = "Emlak Ekle";
            this.btn_MulkiyetEkle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_MulkiyetEkle.TextOffset = new System.Drawing.Point(25, 0);
            this.btn_MulkiyetEkle.UseTransparentBackground = true;
            this.btn_MulkiyetEkle.Click += new System.EventHandler(this.btn_MulkiyetEkle_Click);
            // 
            // btn_Mulkiyetler
            // 
            this.btn_Mulkiyetler.Animated = true;
            this.btn_Mulkiyetler.AnimatedGIF = true;
            this.btn_Mulkiyetler.AutoRoundedCorners = true;
            this.btn_Mulkiyetler.BackColor = System.Drawing.Color.Transparent;
            this.btn_Mulkiyetler.BorderRadius = 21;
            this.btn_Mulkiyetler.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Mulkiyetler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Mulkiyetler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Mulkiyetler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Mulkiyetler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Mulkiyetler.FillColor = System.Drawing.Color.Transparent;
            this.btn_Mulkiyetler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Mulkiyetler.ForeColor = System.Drawing.Color.Black;
            this.btn_Mulkiyetler.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btn_Mulkiyetler.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Mulkiyetler.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mulkiyetler.Image")));
            this.btn_Mulkiyetler.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Mulkiyetler.Location = new System.Drawing.Point(35, 261);
            this.btn_Mulkiyetler.Name = "btn_Mulkiyetler";
            this.btn_Mulkiyetler.Size = new System.Drawing.Size(180, 45);
            this.btn_Mulkiyetler.TabIndex = 3;
            this.btn_Mulkiyetler.Text = "Emlaklar";
            this.btn_Mulkiyetler.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Mulkiyetler.TextOffset = new System.Drawing.Point(25, 0);
            this.btn_Mulkiyetler.UseTransparentBackground = true;
            this.btn_Mulkiyetler.Click += new System.EventHandler(this.btn_Mulkiyetler_Click);
            // 
            // btn_MusteriIslemleri
            // 
            this.btn_MusteriIslemleri.Animated = true;
            this.btn_MusteriIslemleri.AnimatedGIF = true;
            this.btn_MusteriIslemleri.AutoRoundedCorners = true;
            this.btn_MusteriIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.btn_MusteriIslemleri.BorderRadius = 21;
            this.btn_MusteriIslemleri.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_MusteriIslemleri.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_MusteriIslemleri.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_MusteriIslemleri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_MusteriIslemleri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_MusteriIslemleri.FillColor = System.Drawing.Color.Transparent;
            this.btn_MusteriIslemleri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_MusteriIslemleri.ForeColor = System.Drawing.Color.Black;
            this.btn_MusteriIslemleri.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btn_MusteriIslemleri.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btn_MusteriIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("btn_MusteriIslemleri.Image")));
            this.btn_MusteriIslemleri.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_MusteriIslemleri.Location = new System.Drawing.Point(32, 363);
            this.btn_MusteriIslemleri.Name = "btn_MusteriIslemleri";
            this.btn_MusteriIslemleri.Size = new System.Drawing.Size(180, 45);
            this.btn_MusteriIslemleri.TabIndex = 2;
            this.btn_MusteriIslemleri.Text = "Müşteri İşlemleri";
            this.btn_MusteriIslemleri.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_MusteriIslemleri.TextOffset = new System.Drawing.Point(25, 0);
            this.btn_MusteriIslemleri.UseTransparentBackground = true;
            this.btn_MusteriIslemleri.Click += new System.EventHandler(this.btn_MusteriIslemleri_Click);
            // 
            // btn_AnaSayfa
            // 
            this.btn_AnaSayfa.Animated = true;
            this.btn_AnaSayfa.AnimatedGIF = true;
            this.btn_AnaSayfa.AutoRoundedCorners = true;
            this.btn_AnaSayfa.BackColor = System.Drawing.Color.Transparent;
            this.btn_AnaSayfa.BorderRadius = 21;
            this.btn_AnaSayfa.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AnaSayfa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AnaSayfa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AnaSayfa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AnaSayfa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AnaSayfa.FillColor = System.Drawing.Color.Transparent;
            this.btn_AnaSayfa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AnaSayfa.ForeColor = System.Drawing.Color.Black;
            this.btn_AnaSayfa.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btn_AnaSayfa.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btn_AnaSayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_AnaSayfa.Image")));
            this.btn_AnaSayfa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AnaSayfa.Location = new System.Drawing.Point(35, 159);
            this.btn_AnaSayfa.Name = "btn_AnaSayfa";
            this.btn_AnaSayfa.Size = new System.Drawing.Size(180, 45);
            this.btn_AnaSayfa.TabIndex = 1;
            this.btn_AnaSayfa.Text = "Ana Sayfa";
            this.btn_AnaSayfa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AnaSayfa.TextOffset = new System.Drawing.Point(25, 0);
            this.btn_AnaSayfa.UseTransparentBackground = true;
            this.btn_AnaSayfa.Click += new System.EventHandler(this.btn_AnaSayfa_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDashboard.BackColor = System.Drawing.SystemColors.Window;
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(218, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1223, 801);
            this.panelDashboard.TabIndex = 1;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1441, 801);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emlakçım";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashBoard_FormClosing);
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel panelDashboard;
        private Guna.UI2.WinForms.Guna2Button btn_AnaSayfa;
        private Guna.UI2.WinForms.Guna2Button btn_Satislar;
        private Guna.UI2.WinForms.Guna2Button btn_MulkiyetEkle;
        private Guna.UI2.WinForms.Guna2Button btn_Mulkiyetler;
        private Guna.UI2.WinForms.Guna2Button btn_MusteriIslemleri;
        private Guna.UI2.WinForms.Guna2Button btn_Hesap;
        private Guna.UI2.WinForms.Guna2Button btn_Logout;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblKullanici;
    }
}

