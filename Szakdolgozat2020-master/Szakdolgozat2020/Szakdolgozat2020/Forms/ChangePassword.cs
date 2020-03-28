using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat2020.Database;
using Szakdolgozat2020.Forms.Head_of_institution;
using Szakdolgozat2020.Modell.Employes;
using Szakdolgozat2020.Repository.Employes;

namespace Szakdolgozat2020.Forms
{
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        RepositoryEmployes repo = new RepositoryEmployes();
        CreateCommand cc = new CreateCommand();
        private DataTable employesDT = new DataTable();
        public ChangePassword()
        {
            InitializeComponent();
            int userId = Convert.ToInt32(LogIn.userId);
            string userName = LogIn.fnameLoged;
            metroLabelLoggedIn.Text = userName;
            metroLabelUserId.Text = userId.ToString();
        }

        public void getEmploye()
        { 
            
        }

        private void metroButtonChangePassword_Click(object sender, EventArgs e)
        {
            string username = LogIn.fnameLoged;
            int userId = Convert.ToInt32(LogIn.userId);
            if (metroTextBoxPassChange.Text == metroTextBoxPassConfirm.Text)
            {
                try
                {
                    //Adatbázisban
                    cc.changePasswordFirstLogIn(username, metroTextBoxPassChange.Text);
                }
                catch (Exception)
                {

                    throw new newPasswordException("Nem sikerült hozzáadni az adatbázishoz.");
                }

                try
                {
                    //Frissítéss a datagridviewba
                    WorkersRegistration wr = new WorkersRegistration();
                    wr.updateDataInDataGriedViewt();
                }
                catch (Exception)
                {

                    throw new newPasswordException("Nem sikerült hozzáadni a listához.");
                }

                LogIn li = new LogIn();
                li.Show();
                this.Hide();
                
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nNem egyeznek a jelszavak, prbálja meg újból!.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
