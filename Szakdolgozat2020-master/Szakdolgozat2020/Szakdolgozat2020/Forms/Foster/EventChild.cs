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
using Szakdolgozat2020.Modell.EventChildren;
using Szakdolgozat2020.Repository.Children;
using Szakdolgozat2020.Repository.ChildrenEvents;
using Szakdolgozat2020.Repository.Events;

namespace Szakdolgozat2020.Forms.Foster
{
    public partial class EventChildForm : MetroFramework.Forms.MetroForm
    {
        private DataTable eventChildrenDT = new DataTable();
        RepositoryEventsChildren rec = new RepositoryEventsChildren();
        EventChildrenDatabaseCommand rce = new EventChildrenDatabaseCommand();
        RepositoryChildren rc = new RepositoryChildren();
        RepositoryDatabaseChildren rdc = new RepositoryDatabaseChildren();
        RepositoryEvents re = new RepositoryEvents();
        EventDatabaseCommand rdb = new EventDatabaseCommand();
        public EventChildForm()
        {
            InitializeComponent();
            rec.setChildrenViews(rce.getEventChildrenFromDatabase());
            rc.setChild(rdc.getChildrenFromDatabase());
            re.setEvents(rdb.getEventFromDatabase());
        }

        // <summary>
        /// DataGridview frissitése
        /// </summary>
        public void updateDataInDataGriedViewt()
        {
            //Adattáblát feltölti a repoba lévő gyermek listából
            eventChildrenDT = rec.getEventChildrensListToDatabase();
            //Gyermek DataGridView-nak 
            metroGridEventChildren.DataSource = null;
            metroGridEventChildren.DataSource = eventChildrenDT;
        }

        public void emptyCells()
        {
            metroTextBoxId.Text = "";
            metroComboBoxChildrenName.SelectedItem = null;
            metrocomboboxEvent.SelectedItem = null;
            metroDateTimeeventDate.Text = "1990-01-01";
        }

