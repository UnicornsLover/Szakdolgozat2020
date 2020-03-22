using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat2020.Repository.Schools;

namespace Szakdolgozat2020.Forms.Foster
{
    public partial class Schools : MetroFramework.Forms.MetroForm
    {
        RepositorySchools rs = new RepositorySchools();
        DatabaseCommand rep = new DatabaseCommand();
        private DataTable schoolchildTD = new DataTable();
        public Schools()
        {
            InitializeComponent();
            rs.setSchools(rep.getSchoolsFromDatabase());
            metroComboBoxSchool.DataSource = rs.getSchoolName();
        }

        private void metroButtonAddSchool_Click(object sender, EventArgs e)
        {
            AddSchool sch = new AddSchool();
            sch.Show();
        }

        private void metroButtonLogOut_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            this.Hide();
        }

        private void metroComboBoxSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            int schoolId = rs.getSchoolId(metroComboBoxSchool.Text);
        }

        private void Schools_Load(object sender, EventArgs e)
        {

        }
    }
}
