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
    public partial class Form4 : Form
    {
        String conString = @"data source=.;initial catalog=vtysBildiri;user id=sa;password=12345;MultipleActiveResultSets=True;";
        public Form4()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from salon", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSalon.DataSource = dt;
            }
        }

        private void salonGuncelle_Click(object sender, EventArgs e)
        {
            salonlar s = new salonlar();
            s.salonAdi = salonAdiText.Text;
            s.salonNo = salonNoText.Text;
            s.bulunduguKat = salonBulunduguKatText.Text;
            s.salonNoEski = salonNoEski.Text;
            
            salonlarDAO salonlarDAO = new salonlarDAO();
            salonlarDAO.salonGuncelle(s);
        }

        private void salonEkle_Click(object sender, EventArgs e)
        {
            salonlar s = new salonlar();
            s.salonNo = salonNoText.Text;
            s.salonAdi = salonAdiText.Text;
            s.bulunduguKat = salonBulunduguKatText.Text;
            salonlarDAO salonlarDAO = new salonlarDAO();
            salonlarDAO.salonEkle(s);

        }

        private void salonSil_Click(object sender, EventArgs e)
        {
            salonlar s = new salonlar();
            s.salonNo = salonNoText.Text;
            
            salonlarDAO salonlarDAO = new salonlarDAO();
            salonlarDAO.salonSil(s);

        }
    }
}
