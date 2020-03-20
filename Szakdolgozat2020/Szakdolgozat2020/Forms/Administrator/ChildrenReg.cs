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
using Szakdolgozat2020.Repository.Children;

namespace Szakdolgozat2020.Forms.Nevelo
{
    public partial class ChildrenReg : MetroFramework.Forms.MetroForm
    {
        private DataTable childrenDT = new DataTable();
        RepositoryChildren repo = new RepositoryChildren();
        RepositoryDatabaseChildren rep = new RepositoryDatabaseChildren();
        public ChildrenReg()
        {
            InitializeComponent();
            repo.setChild(rep.getChildrenFromDatabase());
        }

        /// <summary>
        /// DataGridview frissitése
        /// </summary>
        public void updateDataInDataGriedViewt()
        {
            //Adattáblát feltölti a repoba lévő gyermek listából
            childrenDT = repo.getChildrenListToDatabse();
            //Gyermek DataGridView-nak a forrása a children_fullprofile adattábla
            metroGridChildren.DataSource = null;
            metroGridChildren.DataSource = childrenDT;
        }
        public void emptyCells()
        {
            metroTextBoxID.Text = "";
            metroTextBoxName.Text = "";
            metroComboBoxSex.SelectedItem = null;
            metroTextBoxIdCard.Text = "";
            metroTextBoxTaj.Text = "";
            metroDateTimeBDate.Text = "1990-01-01";
            metroTextBoxBPlace.Text = "";
            metroDateTimeComing.Text = "1990-01-01";
            metroTextBoxLocation.Text = "";
        }

