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

namespace Szakdolgozat2020.Forms
{
    public partial class Nevelo : MetroFramework.Forms.MetroForm
    {
        public Nevelo()
        {
            InitializeComponent();
            metroLabelLoggedName.Text = LogIn.fnameLoged;
        }

        private void metroTileChildrenReg_Click(object sender, EventArgs e)
        {
            try
            {
                Nevelo n = new Nevelo();
                n.Show();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk! Az adatbázis nem érhető el, vagy a bemeneti adatt nem megfelelő. Kérem próbálja újra később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
