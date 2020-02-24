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

namespace Szakdolgozat2020
{
    public partial class LogInScreen : MetroFramework.Forms.MetroForm
    {
        public LogInScreen()
        {
            InitializeComponent();
            
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            panelLoad.Width += 2;
            if (panelLoad.Width >= 522)
            {
                timerLoad.Stop();
                LogIn li = new LogIn();
                li.Show();
                this.Hide();
            }
        }

        private void LogInScreen_Load(object sender, EventArgs e)
        {
            CreateCommand cc = new CreateCommand();
            cc.createDatabase();
            cc.createTableLogIn();
            cc.createTableChildrenFullProfile();
            cc.createTableParents();
            cc.createTableParentsK();
            cc.createTableHealth();
            cc.createTableEvents();
            cc.createTableEventsK();
            cc.createTableSchool();
            cc.createTableChildrenSchool();

            cc.fillTestUsers();
            cc.fillTestChildren();
            cc.fillTestParents();
            cc.fillTestParentsK();
            cc.fillTestHealths();
            cc.fillTestEvents();
            cc.fillTestEventsK();
            cc.fillTestShool();
            cc.fillTestSchoolsk();

        }
    }
}
