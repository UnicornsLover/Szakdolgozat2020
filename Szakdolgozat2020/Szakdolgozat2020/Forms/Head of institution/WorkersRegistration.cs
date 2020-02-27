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
        bool newDataInsert = false;
        public WorkersRegistration()
        {
            InitializeComponent();
            repo.setEmploye(rep.getEmployeesFromDatabase());
        }

        private void updateDataInDataGriedViewt()
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
                MetroMessageBox.Show(this, "Keresés csak pontos név megadásával lehetséges, a cella kitötése kötelező! \nTöltse ki a \"Dolgozó neve:\" cellát!\nHa esetleg minden adatot újra szeretne látni egy szűrés után, csak is kizárólag írja be ezt a \" * \" (csillag) jelet a \"Dolgozó neve:\" cellábas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (metroTextBoxEname.Text == "*")
            {
                updateDataInDataGriedViewt();
            }
            else
            {

                string rowFilter = string.Format("[{0}] = '{1}'", "Név:", metroTextBoxEname.Text);
                (metroGridEmployes.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
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

            DialogResult dr = MetroMessageBox.Show(this, "\n\nBiztos szeretné törölni a dolgozót?", "Dolgozó törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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

        /// <summary>
        /// Dolgozó hozzáadása adatbázidhoz, listához, DatagridView frissítése
        /// </summary>
        private void metroButtonAddWorker_Click(object sender, EventArgs e)
        {
            //Felhasználó név készítés
            string fname = metroTextBoxEUserName.Text;
            string[] words = fname.Split(' ');
            string onewordfname = "";
            foreach (string word in words)
            {
                onewordfname += word;
            }

            int id = repo.getnextEmployesId();

            Employe newEmployee = new Employe(
                id,
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
        
    }
}
