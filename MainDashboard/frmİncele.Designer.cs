namespace MainDashboard
{
    partial class frmİncele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgEmlak = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lstEsyalar = new System.Windows.Forms.CheckedListBox();
            this.cmbEmlak_Durum = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbIsitma = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOdasayisi = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmlak)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgEmlak
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgEmlak.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmlak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgEmlak.ColumnHeadersHeight = 15;
            this.dtgEmlak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgEmlak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEmlak.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgEmlak.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgEmlak.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgEmlak.Location = new System.Drawing.Point(0, 0);
            this.dtgEmlak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgEmlak.Name = "dtgEmlak";
            this.dtgEmlak.ReadOnly = true;
            this.dtgEmlak.RowHeadersVisible = false;
            this.dtgEmlak.RowHeadersWidth = 51;
            this.dtgEmlak.RowTemplate.Height = 24;
            this.dtgEmlak.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgEmlak.Size = new System.Drawing.Size(1541, 57);
            this.dtgEmlak.TabIndex = 0;
            this.dtgEmlak.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgEmlak.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgEmlak.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgEmlak.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgEmlak.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgEmlak.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgEmlak.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgEmlak.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgEmlak.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgEmlak.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtgEmlak.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgEmlak.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgEmlak.ThemeStyle.HeaderStyle.Height = 15;
            this.dtgEmlak.ThemeStyle.ReadOnly = true;
            this.dtgEmlak.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgEmlak.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgEmlak.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtgEmlak.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgEmlak.ThemeStyle.RowsStyle.Height = 24;
            this.dtgEmlak.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgEmlak.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id
            // 
            this.id.DataPropertyName = "Emlak_id";
            this.id.HeaderText = "Column1";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btn_Delete);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.btn_Edit);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel18);
            this.guna2Panel1.Controls.Add(this.txtFiyat);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel17);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel16);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel15);
            this.guna2Panel1.Controls.Add(this.lstEsyalar);
            this.guna2Panel1.Controls.Add(this.cmbEmlak_Durum);
            this.guna2Panel1.Controls.Add(this.cmbIsitma);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel13);
            this.guna2Panel1.Controls.Add(this.txtAdi);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel1.Controls.Add(this.txtOdasayisi);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 57);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1541, 601);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Animated = true;
            this.btn_Delete.AutoRoundedCorners = true;
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.BorderRadius = 26;
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.FillColor = System.Drawing.Color.Red;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(423, 462);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(240, 55);
            this.btn_Delete.TabIndex = 98;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseTransparentBackground = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(21, 22);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(182, 38);
            this.guna2HtmlLabel1.TabIndex = 60;
            this.guna2HtmlLabel1.Text = "Emlak Düzenle";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Animated = true;
            this.btn_Edit.AutoRoundedCorners = true;
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.BorderRadius = 26;
            this.btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(423, 383);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(240, 55);
            this.btn_Edit.TabIndex = 95;
            this.btn_Edit.Text = "Düzenle";
            this.btn_Edit.UseTransparentBackground = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // guna2HtmlLabel18
            // 
            this.guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel18.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel18.Location = new System.Drawing.Point(609, 316);
            this.guna2HtmlLabel18.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            this.guna2HtmlLabel18.Size = new System.Drawing.Size(17, 34);
            this.guna2HtmlLabel18.TabIndex = 97;
            this.guna2HtmlLabel18.Text = "₺";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiyat.DefaultText = "";
            this.txtFiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiyat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiyat.Location = new System.Drawing.Point(335, 316);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.PasswordChar = '\0';
            this.txtFiyat.PlaceholderText = "";
            this.txtFiyat.SelectedText = "";
            this.txtFiyat.Size = new System.Drawing.Size(267, 44);
            this.txtFiyat.TabIndex = 93;
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(335, 281);
            this.guna2HtmlLabel17.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(32, 18);
            this.guna2HtmlLabel17.TabIndex = 96;
            this.guna2HtmlLabel17.Text = "Fiyat";
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(23, 309);
            this.guna2HtmlLabel16.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(69, 18);
            this.guna2HtmlLabel16.TabIndex = 91;
            this.guna2HtmlLabel16.Text = "Oda Sayısı";
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(335, 128);
            this.guna2HtmlLabel15.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(195, 18);
            this.guna2HtmlLabel15.TabIndex = 88;
            this.guna2HtmlLabel15.Text = "Emlak İçindeki eşyaları belirtiniz!";
            // 
            // lstEsyalar
            // 
            this.lstEsyalar.BackColor = System.Drawing.SystemColors.Control;
            this.lstEsyalar.CheckOnClick = true;
            this.lstEsyalar.FormattingEnabled = true;
            this.lstEsyalar.Location = new System.Drawing.Point(335, 155);
            this.lstEsyalar.Margin = new System.Windows.Forms.Padding(4);
            this.lstEsyalar.MultiColumn = true;
            this.lstEsyalar.Name = "lstEsyalar";
            this.lstEsyalar.Size = new System.Drawing.Size(327, 106);
            this.lstEsyalar.TabIndex = 92;
            // 
            // cmbEmlak_Durum
            // 
            this.cmbEmlak_Durum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            this.cmbEmlak_Durum.Location = new System.Drawing.Point(21, 155);
            this.cmbEmlak_Durum.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmlak_Durum.Name = "cmbEmlak_Durum";
            this.cmbEmlak_Durum.Size = new System.Drawing.Size(265, 36);
            this.cmbEmlak_Durum.TabIndex = 68;
            // 
            // cmbIsitma
            // 
            this.cmbIsitma.BackColor = System.Drawing.Color.Transparent;
            this.cmbIsitma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIsitma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsitma.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIsitma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIsitma.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIsitma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbIsitma.ItemHeight = 30;
            this.cmbIsitma.Location = new System.Drawing.Point(21, 411);
            this.cmbIsitma.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIsitma.Name = "cmbIsitma";
            this.cmbIsitma.Size = new System.Drawing.Size(265, 36);
            this.cmbIsitma.TabIndex = 87;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(21, 207);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(64, 18);
            this.guna2HtmlLabel4.TabIndex = 73;
            this.guna2HtmlLabel4.Text = "Emlak Adı";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(23, 385);
            this.guna2HtmlLabel13.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(38, 18);
            this.guna2HtmlLabel13.TabIndex = 79;
            this.guna2HtmlLabel13.Text = "Isıtma";
            // 
            // txtAdi
            // 
            this.txtAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdi.DefaultText = "";
            this.txtAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdi.Location = new System.Drawing.Point(21, 234);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.PasswordChar = '\0';
            this.txtAdi.PlaceholderText = "";
            this.txtAdi.SelectedText = "";
            this.txtAdi.Size = new System.Drawing.Size(267, 39);
            this.txtAdi.TabIndex = 67;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(21, 129);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(88, 18);
            this.guna2HtmlLabel5.TabIndex = 77;
            this.guna2HtmlLabel5.Text = "Emlak Statüsü";
            this.guna2HtmlLabel5.Click += new System.EventHandler(this.guna2HtmlLabel5_Click);
            // 
            // txtOdasayisi
            // 
            this.txtOdasayisi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOdasayisi.DefaultText = "";
            this.txtOdasayisi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOdasayisi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOdasayisi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOdasayisi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOdasayisi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOdasayisi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOdasayisi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOdasayisi.Location = new System.Drawing.Point(21, 334);
            this.txtOdasayisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOdasayisi.Name = "txtOdasayisi";
            this.txtOdasayisi.PasswordChar = '\0';
            this.txtOdasayisi.PlaceholderText = "";
            this.txtOdasayisi.SelectedText = "";
            this.txtOdasayisi.Size = new System.Drawing.Size(267, 44);
            this.txtOdasayisi.TabIndex = 86;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Crimson;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(44, 68);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(198, 37);
            this.guna2HtmlLabel8.TabIndex = 61;
            this.guna2HtmlLabel8.Text = "Emlak Özellikleri";
            // 
            // frmİncele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 658);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dtgEmlak);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmİncele";
            this.Text = "incele";
            this.Load += new System.EventHandler(this.incele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmlak)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView dtgEmlak;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_Edit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel18;
        private Guna.UI2.WinForms.Guna2TextBox txtFiyat;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private System.Windows.Forms.CheckedListBox lstEsyalar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEmlak_Durum;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIsitma;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2TextBox txtAdi;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtOdasayisi;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
    }
}