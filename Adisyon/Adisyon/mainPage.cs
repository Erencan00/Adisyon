using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adisyon
{
    public partial class mainPage : Form
    {
        private masalar masalarInstance;
        private raporlar raporlarInstance;

        public mainPage()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Form içinde form açılabilir yapıyoruz
        }

        masalar Masalar = new masalar();
        raporlar Raporlar = new raporlar();
        private void masalar_Click(object sender, EventArgs e)
        {
            Raporlar.Close();
            Raporlar.Dispose();

            // Form zaten açıksa açma
            if (masalarInstance != null && !masalarInstance.IsDisposed)
            {
                // masalar zaten açık olduğu için odağını ona getir
                masalarInstance.Focus();
            }
            else
            {
                // masalar daha önce açıldıysa yeni bir örneğini oluştur ve göster
                masalarInstance = new masalar();
                masalarInstance.MdiParent = this;
                masalarInstance.Show();
            }
            



        }

        private void raporlar_Click(object sender, EventArgs e)
        {
            // Form zaten açıksa açma
            if (raporlarInstance != null && !raporlarInstance.IsDisposed)
            {
                // masalar zaten açık olduğu için odağını ona getir
                raporlarInstance.Focus();
            }
            else
            {
                // masalar daha önce açıldıysa yeni bir örneğini oluştur ve göster
                raporlarInstance = new raporlar();
                raporlarInstance.MdiParent = this;
                raporlarInstance.Show();
            }
        }
    }
}
