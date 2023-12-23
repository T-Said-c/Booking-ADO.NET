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

namespace Booking
{
    public partial class commandertaxi : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B\SQLEXPRESS;Initial Catalog=BookingPro;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        int codecl;
        string city;

        public commandertaxi(int currentuser,string ville)
        {
            InitializeComponent();
            codecl = currentuser;
            city = ville;
        }


        private void commandertaxi_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select CodeTaxi,Marque,Tel,Adresse,Prix from Taxi where City like '%"+ city+"%'", con);
            con.Open();
            SqlDataReader sqlr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlr);
            dgvdata.DataSource = dt;
            sqlr.Close();
            con.Close();
        }

        private void dgvdata_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i = dgvdata.Rows.IndexOf(dgvdata.CurrentRow);
                lbmar.Text = dgvdata.Rows[i].Cells[1].Value.ToString();
                lbtel.Text = dgvdata.Rows[i].Cells[2].Value.ToString();
                lbadresse.Text = dgvdata.Rows[i].Cells[3].Value.ToString();
                lbprix.Text = dgvdata.Rows[i].Cells[4].Value.ToString();
                pr =lbprix.Text;
                lbprix.Text = lbprix.Text+ " DH";
            } 
            catch (Exception ex)
            {
                
            }
        }

        private string pr;


        public void Set(string s)
        {
            pr = s;
        }
        public string Get()
        {
            return pr;
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int coderes = rnd.Next(1, 10000000);
            int i = dgvdata.Rows.IndexOf(dgvdata.CurrentRow);
            string codetaxi = dgvdata.Rows[i].Cells[0].Value.ToString();
            cmd = new SqlCommand("insert into ResTaxi values (@CodeResTaxi,@CodeTaxi,@CodeClient,@Date,@Heure,@Destination)", con);
            cmd.Parameters.AddWithValue("@CodeResTaxi", coderes);
            cmd.Parameters.AddWithValue("@CodeTaxi", codetaxi);
            cmd.Parameters.AddWithValue("@CodeClient", codecl);
            cmd.Parameters.AddWithValue("@Date", dtp.Value);
            cmd.Parameters.AddWithValue("@Heure", cbh.Text);
            cmd.Parameters.AddWithValue("@Destination", tbdes.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            con.Close();
            MessageBox.Show("La reservation est faite!");
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
