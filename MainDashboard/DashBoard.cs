﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transactions;

namespace MainDashboard
{
    public partial class DashBoard : Form
    {
        
        public DashBoard()
        {
            
            InitializeComponent();

        }
        login giris = new login();
        //loginden kullanıcı ismi gelir
        public string Firma_Adi { get; set; }
        public int firmaId { get; set; }
        private void addusercontrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            UC_AnaSayfa uC_AnaSayfa = new UC_AnaSayfa();
            addusercontrol(uC_AnaSayfa);
        }

        private void btn_MulkiyetEkle_Click(object sender, EventArgs e)
        {
            UC_Mulkiyet_Ekle uC_Mulkiyet_Ekle = new UC_Mulkiyet_Ekle(firmaId);
            addusercontrol(uC_Mulkiyet_Ekle);
        }

        private void btn_Mulkiyetler_Click(object sender, EventArgs e)
        {
            UC_Mulkiyetler uC_Mulkiyetler = new UC_Mulkiyetler(firmaId);
            addusercontrol(uC_Mulkiyetler);
        }

        private void btn_MusteriIslemleri_Click(object sender, EventArgs e)
        {
            UC_Musteri_Islemleri uC_MusteriEkle = new UC_Musteri_Islemleri(firmaId);
            addusercontrol(uC_MusteriEkle);
        }

        private void btn_Satislar_Click(object sender, EventArgs e)
        {
            UC_Satislar uC_Satislar = new UC_Satislar(firmaId);
            addusercontrol(uC_Satislar);
        }

        private void btn_Hesap_Click(object sender, EventArgs e)
        {
            UC_Hesap uC_Hesap = new UC_Hesap(firmaId);
            addusercontrol(uC_Hesap);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            //kullanıcı ismi
            lblKullanici.Text = Firma_Adi;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //çıkış onayı
        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult cevap = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                giris.Show();
            }
            else
                e.Cancel = true;
        }

        private void lblKullanici_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            UC_Admin uC_Admin = new UC_Admin(firmaId);
            addusercontrol(uC_Admin);
        }
    }
}
