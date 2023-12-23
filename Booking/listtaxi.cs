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
    public partial class listtaxi : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B\SQLEXPRESS;Initial Catalog=BookingPro;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        int user;
        public listtaxi(int code)
        {
            InitializeComponent();
            user = code;
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void listtaxi_Load(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbmar.Text == String.Empty || tbtel.Text == String.Empty || tbprix.Text == String.Empty || tbadresse.Text == String.Empty || tbcity.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    Random rnd = new Random();
                    int codetaxi = rnd.Next(1, 10000000);
                    cmd = new SqlCommand("insert into Taxi values (@CodeTaxi,@CodeVendor,@Marque,@Tel,@Adresse,@Prix,@city)", con);
                    cmd.Parameters.AddWithValue("@CodeTaxi", codetaxi);
                    cmd.Parameters.AddWithValue("@CodeVendor", user);
                    cmd.Parameters.AddWithValue("@Marque", tbmar.Text);
                    cmd.Parameters.AddWithValue("@Tel", tbtel.Text);
                    cmd.Parameters.AddWithValue("@Adresse", tbadresse.Text);
                    cmd.Parameters.AddWithValue("@Prix", tbprix.Text);
                    cmd.Parameters.AddWithValue("@city", tbcity.Text);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    MessageBox.Show("Le taxi a été bien ajouté!");
                    tbmar.Text = String.Empty;
                    tbtel.Text = String.Empty;
                    tbadresse.Text = String.Empty;
                    tbprix.Text = String.Empty;
                    tbcity.Text = null;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Veuillez entrer des valeurs correctes");

                con.Close();
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
