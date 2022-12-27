namespace MainDashboard
{
    partial class satis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSat = new Guna.UI2.WinForms.Guna2Button();
            this.grpVarolan = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgMusteriler = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtMusteriadi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMusteriSoyadi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMusteriIletisim = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TCKmlktxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpVarolan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSat
            // 
            this.btnSat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSat.ForeColor = System.Drawing.Color.White;
            this.btnSat.Location = new System.Drawing.Point(1137, 633);
            this.btnSat.Margin = new System.Windows.Forms.Padding(2);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(135, 37);
            this.btnSat.TabIndex = 6;
            this.btnSat.Text = "Sat";
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // grpVarolan
            // 
            this.grpVarolan.AutoScroll = true;
            this.grpVarolan.AutoScrollMinSize = new System.Drawing.Size(200, 25);
            this.grpVarolan.Controls.Add(this.dtgMusteriler);
            this.grpVarolan.FillColor = System.Drawing.Color.Silver;
            this.grpVarolan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpVarolan.ForeColor = System.Drawing.Color.Black;
            this.grpVarolan.Location = new System.Drawing.Point(43, 70);
            this.grpVarolan.Margin = new System.Windows.Forms.Padding(2);
            this.grpVarolan.Name = "grpVarolan";
            this.grpVarolan.Size = new System.Drawing.Size(1229, 409);
            this.grpVarolan.TabIndex = 9;
            this.grpVarolan.Text = "Müşteri Seçiniz";
            // 
            // dtgMusteriler
            // 
            this.dtgMusteriler.AllowUserToAddRows = false;
            this.dtgMusteriler.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgMusteriler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMusteriler.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMusteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMusteriler.ColumnHeadersHeight = 30;
            this.dtgMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.firmaid});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMusteriler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgMusteriler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgMusteriler.Location = new System.Drawing.Point(2, 44);
            this.dtgMusteriler.Margin = new System.Windows.Forms.Padding(2);
            this.dtgMusteriler.Name = "dtgMusteriler";
            this.dtgMusteriler.ReadOnly = true;
            this.dtgMusteriler.RowHeadersVisible = false;
            this.dtgMusteriler.RowHeadersWidth = 51;
            this.dtgMusteriler.RowTemplate.Height = 24;
            this.dtgMusteriler.RowTemplate.ReadOnly = true;
            this.dtgMusteriler.Size = new System.Drawing.Size(1225, 354);
            this.dtgMusteriler.TabIndex = 7;
            this.dtgMusteriler.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgMusteriler.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgMusteriler.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgMusteriler.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgMusteriler.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgMusteriler.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dtgMusteriler.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgMusteriler.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgMusteriler.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgMusteriler.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtgMusteriler.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgMusteriler.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgMusteriler.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgMusteriler.ThemeStyle.ReadOnly = true;
            this.dtgMusteriler.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgMusteriler.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgMusteriler.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtgMusteriler.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgMusteriler.ThemeStyle.RowsStyle.Height = 24;
            this.dtgMusteriler.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgMusteriler.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgMusteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMusteriler_CellClick);
            this.dtgMusteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMusteriler_CellContentClick);
            // 
            // txtMusteriadi
            // 
            this.txtMusteriadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMusteriadi.DefaultText = "";
            this.txtMusteriadi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMusteriadi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMusteriadi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMusteriadi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMusteriadi.Enabled = false;
            this.txtMusteriadi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMusteriadi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMusteriadi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMusteriadi.Location = new System.Drawing.Point(88, 534);
            this.txtMusteriadi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusteriadi.Name = "txtMusteriadi";
            this.txtMusteriadi.PasswordChar = '\0';
            this.txtMusteriadi.PlaceholderText = "";
            this.txtMusteriadi.SelectedText = "";
            this.txtMusteriadi.Size = new System.Drawing.Size(160, 29);
            this.txtMusteriadi.TabIndex = 12;
            // 
            // txtMusteriSoyadi
            // 
            this.txtMusteriSoyadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMusteriSoyadi.DefaultText = "";
            this.txtMusteriSoyadi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMusteriSoyadi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMusteriSoyadi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMusteriSoyadi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMusteriSoyadi.Enabled = false;
            this.txtMusteriSoyadi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMusteriSoyadi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMusteriSoyadi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMusteriSoyadi.Location = new System.Drawing.Point(341, 533);
            this.txtMusteriSoyadi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusteriSoyadi.Name = "txtMusteriSoyadi";
            this.txtMusteriSoyadi.PasswordChar = '\0';
            this.txtMusteriSoyadi.PlaceholderText = "";
            this.txtMusteriSoyadi.SelectedText = "";
            this.txtMusteriSoyadi.Size = new System.Drawing.Size(160, 29);
            this.txtMusteriSoyadi.TabIndex = 12;
            // 
            // txtMusteriIletisim
            // 
            this.txtMusteriIletisim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMusteriIletisim.DefaultText = "";
            this.txtMusteriIletisim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMusteriIletisim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMusteriIletisim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMusteriIletisim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMusteriIletisim.Enabled = false;
            this.txtMusteriIletisim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMusteriIletisim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMusteriIletisim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMusteriIletisim.Location = new System.Drawing.Point(569, 533);
            this.txtMusteriIletisim.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusteriIletisim.Name = "txtMusteriIletisim";
            this.txtMusteriIletisim.PasswordChar = '\0';
            this.txtMusteriIletisim.PlaceholderText = "";
            this.txtMusteriIletisim.SelectedText = "";
            this.txtMusteriIletisim.Size = new System.Drawing.Size(160, 29);
            this.txtMusteriIletisim.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 546);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(292, 546);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(516, 546);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "İletişim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(738, 546);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "TC Kimlik";
            // 
            // TCKmlktxt
            // 
            this.TCKmlktxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCKmlktxt.DefaultText = "";
            this.TCKmlktxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TCKmlktxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TCKmlktxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCKmlktxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCKmlktxt.Enabled = false;
            this.TCKmlktxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCKmlktxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TCKmlktxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCKmlktxt.Location = new System.Drawing.Point(801, 534);
            this.TCKmlktxt.Margin = new System.Windows.Forms.Padding(2);
            this.TCKmlktxt.Name = "TCKmlktxt";
            this.TCKmlktxt.PasswordChar = '\0';
            this.TCKmlktxt.PlaceholderText = "";
            this.TCKmlktxt.SelectedText = "";
            this.TCKmlktxt.Size = new System.Drawing.Size(160, 29);
            this.TCKmlktxt.TabIndex = 14;
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
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 15;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1307, 47);
            this.guna2DataGridView1.TabIndex = 11;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 15;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Musteri_id";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // firmaid
            // 
            this.firmaid.DataPropertyName = "Firma_id";
            this.firmaid.HeaderText = "Column2";
            this.firmaid.Name = "firmaid";
            this.firmaid.ReadOnly = true;
            this.firmaid.Visible = false;
            // 
            // satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1307, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TCKmlktxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteriIletisim);
            this.Controls.Add(this.txtMusteriSoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriadi);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpVarolan);
            this.Controls.Add(this.btnSat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Ekranı";
            this.Load += new System.EventHandler(this.satis_Load);
            this.grpVarolan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSat;
        private Guna.UI2.WinForms.Guna2GroupBox grpVarolan;
        private Guna.UI2.WinForms.Guna2DataGridView dtgMusteriler;
        private Guna.UI2.WinForms.Guna2TextBox txtMusteriadi;
        private Guna.UI2.WinForms.Guna2TextBox txtMusteriSoyadi;
        private Guna.UI2.WinForms.Guna2TextBox txtMusteriIletisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TCKmlktxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        public Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaid;
    }
}