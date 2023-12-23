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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B\SQLEXPRESS;Initial Catalog=BookingPro;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbmdp.PasswordChar = '\0';
            }
            else
            {
                tbmdp.PasswordChar = '*';
            }
        }

        private void btCl_Click_1(object sender, EventArgs e)
        {
            checkstatus.Checked = false;
            btCl.BackColor = Color.Goldenrod;
            btmn.BackColor = Color.DarkGray;
        }

        private void btmn_Click_1(object sender, EventArgs e)
        {
            checkstatus.Checked = true;
            btmn.BackColor = Color.Goldenrod;
            btCl.BackColor = Color.DarkGray;
        }


        int code;

        public string Nom = string.Empty;

        int status;
        public string _Nom
        {
            get { return Nom; }
            set { if (Nom != value) Nom = value; }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            bool a = false;
            bool b = false;
            if (checkstatus.Checked == true)
            {
                cmd = new SqlCommand("Select distinct Email from Vendor", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (tbemail.Text == dr[0].ToString())
                    {
                        a = true;
                        Nom = tbemail.Text;
                        break;

                    }

                }
                dr.Close();
                SqlCommand cmda = new SqlCommand("Select distinct mdp from Vendor", con);
                SqlDataReader sqlr = cmda.ExecuteReader();
                while (sqlr.Read())
                {
                    if (tbmdp.Text == sqlr[0].ToString())
                    {
                        b = true;

                    }

                }
                sqlr.Close();
                con.Close();
                if (a == true && b == true)
                {
                    SqlCommand cmdaz = new SqlCommand("Select distinct CodeVendor from Vendor where email=@email", con);
                    cmdaz.Parameters.AddWithValue("@email", tbemail.Text);
                    con.Open();
                    SqlDataReader sqler = cmdaz.ExecuteReader();
                    while (sqler.Read())
                    {
                        code = int.Parse(sqler[0].ToString());

                    }
                    sqler.Close();
                    con.Close();
                    this.Hide();
                    var menu = new MenuVendor(code);
                    menu.Closed += (s, args) => this.Close();
                    menu.Show();
                    

                }
                else
                {
                    MessageBox.Show("L'email ou Le mot de passe est incorrecte");
                    tbemail.Clear();
                    tbmdp.Clear();
                }
            }
            if (checkstatus.Checked == false)
            {
                cmd = new SqlCommand("Select distinct Email from Client", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (tbemail.Text == dr[0].ToString())
                    {
                        a = true;
                        Nom = tbemail.Text;
                        break;

                    }

                }
                dr.Close();
                SqlCommand cmda = new SqlCommand("Select distinct mdp from Client", con);
                SqlDataReader sqlr = cmda.ExecuteReader();
                while (sqlr.Read())
                {
                    if (tbmdp.Text == sqlr[0].ToString())
                    {
                        b = true;

                    }

                }
                sqlr.Close();
                con.Close();
                if (a == true && b == true)
                {
                    SqlCommand cmdaz = new SqlCommand("Select distinct CodeClient from Client where email=@email", con);
                    cmdaz.Parameters.AddWithValue("@email", tbemail.Text);
                    con.Open();
                    SqlDataReader sqler = cmdaz.ExecuteReader();
                    while (sqler.Read())
                    {
                        code = int.Parse(sqler[0].ToString());

                    }
                    sqler.Close();
                    con.Close();
                    this.Hide();
                    var menu = new Citymenu(code);
                    menu.Closed += (s, args) => this.Close();
                    menu.Show();

                }
                else
                {
                    MessageBox.Show("L'email ou Le mot de passe est incorrecte");
                    tbemail.Clear();
                    tbmdp.Clear();
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            if(checkstatus.Checked == true)
            {
                status =1;
            }
            else
            {
                status =0;
            }
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "signupVendor")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {
                var menu = new signupVendor(status);
                menu.Show();
            }

        }
    }
}
