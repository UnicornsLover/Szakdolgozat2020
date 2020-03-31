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
using Szakdolgozat2020.Modell.Children;
using Szakdolgozat2020.Modell.Soul;
using Szakdolgozat2020.Repository.Children;
using Szakdolgozat2020.Repository.Employes;
using Szakdolgozat2020.Repository.Parents;
using Szakdolgozat2020.Repository.Souls;

namespace Szakdolgozat2020.Forms.Soul
{
    public partial class SoulReg : MetroFramework.Forms.MetroForm
    {
        private DataTable soulsDT = new DataTable();
        RepositorySouls repo = new RepositorySouls();
        DatabaseSoulCommand rep = new DatabaseSoulCommand();
        RepositoryChildren rc = new RepositoryChildren();
        RepositoryDatabaseChildren cd = new RepositoryDatabaseChildren();
        public SoulReg()
        {
            InitializeComponent();
            repo.setSouls(rep.getSoulsFromDatabase());
            rc.setChild(cd.getChildrenFromDatabase());
        }
        /// <summary>
        /// DataGridview frissitése
        /// </summary>
        public void updateDataInDataGriedViewt()
        {
            //Adattáblát feltölti a repoba lévő akták listából
            soulsDT = repo.getSoulsListToDatabase();
            //Akta DataGridView-nak a forrása a children_healths adattábla
            metroGridSoul.DataSource = null;
            metroGridSoul.DataSource = soulsDT;
        }
        public void emptyCells()
        {
            metroTextBoxAId.Text = "";
            metroComboBoxChildrenName.SelectedItem = null;
            metroTextBoxType.Text = "";
            richTextBoxDetails.Text = "";
            richTextBoxST.Text = "";
            metroDateTimeAddedDate.Text = "1990-01-01";
        }

