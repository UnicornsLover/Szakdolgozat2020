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
using Szakdolgozat2020.Modell.SchoolChildren;
using Szakdolgozat2020.Repository.Children;
using Szakdolgozat2020.Repository.ChildrenViews;
using Szakdolgozat2020.Repository.Schools;

namespace Szakdolgozat2020.Forms.Foster
{
    public partial class Schools : MetroFramework.Forms.MetroForm
    {
        private DataTable childrenViewDT = new DataTable();
        ChildrenViews repo = new ChildrenViews(); //repository
        RepositoryChildrenViewDatabaseCommand rep = new RepositoryChildrenViewDatabaseCommand();
        RepositoryChildren rc = new RepositoryChildren();
        RepositoryDatabaseChildren rdc = new RepositoryDatabaseChildren();
        RepositorySchools rs = new RepositorySchools();
        DatabaseCommand sd = new DatabaseCommand();
        public Schools()
        {
            InitializeComponent();
            repo.setChildrenViews(rep.getChildrenviewFromDatabase());
            rc.setChild(rdc.getChildrenFromDatabase());
            rs.setSchools(sd.getSchoolsFromDatabase());
        }

        /// <summary>
        /// DataGridview frissitése
        /// </summary>
        public void updateDataInDataGriedViewt()
        {
            //Adattáblát feltölti a repoba lévő gyermek listából
            childrenViewDT = repo.getChildrensListToDatabase();
            //Gyermek DataGridView-nak a forrása a children_fullprofile adattábla
            metroGridChildSchool.DataSource = null;
            metroGridChildSchool.DataSource = childrenViewDT;
        }
        public void emptyCells()
        {
            metroTextBoxIdS.Text = "";
            metroComboBoxSchool.SelectedItem = null;
            metroComboBoxChildren.SelectedItem = null;
            metroDateTimeBegin.Text = "1990-01-01";
            metroDateTimeFinish.Text = "1990-01-01";
            metroTextBoxType.Text = "";
            metroTextBoxHeadTeacher.Text = "";
        }
        /// <summary>
        /// Beállít Datagridview oszlopait és egyébb dolgot
        /// </summary>
        public void setChildrenViewDataGridView()
        {
            childrenViewDT.Columns[0].ColumnName = "Azonosító:";
            childrenViewDT.Columns[1].ColumnName = "Iskola név:";
            childrenViewDT.Columns[2].ColumnName = "Gyermek neve:";
            childrenViewDT.Columns[3].ColumnName = "Kezdés dátuma:";
            childrenViewDT.Columns[4].ColumnName = "Várható befejezés:";
            childrenViewDT.Columns[5].ColumnName = "Tipusa:";
            childrenViewDT.Columns[6].ColumnName = "Osztályfönők:";


            metroGridChildSchool.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            metroGridChildSchool.ReadOnly = true;
            metroGridChildSchool.AllowUserToDeleteRows = false;
            metroGridChildSchool.AllowUserToAddRows = false;
            metroGridChildSchool.MultiSelect = false;
            metroGridChildSchool.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void Schools_Load(object sender, EventArgs e)
        {
            updateDataInDataGriedViewt();
            setChildrenViewDataGridView();
            metroDateTimeBegin.Text = "1990-01-01";
            metroDateTimeFinish.Text = "1990-01-01";
            metroComboBoxChildren.DataSource = null;
            metroComboBoxChildren.DataSource = rc.getChildrenName();
            metroComboBoxSchool.DataSource = null;
            metroComboBoxSchool.DataSource = rs.getSchoolName();
        }
        private void metroButtonAddSchool_Click(object sender, EventArgs e)
        {
            AddSchool sch = new AddSchool();
            sch.Show();
        }

        private void metroButtonLogOut_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            this.Hide();
        }

