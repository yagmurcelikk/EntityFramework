using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityOrnek1804
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OgrenciDal _OgrenciDal= new OgrenciDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void Yukle()
        {
            dataGridView1.DataSource = _OgrenciDal.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtadguncel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyadguncel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtnotguncel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            _OgrenciDal.Add(new Ogrenci
            {
                Ad = txtadekle.Text,
                Soyad = txtsoyadekle.Text,
                OgrenciNot = Convert.ToInt32(txtnotekle.Text),
            });
            MessageBox.Show("Bilgi Eklendi");
            Yukle();
            txtadekle.Clear();
            txtsoyadekle.Clear();
            txtnotekle.Clear();
        }

        private void btnguncel_Click(object sender, EventArgs e)
        {

            _OgrenciDal.Update(new Ogrenci
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Ad = txtadguncel.Text,
                Soyad = txtsoyadguncel.Text,
                OgrenciNot = Convert.ToInt32(txtnotguncel.Text)
            });
            MessageBox.Show("Bilgi güncellendi");
            Yukle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            _OgrenciDal.Delete(new Ogrenci
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
            });
            MessageBox.Show("Bilgi silindi");
            Yukle();
        }
    }
}
