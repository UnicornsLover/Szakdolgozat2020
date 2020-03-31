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
using Szakdolgozat2020.Modell.Employes;
using Szakdolgozat2020.Repository.Employes;

namespace Szakdolgozat2020.Forms.Head_of_institution
{
    public partial class WorkersRegistration : MetroFramework.Forms.MetroForm
    {
        private DataTable employesDT = new DataTable();
        RepositoryEmployes repo = new RepositoryEmployes();
        RepositoryDatabseAndTableEmploye rep = new RepositoryDatabseAndTableEmploye();
        public WorkersRegistration()
        {
            InitializeComponent();
            repo.setEmploye(rep.getEmployeesFromDatabase());  
        }

        /// <summary>
        /// DataGridview frissitése
        /// </summary>
        public void updateDataInDataGriedViewt()
        {
            //Adattáblát feltölti a repoba lévő dolgozók listából
            employesDT = repo.getEmployesListToDataTable();
            //Dolgozók DataGridView-nak a forrása a employes_login adattábla
            metroGridEmployees.DataSource = null;
            metroGridEmployees.DataSource = employesDT;  
        }

        /// <summary>
        /// Beállít Datagridview oszlopait és egyébb dolgot
        /// </summary>
        public void setEmployeDataGridView()
        {
            employesDT.Columns[0].ColumnName = "Dolgozó azonosító:";
            employesDT.Columns[1].ColumnName = "Név:";
            employesDT.Columns[2].ColumnName = "Lánykori neve:";
            employesDT.Columns[3].ColumnName = "Neme:";
            employesDT.Columns[4].ColumnName = "Születési idő:";
            employesDT.Columns[5].ColumnName = "Születési hely:";
            employesDT.Columns[6].ColumnName = "Betöltött munkakör:";
            employesDT.Columns[7].ColumnName = "Lakcím:";
            employesDT.Columns[8].ColumnName = "Személyigazolvány szám:";
            employesDT.Columns[9].ColumnName = "Felhasználó név:";
            employesDT.Columns[10].ColumnName = "Jelszó:";


            metroGridEmployees.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            metroGridEmployees.ReadOnly = true;
            metroGridEmployees.AllowUserToDeleteRows = false;
            metroGridEmployees.AllowUserToAddRows = false;
            metroGridEmployees.MultiSelect = false;
            
        }

        /// <summary>
        /// Form elinduláskor való meghívás
        /// </summary>
        private void WorkersRegistration_Load(object sender, EventArgs e)
        {
            updateDataInDataGriedViewt();
            setEmployeDataGridView();
            emptyCells();
            updateEmployeesNumber();
        }

        /// <summary>
        /// Kiválasztott cell adatok jelenjenek meg a cellákban
        /// </summary>


