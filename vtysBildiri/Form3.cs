using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtysBildiri
{
    public partial class Form3 : Form
    {
        String conString = @"data source=.;initial catalog=vtysBildiri;user id=sa;password=12345;MultipleActiveResultSets=True;";
        public Form3()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from katilimcilar", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewKatilimci.DataSource = dt;
            }

           

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void katilimcilarEkle_Click(object sender, EventArgs e)
        {
            katilimcilar k = new katilimcilar();
            k.katilimciAdi = katilimcilarAdiText.Text;
            k.tcKimlikNo = katilimcilarTcKimlikNoText.Text;
            k.katilimciSoyadi = katilimcilarSoyadiText.Text;
            k.gorevUnvani = katilimcilarGorevUnvaniText.Text;
            katilimcilarDAO katilimcilarDAO = new katilimcilarDAO();
            katilimcilarDAO.katilimciEkle(k);

            

            // combobox için:   String getItem = comboBoxKurumSec.SelectedItem.ToString();


            
        }
        private void katilimcilarSil_Click(object sender, EventArgs e)
        {
            katilimcilar k = new katilimcilar();
            k.tcKimlikNo = katilimcilarTcKimlikNoText.Text;
            
        
            katilimcilarDAO katilimcilarDAO = new katilimcilarDAO();
            katilimcilarDAO.katilimciSil(k);

        }
       
        private void katilimcilarGuncelle_Click(object sender, EventArgs e)
        {
            katilimcilar k = new katilimcilar();
            k.katilimciAdi = katilimcilarAdiText.Text;
            k.tcKimlikNo = katilimcilarTcKimlikNoText.Text;
            k.katilimciSoyadi = katilimcilarSoyadiText.Text;
            k.gorevUnvani = katilimcilarGorevUnvaniText.Text;
            k.tcKimlikNoEski = tcKimlikNoEski.Text;
            katilimcilarDAO katilimcilarDAO = new katilimcilarDAO();
            katilimcilarDAO.katilimciGuncelle(k);
        }
    }
}
