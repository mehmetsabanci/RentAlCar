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
    public partial class FrmRentAlCarAnaSayfa : Form
    {
        public FrmRentAlCarAnaSayfa()
        {
            InitializeComponent();
        }
        
        public string EPosta;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmRentAlCarAnaSayfa_Load(object sender, EventArgs e)
        {
            label1.Text = EPosta;
            SqlCommand komut = new SqlCommand("Select Kullaniciid,KullaniciAd,KullaniciSoyad From TblKullanicilar where KullaniciEPosta=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",label1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label18.Text = dr[0].ToString();
                label2.Text = dr[1] + " " + dr[2].ToString();

            }
            bgl.baglanti().Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmFavoriler fr = new FrmFavoriler();
            fr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            FrmIlanEkle fr = new FrmIlanEkle();
            fr.kullaniciidshow = label18.Text;
            fr.Show();
            
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmOdemeSayfasi fr = new FrmOdemeSayfasi();
            fr.kira = label6.Text;
            fr.Text = "Hyundai 1.5";
            fr.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmOdemeSayfasi fr = new FrmOdemeSayfasi();
            fr.kira = label7.Text;
            fr.Text = "Audi A4";
            fr.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FrmOdemeSayfasi fr = new FrmOdemeSayfasi();
            fr.kira = label13.Text;
            fr.Text = "BMW M4 Cabrio";
            fr.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmOdemeSayfasi fr = new FrmOdemeSayfasi();
            fr.kira = label9.Text;
            fr.Text = "Audi Quattro Jeep";
            fr.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FrmOdemeSayfasi fr = new FrmOdemeSayfasi();
            fr.kira = label11.Text;
            fr.Text = "Mercedes Cls 250";
            fr.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            FrmOdemeSayfasi fr = new FrmOdemeSayfasi();
            fr.kira = label15.Text;
            fr.Text = "Volvo XC40";
            fr.Show();
        }
    }
}
