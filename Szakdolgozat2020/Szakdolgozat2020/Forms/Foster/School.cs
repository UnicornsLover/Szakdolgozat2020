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
    public partial class School : MetroFramework.Forms.MetroForm
    {
        public School()
        {
            InitializeComponent();
        }

        private void metroButtonAddSchool_Click(object sender, EventArgs e)
        {
            AddSchool sch = new AddSchool();
            sch.Show();
        }

        private void metroButtonLogOut_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            this.Hide();
        }
    }
}
