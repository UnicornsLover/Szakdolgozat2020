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
using Szakdolgozat2020.Forms.Soul;
using Szakdolgozat2020.Repository.ChildrenEvents;
using Szakdolgozat2020.Repository.ChildrenViews;
using Szakdolgozat2020.Repository.Events;
using Szakdolgozat2020.Repository.Schools;
using Szakdolgozat2020.Repository.Souls;

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
            metroTileInReason.Enabled = false;
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
                Schools sc = new Schools();
                sc.Show();
            }
            catch (RepositoryChildrenViewReadyDataFromEmployes_LoginException ex)
            {

                Debug.WriteLine(ex.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk! Az adatbázis nem érhető el, vagy a bemeneti adatt nem megfelelő. Kérem próbálja újra később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTileIntAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                AddSchool asd = new AddSchool();
                asd.Show();
            }
            catch (RepositorySchoolsReadyDataFromEmployes_LoginException ex)
            {

                Debug.WriteLine(ex.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk! Az adatbázis nem érhető el, vagy a bemeneti adatt nem megfelelő. Kérem próbálja újra később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTileEvents_Click(object sender, EventArgs e)
        {
            
            try
            {
                EventsAdd ea = new EventsAdd();
                ea.Show();
            }
            catch (RepositoryEventsReadyDataFromEmployes_LoginException ex)
            {

                Debug.WriteLine(ex.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk! Az adatbázis nem érhető el, vagy a bemeneti adatt nem megfelelő. Kérem próbálja újra később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                EventChildForm ec = new EventChildForm();
                ec.Show();
            }
            catch (RepositoryEventChildrenReadyDataFromEmployes_LoginException ex)
            {

                Debug.WriteLine(ex.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk! Az adatbázis nem érhető el, vagy a bemeneti adatt nem megfelelő. Kérem próbálja újra később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTileAddMEvents_Click(object sender, EventArgs e)
        {
            
            try
            {
                SoulReg sr = new SoulReg();
                sr.Show();
            }
            catch (RepositorySoulsReadyDataFromEmployes_LoginException ex)
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