        /// <summary>
        /// Beállít Datagridview oszlopait és egyébb dolgot
        /// </summary>
        public void setChildrenDataGridView()
        {
            childrenDT.Columns[0].ColumnName = "Gyermek azonosító:";
            childrenDT.Columns[1].ColumnName = "Név:";
            childrenDT.Columns[2].ColumnName = "Neme:";
            childrenDT.Columns[3].ColumnName = "Személyigazolvány száma:";
            childrenDT.Columns[4].ColumnName = "TAJ száma:";
            childrenDT.Columns[5].ColumnName = "Születési idő:";
            childrenDT.Columns[6].ColumnName = "Születési hely:";
            childrenDT.Columns[7].ColumnName = "Belépés ideje:";
            childrenDT.Columns[8].ColumnName = "Tartózkódás (int.):";


            metroGridChildren.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            metroGridChildren.ReadOnly = true;
            metroGridChildren.AllowUserToDeleteRows = false;
            metroGridChildren.AllowUserToAddRows = false;
            metroGridChildren.MultiSelect = false;
            metroGridChildren.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        public void updateCildrenNumber()
        {
            metroLabelDb.Text = "Jelenleg gyermekek száma az intézménybe: " + repo.getChildrenNumber().ToString() + " .";
        }

        /// <summary>
        /// Form elinduláskor való meghívás
        /// </summary>
        private void ChildrenReg_Load(object sender, EventArgs e)
        {
            updateDataInDataGriedViewt();
            setChildrenDataGridView();
            metroDateTimeBDate.Text = "1990-01-01";
            metroDateTimeComing.Text = "1990-01-01";
            updateCildrenNumber();
        }

        /// <summary>
        /// Datgridview-ba való kereseés a 'Neve:' cella segítségével
        /// </summary>
        private void metroButtonSearch_Click(object sender, EventArgs e)
        {
            if (metroTextBoxName.Text == "")
            {
                MetroMessageBox.Show(this, "Keresés csak pontos név megadásával lehetséges (pl: Bálint István - nagy betű is fontos), a cella kitötése kötelező! \nTöltse ki a \"Neve:\" cellát!\nHa esetleg minden adatot újra szeretne látni egy szűrés után, csak is kizárólag írja be ezt a \" * \" (csillag) jelet a \"Dolgozó neve:\" cellábas!", "Hiba\n\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (metroTextBoxName.Text == "*")
            {
                updateDataInDataGriedViewt();
            }
            else
            {
                string rowFilter = string.Format("[{0}] = '{1}'", "Név:", metroTextBoxName.Text);
                (metroGridChildren.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

                if (metroGridChildren.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Keresés csak pontos név megadásával lehetséges (pl: Bálint István - nagy betű is fontos), a cella kitötése kötelező! \nTöltse ki a \"Neve:\" cellát!\nHa esetleg minden adatot újra szeretne látni egy szűrés után, csak is kizárólag írja be ezt a \" * \" (csillag) jelet a \"Neve:\" cellábas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Cellák ürítése
        /// </summary>
        private void metroButtonClearCells_Click(object sender, EventArgs e)
        {
            emptyCells();
        }

        /// <summary>
        /// Gyerek törlése
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            //Ha sor nullat ad vissza ne történjen 
            if ((metroGridChildren.Rows) == null || (metroGridChildren.Rows.Count == 0))
            {
                return;
            }
            int selectedIndex = metroGridChildren.SelectedRows[0].Index;

            DialogResult dr = MetroMessageBox.Show(this, "\n\nBiztos szeretné törölni a gyermeket?", "Dolgozó törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //Törlés a listából
                int id = -1;
                if (!int.TryParse(metroGridChildren.SelectedRows[0].Cells[0].Value.ToString(), out id))
                {
                    return;
                }

                try
                {
                    repo.deleteChildInList(id);
                }
                catch (RepositoryChildExceptionCantDelete ex)
                {

                    Debug.WriteLine("A dolgozó törlése sikertelen volt a listából!");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a törlés sikertelen volt az listából.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //Törlés az adatbázisból
                try
                {
                    rep.deleteChildFromDatabase(id);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("A gyermek törlése sikertelen volt az adatbázisból");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a törlés sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //DataGridView frissítése
                updateDataInDataGriedViewt();
                updateCildrenNumber();
            }
            else
            {
                Debug.WriteLine("'DialogResult.No'-ra futott rá!");
            }
        }

        /// <summary>
        /// Gyerek hozzáadása
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            errorProviderName.Clear();
            errorProviderSex.Clear();
            errorProviderTaj.Clear();
            errorProviderIdCard.Clear();
            errorProviderBdate.Clear();
            errorProviderBPlace.Clear();
            errorProviderComing.Clear();
            errorProviderLocation.Clear();
            try
            {
                int id = repo.getnextChildId();
                string sex = "";

                if (metroComboBoxSex.Text == "")
                {
                    throw new ModellChildNotValidSexException();
                }
                else
                {
                    if (metroComboBoxSex.Text == "férfi")
                    {
                        sex = "False";
                    }
                    else if (metroComboBoxSex.Text == "nő")
                    {
                        sex = "True";
                    }
                }

                Child newEmployee = new Child(
                    id,
                    metroTextBoxName.Text,
                    sex,
                    metroTextBoxIdCard.Text,
                    metroTextBoxTaj.Text,
                    metroDateTimeBDate.Text,
                    metroTextBoxBPlace.Text,
                    metroDateTimeComing.Text,
                    metroTextBoxLocation.Text
                   );

                //Hozzáadás az adatbázishoz
                try
                {
                    rep.insertChildrenToDatabase(newEmployee);
                }
                catch (Exception)
                {
                    
                    throw new insertChildException();
                }

                //Hozzáadás a listához
                try
                {
                    repo.addChildToList(newEmployee);
                }
                catch (Exception)
                {

                    Debug.WriteLine("A dolgozó felvétele sikertelen volt a listához");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt a listához.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //DataGridView frissítése
                updateDataInDataGriedViewt();
                updateCildrenNumber();
                emptyCells();
            }
            catch (insertChildException ice)
            {
                Debug.WriteLine("A dolgozó felvétele sikertelen volt az adatbázishoz, " + ice.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt. Nem lehet ugyan olyna személyigazolvány szám és taj szám, mint ami már van a DataGridView-ba és az adatbázisba.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellChildNotValidNameException mne)
            {
                errorProviderName.SetError(metroTextBoxName, mne.Message);
            }
            catch (ModellChildNotValidSexException mse)
            {
                errorProviderSex.SetError(metroComboBoxSex, mse.Message);
            }
            catch (MedellNotValidChiIdcardException mie)
            {
                errorProviderIdCard.SetError(metroTextBoxIdCard, mie.Message);
            }
            catch (ModellChildNotValidTajnumberException mte)
            {
                errorProviderTaj.SetError(metroTextBoxTaj, mte.Message);
            }
            catch (ModellChildNotValidBirthdayException mbe)
            {
                errorProviderBdate.SetError(metroDateTimeBDate, mbe.Message);
            }
            catch (ModellChildNotValidBirthplaceException mbpe)
            {
                errorProviderBPlace.SetError(metroTextBoxBPlace, mbpe.Message);
            }
            catch (ModellChildNotValidComingException mle)
            {
                errorProviderComing.SetError(metroDateTimeComing, mle.Message);
            }
            catch (ModellChildNotValidLocationException mle)
            {
                errorProviderLocation.SetError(metroTextBoxLocation, mle.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void metroButtonModify_Click(object sender, EventArgs e)
        {
            errorProviderName.Clear();
            errorProviderSex.Clear();
            errorProviderTaj.Clear();
            errorProviderIdCard.Clear();
            errorProviderBdate.Clear();
            errorProviderBPlace.Clear();
            errorProviderComing.Clear();
            errorProviderLocation.Clear();
            try
            {
                Child modified = new Child(
                Convert.ToInt32(metroTextBoxID.Text),
                metroTextBoxName.Text,
                metroComboBoxSex.Text,
                metroTextBoxIdCard.Text,
                metroTextBoxTaj.Text,
                metroDateTimeBDate.Text,
                metroTextBoxBPlace.Text,
                metroDateTimeComing.Text,
                metroTextBoxLocation.Text
                );
                int id = Convert.ToInt32(metroTextBoxID.Text);

                //Módosítás az adatbázisban
                try
                {
                    rep.updateChildrenInDatabase(id, modified);
                }
                catch (Exception ex)
                {
                    throw new updateChildException();
                }

                //Módosítás a listában
                try
                {
                    repo.updateChildInList(id, modified);
                }
                catch (Exception ex)
                {

                    Debug.WriteLine("A gyermek módosítása sikertelen volt a listában");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítása sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                //Módosítás miatt DataGridView updatelése
                updateDataInDataGriedViewt();
            }
            catch (updateChildException uce)
            {
                Debug.WriteLine("A dolgozó módosítás sikertelen volt az adatbázishoz, " + uce.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítás sikertelen volt. Nem lehet ugyan olyna személyigazolvány szám és taj szám, mint ami már van a DataGridView-ba és az adatbázisba.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellChildNotValidNameException mne)
            {
                errorProviderName.SetError(metroTextBoxName, mne.Message);
            }
            catch (ModellChildNotValidSexException mse)
            {
                errorProviderSex.SetError(metroComboBoxSex, mse.Message);
            }
            catch (MedellNotValidChiIdcardException mie)
            {
                errorProviderIdCard.SetError(metroTextBoxIdCard, mie.Message);
            }
            catch (ModellChildNotValidTajnumberException mte)
            {
                errorProviderTaj.SetError(metroTextBoxTaj, mte.Message);
            }
            catch (ModellChildNotValidBirthdayException mbe)
            {
                errorProviderBdate.SetError(metroDateTimeBDate, mbe.Message);
            }
            catch (ModellChildNotValidBirthplaceException mbpe)
            {
                errorProviderBPlace.SetError(metroTextBoxBPlace, mbpe.Message);
            }
            catch (ModellChildNotValidComingException mle)
            {
                errorProviderComing.SetError(metroDateTimeComing, mle.Message);
            }
            catch (ModellChildNotValidLocationException mle)
            {
                errorProviderLocation.SetError(metroTextBoxLocation, mle.Message);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroGridChildren_SelectionChanged(object sender, EventArgs e)
        {
            if (metroGridChildren.SelectedRows.Count != 0)
            {
                metroGridChildren.CurrentRow.Selected = true;
                metroTextBoxID.Text = metroGridChildren.SelectedRows[0].Cells[0].Value.ToString();
                metroTextBoxName.Text = metroGridChildren.SelectedRows[0].Cells[1].Value.ToString();
                metroComboBoxSex.Text = metroGridChildren.SelectedRows[0].Cells[2].Value.ToString();
                metroTextBoxIdCard.Text = metroGridChildren.SelectedRows[0].Cells[3].Value.ToString();
                metroTextBoxTaj.Text = metroGridChildren.SelectedRows[0].Cells[4].Value.ToString();
                metroDateTimeBDate.Text = metroGridChildren.SelectedRows[0].Cells[5].Value.ToString();
                metroTextBoxBPlace.Text = metroGridChildren.SelectedRows[0].Cells[6].Value.ToString();
                metroDateTimeComing.Text = metroGridChildren.SelectedRows[0].Cells[7].Value.ToString();
                metroTextBoxLocation.Text = metroGridChildren.SelectedRows[0].Cells[8].Value.ToString();
            }
        }
    }
}
