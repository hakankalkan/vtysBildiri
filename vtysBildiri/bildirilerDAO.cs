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
    class bildirilerDAO
    {
        public void bildiriEkle(bildiriler b)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into bildiri(bildiriNo, bildiriAdi, gun, saat) values (@bildiriNo, @bildiriAdi, @gun, @saat)", con);
                cmd.Parameters.AddWithValue("@bildiriNo", b.bildiriNo);
                cmd.Parameters.AddWithValue("@bildiriAdi", b.bildiriAdi);
                cmd.Parameters.AddWithValue("@gun", b.gun);
                cmd.Parameters.AddWithValue("@saat", b.saat);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Eklendi");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }

        public void bildiriSil(bildiriler b)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("delete from bildiri where bildiriNo=@bildiriNo", con);
                
                int x = 0;
                Int32.TryParse(b.bildiriNo, out x);
                cmd.Parameters.AddWithValue("@bildiriNo", x);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silindi");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }

        public void bildiriGuncelle(bildiriler b)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("update bildiri set bildiriNo=@bildiriNo, bildiriAdi=@bildiriAdi, gun=@gun, saat=@saat where bildiriNo=@bildiriNoEski", con);
                cmd.Parameters.AddWithValue("@bildiriNo", b.bildiriNo);
                cmd.Parameters.AddWithValue("@bildiriAdi", b.bildiriAdi);
                cmd.Parameters.AddWithValue("@gun", b.gun);
                cmd.Parameters.AddWithValue("@saat", b.saat);
                int x = 0;
                Int32.TryParse(b.bildiriNoEski, out x);
                cmd.Parameters.AddWithValue("@x", x);
                cmd.Parameters.AddWithValue("@bildiriNoEski", x);
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
            SqlConnection con = new SqlConnection("data source=.;initial catalog=vtysBildiri;user id=sa;password=18982885638Hk+;MultipleActiveResultSets=True;");
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
