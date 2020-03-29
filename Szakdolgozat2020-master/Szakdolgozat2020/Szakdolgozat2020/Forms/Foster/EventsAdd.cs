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
using Szakdolgozat2020.Modell.Event;
using Szakdolgozat2020.Repository.Events;

namespace Szakdolgozat2020.Forms.Foster
{
    public partial class EventsAdd : MetroFramework.Forms.MetroForm
    {
        private DataTable eventTD = new DataTable();
        RepositoryEvents rs = new RepositoryEvents();
        EventDatabaseCommand edc = new EventDatabaseCommand();
        Fosterhomepage fh = new Fosterhomepage();
        public EventsAdd()
        {
            InitializeComponent();
            rs.setEvents(edc.getEventFromDatabase());
        }

        private void EventsAdd_Load(object sender, EventArgs e)
        {
            updateDataInDataGriedViewt();
            setEventsDataGridView();
        }

        /// <summary>
        /// DataGridview frissitése
        /// </summary>
        public void updateDataInDataGriedViewt()
        {
            //Adattáblát feltölti a repoba lévő esemény listából
            eventTD = rs.getEventsListToDatabase();
            //esemény DataGridView-nak a forrása a school adattábla
            metroGridEvents.DataSource = null;
            metroGridEvents.DataSource = eventTD;
        }
        public void emptyCells()
        {
            metroTextBoxId.Text = "";
            metroTextBoxTitle.Text = "";
            richTextBoxDetails.Text = "";
            metroTextBoxBy.Text = fh.getLogName();
        }

