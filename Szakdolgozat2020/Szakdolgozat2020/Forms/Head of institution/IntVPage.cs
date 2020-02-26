using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat2020.Forms.Head_of_institution;

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
            WorkersRegistration wr = new WorkersRegistration();
            wr.Show();
        }
    }
}
