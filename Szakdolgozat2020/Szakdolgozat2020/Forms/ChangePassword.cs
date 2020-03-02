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
using Szakdolgozat2020.Modell.Employes;
using Szakdolgozat2020.Repository.Employes;

namespace Szakdolgozat2020.Forms
{
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        RepositoryEmployes repo = new RepositoryEmployes();
        CreateCommand cc = new CreateCommand();
        public ChangePassword()
        {
            InitializeComponent();
            int userId = Convert.ToInt32(LogIn.userId);
            string userName = LogIn.fnameLoged;
            metroLabelLoggedIn.Text = userName;
            metroLabelUserId.Text = userId.ToString();
        }

        private void metroButtonChangePassword_Click(object sender, EventArgs e)
        {
            string username = LogIn.fnameLoged;
            if (metroTextBoxPassChange.Text == metroTextBoxPassConfirm.Text)
            {
                cc.changePasswordFirstLogIn(username, metroLabelPasswordConfig.Text);
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nNem egyeznek a jelszavak, prbálja meg újból!.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
