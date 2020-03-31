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
using Szakdolgozat2020.Modell.Parents;
using Szakdolgozat2020.Repository.Children;
using Szakdolgozat2020.Repository.Parents;

namespace Szakdolgozat2020.Forms.Administrator
{
    public partial class ParentsReg : MetroFramework.Forms.MetroForm
    {
        private DataTable parentsTD = new DataTable();
        RepositoryParents repo = new RepositoryParents();
        RepositoryDatabaseParents rep = new RepositoryDatabaseParents();
        public ParentsReg()
        {
            InitializeComponent();
            repo.setParents(rep.getParentsFromDatabase());
        }

        private void ParentsReg_Load(object sender, EventArgs e)
        {
            updateDataInDataGriedViewt();
            setParentsDataGridView();
            emptyCells();
            updateParentsNumber();
        }

        /// <summary>
        /// DataGridview frissitése
        /// </summary>
        public void updateDataInDataGriedViewt()
        {
            //Adattáblát feltölti a repoba lévő Szülő listából
            parentsTD = repo.getParentsListToDatabase();
            //Szülő DataGridView-nak a forrása a children_fullprofile adattábla
            metroGridParents.DataSource = null;
            metroGridParents.DataSource = parentsTD;
        }

        public void emptyCells()
        {
            metroTextBoxID.Text = "";
            metroTextBoxName.Text = "";
            metroDateTimeBDate.Text = "1950-01-01";
            metroTextBoxIdCard.Text = "";
            metroComboBoxSex.SelectedItem = null;
            metroTextBoxIdCard.Text = "";
            metroComboBoxLoginPermission.SelectedItem = null;
            metroTextBoxUser.Text = "";
            metroTextBoxPassword.Text = "";
        }
        /// <summary>
        /// Beállít Datagridview oszlopait és egyébb dolgot
        /// </summary>
        public void setParentsDataGridView()
        {
            parentsTD.Columns[0].ColumnName = "Szülő azonosító:";
            parentsTD.Columns[1].ColumnName = "Név:";
            parentsTD.Columns[2].ColumnName = "Neme:";
            parentsTD.Columns[3].ColumnName = "Születési idő:";
            parentsTD.Columns[4].ColumnName = "Személyigazolvány száma:";   
            parentsTD.Columns[5].ColumnName = "Engedély:";
            parentsTD.Columns[6].ColumnName = "Felhasználó név:";
            parentsTD.Columns[7].ColumnName = "Jelszó:";


            metroGridParents.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            metroGridParents.ReadOnly = true;
            metroGridParents.AllowUserToDeleteRows = false;
            metroGridParents.AllowUserToAddRows = false;
            metroGridParents.MultiSelect = false;
            metroGridParents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void updateParentsNumber()
        {
            metroLabelPdb.Text = "Jelenleg gyermekek száma az intézménybe: " + repo.getParentsNumber().ToString() + " .";
        }


        private void metroButtonSearch_Click(object sender, EventArgs e)
        {
            if (metroTextBoxName.Text == "")
            {
                MetroMessageBox.Show(this, "Keresés csak pontos név megadásával lehetséges (pl: Bálint István - nagy betű is fontos), a cella kitötése kötelező! \nTöltse ki a \"Neve:\" cellát!\nHa esetleg minden adatot újra szeretne látni egy szűrés után, csak is kizárólag írja be ezt a \" * \" (csillag) jelet a \"Neve:\" cellábas!", "Hiba\n\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (metroTextBoxName.Text == "*")
            {
                updateDataInDataGriedViewt();
            }
            else
            {
                string rowFilter = string.Format("[{0}] = '{1}'", "Név:", metroTextBoxName.Text);
                (metroGridParents.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

                if (metroGridParents.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Keresés csak pontos név megadásával lehetséges (pl: Bálint István - nagy betű is fontos), a cella kitötése kötelező! \nTöltse ki a \"Neve:\" cellát!\nHa esetleg minden adatot újra szeretne látni egy szűrés után, csak is kizárólag írja be ezt a \" * \" (csillag) jelet a \"Neve:\" cellábas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        
        private void metroButtonClearCells_Click(object sender, EventArgs e)
        {
            emptyCells();
        }
        /// <summary>
        /// szülő törlése
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            //Ha sor nullat ad vissza ne történjen 
            if ((metroGridParents.Rows) == null || (metroGridParents.Rows.Count == 0))
            {
                return;
            }

            try
            {
                int selectedIndex = metroGridParents.SelectedRows[0].Index;

                DialogResult dr = MetroMessageBox.Show(this, "\n\nBiztos szeretné törölni a szülőt?", "Szülő törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //Törlés a listából
                    int id = -1;
                    if (!int.TryParse(metroGridParents.SelectedRows[0].Cells[0].Value.ToString(), out id))
                    {
                        return;
                    }

                    try
                    {
                        rep.deleteParentFromDatabase(id);
                        repo.deleteParentInList(id);
                    }
                    catch (RepositoryParentExceptionCantDelete)
                    {

                        Debug.WriteLine("A szülő törlése sikertelen volt, nem lehet törölni olyan adatot, ami más adatbázisban szerepel.");
                        MetroMessageBox.Show(this, "\n\nA szülő törlése sikertelen volt, nem lehet törölni olyan adatot, ami más adatbázisban szerepel.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //DataGridView frissítése
                    updateDataInDataGriedViewt();
                    updateParentsNumber();
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
        public string getRegUserName(string adat)
        {
            try
            {
                errorProviderName.Clear();
                string name = "";
                string fname = adat;
                char[] betuk = new char[10];

                if (fname != "" && fname.Length >= 5)
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
                    throw new ModellNotValidParentNamee("Kérem töltse ki 'Neve' mezőt, a megadása kötelező.");
                }
                return name;
            }
            catch (ModellNotValidParentNamee mne)
            {

                errorProviderName.SetError(metroTextBoxName, mne.Message);
                return null;
            }
            

            
        }
        public string getPermisiion(string adat)
        {
            adat = "";

            if (metroComboBoxLoginPermission.Text == "")
            {
                throw new MedellNotValidParentLoginPerException();
            }
            else
            {
                if (metroComboBoxLoginPermission.Text == "Engedélyezés")
                {
                    adat = "1";
                }
                else if (metroComboBoxLoginPermission.Text == "Tiltás")
                {
                    adat = "0";
                }
            }
            return
                 adat;
        }
        /// <summary>
        /// Beállyítja az alapértelmezett jelszót a frissen regisztrált dolgozónak
        /// </summary>
        /// <returns> Alapértelmezett jelszó</returns>
        public string getRegUserPassword(string adat)
        {
            adat = "abc123";
            return adat;
        }
        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            errorProviderBday.Clear();
            errorProviderIdCard.Clear();
            errorProviderName.Clear();
            errorProviderPermission.Clear();
            errorProviderSex.Clear();
            try
            {
                int id = repo.getnextParentId();
                

                Parent newParent = new Parent(
                    id,
                    metroTextBoxName.Text,
                    metroComboBoxSex.Text,
                    metroDateTimeBDate.Text,
                    metroTextBoxIdCard.Text,
                    getPermisiion(metroComboBoxLoginPermission.Text),
                    getRegUserName(metroTextBoxName.Text),
                    getRegUserPassword(metroTextBoxPassword.Text)
                   );

                Parent newParent2 = new Parent(
                    id,
                    metroTextBoxName.Text,
                    metroComboBoxSex.Text,
                    metroDateTimeBDate.Text,
                    metroTextBoxIdCard.Text,
                    metroComboBoxLoginPermission.Text,
                    getRegUserName(metroTextBoxName.Text),
                    getRegUserPassword(metroTextBoxPassword.Text)
                   );

                //Hozzáadás az adatbázishoz
                try
                {
                    rep.insertParentToDatabase(newParent);
                }
                catch (Exception)
                {

                    throw new insertParentException();
                }

                //Hozzáadás a listához
                try
                {
                    repo.addParentsToList(newParent2);
                }
                catch (Exception)
                {

                    Debug.WriteLine("A szülő felvétele sikertelen volt a listához");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt a listához.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //DataGridView frissítése
                updateDataInDataGriedViewt();
                updateParentsNumber();
                emptyCells();
            }
            catch (insertParentException ipe)
            {
                Debug.WriteLine("A szülő felvétele sikertelen volt az adatbázishoz, " + ipe.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt. Nem lehet két ugyan olyna személyigazolvány szám.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellNotValidParentNamee npe)
            {
                errorProviderName.SetError(metroTextBoxName, npe.Message);
            }
            catch (MedellNotValidParentLoginPerException nle)
            {
                errorProviderPermission.SetError(metroComboBoxLoginPermission, nle.Message);
            }
            catch (ModellParentNotValidSexException mse)
            {
                errorProviderSex.SetError(metroComboBoxSex, mse.Message);
            }
            catch (MedellNotValidParentIdcardException pie)
            {
                errorProviderIdCard.SetError(metroTextBoxIdCard, pie.Message);
            }
            catch (ModellNotValidParentBirthDayDateException mnb)
            {
                errorProviderBday.SetError(metroDateTimeBDate,mnb.Message);
            }
        }

        private void metroButtonModify_Click(object sender, EventArgs e)
        {
            try
            {
                Parent modified2 = new Parent(
                    Convert.ToInt32(metroTextBoxID.Text),
                    metroTextBoxName.Text,
                    metroComboBoxSex.Text,
                    metroDateTimeBDate.Text,
                    metroTextBoxIdCard.Text,
                    metroComboBoxLoginPermission.Text,
                    getRegUserName(metroTextBoxName.Text),
                    getRegUserPassword(metroTextBoxPassword.Text)
                   );

                Parent modified = new Parent(
                    Convert.ToInt32(metroTextBoxID.Text),
                    metroTextBoxName.Text,
                    metroComboBoxSex.Text,
                    metroDateTimeBDate.Text,
                    metroTextBoxIdCard.Text,
                    getPermisiion(metroComboBoxLoginPermission.Text),
                    getRegUserName(metroTextBoxName.Text),
                    getRegUserPassword(metroTextBoxPassword.Text)
                   );

                

                int id = Convert.ToInt32(metroTextBoxID.Text);

                //Módosítás az adatbázisban
                try
                {
                    rep.updateParentInDatabase(id, modified);
                }
                catch (Exception ex)
                {
                    throw new updateParentException();
                }

                //Módosítás a listában
                try
                {
                    repo.updateParentInList(id, modified2);
                }
                catch (Exception ex)
                {

                    Debug.WriteLine("A szülő módosítása sikertelen volt a listában");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítása sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //Módosítás miatt DataGridView updatelése
                updateDataInDataGriedViewt();
                updateParentsNumber();
            }
            catch (updateParentException upe)
            {
                Debug.WriteLine("A szülő módositása sikertelen volt az adatbázishoz, " + upe.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítása sikertelen volt. Nem lehet két ugyan olyna személyigazolvány szám.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellNotValidParentName npe)
            {
                errorProviderName.SetError(metroTextBoxName, npe.Message);
            }
            catch (MedellNotValidParentLoginPerException nle)
            {
                errorProviderPermission.SetError(metroComboBoxLoginPermission, nle.Message);
            }
            catch (ModellParentNotValidSexException mse)
            {
                errorProviderSex.SetError(metroComboBoxSex, mse.Message);
            }
            catch (MedellNotValidParentIdcardException pie)
            {
                errorProviderIdCard.SetError(metroTextBoxName, pie.Message);
            }
            catch (ModellNotValidParentBirthDayDateException mnd)
            {
                errorProviderSex.SetError(metroDateTimeBDate, mnd.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void metroGridParents_SelectionChanged(object sender, EventArgs e)
        {
            if(metroGridParents.SelectedRows.Count != 0)
            {
                metroGridParents.CurrentRow.Selected = true;
                metroTextBoxID.Text = metroGridParents.SelectedRows[0].Cells[0].Value.ToString();
                metroTextBoxName.Text = metroGridParents.SelectedRows[0].Cells[1].Value.ToString();
                metroComboBoxSex.Text = metroGridParents.SelectedRows[0].Cells[2].Value.ToString();
                metroDateTimeBDate.Text = metroGridParents.SelectedRows[0].Cells[3].Value.ToString();
                metroTextBoxIdCard.Text = metroGridParents.SelectedRows[0].Cells[4].Value.ToString();
                metroComboBoxLoginPermission.Text = metroGridParents.SelectedRows[0].Cells[5].Value.ToString();
                metroTextBoxUser.Text = metroGridParents.SelectedRows[0].Cells[6].Value.ToString();
                metroTextBoxPassword.Text = metroGridParents.SelectedRows[0].Cells[7].Value.ToString();
            }
        }
    }
}