        /// <summary>
        /// Beállít Datagridview oszlopait és egyébb dolgot
        /// </summary>
        public void setSoulDataGridView()
        {
            soulsDT.Columns[0].ColumnName = "Akta azonosító:";
            soulsDT.Columns[1].ColumnName = "Gyermek neve:";
            soulsDT.Columns[2].ColumnName = "Tipusa:";
            soulsDT.Columns[3].ColumnName = "Részletek:";
            soulsDT.Columns[4].ColumnName = "Különleges ellátás:";
            soulsDT.Columns[5].ColumnName = "Felvétel dátuma:";
            soulsDT.Columns[6].ColumnName = "Felvevő neve:";


            metroGridSoul.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            metroGridSoul.ReadOnly = true;
            metroGridSoul.AllowUserToDeleteRows = false;
            metroGridSoul.AllowUserToAddRows = false;
            metroGridSoul.MultiSelect = false;
            metroGridSoul.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void SoulReg_Load(object sender, EventArgs e)
        {
            updateDataInDataGriedViewt();
            setSoulDataGridView();
            emptyCells();
            metroComboBoxChildrenName.DataSource = rc.getChildrenName();

        }

        private void metroButtonClearCells_Click(object sender, EventArgs e)
        {
            emptyCells();
        }

        private void metroButtonSearch_Click(object sender, EventArgs e)
        {
            if (metroComboBoxChildrenName.Text == "")
            {
                MetroMessageBox.Show(this, "Keresés csak a 'Gyermek neve' kiválasztása segítségével lehet!\nHa esetleg minden adatot újra szeretne látni egy szűrés után, csak is kizárólag válassza ki ezt a \" * \" (csillag) jelet a \"Gyermek neve:\" cellábas!", "Hiba\n\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (metroComboBoxChildrenName.Text == "*")
            {
                updateDataInDataGriedViewt();
            }
            else
            {
                string rowFilter = string.Format("[{0}] = '{1}'", "Gyermek neve:", metroComboBoxChildrenName.Text);
                (metroGridSoul.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

                if (metroGridSoul.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Nincs ilyen keressett gyerek a vizsgálatok között (adatbázisban).","Közlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        /// <summary>
        /// Akta törlése
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            //Ha sor nullat ad vissza ne történjen 
            if ((metroGridSoul.Rows) == null || (metroGridSoul.Rows.Count == 0))
            {
                return;
            }

            try
            {
                int selectedIndex = metroGridSoul.SelectedRows[0].Index;

                DialogResult dr = MetroMessageBox.Show(this, "\n\nBiztos szeretné törölni a gyermeket?", "Dolgozó törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //Törlés a listából
                    int id = -1;
                    if (!int.TryParse(metroGridSoul.SelectedRows[0].Cells[0].Value.ToString(), out id))
                    {
                        return;
                    }

                    try
                    {
                        rep.deleteSoulFromDatabase(id);
                        repo.deleteSoulInList(id);
                    }
                    catch (RepositorySoulExceptionCantDelete ex)
                    {

                        Debug.WriteLine("A dolgozó törlése sikertelen volt, mert más adatbázisban is szerepel! Nem lehet törölni.");
                        MetroMessageBox.Show(this, "\n\nA dolgozó törlése sikertelen volt, mert más adatbázisban is szerepel!", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void metroGridSoul_SelectionChanged(object sender, EventArgs e)
        {
            if (metroGridSoul.SelectedRows.Count != 0)
            {
                metroGridSoul.CurrentRow.Selected = true;
                metroTextBoxAId.Text = metroGridSoul.SelectedRows[0].Cells[0].Value.ToString();
                metroComboBoxChildrenName.Text = metroGridSoul.SelectedRows[0].Cells[1].Value.ToString();
                metroTextBoxType.Text = metroGridSoul.SelectedRows[0].Cells[2].Value.ToString();
                richTextBoxDetails.Text = metroGridSoul.SelectedRows[0].Cells[3].Value.ToString();
                richTextBoxST.Text = metroGridSoul.SelectedRows[0].Cells[4].Value.ToString();
                metroDateTimeAddedDate.Text = metroGridSoul.SelectedRows[0].Cells[5].Value.ToString();
                metroTextBoxAddedPerson.Text = metroGridSoul.SelectedRows[0].Cells[6].Value.ToString();
                
            }
        }
        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            errorProviderAdded.Clear();
            errorProviderChildrenName.Clear();
            errorProviderDetils.Clear();
            errorProviderSpecial.Clear();
            errorProviderType.Clear();

            try
            {
                int id = repo.getnextSoulId();

                SoulM newSoul2 = new SoulM(
                    id,
                    metroComboBoxChildrenName.Text,
                    metroTextBoxType.Text,
                    richTextBoxDetails.Text,
                    richTextBoxST.Text,
                    metroDateTimeAddedDate.Text,
                    metroTextBoxAddedPerson.Text
                   );

                SoulM newSoul = new SoulM(
                    id,
                    rc.getChildrenId(metroComboBoxChildrenName.Text),
                    metroTextBoxType.Text,
                    richTextBoxDetails.Text,
                    richTextBoxST.Text,
                    metroDateTimeAddedDate.Text,
                    metroTextBoxAddedPerson.Text
                   );

                

                //Hozzáadás az adatbázishoz
                try
                {
                    rep.insertSoulToDatabase(newSoul);
                }
                catch (Exception)
                {

                    throw new insertSoulException();
                }

                //Hozzáadás a listához
                try
                {
                    repo.addSoulsToList(newSoul2);
                }
                catch (Exception)
                {

                    Debug.WriteLine("Az akta felvétele sikertelen volt a listához");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt a listához.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //DataGridView frissítése
                updateDataInDataGriedViewt();
                emptyCells();
            }
            catch (ModellSoulNotValidChildrenNameException mncn)
            {
                errorProviderChildrenName.SetError(metroComboBoxChildrenName, mncn.Message);
            }
            catch (ModellSoulNotValidDateException mde)
            {
                errorProviderAdded.SetError(metroDateTimeAddedDate, mde.Message);
            }
            catch (ModellSoulNotValidDetailsException mde)
            {
                errorProviderDetils.SetError(richTextBoxDetails, mde.Message);
            }
            catch (ModellSoulNotValidSpecaialTreatmentException mste)
            {
                errorProviderSpecial.SetError(richTextBoxST, mste.Message);
            }
            catch (ModellSoulNotValidTypeException mte)
            {
                errorProviderType.SetError(metroTextBoxType,mte.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        private void metroButtonModify_Click(object sender, EventArgs e)
        {
            try
            {
                SoulM modified = new SoulM(
                    Convert.ToInt32(metroTextBoxAId.Text),
                    rc.getChildrenId(metroComboBoxChildrenName.Text),
                    metroTextBoxType.Text,
                    richTextBoxDetails.Text,
                    richTextBoxST.Text,
                    metroDateTimeAddedDate.Text,
                    metroTextBoxAddedPerson.Text
                   );
                SoulM modified2 = new SoulM(
                    Convert.ToInt32(metroTextBoxAId.Text),
                    metroComboBoxChildrenName.Text,
                    metroTextBoxType.Text,
                    richTextBoxDetails.Text,
                    richTextBoxST.Text,
                    metroDateTimeAddedDate.Text,
                    metroTextBoxAddedPerson.Text
                   );
                int id = Convert.ToInt32(metroTextBoxAId.Text);

                //Módosítás az adatbázisban
                try
                {
                    rep.updateSoulInDatabase(id, modified);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message+"***************************************************************-");
                    throw new updateSoulException();
                }

                //Módosítás a listában
                try
                {
                    repo.updateSoulInList(id, modified2);
                }
                catch (Exception ex)
                {

                    Debug.WriteLine("Az akta módosítása sikertelen volt a listában");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítása sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                //Módosítás miatt DataGridView updatelése
                updateDataInDataGriedViewt();
            }
            catch (ModellSoulNotValidChildrenNameException mncn)
            {
                errorProviderChildrenName.SetError(metroComboBoxChildrenName, mncn.Message);
            }
            catch (ModellSoulNotValidDateException mde)
            {
                errorProviderAdded.SetError(metroDateTimeAddedDate, mde.Message);
            }
            catch (ModellSoulNotValidDetailsException mde)
            {
                errorProviderDetils.SetError(richTextBoxDetails, mde.Message);
            }
            catch (ModellSoulNotValidSpecaialTreatmentException mste)
            {
                errorProviderSpecial.SetError(richTextBoxST, mste.Message);
            }
            catch (ModellSoulNotValidTypeException mte)
            {
                errorProviderType.SetError(metroTextBoxType, mte.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
