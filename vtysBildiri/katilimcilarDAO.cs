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
    class katilimcilarDAO
    {
        public void katilimciEkle(katilimcilar k)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into katilimcilar(tcKimlikNo, adi, soyadi, gorevUnvani) values (@tcKimlikNo, @adi, @soyadi, @gorevUnvani)", con);
                cmd.Parameters.AddWithValue("@tcKimlikNo", k.tcKimlikNo);
                cmd.Parameters.AddWithValue("@adi", k.katilimciAdi);
                cmd.Parameters.AddWithValue("@soyadi", k.katilimciSoyadi);
                cmd.Parameters.AddWithValue("@gorevUnvani", k.gorevUnvani);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Eklendi");
       

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }

        public void katilimciSil(katilimcilar k)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("delete from katilimcilar where tcKimlikNo=@tcKimlikNo", con);
                int x = 0;
                Int32.TryParse(k.tcKimlikNo, out x);
                cmd.Parameters.AddWithValue("@tcKimlikNo", x);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silindi");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }
       
        public void katilimciGuncelle(katilimcilar k)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("update katilimcilar set tcKimlikNo=@tcKimlikNo, adi=@katilimciAdi, soyadi=@katilimciSoyadi, gorevUnvani=@gorevUnvani where tcKimlikNo=@tcKimlikNoEski", con);
                cmd.Parameters.AddWithValue("@tcKimlikNo", k.tcKimlikNo);
                cmd.Parameters.AddWithValue("@katilimciAdi", k.katilimciAdi);
                cmd.Parameters.AddWithValue("@katilimciSoyadi", k.katilimciSoyadi);
                cmd.Parameters.AddWithValue("@gorevUnvani", k.gorevUnvani);
                int x = 0;
                Int32.TryParse(k.tcKimlikNoEski, out x);
                cmd.Parameters.AddWithValue("@x", x);
                cmd.Parameters.AddWithValue("@tcKimlikNoEski", x);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Güncellendi");

            }
            catch(Exception e)
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
