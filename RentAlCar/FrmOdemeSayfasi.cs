using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAlCar
{
    public partial class FrmOdemeSayfasi : Form
    {
        public FrmOdemeSayfasi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Talebiniz alınmıştır. 1-3 iş günü içerinde bilgilendireceksiniz!");
        }
        public string kira;
        private void FrmOdemeSayfasi_Load(object sender, EventArgs e)
        {
            label7.Text = kira;
        }
    }
}
