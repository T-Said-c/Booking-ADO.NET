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
    public partial class Citymenu : Form
    {
        int user;
        public Citymenu(int code)
        {
            InitializeComponent();
            user = code;
        }

        private void Citymenu_Load(object sender, EventArgs e)
        {

        }

        private void btncasa_Click(object sender, EventArgs e)
        {
            String city = btncasa.Text;
            this.Hide();
            var menu = new MenuClient(user,city);
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void btnrabat_Click(object sender, EventArgs e)
        {
            String city = btnrabat.Text;
            this.Hide();
            var menu = new MenuClient(user, city);
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void btnmarrakech_Click(object sender, EventArgs e)
        {
            String city = btnmarrakech.Text;
            this.Hide();
            var menu = new MenuClient(user, city);
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void btntetouan_Click(object sender, EventArgs e)
        {
            String city = btntetouan.Text;
            this.Hide();
            var menu = new MenuClient(user, city);
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}
