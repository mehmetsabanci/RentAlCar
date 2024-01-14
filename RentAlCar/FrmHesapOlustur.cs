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
    public partial class FrmHesapOlustur : Form
    {
        public FrmHesapOlustur()
        {
            InitializeComponent();
        }
        
       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Start();

            
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
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FindForm().Top -= 10;
            if(this.FindForm().Top >= 50)
            {
                timer1.Stop();
                this.Hide();
               
                
          }

       }
        
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into TblKullanicilar (KullaniciAd,KullaniciSoyad,KullaniciDogumTarih,KullaniciEPosta,KullaniciSifre,KullaniciCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", TxtEposta.Text);
            komut.Parameters.AddWithValue("@p5", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p6", CmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Tamamlanmıştır, Lütfen Giriş Yapın","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Hide();

        }
    }
    }

