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
using System.Data.SqlClient;

namespace RentAlCar
{
    public partial class FrmGirisYap : Form
    {
        public FrmGirisYap()
        {
            InitializeComponent();
        }
        FrmHesapOlustur fr = new FrmHesapOlustur();
        private void FrmGirisYap_Load(object sender, EventArgs e)
        {
            fr.Show();
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
            pictureBox2.Visible=true;
            TxtSifre.UseSystemPasswordChar = true;
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fr.Left += 10;
           
            if (fr.Left >= 900) {
                timer1.Stop();
                this.TopMost = false;
                fr.TopMost = true;
                timer2.Start();
            }
            
            

        }        
        private void timer2_Tick(object sender, EventArgs e)
        {
            fr.Left -= 10;
            if(fr.Left <= 490)
            {
                timer2.Stop();
                
            }
        
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TblKullanicilar where KullaniciEPosta=@p1 and KullaniciSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtEPosta.Text);
            komut.Parameters.AddWithValue("@p2",TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmIlanEkle frll = new FrmIlanEkle();
                FrmRentAlCarAnaSayfa frl = new FrmRentAlCarAnaSayfa();
                frl.EPosta = TxtEPosta.Text;
                frl.Show();
                fr.Hide();
                this.Hide();
            }
            else
            {
                
                    MessageBox.Show("Hatalı E-Posta veya Şifre","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            //
            //
            
        }
    }
}
