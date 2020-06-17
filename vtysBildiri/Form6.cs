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
    public partial class Form6 : Form
    {
        String conString = @"data source=.;initial catalog=vtysBildiri;user id=sa;password=12345;MultipleActiveResultSets=True;";

        public Form6()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TcKimlikNo, adi FROM[katilimcilar] JOIN bildiri ON [katilimcilar].tcKimlikNo = tcKimlikNo", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBildiriIzleme.DataSource = dt;
            }

        }


    }
}
