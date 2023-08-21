using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections;
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
        public static void SetDefaultPropertiesForSpinEdit(SpinEdit spinEdit)
        {
            spinEdit.Properties.IsFloatValue = false;
            spinEdit.Properties.MinValue = 0;
            spinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;   
        }

        public static void SetDefaultForBarManagerBars(BarManager barManager)
        {
            foreach (var obj in barManager.Bars)
            {
                if (obj is Bar)
                {
                    Bar bar = obj as Bar;
                    if (bar != null)
                    {
                        bar.OptionsBar.AllowQuickCustomization = false;
                        bar.OptionsBar.DisableCustomization = true;
                        bar.OptionsBar.DrawDragBorder = false;
                    }
                }
            }
        }

        public static void SetDefaultForComboBoxEdit(ComboBoxEdit comboBox)
        {
            comboBox.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

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

        public static void DisableBarMangagerItems(BarManager barManager, List<BarItem> barManagerItems)
        {

            BarItems barItems = barManager.Items;
            foreach (BarItem barItem in barItems)
            {

                //barItem.Enabled = true;

                if (barManagerItems.Contains(barItem))
                {
                    barItem.Enabled = false;
                }
            }
        }

        public static void EnableBarMangagerItems(BarManager barManager, List<BarItem> barManagerItems)
        {

            BarItems barItems = barManager.Items;
            foreach (BarItem barItem in barItems)
            {

                //barItem.Enabled = false;

                if (barManagerItems.Contains(barItem))
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

        public static string getSelectedStringOfComboBox(BindingSource bds, ComboBoxEdit cbx, string value)
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


        public static string GetBindingSourceData(BindingSource source, int position, string key)
        {
            string result = null;
            try
            {
                result = (string)((DataRowView)source[position])[key].ToString();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, ex.Message);
            }

            return result;
        }

        public static void SetBindingSourceData(BindingSource source, int position, string key, string data)
        {
            try
            {
                ((DataRowView)source[position])[key] = data;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, ex.Message);
            }
        }

        public static bool UpdateTableAdapter()
        {
            bool updateSuccessfully = false;
            try
            {

            }
            catch (Exception ex)
            {

            }

            return updateSuccessfully;
        }

        public static void FillComboBox(ComboBoxEdit comboBox, DataTable dataTable, string rowName)
        {
            ComboBoxItemCollection itemsCollection = comboBox.Properties.Items;
            itemsCollection.BeginUpdate();
            try
            {
                foreach (DataRowView item in dataTable.Rows)
                {
                    itemsCollection.Add(item.Row[rowName]);
                }

            }
            finally
            {
                itemsCollection.EndUpdate();
            }
        }

        public static void FillComboBox(ComboBoxEdit comboBox, BindingSource dataSource, string rowName)
        {
            IList rows = dataSource.List;
            if (rows.Count > 0)
            {
                ComboBoxItemCollection itemsCollection = comboBox.Properties.Items;
                itemsCollection.BeginUpdate();
                try
                {
                    foreach (DataRowView item in rows)
                    {
                        itemsCollection.Add(item.Row[rowName]);
                    }

                }
                finally
                {
                    itemsCollection.EndUpdate();
                    SetDefaultForComboBoxEdit(comboBox);
                    comboBox.SelectedIndex = 0;
                }
            }
        }

        public static void FillComboBox(RepositoryItemComboBox comboBox, BindingSource dataSource, string rowName)
        {
            IList rows = dataSource.List;
            if (rows.Count > 0)
            {
                ComboBoxItemCollection itemsCollection = comboBox.Items;
                itemsCollection.BeginUpdate();
                try
                {
                    foreach (DataRowView item in rows)
                    {
                        itemsCollection.Add(item.Row[rowName]);
                    }

                }
                finally
                {
                    itemsCollection.EndUpdate();
                }
            }
        }

        public static void FillComboBox(ComboBoxEdit comboBox, BindingSource dataSource, string[] columns, string outputFormat)
        {
            IList rows = dataSource.List;
            if (rows.Count > 0)
            {
                ComboBoxItemCollection itemsCollection = comboBox.Properties.Items;
                itemsCollection.BeginUpdate();
                try
                {
                    foreach (DataRowView item in rows)
                    {
                        List<string> values = new List<string>();
                        foreach (string col in columns)
                        {
                            string value = item.Row[col].ToString().Trim();
                            values.Add(value);
                        }

                        itemsCollection.Add(string.Format(outputFormat, values.ToArray()));
                    }

                }
                finally
                {
                    itemsCollection.EndUpdate();
                    comboBox.SelectedIndex = 0;
                }
            }
        }

        public static void FillComboBox(ComboBoxEdit comboBox, BindingSource dataSource, string[] columns)
        {
            IList rows = dataSource.List;
            if (rows.Count > 0)
            {
                ComboBoxItemCollection itemsCollection = comboBox.Properties.Items;
                itemsCollection.BeginUpdate();
                try
                {
                    foreach (DataRowView item in rows)
                    {
                        List<string> values = new List<string>();
                        foreach (string col in columns)
                        {
                            string value = item.Row[col].ToString().Trim();
                            values.Add(value);
                        }
                        itemsCollection.Add(string.Join(" - ", values));
                    }

                }
                finally
                {
                    itemsCollection.EndUpdate();
                    SetDefaultForComboBoxEdit(comboBox);
                    comboBox.SelectedIndex = 0;
                }
            }
        }

        public static void FillComboBox(ComboBoxEdit comboBox, string[] data)
        {

            ComboBoxItemCollection itemsCollection = comboBox.Properties.Items;
            itemsCollection.BeginUpdate();
            try
            {

                foreach (string datum in data)
                {
                    itemsCollection.Add(datum);
                }
            }
            finally
            {
                itemsCollection.EndUpdate();
                SetDefaultForComboBoxEdit(comboBox);
                comboBox.SelectedIndex = 0;
            }
        }
    }
}