        /// <summary>
        /// Beállít Datagridview oszlopait és egyébb dolgot
        /// </summary>
        public void setEventChildrenDataGridView()
        {
            eventChildrenDT.Columns[0].ColumnName = "Esemény azonosítója:";
            eventChildrenDT.Columns[1].ColumnName = "Gyermek neve:";
            eventChildrenDT.Columns[2].ColumnName = "Esemény címe";
            eventChildrenDT.Columns[3].ColumnName = "Esemény dátuma:";



            metroGridEventChildren.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            metroGridEventChildren.ReadOnly = true;
            metroGridEventChildren.AllowUserToDeleteRows = false;
            metroGridEventChildren.AllowUserToAddRows = false;
            metroGridEventChildren.MultiSelect = false;
            metroGridEventChildren.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void EventChild_Load(object sender, EventArgs e)
        {
            updateDataInDataGriedViewt();
            setEventChildrenDataGridView();
            metroDateTimeeventDate.Text = "1990-01-01";
            metroComboBoxChildrenName.DataSource = null;
            metroComboBoxChildrenName.DataSource = rc.getChildrenName();
            metrocomboboxEvent.DataSource = null;
            metrocomboboxEvent.DataSource = re.getEventName();
        }

        private void metroButtonSearch_Click(object sender, EventArgs e)
        {
            if (metroComboBoxChildrenName.Text == "")
            {
                MetroMessageBox.Show(this, "Kereséshez válasza ki az adott gyermeket! \n 'Gyermek neve:' cellánál, majd utána kattintson a keresés gombra.", "Hiba\n\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (metroComboBoxChildrenName.Text == "*")
            {
                updateDataInDataGriedViewt();
            }
            else
            {
                string rowFilter = string.Format("[{0}] = '{1}'", "Gyermek név:", metroComboBoxChildrenName.Text);
                (metroGridEventChildren.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

                if (metroGridEventChildren.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Kereséshez válasza ki az adott gyermeket! \n 'Gyermek neve:' cellánál, majd utána kattintson a keresés gombra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if ((metroGridEventChildren.Rows) == null || (metroGridEventChildren.Rows.Count == 0))
            {
                return;
            }
            int selectedIndex = metroGridEventChildren.SelectedRows[0].Index;

            DialogResult dr = MetroMessageBox.Show(this, "\n\nBiztos szeretné törölni a gyerek esemény párt?", "Gyerek esemény pár törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //Törlés a listából
                //Törlés az adatbázisból
                int id = -1;
                if (!int.TryParse(metroGridEventChildren.SelectedRows[0].Cells[0].Value.ToString(), out id))
                {
                    return;
                }

                try
                {
                    rce.deleteEventChildFromDatabase(id);
                    rec.deleteEventChildrenViewInList(id);
                }
                catch (RepositoryEventChildrenExceptionCantDelete)
                {

                    Debug.WriteLine("A gyermek esemény törlése sikertelen volt a listából, mert másik adatbázisban is szerepel!");
                    MetroMessageBox.Show(this, "\n\nA vizsgálat törlése sikertelen volt a listából.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //DataGridView frissítése
                updateDataInDataGriedViewt();
            }
            else
            {
                Debug.WriteLine("'DialogResult.No'-ra futott rá!");
            }
        }

        private void metroGridEventChildren_SelectionChanged(object sender, EventArgs e)
        {
            if (metroGridEventChildren.SelectedRows.Count != 0)
            {
                metroGridEventChildren.CurrentRow.Selected = true;
                metroTextBoxId.Text = metroGridEventChildren.SelectedRows[0].Cells[0].Value.ToString();
                metroComboBoxChildrenName.Text = metroGridEventChildren.SelectedRows[0].Cells[1].Value.ToString();
                metrocomboboxEvent.Text = metroGridEventChildren.SelectedRows[0].Cells[2].Value.ToString();
                metroDateTimeeventDate.Text = metroGridEventChildren.SelectedRows[0].Cells[3].Value.ToString();

            }
        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            errorProviderChildrenName.Clear();
            errorProviderDate.Clear();
            errorProviderEventName.Clear();
            try
            {
                int id = rec.getnextChildrenViewId();


                EventChild newEventChild1 = new EventChild(
                    id,
                    metroComboBoxChildrenName.Text,
                    metrocomboboxEvent.Text,
                    metroDateTimeeventDate.Text
                   );

                EventChild newEventChild2 = new EventChild(
                    id,
                    rc.getChildrenId(metroComboBoxChildrenName.Text),
                    re.getEventID(metrocomboboxEvent.Text),
                    metroDateTimeeventDate.Text
                   );


                //Hozzáadás az adatbázishoz
                try
                {
                    rce.insertEventChildrenToDatabase(newEventChild2);
                }
                catch (Exception)
                {
                    throw new insertEventChildrenException();
                }

                //Hozzáadás a listához
                try
                {
                    rec.addEventChildrenViewToList(newEventChild1);
                }
                catch (Exception)
                {

                    Debug.WriteLine("Az esemény gyerek pár felvétele sikertelen volt a listához");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt a listához.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                //DataGridView frissítése
                updateDataInDataGriedViewt();
                emptyCells();
            }
            catch (insertEventChildrenException ise)
            {
                Debug.WriteLine("Az esemény gyerek pár felvétele sikertelen volt az adatbázishoz, " + ise.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt. ", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellNotValidExceptionChildrenName mcn)
            {
                errorProviderChildrenName.SetError(metroComboBoxChildrenName, mcn.Message);
            }
            catch (ModellNotValidExceptionEventName mevn)
            {
                errorProviderEventName.SetError(metrocomboboxEvent, mevn.Message);
            }
            catch (ModellNotValidExceptionEventDate mecd)
            {
                errorProviderDate.SetError(metroDateTimeeventDate, mecd.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void metroButtonModify_Click(object sender, EventArgs e)
        {
            errorProviderChildrenName.Clear();
            errorProviderDate.Clear();
            errorProviderEventName.Clear();
            try
            {
                EventChild modified = new EventChild(
                Convert.ToInt32(metroTextBoxId.Text),
                   metroComboBoxChildrenName.Text,
                   metrocomboboxEvent.Text,
                   metroDateTimeeventDate.Text
                );
                EventChild modified2 = new EventChild(
                Convert.ToInt32(metroTextBoxId.Text),
                    rc.getChildrenId(metroComboBoxChildrenName.Text),
                    re.getEventID(metrocomboboxEvent.Text),
                   metroDateTimeeventDate.Text
                );

                int id = Convert.ToInt32(metroTextBoxId.Text);

                //Módosítás az adatbázisban
                try
                {
                    rce.updateChildrenInDatabase(id, modified2);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    throw new updateEventChildrenException();
                }


                //Módosítás a listában
                try
                {
                    rec.updateEventChildrenViewInList(id, modified);
                }
                catch (Exception ex)
                {

                    Debug.WriteLine("Az esemény gyerek pár  módosítása sikertelen volt a listában");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítása sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                //Módosítás miatt DataGridView updatelése
                updateDataInDataGriedViewt();
            }
            catch (updateEventChildrenException uee)
            {
                Debug.WriteLine("Az gyermek esemény módosítás sikertelen volt az adatbázishoz, " + uee.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítás sikertelen volt.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellNotValidExceptionChildrenName mcn)
            {
                errorProviderChildrenName.SetError(metroComboBoxChildrenName, mcn.Message);
            }
            catch (ModellNotValidExceptionEventName mevn)
            {
                errorProviderEventName.SetError(metrocomboboxEvent, mevn.Message);
            }
            catch (ModellNotValidExceptionEventDate mecd)
            {
                errorProviderDate.SetError(metroDateTimeeventDate, mecd.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
