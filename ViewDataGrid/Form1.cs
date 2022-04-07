using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRODIDataSet.mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter1.Fill(this.pRODIDataSet.mahasiswa);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa_Coba' table. You can move, or remove it, as needed.
            this.mahasiswa_CobaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa_Coba);
            // TODO: This line of code loads data into the 'prodiTIDataSet.UserMhs' table. You can move, or remove it, as needed.
            this.userMhsTableAdapter.Fill(this.prodiTIDataSet.UserMhs);
            // TODO: This line of code loads data into the 'prodiTIDataSet.MataKuliah' table. You can move, or remove it, as needed.
            this.mataKuliahTableAdapter.Fill(this.prodiTIDataSet.MataKuliah);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Nilai' table. You can move, or remove it, as needed.
            this.nilaiTableAdapter.Fill(this.prodiTIDataSet.Nilai);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa1' table. You can move, or remove it, as needed.
            this.mahasiswa1TableAdapter.Fill(this.prodiTIDataSet.Mahasiswa1);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            //Warna font pada satu kolom

            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.YellowGreen;
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.DarkRed;
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.RosyBrown;
            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.DarkRed;
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Yellow;

            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Brown;
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Goldenrod;
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.BlueViolet;

            //Warna kursor
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.BlueViolet;

            //Membuat data bagian jenis kelamin menjadi center
            this.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void mahasiswa1BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void prodiTIDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
