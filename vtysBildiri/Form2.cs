using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vtysBildiri
{

    public partial class Form2 : Form
    {
        String conString = @"data source=.;initial catalog=vtysBildiri;user id=sa;password=12345;MultipleActiveResultSets=True;";
        public Form2()
        {
            InitializeComponent();

            fillComboBox();
            showResults();

        }
        public void Form2_Load(object sender, EventArgs e)
        {


        }

        private void kurumEkle_Click(object sender, EventArgs e)
        {
            kurumlar k = new kurumlar();
            k.kurumAdi = kurumAdiText.Text;
            k.kurumNo = kurumNoText.Text;
            k.kurumNoEski = kurumNoEskiText.Text;
            kurumlarDAO kurumlarDAO = new kurumlarDAO();
            kurumlarDAO.kurumEkle(k);

         


        }
        private void kurumGuncelle_Click(object sender, EventArgs e)
        {
            kurumlar k = new kurumlar();
            k.kurumNo = kurumNoText.Text;
            k.kurumAdi = kurumAdiText.Text;
            k.kurumNoEski = kurumNoEskiText.Text;
            kurumlarDAO kurumlarDAO = new kurumlarDAO();
            kurumlarDAO.kurumGuncelle(k);
        }
        private void kurumSil_Click(object sender, EventArgs e)
        {
            kurumlar k = new kurumlar();
            k.kurumAdi = kurumAdiText.Text;
            k.kurumNo = kurumNoText.Text;
            k.kurumNoEski = kurumNoEskiText.Text;
            kurumlarDAO kurumlarDAO = new kurumlarDAO();
            kurumlarDAO.kurumSil(k);

        }
        public void showResults()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select kurumNo, kurumAdi from kurumlar", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewKurum.DataSource = dt;

            }
        }

        public void fillComboBox()
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("select  tcKimlikNo, adi from katilimcilar", con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String a = reader.GetString(1);
                    comboBoxKatilimci.Items.Add(a);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 

}
