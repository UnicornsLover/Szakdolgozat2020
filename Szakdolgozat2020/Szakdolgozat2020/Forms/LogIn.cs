using MetroFramework;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat2020.Database;
using Szakdolgozat2020.Forms;

namespace Szakdolgozat2020
{
    public partial class LogIn : MetroFramework.Forms.MetroForm
    {
        public static string fnameLoged = "";
        private readonly string connectionString;
        Connection dc = new Connection();
        public LogIn()
        {
            connectionString = dc.getConnectionString();
            InitializeComponent();
            metroTextBoxPass.PasswordChar = '*';
        }

        private void metroButtonLogIn_Click(object sender, EventArgs e)
        {

            string hiba = "";
            labelError.Font = new Font("Times New Roman", 12);
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM loginusers WHERE fname = '" + metroTextBoxFName.Text + "' AND password = '" + metroTextBoxPass.Text + "'; ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            //bool login = false;
            if (dr.Read())
            {
                this.Hide();
                switch (dr["job"].ToString())
                {
                    case "boss":
                        Boss f = new Boss();
                        f.Show();
                        break;
                    case "nevelo":
                        Form2 f2 = new Form2();
                        f2.Show();
                        break;
                    case "intvezeto":
                        IntVPage ivp = new IntVPage();
                        ivp.Show();
                        break;
                    default:
                        hiba += "Nem rendelkezik státusszal!";
                        labelError.Text += hiba;
                        break;
                }
                fnameLoged = metroTextBoxFName.Text; //bejelenkező neve tárolva
                //metrolabelnev.Text = LogIn.FnameLoged -> ez kell majd a formra ahova kiírod ki jelentkezett be
            }
            else
            {
                //errorProviderFName.SetError(metroTextBoxFName, "Hibás felhasználónév, kérlek próbálokozz újból!");
                //hiba += "Hibás felhasználónév vagy jelszó,\n kérlek próbálokozz újból!";
                labelError.Text = hiba;
                MetroMessageBox.Show(this, "Hibás felhasználónév vagy jelszó,\n kérlek próbálokozz újból!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            con.Close();

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