        /// <summary>
        /// Beállít Datagridview oszlopait és egyébb dolgot
        /// </summary>
        public void setEventsDataGridView()
        {
            eventTD.Columns[0].ColumnName = "Esemény azonosító:";
            eventTD.Columns[1].ColumnName = "Cím:";
            eventTD.Columns[2].ColumnName = "Leírás:";
            eventTD.Columns[3].ColumnName = "Felvéve:";

            metroGridEvents.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            metroGridEvents.ReadOnly = true;
            metroGridEvents.AllowUserToDeleteRows = false;
            metroGridEvents.AllowUserToAddRows = false;
            metroGridEvents.MultiSelect = false;
            metroGridEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void metroButtonSearch_Click(object sender, EventArgs e)
        {
            if (metroTextBoxTitle.Text == "")
            {
                MetroMessageBox.Show(this, "Keresés csak pontos név megadásával lehetséges (pl: Kecskeméti Református Gimnázium - nagy betű is fontos), a cella kitötése kötelező! \nTöltse ki a \"Neve:\" cellát!\nHa esetleg minden adatot újra szeretne látni egy szűrés után, csak is kizárólag írja be ezt a \" * \" (csillag) jelet a \"Neve:\" cellábas!", "Hiba\n\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (metroTextBoxTitle.Text == "*")
            {
                updateDataInDataGriedViewt();
            }
            else
            {
                string rowFilter = string.Format("[{0}] = '{1}'", "Cím:", metroTextBoxTitle.Text);
                (metroGridEvents.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

                if (metroGridEvents.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Keresés csak pontos név megadásával lehetséges (pl: Kirándulás a mecsekben - nagy betű is fontos), a cella kitötése kötelező! \nTöltse ki a \"Cím:\" cellát!\nHa esetleg minden adatot újra szeretne látni egy szűrés után, csak is kizárólag írja be ezt a \" * \" (csillag) jelet a \"Neve:\" cellábas!", "Hiba\n\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void metroButtonClearCells_Click(object sender, EventArgs e)
        {
            emptyCells();
        }

        /// <summary>
        /// Esemény törlése
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            //Ha sor nullat ad vissza ne történjen 
            if ((metroGridEvents.Rows) == null || (metroGridEvents.Rows.Count == 0))
            {
                return;
            }
            int selectedIndex = metroGridEvents.SelectedRows[0].Index;

            DialogResult dr = MetroMessageBox.Show(this, "\n\nBiztos szeretné törölni az eseményt?", "Esemény törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //Törlés a listából
                //Törlés az adatbázisból
                int id = -1;
                if (!int.TryParse(metroGridEvents.SelectedRows[0].Cells[0].Value.ToString(), out id))
                {
                    return;
                }

                try
                {
                    edc.deleteEventFromDatabase(id);
                    rs.deleteEventInList(id);
                }
                catch (RepositoryEventExceptionCantDelete)
                {

                    Debug.WriteLine("Az esemény törlése sikertelen volt a listából, mert másik adatbázisba szerepel!");
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

        private void metroGridEvents_SelectionChanged(object sender, EventArgs e)
        {
            if (metroGridEvents.SelectedRows.Count != 0)
            {
                metroGridEvents.CurrentRow.Selected = true;
                metroTextBoxId.Text = metroGridEvents.SelectedRows[0].Cells[0].Value.ToString();
                metroTextBoxTitle.Text = metroGridEvents.SelectedRows[0].Cells[1].Value.ToString();
                richTextBoxDetails.Text = metroGridEvents.SelectedRows[0].Cells[2].Value.ToString();
                metroTextBoxBy.Text = metroGridEvents.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void metroButtonModify_Click(object sender, EventArgs e)
        {
            errorProviderTitle.Clear();
            errorProviderDetails.Clear();

            try
            {
                Event modified = new Event(
                Convert.ToInt32(metroTextBoxId.Text),
                metroTextBoxTitle.Text,
                richTextBoxDetails.Text,
                metroTextBoxBy.Text
                );
                int id = Convert.ToInt32(metroTextBoxId.Text);

                //Módosítás az adatbázisban
                try
                {
                    edc.updateEventInDatabase(id, modified);
                }
                catch (Exception ex)
                {
                    throw new updateEventException();
                }


                //Módosítás a listában
                try
                {
                    rs.updateEventInList(id, modified);
                }
                catch (Exception ex)
                {

                    Debug.WriteLine("Az esemény módosítása sikertelen volt a listában");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítása sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                //Módosítás miatt DataGridView updatelése
                updateDataInDataGriedViewt();
            }
            catch (updateEventException uee)
            {
                Debug.WriteLine("Az esemény módosítás sikertelen volt az adatbázishoz, " + uee.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítás sikertelen volt. Nem lehet két ugyan olyan című esemény az adatbázsban.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellNotValidEventDetails med)
            {
                errorProviderDetails.SetError(richTextBoxDetails, med.Message);
            }
            catch (ModellNotValidEventTitle mnt)
            {
                errorProviderTitle.SetError(metroTextBoxTitle, mnt.Message);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            errorProviderTitle.Clear();
            errorProviderDetails.Clear();

            try
            {


                int id = rs.getnextEventId();

                Event newEvent = new Event(
                    id,
                    metroTextBoxTitle.Text,
                    richTextBoxDetails.Text,
                    metroTextBoxBy.Text
                   );

                //Hozzáadás az adatbázishoz
                try
                {
                    edc.insertEventToDatabase(newEvent);
                }
                catch (Exception)
                {
                    throw new insertEventException();
                }

                //Hozzáadás a listához
                try
                {
                    rs.addEventToList(newEvent);
                }
                catch (Exception)
                {

                    Debug.WriteLine("Az esemény felvétele sikertelen volt a listához");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt a listához.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                //DataGridView frissítése
                updateDataInDataGriedViewt();
                emptyCells();
            }
            catch (insertSchoolException ise)
            {
                Debug.WriteLine("Az esemény felvétele sikertelen volt az adatbázishoz, " + ise.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt. Nem lehet két ugyan olyan című esemény az adatbázsban.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellNotValidEventDetails med)
            {
                errorProviderDetails.SetError(richTextBoxDetails, med.Message);
            }
            catch (ModellNotValidEventTitle mnt)
            {
                errorProviderTitle.SetError(metroTextBoxTitle, mnt.Message);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
