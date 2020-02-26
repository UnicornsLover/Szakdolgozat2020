using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                metroTextBoxEBirth.Text = metroGridEmployes.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                metroTextBoxBPlace.Text = metroGridEmployes.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                metroComboBoxEjobtype.Text = metroGridEmployes.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                metroComboBoxELocation.Text = metroGridEmployes.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                metroTextBoxEUserName.Text = metroGridEmployes.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                metroTextBoxEPassword.Text = metroGridEmployes.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            }
        }
    }
}
