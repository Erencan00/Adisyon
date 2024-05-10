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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void girisBtn_Click(object sender, EventArgs e)
        {
            string kullanıcıAdi = "1";
            string sifre = "1";


            if (kullanıcıAdiTxt.Text == kullanıcıAdi && sıfreTxt.Text == sifre)
            {
                mainPage mainPage = new mainPage();
                mainPage.Show();

            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }

            if (kullanıcıAdiTxt.Text == "" && sıfreTxt.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre kısmı boş bırakılamaz");
            }



        }
    }
}
