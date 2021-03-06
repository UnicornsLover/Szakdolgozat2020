﻿using MetroFramework;
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
using Szakdolgozat2020.Modell.ChildParent;
using Szakdolgozat2020.Repository.Children;
using Szakdolgozat2020.Repository.ChildrenParents;
using Szakdolgozat2020.Repository.Parents;

namespace Szakdolgozat2020.Forms.Administrator
{
    public partial class ParChiReg : MetroFramework.Forms.MetroForm
    {
        private DataTable childrenParentDT = new DataTable();
        RepositoryChildren rc = new RepositoryChildren();
        RepositoryDatabaseChildren rdc = new RepositoryDatabaseChildren();
        RepositoryParents rp = new RepositoryParents();
        RepositoryDatabaseParents rdp = new RepositoryDatabaseParents();
        RepositoryChildrenParents repo = new RepositoryChildrenParents();
        ChildrenParentDatabaseCommand rpcdb = new ChildrenParentDatabaseCommand();
        
        /// <summary>
        /// Konstruktor
        /// </summary>
        public ParChiReg()
        {
            InitializeComponent();
            repo.setChildParent(rpcdb.getChildrenParentsFromDatabase());
            rc.setChild(rdc.getChildrenFromDatabase());
            rp.setParents(rdp.getParentsFromDatabase());

        }
        /// <summary>
        /// DataGridview frissitése
        /// </summary>
        public void updateDataInDataGriedViewt()
        {
            //Adattáblát feltölti a repoba lévő gyermek listából
            childrenParentDT = repo.getChildrenParentsListToDatabse();
            //Gyermek-szülő DataGridView-nak 
            metroGridPC.DataSource = null;
            metroGridPC.DataSource = childrenParentDT;
        }

        /// <summary>
        /// Inputok ürítése, alaphelyzetbe állítása
        /// </summary>
        public void emptyCells()
        {
            metroTextBoxID.Text = "";
            metroComboBoxParenttName.SelectedItem = null;
            metroComboBoxChildrenName.SelectedItem = null;
        }

