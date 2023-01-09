using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDashboard
{
    public partial class UC_Admin : UserControl
    {
        public int firmaId { get; set; }
        public UC_Admin(int firma_id)
        {
            firmaId = firma_id;
            InitializeComponent();
        }
        private void addusercontrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelAdmin.Controls.Clear();
            PanelAdmin.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_KullaniciEkle_Click(object sender, EventArgs e)
        {
            UC_KullaniciEkle uC_KullaniciEkle = new UC_KullaniciEkle(firmaId);
            addusercontrol(uC_KullaniciEkle);
        }

        private void btn_KullaniciGuncelle_Click(object sender, EventArgs e)
        {
            UC_KullaniciUpdate uC_KullaniciUpdate = new UC_KullaniciUpdate();
            addusercontrol(uC_KullaniciUpdate);
        }
    }
}
