using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataSiswa.DAL;
using dataSiswa.BLL;

namespace dataSiswa.UI
{
    public partial class DataSiswa : UserControl
    {
        public DataSiswa()
        {
            InitializeComponent();
        }

        //SiswaBLL s = new SiswaBLL();
        //SiswaDAL dal = new SiswaDAL();










        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

       /* private void Clear()
        {
            txtNIS.Text = "";
            txtNama.Text = "";
            cmbJekel.Text = "";
            txtAlamat.Text = "";
            txtNoHP.Text = "";
        } */

      /*  private void BtnTambah_Click(object sender, EventArgs e)
        {
            s.nis = txtNIS.Text;
            s.nama = txtNama.Text;
            s.jekel = cmbJekel.Text;
            s.alamat = txtAlamat.Text;
            s.no_hp = txtNoHP.Text;

            bool success = dal.Insert(s);
            if (success==true)
            {
                MessageBox.Show("Data Siswa Berhasil ditambahkan");
                Clear();
                
            }
            else
            {
                MessageBox.Show("Maaf, Data Siswa gagal ditambahkan");
            }
            DataTable dt = dal.Select();
            dgvSiswa.DataSource = dt;
        }*/

        private void TxtNIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataSiswa_Load(object sender, EventArgs e)
        {

        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {

        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {

        }
    }
}
