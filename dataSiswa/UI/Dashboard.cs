using dataSiswa.BLL;
using dataSiswa.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataSiswa
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            sidePanel.Height = btnHome.Height;
            home1.BringToFront();
          
        }
        SiswaBLL s = new SiswaBLL();
        SiswaDAL dal = new SiswaDAL();

        private void Button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            home1.BringToFront();
            
        }
        
        private void Button1_Click_1(object sender, EventArgs e)
        {
            

            if (MessageBox.Show("Apa Anda Yakin Ingin Keluar dari Program?","Konfirmasi Keluar", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString()=="YA" )
            {
                Application.Exit();
            }
            else
            {
                Application.Exit();              
               
            }
           

           
        }

        private void BtnSiswa_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnSiswa.Height;
            sidePanel.Top = btnSiswa.Top;
            dataSiswa4.BringToFront();
        }

        private void BtnKelas_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnKelas.Height;
            sidePanel.Top = btnKelas.Top;
            dataKelas1.BringToFront();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BtnGuru_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnGuru.Height;
            sidePanel.Top = btnGuru.Top;
            dataGuru1.BringToFront();
        }
    }
}
