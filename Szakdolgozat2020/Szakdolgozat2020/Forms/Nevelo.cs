using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