        private void metroButtonSearch_Click(object sender, EventArgs e)
        {

            if (metroComboBoxSchool.Text == "")
            {
                MetroMessageBox.Show(this, "Kereséshez válasza ki az adott intézményt! \n Ha mindet szeretné látni akkor válaszd ki ezt a jelet \" * \" (csillag) jelet a \"Intézmények:\" cellánál!", "Hiba\n\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (metroComboBoxSchool.Text == "*")
            {
                updateDataInDataGriedViewt();
            }
            else
            {
                string rowFilter = string.Format("[{0}] = '{1}'", "Iskola név:", metroComboBoxSchool.Text);
                (metroGridChildSchool.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

                if (metroGridChildSchool.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Kereséshez válasza ki az adott intézményt! \n Ha mindet szeretné látni akkor válaszd ki ezt a jelet \" * \" (csillag) jelet a \"Intézmények:\" cellánál!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void metroButtonClearCells_Click(object sender, EventArgs e)
        {
            emptyCells();
        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            //Ha sor nullat ad vissza ne történjen 
            if ((metroGridChildSchool.Rows) == null || (metroGridChildSchool.Rows.Count == 0))
            {
                return;
            }
            int selectedIndex = metroGridChildSchool.SelectedRows[0].Index;

            DialogResult dr = MetroMessageBox.Show(this, "\n\nBiztos szeretné törölni a szülőt?", "Szülő törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //Törlés a listából
                //Törlés az adatbázisból
                int id = -1;
                if (!int.TryParse(metroGridChildSchool.SelectedRows[0].Cells[0].Value.ToString(), out id))
                {
                    return;
                }

                try
                {
                    rep.deleteChildrenViewFromDatabase(id);
                    repo.deleteChildrenViewInList(id);
                }
                catch (RepositoryChildrenViewExceptionCantDelete)
                {

                    Debug.WriteLine("A vizsgálat törlése sikertelen volt a listából, mert másik adatbázisban is szerepel!");
                    MetroMessageBox.Show(this, "\n\nA vizsgálat törlése sikertelen volt a listából, mert másik adatbázisban is szerepel!", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //DataGridView frissítése
                updateDataInDataGriedViewt();
            }
            else
            {
                Debug.WriteLine("'DialogResult.No'-ra futott rá!");
            }
        }

        private void metroGridChildSchool_SelectionChanged(object sender, EventArgs e)
        {
            if (metroGridChildSchool.SelectedRows.Count != 0)
            {
                metroGridChildSchool.CurrentRow.Selected = true;
                metroTextBoxIdS.Text = metroGridChildSchool.SelectedRows[0].Cells[0].Value.ToString();
                metroComboBoxChildren.Text = metroGridChildSchool.SelectedRows[0].Cells[1].Value.ToString();
                metroComboBoxSchool.Text = metroGridChildSchool.SelectedRows[0].Cells[2].Value.ToString();
                metroDateTimeBegin.Text = metroGridChildSchool.SelectedRows[0].Cells[3].Value.ToString();
                metroDateTimeFinish.Text = metroGridChildSchool.SelectedRows[0].Cells[4].Value.ToString();
                metroTextBoxType.Text = metroGridChildSchool.SelectedRows[0].Cells[5].Value.ToString();
                metroTextBoxHeadTeacher.Text = metroGridChildSchool.SelectedRows[0].Cells[6].Value.ToString();


            }
        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            errorProviderBeginn.Clear();
            errorProviderChildren.Clear();
            errorProviderFinish.Clear();
            errorProviderHTeacher.Clear();
            errorProviderSchool.Clear();
            errorProviderType.Clear();
            try
            {
                int id = repo.getnextChildrenViewId();

                
                ChildrenView newChildrenView2 = new ChildrenView(
                    id,
                    metroComboBoxChildren.Text,
                    metroComboBoxSchool.Text,
                    metroDateTimeBegin.Text,
                    metroDateTimeFinish.Text,
                    metroTextBoxType.Text,
                    metroTextBoxHeadTeacher.Text
                   );

                ChildrenView newChildrenView = new ChildrenView(
                    id,
                    rs.getSchoolIdInsert(metroComboBoxSchool.Text),
                    rc.getChildrenId(metroComboBoxChildren.Text),
                    metroDateTimeBegin.Text,
                    metroDateTimeFinish.Text,
                    metroTextBoxType.Text,
                    metroTextBoxHeadTeacher.Text
                   );


                //Hozzáadás az adatbázishoz
                try
                {
                    rep.insertParentToDatabase(newChildrenView);
                }
                catch (Exception)
                {
                    throw new insertChildrenViewException();
                }

                //Hozzáadás a listához
                try
                {
                    repo.addChildrenViewToList(newChildrenView2);
                }
                catch (Exception)
                {

                    Debug.WriteLine("Az intézmény gyerek pár felvétele sikertelen volt a listához");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt a listához.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                


                //DataGridView frissítése
                updateDataInDataGriedViewt();
                emptyCells();
            }
            catch (insertSchoolException ise)
            {
                Debug.WriteLine("Az intézmény gyerek pár felvétele sikertelen volt az adatbázishoz, " + ise.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt. ", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellChildrenViewExceptionNotValidChildren mnc)
            {
                errorProviderChildren.SetError(metroComboBoxSchool, mnc.Message);
            }
            catch (ModellChildrenViewExceptionNotValidSchool mns)
            {
                errorProviderSchool.SetError(metroComboBoxChildren, mns.Message);
            }
            catch (ModellChildrenViewExceptionNotValidType mnt)
            {
                errorProviderType.SetError(metroTextBoxType, mnt.Message);
            }
            catch (ModellChildrenViewExceptionNotValidHteacher mnh)
            {
                errorProviderHTeacher.SetError(metroTextBoxHeadTeacher, mnh.Message);
            }
            catch (ModellChildrenViewExceptionNotValidDates mnd)
            {
                errorProviderBeginn.SetError(metroDateTimeBegin, mnd.Message);
                errorProviderFinish.SetError(metroDateTimeFinish, mnd.Message);
            }
            catch (ModellChildrenViewExceptionNotValidDates2 mnd)
            {
                errorProviderBeginn.SetError(metroDateTimeBegin, mnd.Message);
            }
            catch (ModellChildrenViewExceptionNotValidDates3 mnd)
            {
                errorProviderFinish.SetError(metroDateTimeFinish, mnd.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void metroButtonModify_Click(object sender, EventArgs e)
        {
            errorProviderBeginn.Clear();
            errorProviderChildren.Clear();
            errorProviderFinish.Clear();
            errorProviderHTeacher.Clear();
            errorProviderSchool.Clear();
            errorProviderType.Clear();
            try
            {
                ChildrenView modified = new ChildrenView(
                Convert.ToInt32(metroTextBoxIdS.Text),
                    rs.getSchoolIdInsert(metroComboBoxSchool.Text),
                    rc.getChildrenId(metroComboBoxChildren.Text),
                    metroDateTimeBegin.Text,
                    metroDateTimeFinish.Text,
                    metroTextBoxType.Text,
                    metroTextBoxHeadTeacher.Text
                );
                ChildrenView modified2 = new ChildrenView(
                Convert.ToInt32(metroTextBoxIdS.Text),
                    metroComboBoxChildren.Text,
                    metroComboBoxSchool.Text,
                    metroDateTimeBegin.Text,
                    metroDateTimeFinish.Text,
                    metroTextBoxType.Text,
                    metroTextBoxHeadTeacher.Text
                );

                int id = Convert.ToInt32(metroTextBoxIdS.Text);

                //Módosítás az adatbázisban
                try
                {
                    rep.updateChildrenViewInDatabase(id, modified);
                }
                catch (Exception ex)
                {
                    throw new updateChildrenViewException();
                }


                //Módosítás a listában
                try
                {
                    repo.updateChildrenViewInList(id, modified2);
                }
                catch (Exception ex)
                {

                    Debug.WriteLine("Az intézmény gyerek pár  módosítása sikertelen volt a listában");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítása sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                //Módosítás miatt DataGridView updatelése
                updateDataInDataGriedViewt();
            }
            catch (updateChildrenViewException uee)
            {
                Debug.WriteLine("Az intézmény módosítás sikertelen volt az adatbázishoz, " + uee.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítás sikertelen volt. Nem lehet két ugyan olyan nevű intézmény.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellChildrenViewExceptionNotValidChildren mnc)
            {
                errorProviderChildren.SetError(metroComboBoxChildren, mnc.Message);
            }
            catch (ModellChildrenViewExceptionNotValidSchool mns)
            {
                errorProviderSchool.SetError(metroComboBoxSchool, mns.Message);
            }
            catch (ModellChildrenViewExceptionNotValidType mnt)
            {
                errorProviderType.SetError(metroTextBoxType, mnt.Message);
            }
            catch (ModellChildrenViewExceptionNotValidHteacher mnh)
            {
                errorProviderHTeacher.SetError(metroTextBoxHeadTeacher, mnh.Message);
            }
            catch (ModellChildrenViewExceptionNotValidDates mnd)
            {
                errorProviderBeginn.SetError(metroDateTimeBegin, mnd.Message);
                errorProviderFinish.SetError(metroDateTimeFinish, mnd.Message);
            }
            catch (ModellChildrenViewExceptionNotValidDates2 mnd)
            {
                errorProviderBeginn.SetError(metroDateTimeBegin, mnd.Message);
            }
            catch (ModellChildrenViewExceptionNotValidDates3 mnd)
            {
                errorProviderFinish.SetError(metroDateTimeFinish, mnd.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
