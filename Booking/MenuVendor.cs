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
    public partial class MenuVendor : Form
    {
        int codeven;
        public MenuVendor(int currentuser)
        {
            InitializeComponent();
            codeven = currentuser;
        }

        private void MenuVendor_Load(object sender, EventArgs e)
        {
           
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
                loadform(new listhotel(codeven));

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
                loadform(new listhouse(codeven));

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
                loadform(new Profil(codeven));

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
                loadform(new listcar(codeven));

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
                loadform(new listtaxi(codeven));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new login();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void changepanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