        /// <summary>
        /// Datagridview Beállítása
        /// </summary>
        public void setChildrenParentViewDataGridView()
        {
            childrenParentDT.Columns[0].ColumnName = "Azonosító:";
            childrenParentDT.Columns[1].ColumnName = "Szülő név:";
            childrenParentDT.Columns[2].ColumnName = "Gyermek neve:";


            metroGridPC.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            metroGridPC.ReadOnly = true;
            metroGridPC.AllowUserToDeleteRows = false;
            metroGridPC.AllowUserToAddRows = false;
            metroGridPC.MultiSelect = false;
            metroGridPC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Form loadja, beállítások
        /// </summary>
        private void ParChiReg_Load(object sender, EventArgs e)
        {
            updateDataInDataGriedViewt();
            setChildrenParentViewDataGridView();
            emptyCells();
            metroComboBoxChildrenName.DataSource =null;
            metroComboBoxChildrenName.DataSource =rc.getChildrenName();
            metroComboBoxParenttName.DataSource = null;
            metroComboBoxParenttName.DataSource = rp.getParentsName();
        }

        /// <summary>
        /// Gyerek név alapján keresés
        /// </summary>
        private void metroButtonSearch_Click(object sender, EventArgs e)
        {
            if (metroComboBoxChildrenName.Text == "")
            {
                MetroMessageBox.Show(this, "Kereséshez válassza kis a gyerek nevét! Kivéálasztás kötelező!", "Hiba\n\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (metroComboBoxChildrenName.Text == "*")
            {
                updateDataInDataGriedViewt();
            }
            else
            {
                string rowFilter = string.Format("[{0}] = '{1}'", "Gyermek neve:", metroComboBoxChildrenName.Text);
                (metroGridPC.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

                if (metroGridPC.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Kereséshez válassza ki a gyerek nevét! Kivéálasztás kötelező!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Gombnyomásra az inputok aéaphelyzetbeállítása
        /// </summary>
        private void metroButtonClearCells_Click(object sender, EventArgs e)
        {
            emptyCells();
        }

        /// <summary>
        /// Törlés Gyerek-Szülő pár
        /// </summary>
        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            //Ha sor nullat ad vissza ne történjen 
            if ((metroGridPC.Rows) == null || (metroGridPC.Rows.Count == 0))
            {
                return;
            }

            try
            {
                int selectedIndex = metroGridPC.SelectedRows[0].Index;

                DialogResult dr = MetroMessageBox.Show(this, "\n\nBiztos szeretné törölni a szülő-gyerek párat?", "Szülő-Gyerek pár törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //Törlés a listából
                    //Törlés az adatbázisból
                    int id = -1;
                    if (!int.TryParse(metroGridPC.SelectedRows[0].Cells[0].Value.ToString(), out id))
                    {
                        return;
                    }

                    try
                    {
                        rpcdb.deleteChildParentFromDatabase(id);
                        repo.deleteChildParentInList(id);
                    }
                    catch (RepositoryChildrenParentExceptionCantDelete)
                    {

                        Debug.WriteLine("A Gyerek-Szülő pár törlése sikertelen volt a listából, mert másik adatbázisban is szerepel!");
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
            catch (ArgumentOutOfRangeException ae)
            {

                Debug.WriteLine("A törlés sikertelen volt!" + ae.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a törlés sikertelen volt. Kattintson a táblázatba arra a sora amit törölni kiván!", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Kiválasztott sor alapján az inputok feltöltése
        /// </summary>
        private void metroGridPC_SelectionChanged(object sender, EventArgs e)
        {
            if (metroGridPC.SelectedRows.Count != 0)
            {
                metroGridPC.CurrentRow.Selected = true;
                metroTextBoxID.Text = metroGridPC.SelectedRows[0].Cells[0].Value.ToString();
                metroComboBoxParenttName.Text = metroGridPC.SelectedRows[0].Cells[1].Value.ToString();
                metroComboBoxChildrenName.Text = metroGridPC.SelectedRows[0].Cells[2].Value.ToString();
            }
                
        }

        /// <summary>
        /// Szülő-Gyerek pár hozzáadása
        /// </summary>
        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            errorProviderParent.Clear();
            errorProviderChildren.Clear();

            try
            {
                int id = repo.getnextChildParentId();


                ChildParent newChildrenView2 = new ChildParent(
                    id,
                    metroComboBoxChildrenName.Text,
                    metroComboBoxParenttName.Text
                    
                   );

                ChildParent newChildrenView = new ChildParent(
                    id,
                    rp.getParentIdInsert(metroComboBoxParenttName.Text),
                    rc.getChildrenId(metroComboBoxChildrenName.Text)
                   );


                //Hozzáadás az adatbázishoz
                try
                {
                    rpcdb.insertChildrenParentToDatabase(newChildrenView);
                }
                catch (Exception)
                {
                    throw new insertChildrenParentException();
                }

                //Hozzáadás a listához
                try
                {
                    repo.addChildParentToList(newChildrenView2);
                }
                catch (Exception)
                {

                    Debug.WriteLine("Az Szülő-Gyerek pár felvétele sikertelen volt a listához");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt a listához.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                //DataGridView frissítése
                updateDataInDataGriedViewt();
                emptyCells();
            }
            catch (insertChildrenParentException ise)
            {
                Debug.WriteLine("Az Szülő-Gyerek pár felvétele sikertelen volt az adatbázishoz, " + ise.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a felvétel sikertelen volt. ", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellExceptionNotValidPArentName mpe)
            {
                errorProviderParent.SetError(metroComboBoxParenttName, mpe.Message);
            }
            catch (ModellExceptionNotValidChildrenName mce)
            {
                errorProviderChildren.SetError(metroComboBoxChildrenName, mce.Message);
            }
            
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Szülő-Gyerek pár módosításaa
        /// </summary>
        private void metroButtonModify_Click(object sender, EventArgs e)
        {
            errorProviderParent.Clear();
            errorProviderChildren.Clear();
            try
            {
                ChildParent modified = new ChildParent(
                Convert.ToInt32(metroTextBoxID.Text),
                    rp.getParentIdInsert(metroComboBoxParenttName.Text),
                    rc.getChildrenId(metroComboBoxChildrenName.Text)
                );

                ChildParent modified2 = new ChildParent(
                Convert.ToInt32(metroTextBoxID.Text),
                   metroComboBoxChildrenName.Text,
                    metroComboBoxParenttName.Text
                );

                int id = Convert.ToInt32(metroTextBoxID.Text);

                //Módosítás az adatbázisban
                try
                {
                    rpcdb.updateChildrenInDatabase(id, modified);
                }
                catch (Exception ex)
                {
                    throw new updateChildrenParentException();
                }


                //Módosítás a listában
                try
                {
                    repo.updateChildParentInList(id, modified2);
                }
                catch (Exception ex)
                {

                    Debug.WriteLine("Az Szülő-Gyerek pár  módosítása sikertelen volt a listában");
                    MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítása sikertelen volt az adatbázisból.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                //Módosítás miatt DataGridView updatelése
                updateDataInDataGriedViewt();
            }
            catch (updateChildrenParentException uee)
            {
                Debug.WriteLine("Az Szülő-Gyerek módosítás sikertelen volt az adatbázishoz, " + uee.Message);
                MetroMessageBox.Show(this, "\n\nHibát észleltünk, a módosítás sikertelen volt.", "Felhívás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ModellExceptionNotValidPArentName mpe)
            {
                errorProviderParent.SetError(metroComboBoxParenttName, mpe.Message);
            }
            catch (ModellExceptionNotValidChildrenName mce)
            {
                errorProviderChildren.SetError(metroComboBoxChildrenName, mce.Message);
            }
            
            catch (Exception)
            {
                throw;
            }
        }
    }
}
