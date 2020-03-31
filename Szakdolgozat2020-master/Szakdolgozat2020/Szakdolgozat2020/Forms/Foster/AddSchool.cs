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
using Szakdolgozat2020.Modell.School;
using Szakdolgozat2020.Repository.Schools;

namespace Szakdolgozat2020.Forms.Foster
{
    public partial class AddSchool : MetroFramework.Forms.MetroForm
    {
        private DataTable schoolTD = new DataTable();
        RepositorySchools repo = new RepositorySchools();
        DatabaseCommand rep = new DatabaseCommand();
        public AddSchool()
        {
            InitializeComponent();
            repo.setSchools(rep.getSchoolsFromDatabase());
        }

        private void AddSchool_Load(object sender, EventArgs e)
        {
            updateDataInDataGriedViewt();
            setSchoolsDataGridView();
            emptyCells();
        }

        /// <summary>
        /// DataGridview frissitése
        /// </summary>
        public void updateDataInDataGriedViewt()
        {
            //Adattáblát feltölti a repoba lévő iskola listából
            schoolTD = repo.getSchoolsListToDatabase();
            //Iskol DataGridView-nak a forrása a school adattábla
            metroGridSchoolBasic.DataSource = null;
            metroGridSchoolBasic.DataSource = schoolTD;
        }

        public void emptyCells()
        {
            metroTextBoxSID.Text = "";
            metroTextBoxName.Text = "";
            metroTextBoxLocation.Text = "";
            metroTextBoxPhone.Text = "";
        }

