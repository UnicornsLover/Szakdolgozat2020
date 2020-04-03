using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat2020.Forms.Soul;

namespace Szakdolgozat2020.Forms.Foster
{
    public partial class Fosterhomepage : MetroFramework.Forms.MetroForm
    {
        public Fosterhomepage()
        {
            InitializeComponent();
            metroLabelLoggedName.Text = LogIn.fnameLoged;
        }

        public string getLogName()
        { 
            string a = LogIn.fnameLoged;
            return a;
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

        private void metroTileIntAdd_Click(object sender, EventArgs e)
        {
            AddSchool asd = new AddSchool();
            asd.Show();
        }

        private void metroTileEvents_Click(object sender, EventArgs e)
        {
            EventsAdd ea = new EventsAdd();
            ea.Show();
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            EventChildForm ec = new EventChildForm();
            ec.Show();
        }

        private void metroTileAddMEvents_Click(object sender, EventArgs e)
        {
            SoulReg sr = new SoulReg();
            sr.Show();
        }
    }
}