        /// <summary>
        /// Datgridview-ba való kereseés a 'Neve:' cella segítségével
        /// </summary>
        private void metroButtonSearch_Click(object sender, EventArgs e)
        {

            if (metroTextBoxEname.Text == "")
            {
                MetroMessageBox.Show(this, "Keresés csak pontos név megadásával lehetséges (pl: Bálint István - nagy betű is fontos), a cella kitötése kötelező! \nTöltse ki a \"Neve:\" cellát!\nHa esetleg minden adatot újra szeretne látni egy szűrés után, csak is kizárólag írja be ezt a \" * \" (csillag) jelet a \"Dolgozó neve:\" cellábas!", "Hiba\n\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (metroTextBoxEname.Text == "*")
            {
                updateDataInDataGriedViewt();
            }
            else
            {
                string rowFilter = string.Format("[{0}] = '{1}'", "Név:", metroTextBoxEname.Text);
                (metroGridEmployees.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

                if (metroGridEmployees.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Keresés csak pontos név megadásával lehetséges (pl: Bálint István - nagy betű is fontos), a cella kitötése kötelező! \nTöltse ki a \"Neve:\" cellát!\nHa esetleg minden adatot újra szeretne látni egy szűrés után, csak is kizárólag írja be ezt a \" * \" (csillag) jelet a \"Neve:\" cellábas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void emptyCells()
        {
            metroTextBoxEID.Text = "";
            metroTextBoxEname.Text = ""; 
            metroTextBoxEMaidname.Text = "";
            metroComboBoxESex.SelectedItem = null;
            metroDateTimeEBirth.Text = "1945 - 01 - 01";
            metroTextBoxBPlace.Text = "";
            metroComboBoxEjobtype.SelectedItem = null;
            metroTextBoxAddress.Text = "";
            metroTextBoxIdCard.Text = "";
            metroTextBoxEUserName.Text = "";
            metroTextBoxEPassword.Text = "";
        }
        /// <summary>
        /// Cellák ürítése
        /// </summary>
        private void metroButtonCleanCells_Click(object sender, EventArgs e)
        {
            emptyCells();
        }

        /// <summary>
        /// Dolgozó törlése adatbázidból, listából, DatagridView frissítése
        /// </summary>
        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            //Ha sor nullat ad vissza ne történjen 
            if ((metroGridEmployees.Rows) == null || (metroGridEmployees.Rows.Count == 0))
            {
                return;
            }

            try
            {
                int selectedIndex = metroGridEmployees.SelectedRows[0].Index;

                DialogResult dr = MetroMessageBox.Show(this, "\n\nBiztos szeretné törölni a dolgozót?", "Dolgozó törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //Törlés a listából
                    int id = -1;
                    if (!int.TryParse(metroGridEmployees.SelectedRows[0].Cells[0].Value.ToString(), out id))
                    {
                        return;
                    }

                    try
                    {
                        repo.deleteEmployeInList(id);
                    }
                    catch (RepositoryEmployeExceptionCantDelete ex)
                    {

                        Debug.WriteLine("A dolgozó törlése sikertelen volt a listából!");
                        MetroMessageBox.Show(this, "\n\nHibát észleltünk, a törlés sikertelen volt az listából.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //Törlés az adatbázisból
                    try
                    {
                        rep.deleteEmployeFromDatabase(id);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("A dolgozó törlése sikertelen volt az adatbázisból");
                        MetroMessageBox.Show(this, "\n\nHibát észleltünk, a törlés sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //DataGridView frissítése
                    updateDataInDataGriedViewt();
                    updateEmployeesNumber();
                }
                else
                {
                    Debug.WriteLine("DialogResult.No-ra futott rá!");
                }
            }
            catch (ArgumentOutOfRangeException ae)
            {

                Debug.WriteLine("A törlés sikertelen volt!" + ae.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a törlés sikertelen volt. Kattintson a táblázatba arra a sora amit törölni kiván!", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
        /// <summary>
        /// Dolgozó módosítása adatbázidban, listában, DatagridView frissítése
        /// </summary>
        private void metroButtonModify_Click(object sender, EventArgs e)
        {
            errorProviderBPlace.Clear();
            errorProviderJob.Clear();
            errorProviderMaidenName.Clear();
            errorProviderName.Clear();
            errorProviderLocation.Clear();
            errorProviderSex.Clear();
            errorProviderBirthdayDate.Clear();
            errorProviderIdcard.Clear();

            try
            {
                Employe modified = new Employe(
                Convert.ToInt32(metroTextBoxEID.Text),
                metroTextBoxEname.Text,
                metroTextBoxEMaidname.Text,
                metroComboBoxESex.Text,
                metroDateTimeEBirth.Text,
                metroTextBoxBPlace.Text,
                metroTextBoxAddress.Text,
                metroComboBoxEjobtype.Text,
                metroTextBoxIdCard.Text,
                metroTextBoxEUserName.Text,
                metroTextBoxEPassword.Text
                );
                int id = Convert.ToInt32(metroTextBoxEID.Text);

                //Módosítás az adatbázisban
                try
                {
                    rep.updateEmployeeInDatabase(id, modified);
                }
                catch (Exception ex)
                {
                    throw new updateEmployeException();
                }


                //Módosítás a listában
                try
                {
                    repo.updateEmployeInList(id, modified);
                }
                catch (Exception ex)
                {

                    Debug.WriteLine("A dolgozó módosítása sikertelen volt a listában");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítása sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                //Módosítás miatt DataGridView updatelése
                updateDataInDataGriedViewt();
            }
            catch (updateEmployeException uee)
            {
                Debug.WriteLine("A dolgozó módosítás sikertelen volt az adatbázishoz, " + uee.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítás sikertelen volt. Nem lehet két ugyan olyan személyigazolvány szám az adatbázsban.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MedellNotValidEmpIdcardException mie)
            {
                errorProviderIdcard.SetError(metroTextBoxIdCard, mie.Message);
            }
            catch (ModellEmployeNotValidBirthPlacesException mex)
            {
                errorProviderBPlace.SetError(metroTextBoxBPlace, mex.Message);
            }
            catch (ModellEmployeNotValidJobExeption mje)
            {
                errorProviderJob.SetError(metroComboBoxEjobtype, mje.Message);
            }
            catch (ModellEmployeNotValidLocationException mle)
            {
                errorProviderLocation.SetError(metroTextBoxAddress, mle.Message);
            }
            catch (ModellEmployeNotValidNameException mne)
            {
                errorProviderName.SetError(metroTextBoxEname, mne.Message);
            }
            catch (ModellEmployeNotValidSexException mse)
            {
                errorProviderSex.SetError(metroComboBoxESex, mse.Message);
            }
            catch (ModellNotValidEmployeBirthDayDateException mbe)
            {
                errorProviderBirthdayDate.SetError(metroDateTimeEBirth, mbe.Message);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        //********************************************************Átalakítás a hozzáadáshoz**********************************************
        /// <summary>
        /// Beállítja a felhasználó nevét a frissen felvitt dolgozónak
        /// </summary>
        /// <returns>Felhasználónév</returns>
        public string getRegUserName()
        {
            errorProviderName.Clear();
            string name = "";
            string fname = metroTextBoxEname.Text;
            char[] betuk = new char[10];

            if (fname != "")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (fname[i] != ' ')
                    {

                        name += Char.ToLower(fname[i]);
                    }
                }
            }
            else
            {
                throw new ModellEmployeNotValidNameException("Kérem töltse ki 'Neve' mezőt, a megadása kötelező.");
            }

            return name;
        }

        /// <summary>
        /// Beállyítja az alapértelmezett jelszót a frissen regisztrált dolgozónak
        /// </summary>
        /// <returns> Alapértelmezett jelszó</returns>
        public string getRegUserPassword()
        {
            string password = "abc123";
            return password;
        }

        private void metroButtonAddWorker_Click(object sender, EventArgs e)
        {
            
            errorProviderBPlace.Clear();
            errorProviderJob.Clear();
            errorProviderMaidenName.Clear();
            errorProviderName.Clear();
            errorProviderLocation.Clear();
            errorProviderSex.Clear();
            errorProviderBirthdayDate.Clear();
            errorProviderIdcard.Clear();

            try
            {


                int id = repo.getnextEmployeId();
                
                Employe newEmployee = new Employe(
                    id,
                    metroTextBoxEname.Text,
                    metroTextBoxEMaidname.Text,
                    metroComboBoxESex.Text,
                    metroDateTimeEBirth.Text,
                    metroTextBoxBPlace.Text,
                    metroComboBoxEjobtype.Text,
                    metroTextBoxAddress.Text,
                    metroTextBoxIdCard.Text,
                    getRegUserName(),
                    getRegUserPassword()
                   );

                //Hozzáadás az adatbázishoz
                try
                {
                    rep.insertEmployeeToDatabase(newEmployee);
                }
                catch (Exception)
                {
                    throw new insertEmployeException();
                }

                //Hozzáadás a listához
                try
                {
                    repo.addEmployeeToList(newEmployee);
                }
                catch (Exception)
                {

                    Debug.WriteLine("A dolgozó felvétele sikertelen volt a listához");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt a listához.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                //DataGridView frissítése
                updateDataInDataGriedViewt();
                updateEmployeesNumber();
                emptyCells();
            }
            catch (insertEmployeException iee)
            {
                Debug.WriteLine("A dolgozó felvétele sikertelen volt az adatbázishoz, " + iee.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt. Nem lehet két ugyanolyan személy az adatbázisba, akiknek ugyan az a személyigazolvány számuk.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MedellNotValidEmpIdcardException mie)
            {
                errorProviderIdcard.SetError(metroTextBoxIdCard, mie.Message);
            }
            catch (ModellEmployeNotValidBirthPlacesException mex)
            {
                errorProviderBPlace.SetError(metroTextBoxBPlace, mex.Message);
            }
            catch (ModellEmployeNotValidJobExeption mje)
            {
                errorProviderJob.SetError(metroComboBoxEjobtype, mje.Message);
            }
            catch (ModellEmployeNotValidLocationException mle)
            {
                errorProviderLocation.SetError(metroTextBoxAddress, mle.Message);
            }
            catch (ModellEmployeNotValidNameException mne)
            {
                errorProviderName.SetError(metroTextBoxEname, mne.Message);
            }
            catch (ModellEmployeNotValidSexException mse)
            {
                errorProviderSex.SetError(metroComboBoxESex, mse.Message);
            }
            catch (ModellEmployeNotValidMaidenNameException mme)
            {
                errorProviderMaidenName.SetError(metroButtonNone, mme.Message);
            }
            catch (ModellNotValidEmployeBirthDayDateException mbe)
            {
                errorProviderBirthdayDate.SetError(metroDateTimeEBirth, mbe.Message);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void metroButtonTheSame_Click(object sender, EventArgs e)
        {
            metroTextBoxEMaidname.Text = metroTextBoxEname.Text;
        }

        private void metroButtonNone_Click(object sender, EventArgs e)
        {
            metroTextBoxEMaidname.Text = "-";
        }

        public void updateEmployeesNumber()
        {
            metroLabelDB.Text ="Jelenleg dolgozók száma az intézménybe: "+repo.getEmployeesNumber().ToString()+" ember.";
        }

        private void metroGridEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (metroGridEmployees.SelectedRows.Count != 0)
            {
                metroGridEmployees.CurrentRow.Selected = true;
                metroTextBoxEID.Text = metroGridEmployees.SelectedRows[0].Cells[0].Value.ToString();
                metroTextBoxEname.Text = metroGridEmployees.SelectedRows[0].Cells[1].Value.ToString();
                metroTextBoxEMaidname.Text = metroGridEmployees.SelectedRows[0].Cells[2].Value.ToString();
                metroComboBoxESex.Text = metroGridEmployees.SelectedRows[0].Cells[3].Value.ToString();
                metroDateTimeEBirth.Text = metroGridEmployees.SelectedRows[0].Cells[4].Value.ToString();
                metroTextBoxBPlace.Text = metroGridEmployees.SelectedRows[0].Cells[5].Value.ToString();
                metroComboBoxEjobtype.Text = metroGridEmployees.SelectedRows[0].Cells[6].Value.ToString();
                metroTextBoxAddress.Text = metroGridEmployees.SelectedRows[0].Cells[7].Value.ToString();
                metroTextBoxIdCard.Text = metroGridEmployees.SelectedRows[0].Cells[8].Value.ToString();
                metroTextBoxEUserName.Text = metroGridEmployees.SelectedRows[0].Cells[9].Value.ToString();
                metroTextBoxEPassword.Text = metroGridEmployees.SelectedRows[0].Cells[10].Value.ToString();
            }
        }
    }
}