        /// <summary>
        /// Beállít Datagridview oszlopait és egyébb dolgot
        /// </summary>
        public void setSchoolsDataGridView()
        {
            schoolTD.Columns[0].ColumnName = "Iskola azonosító:";
            schoolTD.Columns[1].ColumnName = "Név:";
            schoolTD.Columns[2].ColumnName = "Elheyezkedés:";
            schoolTD.Columns[3].ColumnName = "Vezetékes telefonszám:";

            metroGridSchoolBasic.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            metroGridSchoolBasic.ReadOnly = true;
            metroGridSchoolBasic.AllowUserToDeleteRows = false;
            metroGridSchoolBasic.AllowUserToAddRows = false;
            metroGridSchoolBasic.MultiSelect = false;
            metroGridSchoolBasic.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void metroButtonSearch_Click(object sender, EventArgs e)
        {
            if (metroTextBoxName.Text == "")
            {
                MetroMessageBox.Show(this, "Keresés csak pontos név megadásával lehetséges (pl: Kecskeméti Református Gimnázium - nagy betű is fontos), a cella kitötése kötelező! \nTöltse ki a \"Neve:\" cellát!\nHa esetleg minden adatot újra szeretne látni egy szűrés után, csak is kizárólag írja be ezt a \" * \" (csillag) jelet a \"Neve:\" cellábas!", "Hiba\n\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (metroTextBoxName.Text == "*")
            {
                updateDataInDataGriedViewt();
            }
            else
            {
                string rowFilter = string.Format("[{0}] = '{1}'", "Név:", metroTextBoxName.Text);
                (metroGridSchoolBasic.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

                if (metroGridSchoolBasic.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Keresés csak pontos név megadásával lehetséges (pl: Kecskeméti Református Gimnázium - nagy betű is fontos), a cella kitötése kötelező! \nTöltse ki a \"Neve:\" cellát!\nHa esetleg minden adatot újra szeretne látni egy szűrés után, csak is kizárólag írja be ezt a \" * \" (csillag) jelet a \"Neve:\" cellábas!", "Hiba\n\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void metroButtonCleanCells_Click(object sender, EventArgs e)
        {
            emptyCells();
        }
        /// <summary>
        /// Iskola törlése
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            //Ha sor nullat ad vissza ne történjen 
            if ((metroGridSchoolBasic.Rows) == null || (metroGridSchoolBasic.Rows.Count == 0))
            {
                return;
            }

            try
            {
                int selectedIndex = metroGridSchoolBasic.SelectedRows[0].Index;

                DialogResult dr = MetroMessageBox.Show(this, "\n\nBiztos szeretné törölni az iskolát?", "Iskola törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //Törlés a listából
                    //Törlés az adatbázisból
                    int id = -1;
                    if (!int.TryParse(metroGridSchoolBasic.SelectedRows[0].Cells[0].Value.ToString(), out id))
                    {
                        return;
                    }

                    try
                    {
                        rep.deleteSchoolFromDatabase(id);
                        repo.deleteSchoolInList(id);
                    }
                    catch (RepositorySchoolExceptionCantDelete)
                    {

                        Debug.WriteLine("Az iskola törlése sikertelen volt a listából, mert másik adatbázisba szerepel!");
                        MetroMessageBox.Show(this, "\n\nHibát észleltünk, a törlés sikertelen volt az listából.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //DataGridView frissítése
                    updateDataInDataGriedViewt();
                }
                else
                {
                    Debug.WriteLine("'DialogResult.No'-ra futott rá!");
                }
            }
            catch (ArgumentOutOfRangeException ae)
            {

                Debug.WriteLine("A törlés sikertelen volt!" + ae.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a törlés sikertelen volt. Kattintson a táblázatba arra a sora amit törölni kiván!", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void metroGridSchoolBasic_SelectionChanged(object sender, EventArgs e)
        {
            if (metroGridSchoolBasic.SelectedRows.Count != 0)
            {
                metroGridSchoolBasic.CurrentRow.Selected = true;
                metroTextBoxSID.Text = metroGridSchoolBasic.SelectedRows[0].Cells[0].Value.ToString();
                metroTextBoxName.Text = metroGridSchoolBasic.SelectedRows[0].Cells[1].Value.ToString();
                metroTextBoxLocation.Text = metroGridSchoolBasic.SelectedRows[0].Cells[2].Value.ToString();
                metroTextBoxPhone.Text = metroGridSchoolBasic.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        /// <summary>
        /// Iskola módosítása adatbázisban, listában, DatagridView frissítése
        /// </summary>
        private void metroButtonModify_Click(object sender, EventArgs e)
        {
            errorProviderName.Clear();
            errorProviderLocation.Clear();
            errorProviderPhone.Clear();

            try
            {
                School modified = new School(
                Convert.ToInt32(metroTextBoxSID.Text),
                metroTextBoxName.Text,
                metroTextBoxLocation.Text,
                metroTextBoxPhone.Text
                );
                int id = Convert.ToInt32(metroTextBoxSID.Text);

                //Módosítás az adatbázisban
                try
                {
                    rep.updateSchoolInDatabase(id, modified);
                }
                catch (Exception ex)
                {
                    throw new updateSchoolException();
                }


                //Módosítás a listában
                try
                {
                    repo.updateSchoolInList(id, modified);
                }
                catch (Exception ex)
                {

                    Debug.WriteLine("Az iskola módosítása sikertelen volt a listában");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítása sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                //Módosítás miatt DataGridView updatelése
                updateDataInDataGriedViewt();
            }
            catch (updateSchoolException uee)
            {
                Debug.WriteLine("Az intézmény módosítás sikertelen volt az adatbázishoz, " + uee.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítás sikertelen volt. Nem lehet két ugyan olyan nevű intézmény.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellNotValidSchoolNameException mne)
            {
                errorProviderName.SetError(metroTextBoxName, mne.Message);
            }
            catch (ModellNotValidSchoolLocationException msl)
            {
                errorProviderLocation.SetError(metroTextBoxLocation, msl.Message);
            }
            catch (ModellNotValidSchoolphoneException mpe)
            {
                errorProviderPhone.SetError(metroTextBoxPhone, mpe.Message);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Iskola intézmény hozzáadása
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButtonAddSchool_Click(object sender, EventArgs e)
        {
            errorProviderName.Clear();
            errorProviderLocation.Clear();
            errorProviderPhone.Clear();

            try
            {


                int id = repo.getnextSchoolId();

                School newSchool = new School(
                    id,
                    metroTextBoxName.Text,
                    metroTextBoxLocation.Text,
                    metroTextBoxPhone.Text
                   );

                //Hozzáadás az adatbázishoz
                try
                {
                    rep.insertSchoolToDatabase(newSchool);
                }
                catch (Exception)
                {
                    throw new insertSchoolException();
                }

                //Hozzáadás a listához
                try
                {
                    repo.addSchoolToList(newSchool);
                }
                catch (Exception)
                {

                    Debug.WriteLine("Az intézmény felvétele sikertelen volt a listához");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt a listához.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                //DataGridView frissítése
                updateDataInDataGriedViewt();
                emptyCells();
            }
            catch (insertSchoolException ise)
            {
                Debug.WriteLine("Az intézmény felvétele sikertelen volt az adatbázishoz, " + ise.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt. Nem lehet két ugyanolyan nevű intézmény az adatbázisba.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellNotValidSchoolNameException mne)
            {
                errorProviderName.SetError(metroTextBoxName, mne.Message);
            }
            catch (ModellNotValidSchoolLocationException msl)
            {
                errorProviderLocation.SetError(metroTextBoxLocation, msl.Message);
            }
            catch (ModellNotValidSchoolphoneException mpe)
            {
                errorProviderPhone.SetError(metroTextBoxPhone, mpe.Message);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroGridSchoolBasic_SelectionChanged_1(object sender, EventArgs e)
        {
            if (metroGridSchoolBasic.SelectedRows.Count != 0)
            {
                metroGridSchoolBasic.CurrentRow.Selected = true;
                metroTextBoxSID.Text = metroGridSchoolBasic.SelectedRows[0].Cells[0].Value.ToString();
                metroTextBoxName.Text = metroGridSchoolBasic.SelectedRows[0].Cells[1].Value.ToString();
                metroTextBoxLocation.Text = metroGridSchoolBasic.SelectedRows[0].Cells[2].Value.ToString();
                metroTextBoxPhone.Text = metroGridSchoolBasic.SelectedRows[0].Cells[3].Value.ToString();
                
            }
        }
    }
}
