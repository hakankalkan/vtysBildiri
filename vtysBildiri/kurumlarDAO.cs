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
    class kurumlarDAO
    {
        public void kurumEkle(kurumlar k)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into kurumlar(kurumNo, kurumAdi) values (@kurumNo, @kurumAdi)", con);
                cmd.Parameters.AddWithValue("@kurumNo", k.kurumNo);
                cmd.Parameters.AddWithValue("@kurumAdi", k.kurumAdi);
                //cmd.Parameters.AddWithValue("@tc","14");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Eklendi");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }

        public void kurumSil(kurumlar k)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("delete from kurumlar where kurumNo=@kurumNo", con);
                cmd.Parameters.AddWithValue("@kurumNo", k.kurumNo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silindi");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }

        public void kurumGuncelle(kurumlar k)
        {
            SqlConnection con = openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("update kurumlar set kurumNo=@kurumNo , kurumAdi=@kurumAdi where kurumNo=@kurumNoEski", con);
                cmd.Parameters.AddWithValue("@kurumNo", k.kurumNo);
                cmd.Parameters.AddWithValue("@kurumAdi", k.kurumAdi);
               // cmd.Parameters.AddWithValue("@tcKimlikNo", null);
                int x = 0;
                Int32.TryParse(k.kurumNoEski, out x);
                cmd.Parameters.AddWithValue("@x", x);
                cmd.Parameters.AddWithValue("@kurumNoEski", x);
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
        /*
            public void kurumlartcKimlikNoEkle(tcKimlikNo)
            {
                SqlConnection con = new SqlConnection();
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into kurumlar (tcKimlikNo) values (@x) where kurumNo=getItem", con);
                    cmd.Parameters.AddWithValue("@x", tcKimlikNo)
                }
            }

        */

        


    }
}
