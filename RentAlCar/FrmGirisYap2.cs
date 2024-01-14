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
    public partial class FrmGirisYap2 : Form
    {
        public FrmGirisYap2()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            TxtSifre2.UseSystemPasswordChar = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            TxtSifre2.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FindForm().Top -= 10;
            if (this.FindForm().Top >= 50)
            {
                timer1.Stop();
                this.Hide();


            }
        }


        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TblKullanicilar where KullaniciEPosta=@p1 and KullaniciSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtEPosta2.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmRentAlCarAnaSayfa frl = new FrmRentAlCarAnaSayfa();
                frl.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı E-Posta veya Şifre", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //this.Hide();
        }
    }
}
