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
    public partial class commandhotel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B\SQLEXPRESS;Initial Catalog=BookingPro;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        int codecl;
        string city;

        public commandhotel(int currentuser,string ville)
        {
            InitializeComponent();
            codecl = currentuser;
            city = ville;

        }

        private void commandhotel_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select CodeHotel,Nom,Adresse,Rating,Description,Prix,PhotoOut,PhotoRoom,PhotoView from Hotel where City like '%"+ city+"%'", con);
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
                reset();
                int r;
                int i = dgvdata.Rows.IndexOf(dgvdata.CurrentRow);
                lbnom.Text = dgvdata.Rows[i].Cells[1].Value.ToString();
                lbadresse.Text = dgvdata.Rows[i].Cells[2].Value.ToString();
                r = int.Parse(dgvdata.Rows[i].Cells[3].Value.ToString());
                rate(r);
                tbdess.Text = dgvdata.Rows[i].Cells[4].Value.ToString();
                lbprix.Text = dgvdata.Rows[i].Cells[5].Value.ToString();
                picinsert(i, 6, phout);
                picinsert(i, 7, phch);
                picinsert(i, 8, phvue);
                pr =lbprix.Text;
                lbprix.Text = lbprix.Text+ " DH";
            }
            catch (Exception ex)
            {
                
            }


        }
        Byte[] data;
        public void picinsert(int i,int p,PictureBox pic)
        {
            data = (Byte[])(dgvdata.Rows[i].Cells[p].Value);
            var stream = new MemoryStream(data);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Image = Image.FromStream(stream);

        }
        public void rate(int i)
        {
            if (i == 1)
            {
                st1.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");
            }
            if (i == 2)
            {
                st1.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");
                st2.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");

            }
            if (i == 3)
            {
                st1.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");
                st2.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");
                st3.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");

            }
            if (i == 4)
            {
                st1.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");
                st2.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");
                st3.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");
                st4.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");

            }
            if (i == 5)
            {
                st1.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");
                st2.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");
                st3.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");
                st4.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");
                st5.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\goldstar.png");

            }
        }

        public void reset()
        {
            st1.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\greystar.png");
            st2.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\greystar.png");
            st3.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\greystar.png");
            st4.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\greystar.png");
            st5.Image = Image.FromFile(@"C:\Users\Nabstie\Pictures\prog\greystar.png");
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

        private void st4_Click(object sender, EventArgs e)
        {

        }

        private void btnres_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int coderes = rnd.Next(1, 10000000);
            int i = dgvdata.Rows.IndexOf(dgvdata.CurrentRow);
            string codehotel= dgvdata.Rows[i].Cells[0].Value.ToString();
            cmd = new SqlCommand("insert into Reshotel values (@CodeReshotel,@CodeHotel,@CodeClient,@Montant,@Datedebut,@Nuits)", con);
            cmd.Parameters.AddWithValue("@CodeReshotel", coderes);
            cmd.Parameters.AddWithValue("@CodeHotel", codehotel);
            cmd.Parameters.AddWithValue("@CodeClient", codecl);
            string p = lbprix.Text.Substring(0, lbprix.Text.Length - 3);
            cmd.Parameters.AddWithValue("@Montant", p);
            cmd.Parameters.AddWithValue("@Datedebut", dtp.Value);
            cmd.Parameters.AddWithValue("@Nuits", nudnuit.Value.ToString());
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            con.Close();
            MessageBox.Show("La reservation est faite!");
        }

        private void st1_Click(object sender, EventArgs e)
        {

        }
    }
}
