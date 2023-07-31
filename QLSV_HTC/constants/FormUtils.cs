﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT.constants
{
    public class FormUtils
    {
        public static void DisableMatrixButtons(BarManager barManager, List<BarButtonItem> disabledBarButtonItems)
        {
            foreach (object item in barManager.Items)
            {
                if (item is BarButtonItem)
                {
                    BarButtonItem barButtonItem = item as BarButtonItem;

                    barButtonItem.Enabled = true;

                    if (disabledBarButtonItems.Contains(barButtonItem))
                    {
                        barButtonItem.Enabled = false;
                    }
                }
            }
        }

        public static void DisableMatrixBarMangagerItems(BarManager barManager, List<BarItem> disabledBarButtonItems)
        {

            BarItems barItems = barManager.Items;
            foreach (BarItem barItem in barItems)
            {

                barItem.Enabled = true;

                if (disabledBarButtonItems.Contains(barItem))
                {
                    barItem.Enabled = false;
                }
            }
        }

        public static void EnableMatrixBarMangagerItems(BarManager barManager, List<BarItem> disabledBarButtonItems)
        {

            BarItems barItems = barManager.Items;
            foreach (BarItem barItem in barItems)
            {

                barItem.Enabled = false;

                if (disabledBarButtonItems.Contains(barItem))
                {
                    barItem.Enabled = true;
                }
            }
        }

        public static void DisableMatrixContexMenuItems(ContextMenuStrip barManager, List<ToolStripMenuItem> disabledBarButtonItems)
        {

            ToolStripItemCollection items = barManager.Items;
            foreach (ToolStripMenuItem barItem in items)
            {

                barItem.Enabled = true;

                if (disabledBarButtonItems.Contains(barItem))
                {
                    barItem.Enabled = false;
                }
            }
        }

        public static void EnableMatrixContexMenuItems(ContextMenuStrip barManager, List<ToolStripMenuItem> disabledBarButtonItems)
        {

            ToolStripItemCollection items = barManager.Items;
            foreach (ToolStripMenuItem barItem in items)
            {

                barItem.Enabled = false;

                if (disabledBarButtonItems.Contains(barItem))
                {
                    barItem.Enabled = true;
                }
            }
        }


        public static void ShowDialog()
        {

        }

        public static void ValidateInput()
        {

        }

        public static void FillCombobox(ComboBoxEdit comboBox, string connectionString, string command, string displayValue)
        {
            //DataTable dt = new DataTable();
            //if(Program.conn.State == ConnectionState.Closed)
            //{
            //    Program.conn.Close();
            //}

            //SqlDataAdapter sda = new SqlDataAdapter(command, connectionString);
            //sda.Fill(dt);
            //Program.conn.Close();
            //

        }

        public static string getSelectedStringOfComboBox(BindingSource bds,ComboBoxEdit cbx, string value)
        {
            string returnValue = "";
            if (bds != null || cbx != null || !string.IsNullOrEmpty(value))
            {
                int index = cbx.SelectedIndex;
                returnValue = (string)((DataRowView)bds[index])[value].ToString();
            }
            return returnValue;
        }

        public static void FillDataTable(object tableAdapter, string connectionString)
        {
            
        }

    }
}