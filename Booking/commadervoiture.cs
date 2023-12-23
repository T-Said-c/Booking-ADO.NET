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
using System.IO;

namespace Booking
{
    public partial class commadervoiture : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B\SQLEXPRESS;Initial Catalog=BookingPro;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        int codecl;
        string city;

        public commadervoiture(int currentuser,string ville)
        {
            InitializeComponent();
            codecl = currentuser;
            city = ville;
        }

        private void commadervoiture_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select CodeVoiture,Marque,type,Modele,Carburant,Transmission,Adresse,Prix,Photo from Voiture where City like '%"+ city+"%'", con);
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
                nudnuit.Value = 1;
                int i = dgvdata.Rows.IndexOf(dgvdata.CurrentRow);
                lbmar.Text = dgvdata.Rows[i].Cells[1].Value.ToString();
                lbtype.Text = dgvdata.Rows[i].Cells[2].Value.ToString();
                lbmod.Text = dgvdata.Rows[i].Cells[3].Value.ToString();
                lbcar.Text = dgvdata.Rows[i].Cells[4].Value.ToString();
                lbtr.Text = dgvdata.Rows[i].Cells[5].Value.ToString();
                lbadresse.Text = dgvdata.Rows[i].Cells[6].Value.ToString();
                lbprix.Text = dgvdata.Rows[i].Cells[7].Value.ToString();
                picinsert(i, 8, ph);
                pr =lbprix.Text;
                lbprix.Text = lbprix.Text+ " DH";
            }
            catch (Exception ex)
            {

            }
        }
        Byte[] data;
        public void picinsert(int i, int p, PictureBox pic)
        {
            data = (Byte[])(dgvdata.Rows[i].Cells[p].Value);
            var stream = new MemoryStream(data);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Image = Image.FromStream(stream);

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

        private void nudnuit_ValueChanged(object sender, EventArgs e)
        {
            lbprix.Text = (int.Parse(pr)*nudnuit.Value).ToString()+ " DH";
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int coderes = rnd.Next(1, 10000000);
            int i = dgvdata.Rows.IndexOf(dgvdata.CurrentRow);
            string codevoiture = dgvdata.Rows[i].Cells[0].Value.ToString();
            cmd = new SqlCommand("insert into ResVoiture values (@CodeResVoiture,@CodeHouse,@CodeClient,@Montant,@Datedebut,@Jours)", con);
            cmd.Parameters.AddWithValue("@CodeResVoiture", coderes);
            cmd.Parameters.AddWithValue("@CodeHouse", codevoiture);
            cmd.Parameters.AddWithValue("@CodeClient", codecl);
            string p = lbprix.Text.Substring(0, lbprix.Text.Length - 3);
            cmd.Parameters.AddWithValue("@Montant", p);
            cmd.Parameters.AddWithValue("@Datedebut", dtp.Value);
            cmd.Parameters.AddWithValue("@Jours", nudnuit.Value.ToString());
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            con.Close();
            MessageBox.Show("La reservation est faite!");
        }
    }
}
