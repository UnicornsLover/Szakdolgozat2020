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
using Szakdolgozat2020.Repository.Children;
using Szakdolgozat2020.Repository.ChildrenParents;
using Szakdolgozat2020.Repository.Employes;
using Szakdolgozat2020.Repository.Parents;

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
            catch (RepositoryChildrenReadyDataFromEmployes_LoginException ex)
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
            

            try
            {
                ParentsReg p = new ParentsReg();
                p.Show();
            }
            catch (RepositoryParentsReadyDataFromEmployes_LoginException ex)
            {

                Debug.WriteLine(ex.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk! Az adatbázis nem érhető el, vagy a bemeneti adatt nem megfelelő. Kérem próbálja újra később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTilePC_Click(object sender, EventArgs e)
        {
            
            try
            {
                ParChiReg rp = new ParChiReg();
                rp.Show();
            }
            catch (RepositoryChildrenParentReadyDataFromEmployes_LoginException ex)
            {

                Debug.WriteLine(ex.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk! Az adatbázis nem érhető el, vagy a bemeneti adatt nem megfelelő. Kérem próbálja újra később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Error er = new Error();
            er.Show();
        }
    }
}
