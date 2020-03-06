using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            repo.setChild(rep.getEmployeesFromDatabase());
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
            metroDateTimeBDate.Text = "2000-01-01";
            metroDateTimeComing.Text = "2000-01-01";
            updateCildrenNumber();
        }

        /// <summary>
        /// Kiválasztott cell adatok jelenjenek meg a cellákban
        /// </summary>
        private void metroGridChildren_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGridChildren.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                metroGridChildren.CurrentRow.Selected = true;
                metroTextBoxID.Text = metroGridChildren.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                metroTextBoxName.Text = metroGridChildren.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                metroComboBoxSex.Text = metroGridChildren.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                metroTextBoxIdCard.Text = metroGridChildren.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                metroTextBoxTaj.Text = metroGridChildren.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                metroDateTimeBDate.Text = metroGridChildren.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                metroTextBoxBPlace.Text = metroGridChildren.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                metroDateTimeComing.Text = metroGridChildren.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                metroTextBoxLocation.Text = metroGridChildren.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            }
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
            metroTextBoxID.Text = "";
            metroTextBoxName.Text = "";
            metroComboBoxSex.Text = "";
            metroTextBoxIdCard.Text = "";
            metroTextBoxTaj.Text = "";
            metroDateTimeBDate.Text = "";
            metroTextBoxBPlace.Text = "";
            metroDateTimeComing.Text = "";
            metroTextBoxLocation.Text = "";
        }
       
    }
}
