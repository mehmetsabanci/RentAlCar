using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAlCar
{
    public partial class FrmHesapOlustur2 : Form
    {
        public FrmHesapOlustur2()
        {
            InitializeComponent();
        }
        FrmGirisYap2 frm = new FrmGirisYap2();
        private void FrmHesapOlustur2_Load(object sender, EventArgs e)
        {
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            TxtSifre.UseSystemPasswordChar = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            TxtSifre.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frm.Left += 10;

            if (frm.Left >= 900)
            {
                timer1.Stop();
                this.TopMost = false;
                frm.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm.Left -= 10;
            if (frm.Left <= 490)
            {
                timer2.Stop();

            }
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblKullanicilar (KullaniciAd,KullaniciSoyad,KullaniciDogumTarih,KullaniciEPosta,KullaniciSifre,KullaniciCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", TxtEposta.Text);
            komut.Parameters.AddWithValue("@p5", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p6", CmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Tamamlanmıştır, Lütfen Giriş Yapın", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //frm.Hide();
            this.Hide();
        }
    }
}
