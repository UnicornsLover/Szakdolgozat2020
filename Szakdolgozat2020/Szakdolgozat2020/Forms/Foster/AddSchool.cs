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
            setSchoolssDataGridView();
            updateSchooolsNumber();
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
        public void setParentsDataGridView()
        {
            schoolTD.Columns[0].ColumnName = "Iskola azonosító:";
            schoolTD.Columns[1].ColumnName = "Név:";
            schoolTD.Columns[2].ColumnName = "Elheyezkedés:";
            schoolTD.Columns[3].ColumnName = "vzetékes telefonszám:";


            metroGridSchoolBasic.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            metroGridSchoolBasic.ReadOnly = true;
            metroGridSchoolBasic.AllowUserToDeleteRows = false;
            metroGridSchoolBasic.AllowUserToAddRows = false;
            metroGridSchoolBasic.MultiSelect = false;
            metroGridSchoolBasic.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void metroGridSchoolBasic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGridSchoolBasic.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                metroGridSchoolBasic.CurrentRow.Selected = true;
                metroTextBoxSID.Text = metroGridSchoolBasic.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                metroTextBoxName.Text = metroGridSchoolBasic.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                metroTextBoxLocation.Text = metroGridSchoolBasic.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                metroTextBoxPhone.Text = metroGridSchoolBasic.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            }
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
            int selectedIndex = metroGridSchoolBasic.SelectedRows[0].Index;

            DialogResult dr = MetroMessageBox.Show(this, "\n\nBiztos szeretné törölni a iskolát?", "Iskola törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //Törlés a listából
                int id = -1;
                if (!int.TryParse(metroGridSchoolBasic.SelectedRows[0].Cells[0].Value.ToString(), out id))
                {
                    return;
                }

                try
                {
                    repo.deleteSchoolInList(id);
                }
                catch (RepositorySchoolExceptionCantDelete ex)
                {

                    Debug.WriteLine("A iskola törlése sikertelen volt a listából!");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a törlés sikertelen volt az listából.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //Törlés az adatbázisból
                try
                {
                    rep.deleteSchoolFromDatabase(id);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("A iskola törlése sikertelen volt az adatbázisból");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a törlés sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //DataGridView frissítése
                updateDataInDataGriedViewt();
            }
            else
            {
                Debug.WriteLine("'DialogResult.No'-ra futott rá!");
            }
        }
    }
}
