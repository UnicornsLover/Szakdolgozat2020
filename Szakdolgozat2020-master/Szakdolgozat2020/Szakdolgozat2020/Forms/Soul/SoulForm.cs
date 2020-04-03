using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szakdolgozat2020.Forms.Soul
{
    public partial class SoulForm : MetroFramework.Forms.MetroForm
    {
        public SoulForm()
        {
            InitializeComponent();
            metroLabelLoggedName.Text = LogIn.fnameLoged;
        }

        private void metroTileAddMEvents_Click(object sender, EventArgs e)
        {
            SoulReg sr = new SoulReg();
            sr.Show();
        }

        private void metroButtonLogOut_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            this.Hide();
        }
    }
}
