using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class MenuClient : Form
    {
        int codecl;
        string city;
        public MenuClient(int currentuser, string currentcity)
        {
            InitializeComponent();
            codecl = currentuser;
            city = currentcity;
        }

        private void MenuClient_Load(object sender, EventArgs e)
        {
            lbcity.Text = city;
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Citymenu(codecl);
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new login();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
        private void loadform(object form)
        {
            if (this.changepanel.Controls.Count > 0)
            {
                this.changepanel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.changepanel.Controls.Add(f);
            f.Show();

        }

        private void btnhotel_Click(object sender, EventArgs e)
        {
            try
            {
                citypanel.Visible = true;

                loadform(new commandhotel(codecl,city));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                citypanel.Visible = false;
                changepanel.Size = new Size(1180, 440);
                changepanel.BringToFront();
                loadform(new ProfilClient(codecl));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnhouse_Click(object sender, EventArgs e)
        {
            try
            {
                citypanel.Visible = true;
                loadform(new commanderhouse(codecl,city));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncar_Click(object sender, EventArgs e)
        {
            try
            {
                citypanel.Visible = true;

                loadform(new commadervoiture(codecl,city));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btntaxi_Click(object sender, EventArgs e)
        {
            try
            {
                citypanel.Visible = true;

                loadform(new commandertaxi(codecl,city));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
