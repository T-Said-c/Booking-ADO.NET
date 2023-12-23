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
    public partial class listhouse : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2HA4QV3B\SQLEXPRESS;Initial Catalog=BookingPro;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        int user;
        public listhouse(int code)
        {
            InitializeComponent();
            user = code;
        }

        private void listhouse_Load(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream();
            MemoryStream memo = new MemoryStream();
            MemoryStream memor = new MemoryStream();
            MemoryStream memory = new MemoryStream();


            try
            {
                if (tbnom.Text == String.Empty || tbadresse.Text == String.Empty || tbprix.Text == String.Empty || tbdes.Text == String.Empty || phout.Image == null || phbed.Image == null || phcui.Image == null || phtoi.Image == null || tbcity.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    Random rnd = new Random();
                    int codehotel = rnd.Next(1, 10000000);
                    cmd = new SqlCommand("insert into House values (@CodeHouse,@CodeVendor,@Nom,@Adresse,@Prix,@Des,@city,@Ph1,@Ph2,@Ph3,@Ph4)", con);
                    cmd.Parameters.AddWithValue("@CodeHouse", codehotel);
                    cmd.Parameters.AddWithValue("@CodeVendor", user);
                    cmd.Parameters.AddWithValue("@Nom", tbnom.Text);
                    cmd.Parameters.AddWithValue("@Adresse", tbadresse.Text);
                    cmd.Parameters.AddWithValue("@Des", tbdes.Text);
                    cmd.Parameters.AddWithValue("@city", tbcity.Text);
                    cmd.Parameters.AddWithValue("@Prix", tbprix.Text);
                    phout.Image.Save(mem, phout.Image.RawFormat);
                    byte[] img = mem.ToArray();
                    cmd.Parameters.AddWithValue("@Ph1", img);
                    phbed.Image.Save(memo, phbed.Image.RawFormat);
                    byte[] imag = memo.ToArray();
                    cmd.Parameters.AddWithValue("@Ph2", imag);
                    phcui.Image.Save(memor, phcui.Image.RawFormat);
                    byte[] image = memor.ToArray();
                    cmd.Parameters.AddWithValue("@Ph3", image);
                    phtoi.Image.Save(memory, phtoi.Image.RawFormat);
                    byte[] images = memory.ToArray();
                    cmd.Parameters.AddWithValue("@Ph4", images);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    MessageBox.Show("La maison a été bien ajouté!");
                    tbnom.Text = String.Empty;
                    tbadresse.Text = String.Empty;
                    tbprix.Text = String.Empty;
                    tbdes.Text = String.Empty;
                    tbcity.Text = null;
                    phout.Image = null;
                    phbed.Image = null;
                    phcui.Image = null;
                    phtoi.Image = null;

                }

            }
            catch (Exception)
            {
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

        private void phbed_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Open Image";
            dialog.Filter = "png files (*.png)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var PictureBox1 = new PictureBox();
                phbed.Image = Image.FromFile(dialog.FileName);
            }

            dialog.Dispose();
        }

        private void phcui_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Open Image";
            dialog.Filter = "png files (*.png)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var PictureBox1 = new PictureBox();
                phcui.Image = Image.FromFile(dialog.FileName);
            }

            dialog.Dispose();
        }

        private void phtoi_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Open Image";
            dialog.Filter = "png files (*.png)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var PictureBox1 = new PictureBox();
                phtoi.Image = Image.FromFile(dialog.FileName);
            }

            dialog.Dispose();
        }
    }
}
