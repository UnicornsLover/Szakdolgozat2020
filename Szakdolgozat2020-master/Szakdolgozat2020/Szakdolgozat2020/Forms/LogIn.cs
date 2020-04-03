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
using Szakdolgozat2020.Forms.Foster;
using Szakdolgozat2020.Forms.Soul;

namespace Szakdolgozat2020
{
    public partial class LogIn : MetroFramework.Forms.MetroForm
    {
        public static string fnameLoged;
        public static string userId;
        public static string etype;
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
            try
            {
                con.Open();
                string query = "SELECT * FROM employes_login WHERE euname = '" + metroTextBoxFName.Text + "' AND epassword = '" + metroTextBoxPass.Text + "'; ";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                //bool login = false;
                if (dr.Read())
                {
                    this.Hide();
                    if (dr["epassword"].ToString() == "abc123")
                    {
                        fnameLoged = dr["ename"].ToString();
                        userId = dr["ID"].ToString();
                        etype = dr["ejob"].ToString();
                        ChangePassword cp = new ChangePassword();
                        cp.Show();
                    }
                    else
                    {
                        etype = dr["ejob"].ToString();
                        switch (dr["ejob"].ToString())
                        {
                            case "Rendszergazda":
                                fnameLoged = dr["ename"].ToString();
                                Boss f = new Boss();
                                f.Show();
                                break;
                            case "Ügyintéző":
                                fnameLoged = dr["ename"].ToString();
                                HomePageUgy f2 = new HomePageUgy();
                                f2.Show();
                                break;
                            case "Intézményvezető":
                                fnameLoged = dr["ename"].ToString();
                                IntVPage ivp = new IntVPage();
                                ivp.Show();
                                break;
                            case "Nevelő":
                                fnameLoged = dr["ename"].ToString();
                                Fosterhomepage sc = new Fosterhomepage();
                                sc.Show();
                                break;
                            case "Pszichológus":
                                fnameLoged = dr["ename"].ToString();
                                SoulForm sf = new SoulForm();
                                sf.Show();
                                break;
                            default:
                                hiba += "Nem rendelkezik státusszal!";
                                labelError.Text += hiba;
                                break;
                        }
                    }
                }
                else
                {
                    labelError.Text = hiba;
                    MetroMessageBox.Show(this, "Hibás felhasználónév vagy jelszó,\n kérlek próbálokozz újból!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                con.Close();

            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "\n\nHibát észleltünk! Az adatbázis nem érhető el. Kérem próbálja újra később!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
