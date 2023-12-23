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
    public partial class listhotel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B\SQLEXPRESS;Initial Catalog=BookingPro;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        int user;
        public listhotel(int code)
        {
            InitializeComponent();
            user = code;
        }

        private void listhotel_Load(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream();
            MemoryStream memo = new MemoryStream();
            MemoryStream memom = new MemoryStream();


            try
            {
                if (tbnom.Text == String.Empty || tbadresse.Text == String.Empty || cbr == null || tbprix.Text == String.Empty || tbdes.Text == String.Empty || phout.Image == null || phch.Image == null || phvue.Image == null || tbcity.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    Random rnd = new Random();
                    int codehotel = rnd.Next(1, 10000000);
                    cmd = new SqlCommand("insert into Hotel values (@CodeHotel,@CodeVendor,@Nom,@Adresse,@Rating,@Des,@Prix,@city,@Ph1,@Ph2,@Ph3)", con);
                    cmd.Parameters.AddWithValue("@CodeHotel", codehotel);
                    cmd.Parameters.AddWithValue("@CodeVendor", user);
                    cmd.Parameters.AddWithValue("@Nom", tbnom.Text);
                    cmd.Parameters.AddWithValue("@Adresse", tbadresse.Text);
                    cmd.Parameters.AddWithValue("@Rating", cbr.Text);
                    cmd.Parameters.AddWithValue("@Des", tbdes.Text);
                    cmd.Parameters.AddWithValue("@Prix", tbprix.Text);
                    cmd.Parameters.AddWithValue("@city", tbadresse.Text);
                    phout.Image.Save(mem, phout.Image.RawFormat);
                    byte[] img = mem.ToArray();
                    cmd.Parameters.AddWithValue("@Ph1", img);
                    phch.Image.Save(memo, phch.Image.RawFormat);
                    byte[] imag = memo.ToArray();
                    cmd.Parameters.AddWithValue("@Ph2", imag);
                    phvue.Image.Save(memom, phvue.Image.RawFormat);
                    byte[] image = memom.ToArray();
                    cmd.Parameters.AddWithValue("@Ph3", image);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    MessageBox.Show("L'hotel a été bien ajouté!");
                    tbnom.Text = String.Empty;
                    tbadresse.Text = String.Empty;
                    cbr.Text = null;
                    tbprix.Text = String.Empty;
                    tbdes.Text = String.Empty;
                    phout.Image = null;
                    phch.Image = null;
                    tbcity.Text = null;
                    phvue.Image = null;

                }

            }
            catch (Exception) {

                MessageBox.Show("Veuillez entrer des valeurs correctes");

                con.Close(); 
            }
        }

        private void phout_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Open Image";
            dialog.Filter = "png files (*.png)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var PictureBox1 = new PictureBox();
                phout.Image = Image.FromFile(dialog.FileName);
            }

            dialog.Dispose();
        }

        private void phch_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Open Image";
            dialog.Filter = "png files (*.png)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var PictureBox1 = new PictureBox();
                phch.Image = Image.FromFile(dialog.FileName);
            }

            dialog.Dispose();
        }

        private void phvue_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Open Image";
            dialog.Filter = "png files (*.png)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var PictureBox1 = new PictureBox();
                phvue.Image = Image.FromFile(dialog.FileName);
            }

            dialog.Dispose();
        }
    }
}
