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
using Szakdolgozat2020.Forms.Head_of_institution;
using Szakdolgozat2020.Repository.Employes;

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
            catch (RepositoryReadyDataFromEmployes_LoginException ex)
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
            
        }

        private void metroTileWorkerReg_Click(object sender, EventArgs e)
        {
            try
            {
                WorkersRegistration wr = new WorkersRegistration();
                wr.Show();
            }
            catch (RepositoryReadyDataFromEmployes_LoginException ex)
            {
                Debug.WriteLine(ex.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk! Az adatbázis nem érhető el, vagy a bemeneti adatt nem megfelelő. Kérem próbálja újra később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
