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
    public partial class Profil : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B\SQLEXPRESS;Initial Catalog=BookingPro;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        int user;
        public Profil(int code)
        {
            InitializeComponent();
            user = code;
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            infoload();
        }
        
        private void infoload()
        {
            cmd = new SqlCommand("select FullNom,Email,mdp,Tel from Vendor where CodeVendor=@Code", con);
            cmd.Parameters.AddWithValue("@Code", user);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tbnom.Text = dr[0].ToString();
                tbemail.Text = dr[1].ToString();
                tbmdp.Text = dr[2].ToString();
                tbtele.Text = dr[3].ToString();
            }
            dr.Close();
            con.Close();
        }
        private void btnmod_Click(object sender, EventArgs e)
        {
            btnmod.Visible = false;
            btnenr.Visible = true;
            btnann.Visible = true;
            tbnom.ReadOnly = false;
            tbemail.ReadOnly = false;
            tbmdp.ReadOnly = false;
            tbtele.ReadOnly = false;
        }
        private void tbreadtrue()
        {
            tbnom.ReadOnly = true;
            tbemail.ReadOnly = true;
            tbmdp.ReadOnly = true;
            tbtele.ReadOnly = true; 
        }

        private void btnann_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sûr ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                btnmod.Visible = true;
                btnenr.Visible = false;
                btnann.Visible = false;
                tbreadtrue();
                infoload();

            }
        }

        private void btnenr_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                if (tbnom.Text == String.Empty || tbemail.Text == String.Empty || tbmdp.Text == String.Empty || tbtele.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Etes vous sûr de vouloir modifier vos informations?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("update Vendor set FullNom=@Nom ,Email=@Email ,mdp=@mdp ,Tel=@tel where CodeVendor=@user ", con);
                        cmd.Parameters.AddWithValue("@Nom", tbnom.Text);
                        cmd.Parameters.AddWithValue("@Email", tbemail.Text);
                        cmd.Parameters.AddWithValue("@mdp", tbmdp.Text);
                        cmd.Parameters.AddWithValue("@tel", tbtele.Text);
                        cmd.Parameters.AddWithValue("@user", user);
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Close();
                        con.Close();
                        btnmod.Visible = true;
                        btnenr.Visible = false;
                        btnann.Visible = false;
                        tbreadtrue();
                        infoload();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez entrer des valeurs correctes"); MessageBox.Show(ex.Message); con.Close();
            }
        }
         public void charger()
        {if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            DataTable dt = new DataTable();
            dgvdata.DataSource = dt;
            string req = "";
            if (cbp.Text == "Hotel")
            {
                req = "select * from Hotel where CodeVendor like "+ user;
            }
            if (cbp.Text == "Maison")
            {
                req = "select * from house where CodeVendor like "+ user;
            }
            if (cbp.Text == "Voiture")
            {
                req = "select * from Voiture where CodeVendor like "+ user;
            }
            if (cbp.Text == "Taxi")
            {
                req = "select * from Taxi where CodeVendor like "+ user;
            }
            con.Open();
            cmd = new SqlCommand(req, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dgvdata.DataSource = t;
            dr.Close();
            con.Close();
        }
        private void cbp_SelectedIndexChanged(object sender, EventArgs e)
        {
            charger();
        }

        private void btnsup_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                DialogResult dialogResult = MessageBox.Show("Etes vous sûr de vouloir supprimer cette propriété?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    int i = dgvdata.Rows.IndexOf(dgvdata.CurrentRow);
                    int num = int.Parse(dgvdata.Rows[i].Cells[0].Value.ToString());

                    string req = "";
                    if (cbp.Text == "Hotel")
                    {
                        req = "Delete Hotel where CodeHotel like "+ num;
                    }
                    if (cbp.Text == "Maison")
                    {
                        req = "Delete house where CodeHouse like "+ num;
                    }
                    if (cbp.Text == "Voiture")
                    {
                        req = "Delete Voiture where CodeVoiture like "+ num;
                    }
                    if (cbp.Text == "Taxi")
                    {
                        req = "Delete Taxi where CodeTaxi like "+ num;
                    }
                    con.Open();
                    cmd = new SqlCommand(req, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    MessageBox.Show("La propriété a été supprimé!");
                    charger();

                }
            }catch (Exception)
            {
                MessageBox.Show("cette propriété est utilisée au moment");
            }
        }

        private void dgvdata_SelectionChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            int i = dgvdata.Rows.IndexOf(dgvdata.CurrentRow);
            int num = int.Parse(dgvdata.Rows[i].Cells[0].Value.ToString());

            string req = "";
            if (cbp.Text == "Hotel")
            {
                req = "Select * from ResHotel where CodeHotel like "+ num;
            }
            if (cbp.Text == "Maison")
            {
                req = "Select * from Reshouse where CodeHouse like "+ num;
            }
            if (cbp.Text == "Voiture")
            {
                req = "Select * from Resvoiture where CodeVoiture like "+ num;
            }
            if (cbp.Text == "Taxi")
            {
                req = "Select * from ResTaxi where CodeTaxi like "+ num;
            }
            con.Open();
            cmd = new SqlCommand(req, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dgvres.DataSource = t;
            dr.Close();
            con.Close();

        }
    }
}
