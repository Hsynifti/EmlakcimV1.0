namespace MainDashboard
{
    partial class UC_KullaniciUpdate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_Users = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chckbxAdmin = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chckbxActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btn_UserUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Surname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_CompanyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.KullaniciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyadı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İletişim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullanıcıAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Users)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Users
            // 
            this.dtg_Users.AllowUserToAddRows = false;
            this.dtg_Users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtg_Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_Users.ColumnHeadersHeight = 20;
            this.dtg_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KullaniciID,
            this.Adı,
            this.Soyadı,
            this.İletişim,
            this.FirmaAdı,
            this.KullanıcıAdı,
            this.Sifre,
            this.Profit,
            this.isActive,
            this.isAdmin});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Users.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_Users.Location = new System.Drawing.Point(0, 0);
            this.dtg_Users.Name = "dtg_Users";
            this.dtg_Users.ReadOnly = true;
            this.dtg_Users.RowHeadersVisible = false;
            this.dtg_Users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_Users.Size = new System.Drawing.Size(1070, 776);
            this.dtg_Users.TabIndex = 0;
            this.dtg_Users.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_Users.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtg_Users.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtg_Users.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtg_Users.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtg_Users.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtg_Users.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_Users.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtg_Users.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_Users.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtg_Users.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_Users.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtg_Users.ThemeStyle.HeaderStyle.Height = 20;
            this.dtg_Users.ThemeStyle.ReadOnly = true;
            this.dtg_Users.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_Users.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_Users.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtg_Users.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_Users.ThemeStyle.RowsStyle.Height = 22;
            this.dtg_Users.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_Users.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Users_CellContentClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel1.Controls.Add(this.btn_UserUpdate);
            this.guna2Panel1.Controls.Add(this.txt_Username);
            this.guna2Panel1.Controls.Add(this.txt_Pass);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel9);
            this.guna2Panel1.Controls.Add(this.txt_Contact);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel1.Controls.Add(this.txt_Surname);
            this.guna2Panel1.Controls.Add(this.txt_CompanyName);
            this.guna2Panel1.Controls.Add(this.txt_Name);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(302, 776);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.chckbxAdmin);
            this.guna2GroupBox1.Controls.Add(this.chckbxActive);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(15, 460);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(253, 72);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Kullanıcı Yetki Durumu / Aktiflik Durumu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(126, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "|";
            // 
            // chckbxAdmin
            // 
            this.chckbxAdmin.AutoSize = true;
            this.chckbxAdmin.BackColor = System.Drawing.Color.Transparent;
            this.chckbxAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chckbxAdmin.CheckedState.BorderRadius = 0;
            this.chckbxAdmin.CheckedState.BorderThickness = 0;
            this.chckbxAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chckbxAdmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chckbxAdmin.Location = new System.Drawing.Point(26, 44);
            this.chckbxAdmin.Name = "chckbxAdmin";
            this.chckbxAdmin.Size = new System.Drawing.Size(94, 25);
            this.chckbxAdmin.TabIndex = 28;
            this.chckbxAdmin.Text = "Yetki Ver!";
            this.chckbxAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chckbxAdmin.UncheckedState.BorderRadius = 0;
            this.chckbxAdmin.UncheckedState.BorderThickness = 0;
            this.chckbxAdmin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chckbxAdmin.UseVisualStyleBackColor = false;
            // 
            // chckbxActive
            // 
            this.chckbxActive.AutoSize = true;
            this.chckbxActive.BackColor = System.Drawing.Color.Transparent;
            this.chckbxActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chckbxActive.CheckedState.BorderRadius = 0;
            this.chckbxActive.CheckedState.BorderThickness = 0;
            this.chckbxActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chckbxActive.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chckbxActive.Location = new System.Drawing.Point(164, 44);
            this.chckbxActive.Name = "chckbxActive";
            this.chckbxActive.Size = new System.Drawing.Size(61, 25);
            this.chckbxActive.TabIndex = 29;
            this.chckbxActive.Text = "Aktif";
            this.chckbxActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chckbxActive.UncheckedState.BorderRadius = 0;
            this.chckbxActive.UncheckedState.BorderThickness = 0;
            this.chckbxActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chckbxActive.UseVisualStyleBackColor = false;
            // 
            // btn_UserUpdate
            // 
            this.btn_UserUpdate.AutoRoundedCorners = true;
            this.btn_UserUpdate.BorderRadius = 21;
            this.btn_UserUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_UserUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_UserUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_UserUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_UserUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_UserUpdate.ForeColor = System.Drawing.Color.White;
            this.btn_UserUpdate.Location = new System.Drawing.Point(15, 596);
            this.btn_UserUpdate.Name = "btn_UserUpdate";
            this.btn_UserUpdate.Size = new System.Drawing.Size(253, 45);
            this.btn_UserUpdate.TabIndex = 30;
            this.btn_UserUpdate.Text = "Güncelle";
            this.btn_UserUpdate.Click += new System.EventHandler(this.btn_UserUpdate_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.DefaultText = "";
            this.txt_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.Location = new System.Drawing.Point(15, 330);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.PlaceholderText = "";
            this.txt_Username.SelectedText = "";
            this.txt_Username.Size = new System.Drawing.Size(253, 36);
            this.txt_Username.TabIndex = 27;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pass.DefaultText = "";
            this.txt_Pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Pass.Location = new System.Drawing.Point(15, 404);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '\0';
            this.txt_Pass.PlaceholderText = "";
            this.txt_Pass.SelectedText = "";
            this.txt_Pass.Size = new System.Drawing.Size(253, 36);
            this.txt_Pass.TabIndex = 26;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(15, 309);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(60, 15);
            this.guna2HtmlLabel4.TabIndex = 25;
            this.guna2HtmlLabel4.Text = "Kullanıcı Adı";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(15, 383);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(24, 15);
            this.guna2HtmlLabel3.TabIndex = 24;
            this.guna2HtmlLabel3.Text = "Şifre";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(15, 230);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLabel9.TabIndex = 23;
            this.guna2HtmlLabel9.Text = "İletişim";
            // 
            // txt_Contact
            // 
            this.txt_Contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Contact.DefaultText = "";
            this.txt_Contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Contact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Contact.Location = new System.Drawing.Point(15, 251);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.PasswordChar = '\0';
            this.txt_Contact.PlaceholderText = "";
            this.txt_Contact.SelectedText = "";
            this.txt_Contact.Size = new System.Drawing.Size(253, 36);
            this.txt_Contact.TabIndex = 22;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(15, 157);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(46, 15);
            this.guna2HtmlLabel7.TabIndex = 21;
            this.guna2HtmlLabel7.Text = "Firma Adı";
            // 
            // txt_Surname
            // 
            this.txt_Surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Surname.DefaultText = "";
            this.txt_Surname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Surname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Surname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Surname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Surname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Surname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Surname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Surname.Location = new System.Drawing.Point(15, 109);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.PasswordChar = '\0';
            this.txt_Surname.PlaceholderText = "";
            this.txt_Surname.SelectedText = "";
            this.txt_Surname.Size = new System.Drawing.Size(253, 36);
            this.txt_Surname.TabIndex = 20;
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CompanyName.DefaultText = "";
            this.txt_CompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CompanyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CompanyName.Location = new System.Drawing.Point(15, 178);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.PasswordChar = '\0';
            this.txt_CompanyName.PlaceholderText = "";
            this.txt_CompanyName.SelectedText = "";
            this.txt_CompanyName.Size = new System.Drawing.Size(253, 36);
            this.txt_CompanyName.TabIndex = 19;
            // 
            // txt_Name
            // 
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.DefaultText = "";
            this.txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Location = new System.Drawing.Point(15, 35);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.PlaceholderText = "";
            this.txt_Name.SelectedText = "";
            this.txt_Name.Size = new System.Drawing.Size(253, 36);
            this.txt_Name.TabIndex = 18;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(15, 88);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(38, 15);
            this.guna2HtmlLabel5.TabIndex = 17;
            this.guna2HtmlLabel5.Text = "Soyisim";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(15, 14);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(21, 15);
            this.guna2HtmlLabel2.TabIndex = 16;
            this.guna2HtmlLabel2.Text = "İsim";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dtg_Users);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(302, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1070, 776);
            this.guna2Panel2.TabIndex = 2;
            // 
            // KullaniciID
            // 
            this.KullaniciID.DataPropertyName = "Kullanici_id";
            this.KullaniciID.HeaderText = "Column1";
            this.KullaniciID.Name = "KullaniciID";
            this.KullaniciID.ReadOnly = true;
            this.KullaniciID.Visible = false;
            // 
            // Adı
            // 
            this.Adı.DataPropertyName = "Kullaniciadi";
            this.Adı.HeaderText = "Adı";
            this.Adı.Name = "Adı";
            this.Adı.ReadOnly = true;
            // 
            // Soyadı
            // 
            this.Soyadı.DataPropertyName = "Kullanicisoyadi";
            this.Soyadı.HeaderText = "Soyadı";
            this.Soyadı.Name = "Soyadı";
            this.Soyadı.ReadOnly = true;
            // 
            // İletişim
            // 
            this.İletişim.DataPropertyName = "Iletisim";
            this.İletişim.HeaderText = "İletişim";
            this.İletişim.Name = "İletişim";
            this.İletişim.ReadOnly = true;
            // 
            // FirmaAdı
            // 
            this.FirmaAdı.DataPropertyName = "Firma_Adi";
            this.FirmaAdı.HeaderText = "Firma Adı";
            this.FirmaAdı.Name = "FirmaAdı";
            this.FirmaAdı.ReadOnly = true;
            // 
            // KullanıcıAdı
            // 
            this.KullanıcıAdı.DataPropertyName = "user_name";
            this.KullanıcıAdı.HeaderText = "Kullanıcı Adı";
            this.KullanıcıAdı.Name = "KullanıcıAdı";
            this.KullanıcıAdı.ReadOnly = true;
            // 
            // Sifre
            // 
            this.Sifre.DataPropertyName = "pass";
            this.Sifre.HeaderText = "Şifre";
            this.Sifre.Name = "Sifre";
            this.Sifre.ReadOnly = true;
            this.Sifre.Visible = false;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            this.Profit.HeaderText = "Hesaptaki Para";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "isActive";
            this.isActive.HeaderText = "Aktif";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            // 
            // isAdmin
            // 
            this.isAdmin.DataPropertyName = "isAdmin";
            this.isAdmin.HeaderText = "Admin";
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.ReadOnly = true;
            // 
            // UC_KullaniciUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_KullaniciUpdate";
            this.Size = new System.Drawing.Size(1372, 776);
            this.Load += new System.EventHandler(this.UC_KullaniciUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Users)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dtg_Users;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2TextBox txt_Contact;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txt_Surname;
        private Guna.UI2.WinForms.Guna2TextBox txt_CompanyName;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox chckbxAdmin;
        private Guna.UI2.WinForms.Guna2CheckBox chckbxActive;
        private Guna.UI2.WinForms.Guna2Button btn_UserUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txt_Username;
        private Guna.UI2.WinForms.Guna2TextBox txt_Pass;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyadı;
        private System.Windows.Forms.DataGridViewTextBoxColumn İletişim;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullanıcıAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdmin;
    }
}
