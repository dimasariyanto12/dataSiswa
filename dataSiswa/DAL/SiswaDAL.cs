using dataSiswa.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataSiswa.DAL
{

    class SiswaDAL
    {
        
        
          string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region METHOD SELECT AND VIEW DATA
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "select * from tbl_siswa";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
            return dt;
        }

        #endregion

        #region  METHOD INSERT DATA SISWA
        public bool Insert(SiswaBLL s)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
           

            try
            {
                string sql = "Insert into tbl_siswa (nis,nama,jekel,alamat,no_hp)Values(@nis,@nama,@jekel,@alamat,@no_hp);";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nis", s.nis);
                cmd.Parameters.AddWithValue("@nama", s.nama);
                cmd.Parameters.AddWithValue("@jekel", s.jekel);
                cmd.Parameters.AddWithValue("@alamat", s.alamat);
                cmd.Parameters.AddWithValue("@no_hp", s.no_hp);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows>0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }
        #endregion

        #region METHDOD UPDATE DATA SISWA
        public bool Update(SiswaBLL s)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
           

            try
            {
                string sql = "update tbl_siswa set nis=@nis,nama=,@nama,jekel=@jekel,alamat=@alamat,no_hp=@no_hp where id=@id ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nis", s.nis);
                cmd.Parameters.AddWithValue("@nama", s.nama);
                cmd.Parameters.AddWithValue("@jekell", s.jekel);
                cmd.Parameters.AddWithValue("@alamat", s.alamat);
                cmd.Parameters.AddWithValue("@no_hp", s.no_hp);
                cmd.Parameters.AddWithValue("@id", s.id);

                int rows = cmd.ExecuteNonQuery();
                if (rows>0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return success;
        }
        #endregion
       
        #region METHOD HAPUS DATA
        public bool Delete(SiswaBLL s)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            

            try
            {
                string sql = "Delete from tbl_siswa where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", s.id);
                int rows = cmd.ExecuteNonQuery();
                if (rows>0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }
        #endregion

    }
}
