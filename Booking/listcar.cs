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
    public partial class listcar : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B\SQLEXPRESS;Initial Catalog=BookingPro;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        int user;
        public listcar(int code)
        {
            InitializeComponent();
            user = code;
        }

        private void listcar_Load(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Open Image";
            dialog.Filter = "png files (*.png)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var PictureBox1 = new PictureBox();
                pic.Image = Image.FromFile(dialog.FileName);
            }

            dialog.Dispose();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream();

            try
            {
                if (tbmar.Text == String.Empty || tbtype.Text == String.Empty || tbmod == null || cbcar == null || cbtr == null || tbadresse.Text == String.Empty || tbprix.Text == String.Empty || pic.Image == null || tbcity.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    Random rnd = new Random();
                    int codevoiture = rnd.Next(1, 10000000);
                    cmd = new SqlCommand("insert into Voiture values (@CodeVoiture,@CodeVendor,@Marque,@Type,@Modele,@Carburant,@Transmission,@Adresse,@Prix,@city,@Ph)", con);
                    cmd.Parameters.AddWithValue("@CodeVoiture", codevoiture);
                    cmd.Parameters.AddWithValue("@CodeVendor", user);
                    cmd.Parameters.AddWithValue("@Marque", tbmar.Text);
                    cmd.Parameters.AddWithValue("@Type", tbtype.Text);
                    cmd.Parameters.AddWithValue("@Modele", tbmod.Text);
                    cmd.Parameters.AddWithValue("@Carburant", cbcar.Text);
                    cmd.Parameters.AddWithValue("@Transmission", cbtr.Text);
                    cmd.Parameters.AddWithValue("@Adresse", tbadresse.Text);
                    cmd.Parameters.AddWithValue("@city", tbcity.Text);
                    cmd.Parameters.AddWithValue("@Prix", tbprix.Text);
                    pic.Image.Save(mem, pic.Image.RawFormat);
                    byte[] image = mem.ToArray();
                    cmd.Parameters.AddWithValue("@Ph", image);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    MessageBox.Show("La voiture a été bien ajouté!");
                    tbmar.Text = String.Empty;
                    tbadresse.Text = String.Empty;
                    tbtype.Text = " ";
                    tbmod.Text = String.Empty;
                    cbcar.Text = null;
                    cbtr.Text = null;
                    tbadresse.Text = null;
                    tbcity.Text = null;
                    tbprix.Text = String.Empty;
                    pic.Image = null;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez entrer des valeurs correctes");

                con.Close();
            }
        }
    }
}
