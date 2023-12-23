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
    public partial class signupVendor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B\SQLEXPRESS;Initial Catalog=BookingPro;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        int job;
        public signupVendor(int status)
        {
            InitializeComponent();
            job = status;
        }

        string req;
        string req2;
        private void btnsign_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbnom.Text == String.Empty || tbemail.Text == String.Empty|| tbtel.Text == String.Empty || tbmdp.Text == String.Empty ||tbmdp2.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir tous les champs!");
                }
                else {
                    if (job == 1)
                    {
                        req ="select distinct email from Vendor where Email like @email";
                    }
                    if (job == 0)
                    {
                        req = "select distinct email from Client where Email like @email";
                    }
                    SqlCommand comd = new SqlCommand(req, con);
                    comd.Parameters.AddWithValue("@email", tbemail.Text);
                    con.Open();
                    SqlDataReader dr = comd.ExecuteReader();
                    if (dr.Read() != false)
                    {
                        MessageBox.Show("Cette Email existe deja!");
                        dr.Close();
                        con.Close();
                    }
                    else
                    {
                        dr.Close();
                        con.Close();
                        if (tbmdp.Text != tbmdp2.Text) 
                        {
                            MessageBox.Show("les mots de passes ne correspondent pas!");
                        }
                        else
                        {
                            Random rnd = new Random();
                            int codeven = rnd.Next(1, 10000000);

                            if (job == 1)
                            {
                                req2 ="insert into Vendor values (@CodeVendor,@Nom,@Email,@mdp,@tel)";
                            }
                            if (job == 0)
                            {
                                req2 = "insert into Client values (@CodeVendor,@Nom,@Email,@mdp,@tel)";
                            }
                            cmd = new SqlCommand(req2, con);
                            cmd.Parameters.AddWithValue("@CodeVendor", codeven);
                            cmd.Parameters.AddWithValue("@Nom", tbnom.Text);
                            cmd.Parameters.AddWithValue("@Email", tbemail.Text);
                            cmd.Parameters.AddWithValue("@mdp", tbmdp.Text);
                            cmd.Parameters.AddWithValue("@tel", tbtel.Text);
                            con.Open();
                            SqlDataReader dar = cmd.ExecuteReader();
                            dar.Close();
                            con.Close();
                            this.Close();
                        }
                    } 
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Veuillez entrer des valeurs correctes");
            }
        }

        private void signupVendor_Load(object sender, EventArgs e)
        {

        }
    }
}
