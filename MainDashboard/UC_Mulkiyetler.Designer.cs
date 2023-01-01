namespace MainDashboard
{
    partial class UC_Mulkiyetler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbEmlak_Tipi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbEmlak_Turu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbEmlak_Ilce = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbEmlak_Sehir = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbEmlak_Durum = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbEmlak_Semt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtg_Emlaklar = new Guna.UI2.WinForms.Guna2DataGridView();
            this.emlakid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cllIncele = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cllSatis = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Emlaklar)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEmlak_Tipi
            // 
            this.cmbEmlak_Tipi.BackColor = System.Drawing.Color.Transparent;
            this.cmbEmlak_Tipi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmlak_Tipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmlak_Tipi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmlak_Tipi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmlak_Tipi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmlak_Tipi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEmlak_Tipi.ItemHeight = 30;
            this.cmbEmlak_Tipi.Items.AddRange(new object[] {
            "Seçiniz"});
            this.cmbEmlak_Tipi.Location = new System.Drawing.Point(33, 34);
            this.cmbEmlak_Tipi.Name = "cmbEmlak_Tipi";
            this.cmbEmlak_Tipi.Size = new System.Drawing.Size(140, 36);
            this.cmbEmlak_Tipi.StartIndex = 0;
            this.cmbEmlak_Tipi.TabIndex = 1;
            this.cmbEmlak_Tipi.SelectionChangeCommitted += new System.EventHandler(this.guna2ComboBox1_SelectionChangeCommitted);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(33, 13);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(52, 15);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Emlak Tipi";
            // 
            // cmbEmlak_Turu
            // 
            this.cmbEmlak_Turu.BackColor = System.Drawing.Color.Transparent;
            this.cmbEmlak_Turu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmlak_Turu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmlak_Turu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmlak_Turu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmlak_Turu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmlak_Turu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEmlak_Turu.ItemHeight = 30;
            this.cmbEmlak_Turu.Items.AddRange(new object[] {
            "Tip Seçiniz"});
            this.cmbEmlak_Turu.Location = new System.Drawing.Point(203, 34);
            this.cmbEmlak_Turu.Name = "cmbEmlak_Turu";
            this.cmbEmlak_Turu.Size = new System.Drawing.Size(140, 36);
            this.cmbEmlak_Turu.StartIndex = 0;
            this.cmbEmlak_Turu.TabIndex = 3;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(203, 13);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(57, 15);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Emlak Türü";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(372, 13);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(72, 15);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Emlak Durumu";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(539, 13);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(102, 15);
            this.guna2HtmlLabel4.TabIndex = 7;
            this.guna2HtmlLabel4.Text = "Emlağın Bulunduğu İl";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(709, 13);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(114, 15);
            this.guna2HtmlLabel5.TabIndex = 9;
            this.guna2HtmlLabel5.Text = "Emlağın Bulunduğu İlçe";
            // 
            // cmbEmlak_Ilce
            // 
            this.cmbEmlak_Ilce.BackColor = System.Drawing.Color.Transparent;
            this.cmbEmlak_Ilce.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmlak_Ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmlak_Ilce.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmlak_Ilce.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmlak_Ilce.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmlak_Ilce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEmlak_Ilce.ItemHeight = 30;
            this.cmbEmlak_Ilce.Items.AddRange(new object[] {
            "İl Seçiniz"});
            this.cmbEmlak_Ilce.Location = new System.Drawing.Point(709, 34);
            this.cmbEmlak_Ilce.Name = "cmbEmlak_Ilce";
            this.cmbEmlak_Ilce.Size = new System.Drawing.Size(140, 36);
            this.cmbEmlak_Ilce.StartIndex = 0;
            this.cmbEmlak_Ilce.TabIndex = 10;
            this.cmbEmlak_Ilce.SelectionChangeCommitted += new System.EventHandler(this.guna2ComboBox3_SelectionChangeCommitted);
            // 
            // cmbEmlak_Sehir
            // 
            this.cmbEmlak_Sehir.BackColor = System.Drawing.Color.Transparent;
            this.cmbEmlak_Sehir.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmlak_Sehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmlak_Sehir.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmlak_Sehir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmlak_Sehir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmlak_Sehir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEmlak_Sehir.ItemHeight = 30;
            this.cmbEmlak_Sehir.Items.AddRange(new object[] {
            "Seçiniz"});
            this.cmbEmlak_Sehir.Location = new System.Drawing.Point(539, 34);
            this.cmbEmlak_Sehir.Name = "cmbEmlak_Sehir";
            this.cmbEmlak_Sehir.Size = new System.Drawing.Size(140, 36);
            this.cmbEmlak_Sehir.StartIndex = 0;
            this.cmbEmlak_Sehir.TabIndex = 11;
            this.cmbEmlak_Sehir.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox4_SelectedIndexChanged);
            this.cmbEmlak_Sehir.SelectionChangeCommitted += new System.EventHandler(this.guna2ComboBox4_SelectionChangeCommitted);
            // 
            // cmbEmlak_Durum
            // 
            this.cmbEmlak_Durum.BackColor = System.Drawing.Color.Transparent;
            this.cmbEmlak_Durum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmlak_Durum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmlak_Durum.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmlak_Durum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmlak_Durum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmlak_Durum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEmlak_Durum.ItemHeight = 30;
            this.cmbEmlak_Durum.Items.AddRange(new object[] {
            "Seçiniz"});
            this.cmbEmlak_Durum.Location = new System.Drawing.Point(372, 34);
            this.cmbEmlak_Durum.Name = "cmbEmlak_Durum";
            this.cmbEmlak_Durum.Size = new System.Drawing.Size(140, 36);
            this.cmbEmlak_Durum.StartIndex = 0;
            this.cmbEmlak_Durum.TabIndex = 12;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(878, 13);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(121, 15);
            this.guna2HtmlLabel6.TabIndex = 13;
            this.guna2HtmlLabel6.Text = "Emlağın Bulunduğu Semt";
            // 
            // cmbEmlak_Semt
            // 
            this.cmbEmlak_Semt.BackColor = System.Drawing.Color.Transparent;
            this.cmbEmlak_Semt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmlak_Semt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmlak_Semt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmlak_Semt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmlak_Semt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmlak_Semt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEmlak_Semt.ItemHeight = 30;
            this.cmbEmlak_Semt.Items.AddRange(new object[] {
            "İlçe Seçiniz"});
            this.cmbEmlak_Semt.Location = new System.Drawing.Point(878, 34);
            this.cmbEmlak_Semt.Name = "cmbEmlak_Semt";
            this.cmbEmlak_Semt.Size = new System.Drawing.Size(218, 36);
            this.cmbEmlak_Semt.StartIndex = 0;
            this.cmbEmlak_Semt.TabIndex = 14;
            this.cmbEmlak_Semt.SelectionChangeCommitted += new System.EventHandler(this.guna2ComboBox6_SelectionChangeCommitted);
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1114, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 36);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Ara";
            this.btnSearch.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Panel2);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 877);
            this.panel1.TabIndex = 16;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dtg_Emlaklar);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1412, 777);
            this.guna2Panel2.TabIndex = 18;
            // 
            // dtg_Emlaklar
            // 
            this.dtg_Emlaklar.AllowUserToAddRows = false;
            this.dtg_Emlaklar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtg_Emlaklar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Emlaklar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Emlaklar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Emlaklar.ColumnHeadersHeight = 15;
            this.dtg_Emlaklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtg_Emlaklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emlakid,
            this.adi,
            this.tipi,
            this.turu,
            this.durum,
            this.sehir,
            this.ilce,
            this.semt,
            this.cllIncele,
            this.cllSatis});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Emlaklar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Emlaklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_Emlaklar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_Emlaklar.Location = new System.Drawing.Point(0, 0);
            this.dtg_Emlaklar.Name = "dtg_Emlaklar";
            this.dtg_Emlaklar.ReadOnly = true;
            this.dtg_Emlaklar.RowHeadersVisible = false;
            this.dtg_Emlaklar.RowHeadersWidth = 51;
            this.dtg_Emlaklar.Size = new System.Drawing.Size(1412, 777);
            this.dtg_Emlaklar.TabIndex = 17;
            this.dtg_Emlaklar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_Emlaklar.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtg_Emlaklar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtg_Emlaklar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtg_Emlaklar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtg_Emlaklar.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtg_Emlaklar.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_Emlaklar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtg_Emlaklar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_Emlaklar.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtg_Emlaklar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_Emlaklar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtg_Emlaklar.ThemeStyle.HeaderStyle.Height = 15;
            this.dtg_Emlaklar.ThemeStyle.ReadOnly = true;
            this.dtg_Emlaklar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_Emlaklar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_Emlaklar.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtg_Emlaklar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_Emlaklar.ThemeStyle.RowsStyle.Height = 22;
            this.dtg_Emlaklar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_Emlaklar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_Emlaklar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick_1);
            // 
            // emlakid
            // 
            this.emlakid.DataPropertyName = "Emlak_id";
            this.emlakid.HeaderText = "Column1";
            this.emlakid.MinimumWidth = 6;
            this.emlakid.Name = "emlakid";
            this.emlakid.ReadOnly = true;
            this.emlakid.Visible = false;
            // 
            // adi
            // 
            this.adi.DataPropertyName = "Emlak Adı";
            this.adi.HeaderText = "Emlak Adı";
            this.adi.MinimumWidth = 6;
            this.adi.Name = "adi";
            this.adi.ReadOnly = true;
            // 
            // tipi
            // 
            this.tipi.DataPropertyName = "Emlak Tipi";
            this.tipi.HeaderText = "Emlak Tipi";
            this.tipi.MinimumWidth = 6;
            this.tipi.Name = "tipi";
            this.tipi.ReadOnly = true;
            // 
            // turu
            // 
            this.turu.DataPropertyName = "Emlak Türü";
            this.turu.HeaderText = "Emlak Türü";
            this.turu.MinimumWidth = 6;
            this.turu.Name = "turu";
            this.turu.ReadOnly = true;
            // 
            // durum
            // 
            this.durum.DataPropertyName = "Durum";
            this.durum.HeaderText = "Durum";
            this.durum.MinimumWidth = 6;
            this.durum.Name = "durum";
            this.durum.ReadOnly = true;
            // 
            // sehir
            // 
            this.sehir.DataPropertyName = "Şehir";
            this.sehir.HeaderText = "Şehir";
            this.sehir.MinimumWidth = 6;
            this.sehir.Name = "sehir";
            this.sehir.ReadOnly = true;
            // 
            // ilce
            // 
            this.ilce.DataPropertyName = "İlçe";
            this.ilce.HeaderText = "İlçe";
            this.ilce.MinimumWidth = 6;
            this.ilce.Name = "ilce";
            this.ilce.ReadOnly = true;
            // 
            // semt
            // 
            this.semt.DataPropertyName = "Mahalle-Köy";
            this.semt.HeaderText = "Mahalle-Köy";
            this.semt.MinimumWidth = 6;
            this.semt.Name = "semt";
            this.semt.ReadOnly = true;
            // 
            // cllIncele
            // 
            this.cllIncele.HeaderText = "İncele";
            this.cllIncele.MinimumWidth = 6;
            this.cllIncele.Name = "cllIncele";
            this.cllIncele.ReadOnly = true;
            this.cllIncele.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cllIncele.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cllIncele.Text = "incele";
            this.cllIncele.UseColumnTextForButtonValue = true;
            // 
            // cllSatis
            // 
            this.cllSatis.HeaderText = "Satış";
            this.cllSatis.MinimumWidth = 6;
            this.cllSatis.Name = "cllSatis";
            this.cllSatis.ReadOnly = true;
            this.cllSatis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cllSatis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cllSatis.Text = "satış";
            this.cllSatis.UseColumnTextForButtonValue = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.cmbEmlak_Tipi);
            this.guna2Panel1.Controls.Add(this.cmbEmlak_Ilce);
            this.guna2Panel1.Controls.Add(this.cmbEmlak_Turu);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel1.Controls.Add(this.btnSearch);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.cmbEmlak_Durum);
            this.guna2Panel1.Controls.Add(this.cmbEmlak_Semt);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.cmbEmlak_Sehir);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1412, 100);
            this.guna2Panel1.TabIndex = 17;
            // 
            // UC_Mulkiyetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Mulkiyetler";
            this.Size = new System.Drawing.Size(1412, 877);
            this.Load += new System.EventHandler(this.UC_Mulkiyetler_Load);
            this.panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Emlaklar)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cmbEmlak_Tipi;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEmlak_Turu;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEmlak_Ilce;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEmlak_Sehir;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEmlak_Durum;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEmlak_Semt;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dtg_Emlaklar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emlakid;
        private System.Windows.Forms.DataGridViewTextBoxColumn adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilce;
        private System.Windows.Forms.DataGridViewTextBoxColumn semt;
        private System.Windows.Forms.DataGridViewButtonColumn cllIncele;
        private System.Windows.Forms.DataGridViewButtonColumn cllSatis;
    }
}
