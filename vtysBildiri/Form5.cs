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
    public partial class Form5 : Form
    {
        String conString = @"data source=.;initial catalog=vtysBildiri;user id=sa;password=18982885638Hk+;MultipleActiveResultSets=True;";
        public Form5()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select bildiriNo, bildiriAdi, gun, saat from bildiri", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBildiri.DataSource = dt;
            }
        }



        private void bildiriEkle_Click(object sender, EventArgs e)
        {
            bildiriler b = new bildiriler();
            b.bildiriNo = bildiriNoText.Text;
            b.bildiriAdi = bildiriAdiText.Text;
            b.gun = bildiriGunText.Text;
            b.saat = bildiriSaatText.Text;

            bildirilerDAO bildirilerDAO = new bildirilerDAO();
            bildirilerDAO.bildiriEkle(b);
        }

        private void bildiriGuncelle_Click(object sender, EventArgs e)
        {
            bildiriler b = new bildiriler();
            b.bildiriNoEski = bildiriNoEski.Text;
            b.bildiriNo = bildiriNoText.Text;
            b.bildiriAdi = bildiriAdiText.Text;
            b.gun = bildiriGunText.Text;
            b.saat = bildiriSaatText.Text;

            bildirilerDAO bildirilerDAO = new bildirilerDAO();
            bildirilerDAO.bildiriGuncelle(b);
        }

        private void bildiriSil_Click(object sender, EventArgs e)
        {
            bildiriler b = new bildiriler();
            b.bildiriNo = bildiriNoText.Text;
            
            b.bildiriAdi = bildiriAdiText.Text;
            b.gun = bildiriGunText.Text;
            b.saat = bildiriSaatText.Text;

            bildirilerDAO bildirilerDAO = new bildirilerDAO();
            bildirilerDAO.bildiriSil(b);
        }
    }
}
