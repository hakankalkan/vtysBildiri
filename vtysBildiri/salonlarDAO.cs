using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using vtysBildiri;
using System.Windows.Forms;

namespace vtysBildiri
{
    class salonlarDAO
    {
        public void salonEkle(salonlar s)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into salon(salonNo, salonAdi, bulunduguKat) values (@salonNo, @salonAdi, @bulunduguKat)", con);
                cmd.Parameters.AddWithValue("@salonNo", s.salonNo);
                cmd.Parameters.AddWithValue("@salonAdi", s.salonAdi);
                cmd.Parameters.AddWithValue("@bulunduguKat", s.bulunduguKat);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Eklendi");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }

        public void salonSil(salonlar s)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("delete from salon where salonNo=@salonNo", con);
                
                int x = 0;
                Int32.TryParse(s.salonNo, out x);
                cmd.Parameters.AddWithValue("@salonNo", x);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silindi");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }

        public void salonGuncelle(salonlar s)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("update salon set salonNo=@salonNo, salonAdi=@salonAdi, bulunduguKat=@bulunduguKat where salonNo=@salonNoEski", con);
                cmd.Parameters.AddWithValue("@salonNo", s.salonNo);
                cmd.Parameters.AddWithValue("@salonAdi", s.salonAdi);
                cmd.Parameters.AddWithValue("@bulunduguKat", s.bulunduguKat);
                int x = 0;
                Int32.TryParse(s.salonNoEski, out x);
                cmd.Parameters.AddWithValue("@x", x);
                cmd.Parameters.AddWithValue("@salonNoEski", x);
                cmd.ExecuteNonQuery();
                MessageBox.Show("güncellendi");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();
        }


        public static SqlConnection openConnection()
        {
            SqlConnection con = new SqlConnection("data source=.;initial catalog=vtysBildiri;user id=sa;password=12345;MultipleActiveResultSets=True;");
            try
            {
                con.Open();
                return con;

            }
            catch (Exception)
            {

                throw;
            }



        }
        public static void connectionClose(SqlConnection con)
        {
            con.Close();
        }
       

    }
}
