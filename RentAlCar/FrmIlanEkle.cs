using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RentAlCar
{
    public partial class FrmIlanEkle : Form
    {
        public FrmIlanEkle()
        {
            InitializeComponent();
        }
        RentAlCarEntities db = new RentAlCarEntities();
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string kullaniciidshow;

        private void FrmIlanEkle_Load(object sender, EventArgs e)
        {
            label20.Text = kullaniciidshow;
            Txtid.Text = label20.Text;
            Txtid.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TblAraclar t = new TblAraclar();
            t.Kullaniciid = byte.Parse(Txtid.Text);
            t.Vasita = textBox1.Text;
            t.Yil = CmbYil.Text;
            t.Marka = CmbMarka.Text;
            t.Model = CmbModel.Text;
            t.Yakit = CmbYakit.Text;
            t.Vites = CmbVites.Text;
            t.AracDurumu = CmbAracDurumu.Text;
            t.KM = int.Parse(MskKM.Text);
            t.KasaTipi = CmbKasaTipi.Text;
            t.MotorGücü = MskMotorGücü.Text;
            t.MotorHacmi = MskMotorHacmi.Text;
            t.Cekis = CmbCekis.Text;
            t.Renk = CmbRenk.Text;
            t.Kimden = CmbKimden.Text;
            db.TblAraclar.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi tamamlanmıştır!, Listeleyerek görüntüleyebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbMarka.Text == "Alfa Romeo")
            {
                CmbModel.Items.Add("STELVIO QUADRIFOGLIO");
                CmbModel.Items.Add("TONALE PLUG-IN");
                CmbModel.Items.Add("GIULIA QUADRIFOGLIO");
                
            }
            
            else if (CmbMarka.Text == "Audi")
            {
                CmbModel.Items.Add("A4");
                CmbModel.Items.Add("Quattro Jeep");
                CmbModel.Items.Add("RS6");
                
            }
            else if (CmbMarka.Text == "BMW")
            {
                CmbModel.Items.Add("M4 Cabrio");
                CmbModel.Items.Add("M5 Sport");
                CmbModel.Items.Add("520");
                
            }
            else if (CmbMarka.Text == "Chery")
            {
                CmbModel.Items.Add("TIGGO 7 PRO");
                CmbModel.Items.Add("TIGGO 8 PRO");
                CmbModel.Items.Add("AMADO");
            }
            else if (CmbMarka.Text == "Chevrolet")
            {
                CmbModel.Items.Add("Cruze");
                CmbModel.Items.Add("Aveo");
                CmbModel.Items.Add("Camaro");
            }
            else if (CmbMarka.Text == "Citroen")
            {
                CmbModel.Items.Add("C3");
                CmbModel.Items.Add("C4");
                CmbModel.Items.Add("Berlingo");
            }
            else if (CmbMarka.Text == "Cupra")
            {
                CmbModel.Items.Add("Formentor");
                CmbModel.Items.Add("Leon");
                CmbModel.Items.Add("Ateco");
            }
            else if (CmbMarka.Text == "Dacia")
            {
                CmbModel.Items.Add("Duster");
                CmbModel.Items.Add("Sandero");
                CmbModel.Items.Add("Logan");
            }
            else if (CmbMarka.Text == "Ds")
            {
                CmbModel.Items.Add("DS-7");
                CmbModel.Items.Add("DS-4");

            }
            else if (CmbMarka.Text == "Ford")
            {
                CmbModel.Items.Add("Focus");
                CmbModel.Items.Add("Fiesta");

            }
            else if (CmbMarka.Text == "Honda")
            {
                CmbModel.Items.Add("Civic");

            }
            else if (CmbMarka.Text == "Hyundai")
            {
                CmbModel.Items.Add("A4");
                CmbModel.Items.Add("Quattro Jeep");
                CmbModel.Items.Add("RS6");
            }
            else if (CmbMarka.Text == "Kia")
            {
                CmbModel.Items.Add("Cerato");
                CmbModel.Items.Add("Stonic");
                CmbModel.Items.Add("Picanto");
            }
            else if (CmbMarka.Text == "Land Rover")
            {
                CmbModel.Items.Add("Range Rover");
                CmbModel.Items.Add("Discovery");
                CmbModel.Items.Add("Defender");
            }
            else if (CmbMarka.Text == "Mazda")
            {
                CmbModel.Items.Add("RX-8");
                CmbModel.Items.Add("RX-7");
                CmbModel.Items.Add("Familia");
            }
            else if (CmbMarka.Text == "Mercedes")
            {
                CmbModel.Items.Add("Benz");
                CmbModel.Items.Add("Cls 200");
                CmbModel.Items.Add("AMG");
            }
            else if (CmbMarka.Text == "Nissan")
            {
                CmbModel.Items.Add("QASHQAI");
                CmbModel.Items.Add("Juke");
                CmbModel.Items.Add("X-TRAIL");
            }
            else if (CmbMarka.Text == "Opel")
            {
                CmbModel.Items.Add("Astra");
                CmbModel.Items.Add("Insignia");
                CmbModel.Items.Add("Corsa");
            }
            else if (CmbMarka.Text == "Renault")
            {
                CmbModel.Items.Add("Clio");
                CmbModel.Items.Add("Megane");
                CmbModel.Items.Add("Taliant");
            }
            else if (CmbMarka.Text == "Seat")
            {
                CmbModel.Items.Add("Ibiza");
                CmbModel.Items.Add("Toledo");
                CmbModel.Items.Add("Leon");
            }
            else if (CmbMarka.Text == "Skoda")
            {
                CmbModel.Items.Add("Superb");
                CmbModel.Items.Add("Octavia");
                CmbModel.Items.Add("Fabia");
            }
            else if (CmbMarka.Text == "Tesla")
            {
                CmbModel.Items.Add("Model S");
                CmbModel.Items.Add("Model Y");
                CmbModel.Items.Add("Model X");
            }
            else if (CmbMarka.Text == "Togg")
            {
                CmbModel.Items.Add("T10X");
                CmbModel.Items.Add("T10S");
                CmbModel.Items.Add("T8CX");
            }
            else if (CmbMarka.Text == "Toyota")
            {
                CmbModel.Items.Add("Corolla");
                CmbModel.Items.Add("Land Cruiser");
                CmbModel.Items.Add("Yarıs");
            }
            else if (CmbMarka.Text == "Volkswagen")
            {
                CmbModel.Items.Add("Passat");
                CmbModel.Items.Add("Jetta");
                CmbModel.Items.Add("Tiguan");
            }
            else if (CmbMarka.Text == "Volvo")
            {
                CmbModel.Items.Add("XC40");
                CmbModel.Items.Add("XC60");
                CmbModel.Items.Add("XC90");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TblAraclar where Kullaniciid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Txtid.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtAracid.Text);
            var arclr = db.TblAraclar.Find(x);
            db.TblAraclar.Remove(arclr);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi tamamlanmıştır!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(TxtAracid.Text);
            var arclr = db.TblAraclar.Find(d);
            arclr.Vasita = textBox1.Text;
            arclr.Yil = CmbYil.Text;
            arclr.Marka = CmbMarka.Text;
            arclr.Model = CmbModel.Text;
            arclr.Yakit = CmbYakit.Text;
            arclr.Vites = CmbVites.Text;
            arclr.AracDurumu = CmbAracDurumu.Text;
            arclr.KM = int.Parse(MskKM.Text);
            arclr.KasaTipi = CmbKasaTipi.Text;
            arclr.MotorGücü = MskMotorGücü.Text;
            arclr.MotorHacmi = MskMotorHacmi.Text;
            arclr.Cekis = CmbCekis.Text;
            arclr.Renk = CmbRenk.Text;
            arclr.Kimden = CmbKimden.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi tamamlanmıştır!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAracid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txtid.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpg,Jpeg,Png Dosyalar|*.jpg,*.jpeg,*.png";
            openFileDialog1.Title = "Görsel Yükleme";
            openFileDialog1.ShowDialog(this);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.ImageLocation = (openFileDialog1.FileName);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
        }
    }
}
