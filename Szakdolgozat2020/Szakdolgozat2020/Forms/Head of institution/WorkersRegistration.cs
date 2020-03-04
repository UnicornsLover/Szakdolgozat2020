﻿using MetroFramework;
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
        bool newDataInsert = false;
        public WorkersRegistration()
        {
            InitializeComponent();
            repo.setEmploye(rep.getEmployeesFromDatabase());
        }

        public void updateDataInDataGriedViewt()
        {
            //Adattáblát feltölti a repoba lévő dolgozók listából
            employesDT = repo.getEmployesListToDataTable();
            //Dlgozók DataGridView-nak a forrása a employes_login adattábla
            metroGridEmployes.DataSource = null;
            metroGridEmployes.DataSource = employesDT;
            
        }

        public void setEmployeDataGridView()
        {
            employesDT.Columns[0].ColumnName = "Dolgozó azonosító:";
            employesDT.Columns[1].ColumnName = "Név:";
            employesDT.Columns[2].ColumnName = "Lánykori neve:";
            employesDT.Columns[3].ColumnName = "Neme:";
            employesDT.Columns[4].ColumnName = "Születési idő:";
            employesDT.Columns[5].ColumnName = "Szöletési hely:";
            employesDT.Columns[6].ColumnName = "Betöltött munkakör:";
            employesDT.Columns[7].ColumnName = "Lakcím:";
            employesDT.Columns[8].ColumnName = "Felhasználó név:";
            employesDT.Columns[9].ColumnName = "Jelszó:";


            metroGridEmployes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            metroGridEmployes.ReadOnly = true;
            metroGridEmployes.AllowUserToDeleteRows = false;
            metroGridEmployes.AllowUserToAddRows = false;
            metroGridEmployes.MultiSelect = false;
            metroGridEmployes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void WorkersRegistration_Load(object sender, EventArgs e)
        {
            updateDataInDataGriedViewt();
            setEmployeDataGridView();
        }

        private void metroGridEmployes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGridEmployes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                metroGridEmployes.CurrentRow.Selected = true;
                metroTextBoxEID.Text = metroGridEmployes.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                metroTextBoxEname.Text = metroGridEmployes.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                metroTextBoxEMaidname.Text = metroGridEmployes.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                metroComboBoxESex.Text = metroGridEmployes.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                metroDateTimeEBirth.Text = metroGridEmployes.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                metroTextBoxBPlace.Text = metroGridEmployes.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                metroComboBoxEjobtype.Text = metroGridEmployes.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                metroTextBoxAddress.Text = metroGridEmployes.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                metroTextBoxEUserName.Text = metroGridEmployes.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                metroTextBoxEPassword.Text = metroGridEmployes.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            }
        }

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
                (metroGridEmployes.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

                if (metroGridEmployes.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Keresés csak pontos név megadásával lehetséges (pl: Bálint István - nagy betű is fontos), a cella kitötése kötelező! \nTöltse ki a \"Dolgozó neve:\" cellát!\nHa esetleg minden adatot újra szeretne látni egy szűrés után, csak is kizárólag írja be ezt a \" * \" (csillag) jelet a \"Dolgozó neve:\" cellábas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void metroButtonCleanCells_Click(object sender, EventArgs e)
        {
            metroTextBoxEID.Text = "";
            metroTextBoxEname.Text = "";
            metroTextBoxEMaidname.Text = "";
            metroComboBoxESex.Text = "";
            metroDateTimeEBirth.Text = "";
            metroTextBoxBPlace.Text = "";
            metroComboBoxEjobtype.Text = "";
            metroTextBoxAddress.Text = "";
            metroTextBoxEUserName.Text = "";
            metroTextBoxEPassword.Text = "";
        }

        /// <summary>
        /// Dolgozó törlése adatbázidból, listából, DatagridView frissítése
        /// </summary>
        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            //Ha sor nullat ad vissza ne történjen 
            if ((metroGridEmployes.Rows) == null || (metroGridEmployes.Rows.Count == 0))
            {
                return;
            }
            int selectedIndex = metroGridEmployes.SelectedRows[0].Index;

            DialogResult dr = MetroMessageBox.Show(this, "\n\nBiztos szeretné törölni a dolgozót?", "Dolgozó törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Törlés a listából
                int id = -1;
                if (!int.TryParse(metroGridEmployes.SelectedRows[0].Cells[0].Value.ToString(), out id))
                {
                    return;
                }

                try
                {
                    repo.deleteEmployeInList(id);
                }
                catch (RepositoryExceptionCantDelete ex)
                {

                    Debug.WriteLine("A dolgozó törlése sikertelen volt a listából!");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a törlés sikertelen volt az listából.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //Törlés az adatbázisból
                try
                {
                    rep.deleteEmployeeFromDatabase(id);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("A dolgozó törlése sikertelen volt az adatbázisból");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a törlés sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //DataGridView frissítése
                updateDataInDataGriedViewt();

            }
            else
            {
                Debug.WriteLine("DialogResult.No-ra futott rá!");
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
                metroTextBoxEUserName.Text,
                metroTextBoxEPassword.Text
                );
                int id = Convert.ToInt32(metroTextBoxEID.Text);

                //Módosítás a listában
                try
                {
                    repo.updateEmployeeInList(id, modified);
                }
                catch (Exception ex)
                {

                    Debug.WriteLine("A dolgozó módosítása sikertelen volt a listában");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítása sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //Módosítás az adatbázisban
                try
                {
                    rep.updateEmployeeInDatabase(id, modified);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("A dolgozó módosítása sikertelen volt az adatbázisba");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítás sikertelen volt az adatbázisba.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //Módosítás miatt DataGridView updatelése
                updateDataInDataGriedViewt();
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

        public string insertEsex(string esex)
        {
            if (esex != "")
            {
                if (esex == "férfi")
                {
                    esex = "False";
                }
                else if (esex == "nő")
                {
                    esex = "True";
                }
                else
                {
                    esex = "nincs adat";
                }
            }
            else
            {
                throw new ModellEmployeNotValidSexException("Töltse ki 'Neme' mezőt, a megadása kötelező.");
            }

            return esex;
        }
        private void metroButtonAddWorker_Click(object sender, EventArgs e)
        {
            errorProviderBPlace.Clear();
            errorProviderJob.Clear();
            errorProviderMaidenName.Clear();
            errorProviderName.Clear();
            errorProviderLocation.Clear();
            try
            {
                int id = repo.getnextEmployesId();
                Employe newEmployee = new Employe(
                    id,
                    metroTextBoxEname.Text,
                    metroTextBoxEMaidname.Text,
                    insertEsex(metroComboBoxESex.Text),
                    metroDateTimeEBirth.Text,
                    metroTextBoxBPlace.Text,
                    metroComboBoxEjobtype.Text,
                    metroTextBoxAddress.Text,
                    getRegUserName(),
                    getRegUserPassword()
                    );

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

                //Hozzáadás az adatbázishoz
                try
                {
                    rep.insertEmployeeToDatabase(newEmployee);
                }
                catch (Exception)
                {
                    Debug.WriteLine("A dolgozó felvétele sikertelen volt az adatbázishoz");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt az adatbázishoz.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //DataGridView frissítése
                updateDataInDataGriedViewt();
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
            
        }

        private void metroDateTimeEBirth_ValueChanged(object sender, EventArgs e)
        {
            metroDateTimeEBirth.MaxDate = DateTime.Now;
        }

        private void metroButtonTheSame_Click(object sender, EventArgs e)
        {
            metroTextBoxEMaidname.Text = metroTextBoxEname.Text;
        }

        private void metroButtonNone_Click(object sender, EventArgs e)
        {
            metroTextBoxEMaidname.Text = "-";
        }
    }
}
