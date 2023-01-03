namespace MainDashboard
{
    partial class UC_AnaSayfa
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
            this.DataSetEmlaklar = new Guna.Charts.WinForms.GunaAreaDataset();
            this.DataSetSatislar = new Guna.Charts.WinForms.GunaAreaDataset();
            this.SuspendLayout();
            // 
            // DataSetEmlaklar
            // 
            this.DataSetEmlaklar.BorderColor = System.Drawing.Color.Empty;
            this.DataSetEmlaklar.FillColor = System.Drawing.Color.Empty;
            this.DataSetEmlaklar.Label = "Emlaklar";
            // 
            // DataSetSatislar
            // 
            this.DataSetSatislar.BorderColor = System.Drawing.Color.Empty;
            this.DataSetSatislar.FillColor = System.Drawing.Color.Empty;
            this.DataSetSatislar.Label = "Satışlar";
            // 
            // UC_AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_AnaSayfa";
            this.Size = new System.Drawing.Size(1245, 756);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.Charts.WinForms.GunaAreaDataset DataSetEmlaklar;
        private Guna.Charts.WinForms.GunaAreaDataset DataSetSatislar;
    }
}
