using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szakdolgozat2020.Forms.Foster
{
    public partial class Fosterhomepage : MetroFramework.Forms.MetroForm
    {
        public Fosterhomepage()
        {
            InitializeComponent();
            metroLabelLoggedName.Text = LogIn.fnameLoged;
        }

        private void Fosterhomepage_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonLogOut_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Schools sc = new Schools();
            sc.Show();
        }
    }
}
