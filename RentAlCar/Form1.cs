﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisYap fr = new FrmGirisYap();
            fr.Show();
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHesapOlustur2 fr = new FrmHesapOlustur2();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGirisYap fr = new FrmGirisYap();
            fr.Show();
        }
    }
}
