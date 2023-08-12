using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TN_CSDLPT.constants;
using TN_CSDLPT.models;

namespace TN_CSDLPT.views
{
    public partial class FormTeacherRegistration : DevExpress.XtraEditors.XtraForm
    {
        int position = -1;
        ActionMode mode = ActionMode.None;
        BindingList<CallBackAction> callBackActions = new BindingList<CallBackAction>();
        
        public FormTeacherRegistration()
        {
            InitializeComponent();
            InitializeCallBackActions();
        }

        private void FormTestPreparation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.taTeacher_Registration.Fill(this.DataSet.GIAOVIEN_DANGKY);

            Program.FillLocationCombobox(btnLocation, cbxLocation);


            if (((Program.mGroup == Database.ROLE_SCHOOL) || (Program.mGroup == Database.ROLE_TEACHER)) || (Program.mGroup == Database.ROLE_STUDENT))
            {
                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                    btnNew, btnEdit, btnDelete, btnCommit, btnUndo, btnCancel
                });
            }
            else if (Program.mGroup == Database.ROLE_LOCATION)
            {

                FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem> {
                    btnNew, btnEdit, btnDelete, btnCommit
                });

                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                   btnCancel
                });
            }
            gcInfo.Enabled = false;
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = ActionMode.Add;
            bdsTeacher_Registration.AddNew();

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh, btnUndo
            });

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcInfo.Enabled = true;
            gcTeacher_Registration.Enabled = true;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = ActionMode.Edit;

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh, btnUndo
            });

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcInfo.Enabled = true;
            gcTeacher_Registration.Enabled = false;
        }

        private void btnCommit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                mode = ActionMode.Refresh;
                tableAdapterManager.Connection.ConnectionString = Program.connstr;
                this.taTeacher_Registration.Fill(this.DataSet.GIAOVIEN_DANGKY);
                this.bdsTeacher_Registration.Position = this.position;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsRefreshErrorMsg, ex.Message));
            }
            finally
            {
                mode = ActionMode.None;
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void InitializeCallBackActions()
        {
            callBackActions = new BindingList<CallBackAction>();
            callBackActions.RaiseListChangedEvents = true;
            callBackActions.ListChanged += new ListChangedEventHandler(callBackActions_ListChanged);
            bdsTeacher_Registration.ListChanged += new ListChangedEventHandler(bdsTeacher_Registration_ListChanged);
            callBackActions_ListChanged(null, null);
            bdsTeacher_Registration_ListChanged(null, null);
        }

        private void bdsTeacher_Registration_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (bdsTeacher_Registration.Count == 0)
            {
                btnDelete.Enabled = btnEdit.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = btnEdit.Enabled = true;
            }
        }

        private void callBackActions_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnUndo.Enabled = callBackActions.Count != 0;
        }

        private void gvTeacher_Registration_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!mode.Equals(ActionMode.Refresh))
            {
                this.position = bdsTeacher_Registration.Position;
            }
        }
    }
}