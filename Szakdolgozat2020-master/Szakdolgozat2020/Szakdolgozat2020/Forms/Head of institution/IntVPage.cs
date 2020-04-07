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
using Szakdolgozat2020.Forms.Foster;
using Szakdolgozat2020.Forms.Head_of_institution;
using Szakdolgozat2020.Forms.Nevelo;
using Szakdolgozat2020.Forms.Soul;
using Szakdolgozat2020.Repository.Children;
using Szakdolgozat2020.Repository.ChildrenEvents;
using Szakdolgozat2020.Repository.ChildrenParents;
using Szakdolgozat2020.Repository.ChildrenViews;
using Szakdolgozat2020.Repository.Employes;
using Szakdolgozat2020.Repository.Events;
using Szakdolgozat2020.Repository.Parents;
using Szakdolgozat2020.Repository.Schools;
using Szakdolgozat2020.Repository.Souls;

namespace Szakdolgozat2020.Forms
{
    public partial class IntVPage : MetroFramework.Forms.MetroForm
    {
        public IntVPage()
        {
            InitializeComponent();
            metroLabelLoggedName.Text = LogIn.fnameLoged;
        }

        private void IntVPage_Load(object sender, EventArgs e)
        {
        
        }

        private void metroTileReg_Click(object sender, EventArgs e)
        {
            try
            {
                WorkersRegistration wr = new WorkersRegistration();
                wr.Show();
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

        private void metroTileChildrenReg_Click(object sender, EventArgs e)
        {
            
            try 
            {
                ChildrenReg c = new ChildrenReg();
                c.Show();
            }
            catch (RepositoryChildrenReadyDataFromEmployes_LoginException ex)
            {
                Debug.WriteLine(ex.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk! Az adatbázis nem érhető el, vagy a bemeneti adatt nem megfelelő. Kérem próbálja újra később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTileWorkerReg_Click(object sender, EventArgs e)
        {
            try
            {
                WorkersRegistration wr = new WorkersRegistration();
                wr.Show();
            }
            catch (RepositoryEmployeesReadyDataFromEmployes_LoginException ex)
            {
                Debug.WriteLine(ex.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk! Az adatbázis nem érhető el, vagy a bemeneti adatt nem megfelelő. Kérem próbálja újra később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void metroTileAddSchool_Click(object sender, EventArgs e)
        {

            try
            {
                Schools sc = new Schools();
                sc.Show();
            }
            catch (RepositoryEmployeesReadyDataFromEmployes_LoginException ex)
            {
                Debug.WriteLine(ex.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk! Az adatbázis nem érhető el, vagy a bemeneti adatt nem megfelelő. Kérem próbálja újra később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTileAddMEvents_Click(object sender, EventArgs e)
        {

            try
            {
                SoulReg sc = new SoulReg();
                sc.Show();
            }
            catch (RepositorySoulsReadyDataFromEmployes_LoginException ex)
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

        private void metroTileEdu_Click(object sender, EventArgs e)
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

        private void metroTile2_Click(object sender, EventArgs e)
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
