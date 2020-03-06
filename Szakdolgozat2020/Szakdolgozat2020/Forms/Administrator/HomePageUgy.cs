using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat2020.Forms.Administrator;
using Szakdolgozat2020.Forms.Nevelo;
using Szakdolgozat2020.Repository.Employes;

namespace Szakdolgozat2020.Forms.Foster
{
    public partial class HomePageUgy : MetroFramework.Forms.MetroForm
    {
        public HomePageUgy()
        {
            InitializeComponent();
            metroLabelLoggedName.Text = LogIn.fnameLoged;
        }

        private void metroTileChildrenReg_Click(object sender, EventArgs e)
        {
            

            try
            {
                ChildrenReg cr = new ChildrenReg();
                cr.Show();
            }
            catch (RepositoryEmployeesReadyDataFromEmployes_LoginException ex)
            {
                Debug.WriteLine(ex.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk! Az adatbázis nem érhető el, vagy a bemeneti adatt nem megfelelő. Kérem próbálja újra később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButtonLogOut_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ParentsReg p = new ParentsReg();
            p.Show();
        }
    }
}
