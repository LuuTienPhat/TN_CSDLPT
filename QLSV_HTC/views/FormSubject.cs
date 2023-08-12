using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using TN_CSDLPT.constants;
using TN_CSDLPT.models;
using TN_CSDLPT.utils;
using TracNghiem_CSDLPT.Share;
using TracNghiem_CSDLPT.SupportForm;

namespace TN_CSDLPT.views
{
    public partial class FormSubject : DevExpress.XtraEditors.XtraForm
    {
        int position = -1;
        ActionMode mode = ActionMode.None;
        BindingList<CallBackAction> callBackActions = new BindingList<CallBackAction>();

        public FormSubject()
        {
            InitializeComponent();
            InitializeCallBackActions();
        }

        private void FormSubject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'this.DataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.taTeacher_Register.Fill(this.DataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'this.DataSet.BODE' table. You can move, or remove it, as needed.
            this.taTopic.Fill(this.DataSet.BODE);
            // TODO: This line of code loads data into the 'this.DataSet.BANGDIEM' table. You can move, or remove it, as needed.
            this.taScore.Fill(this.DataSet.BANGDIEM);
            // TODO: This line of code loads data into the 'this.DataSet.COSO' table. You can move, or remove it, as needed.
            this.taLocation.Fill(this.DataSet.COSO);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODthis.DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Fill(this.DataSet.MONHOC);

            Program.FillLocationCombobox(btnLocation, cbxLocation);

            if (Program.mGroup == Database.ROLE_SCHOOL)
            {
                btnLocation.Enabled = true;
            }
            else
            {
                btnLocation.Enabled = false;
            }

            if (((Program.mGroup == Database.ROLE_SCHOOL) || (Program.mGroup == Database.ROLE_TEACHER)) || (Program.mGroup == Database.ROLE_STUDENT))
            {
                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                    btnNew, btnEdit, btnDelete, btnCommit, btnUndo, btnCancel
                });
            }
            else
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

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            mode = ActionMode.Add;
            //position = this.bdsSubject.Position;
            this.bdsSubject.AddNew();

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh, btnUndo
            });

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcInfo.Enabled = true;
            gcSubject.Enabled = true;
            teID.Enabled = true;
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            mode = ActionMode.Edit;
            //position = this.bdsSubject.Position;

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh, btnUndo
            });

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcInfo.Enabled = true;
            teID.Enabled = false;
            gcSubject.Enabled = false;
        }

        private void btnCommit_ItemClick(object sender, ItemClickEventArgs e)
        {
            string oldSujectId = FormUtils.GetBindingSourceData(this.bdsSubject, this.bdsSubject.Position, Database.TABLE_SUBJECT_COL_SUBJECT_ID);
            string oldSubjectName = FormUtils.GetBindingSourceData(this.bdsSubject, this.bdsSubject.Position, Database.TABLE_SUBJECT_COL_SUBJECT_NAME);
            if (mode.Equals(ActionMode.Edit))
            {
                if (ValidateInput())
                {
                    CommitDB();
                    string[] args = new string[] { oldSujectId, oldSubjectName };
                    callBackActions.Add(
                        new CallBackAction(mode, DatabaseUtils.BuildQuery(Database.SP_UPDATE_SUBJECT, args)));
                }
                else
                {
                    return;
                }
            }
            if (mode.Equals(ActionMode.Add))
            {
                if (ValidateInput())
                {
                    CommitDB();
                    Hashtable refs = new Hashtable();
                    refs.Add(Database.TABLE_SUBJECT_COL_SUBJECT_ID, oldSujectId);
                    string[] args = new string[] { oldSujectId };
                    callBackActions.Add(
                        new CallBackAction(
                            mode,
                            DatabaseUtils.BuildQuery(Database.SP_DELETE_STUDENT, args),
                            refs
                        ));
                }
                else
                {
                    return;
                }
            }

            mode = ActionMode.None;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcInfo.Enabled = false;
            gcSubject.Enabled = true;
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            mode = ActionMode.Delete;
            string subjectId = FormUtils.GetBindingSourceData(this.bdsSubject, this.bdsSubject.Position, Database.TABLE_SUBJECT_COL_SUBJECT_ID);

            if (CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING,
                string.Format(Translation._argsDeleteWarningMsg, $"Subject {subjectId}")) == DialogResult.OK)
            {
                if (bdsScore.Count <= 0)
                {
                    if (bdsTopic.Count <= 0)
                    {
                        if (bdsTeacher_Register.Count <= 0)
                        {
                            try
                            {
                                string subjectName = FormUtils.GetBindingSourceData(this.bdsSubject, this.bdsSubject.Position, Database.TABLE_SUBJECT_COL_SUBJECT_NAME);
                                this.bdsSubject.RemoveCurrent();
                                this.taSubject.Connection.ConnectionString = Program.connstr;
                                this.taSubject.Update(this.DataSet.MONHOC);
                                string[] args = new string[] { subjectId, subjectName };
                                callBackActions.Add(
                                    new CallBackAction(
                                        mode,
                                        DatabaseUtils.BuildQuery(Database.SP_INSERT_SUBJECT, args)
                                    ));
                            }
                            catch (Exception ex)
                            {
                                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsDeleteErrorMsg, ex.Message));
                                this.taSubject.Update(this.DataSet.MONHOC);
                                this.bdsSubject.Position = this.bdsSubject.Find(Database.TABLE_SUBJECT_COL_SUBJECT_NAME, subjectId);
                                return;
                            }
                            mode = ActionMode.None;
                        }
                        else
                        {
                            CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION, Translation._subjectAlreadyHasTeacherMsg);
                        }
                    }
                    else
                    {
                        CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION, Translation._subjectAlreadyHasTopic);
                    }
                }
                else
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION, Translation._subjectAlreadyHasScoreList);
                }
            }
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            CallBackAction action = callBackActions[callBackActions.Count - 1];
            if (action.BackAction.Equals(ActionMode.Add))
            {
                string subjectId = action.Reference[Database.TABLE_SUBJECT_COL_SUBJECT_ID].ToString();
                if (CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING, string.Format(Translation._argsDeleteWarningMsg, $"Subject {subjectId}")) == DialogResult.OK)
                {
                    try
                    {
                        Program.myReader = Program.ExecSqlDataReader(action.Query);
                        Program.myReader.Read();
                        string key = "";
                        key = Program.myReader.GetString(0).Trim();
                        Program.myReader.Close();
                        Program.databaseConnection.Close();
                        btnRefresh.PerformClick();
                        if (key.Length != 0)
                        {
                            this.bdsSubject.Position = this.bdsSubject.Find(Database.TABLE_SUBJECT_COL_SUBJECT_ID, key);
                        }
                        callBackActions.RemoveAt(callBackActions.Count - 1);
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsUndoErrorMsg, ex.Message));
                        this.taSubject.Update(this.DataSet.MONHOC);
                        Program.myReader.Close();
                        Program.databaseConnection.Close();
                    }
                }
            }
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (mode.Equals(ActionMode.Add))
            {
                gvSubject.DeleteRow(gvSubject.FocusedRowHandle);
            }
            this.bdsSubject.CancelEdit();
            this.bdsSubject.Position = position;
            gcInfo.Enabled = false;
            gcSubject.Enabled = true;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                mode = ActionMode.Refresh;
                tableAdapterManager.Connection.ConnectionString = Program.connstr;
                this.taSubject.Fill(this.DataSet.MONHOC);
                this.bdsSubject.Position = this.position;
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

        private bool ValidateInput()
        {
            bool validated = true;
            if (teID.Text.Trim().Length == 0)
            {
                //teID.ErrorText = string.Format(Translation._argsNotEmptyMsg, Translation._idLabel);
                validated = false;
            }
            if (teName.Text.Trim().Length == 0)
            {
                //teName.ErrorText = string.Format(Translation._argsNotEmptyMsg, Translation._nameLabel);
                validated = false;
            }
            return validated;
        }

        private void FillTable()
        {
            this.DataSet.EnforceConstraints = false;
            this.taSubject.Connection.ConnectionString = Program.connstr;
            this.taSubject.Fill(this.DataSet.MONHOC);
        }

        private void CommitDB()
        {
            try
            {
                this.bdsSubject.EndEdit();
                this.bdsSubject.ResetCurrentItem();
                this.taSubject.Connection.ConnectionString = Program.connstr;
                this.taSubject.Update(this.DataSet.MONHOC);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsCommitErrorMsg, ex.Message));
                this.taSubject.Update(this.DataSet);
            }
        }

        private void InitializeCallBackActions()
        {
            callBackActions = new BindingList<CallBackAction>();
            callBackActions.RaiseListChangedEvents = true;
            callBackActions.ListChanged += new ListChangedEventHandler(callBackActions_ListChanged);
            this.bdsSubject.ListChanged += new ListChangedEventHandler(bdsSubject_ListChanged);
            callBackActions_ListChanged(null, null);
            bdsSubject_ListChanged(null, null);
        }

        private void bdsSubject_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (this.bdsSubject.Count == 0)
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

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboboxEdit = (ComboBoxEdit)sender;
            object editValue = comboboxEdit.EditValue;
            if (comboboxEdit.SelectedItem.ToString() != "System.Data.DataRowView")
            {
                Program.servername = FormUtils.GetBindingSourceData(Program.bdsSubcriber, comboboxEdit.SelectedIndex, Database.VIEW_ALL_LOCATION_COL_LOCATION_SERVER);
                if (comboboxEdit.SelectedIndex != Program.indexCoSo)
                {
                    Program.mlogin = Program.remoteLogin;
                    Program.password = Program.remotePassword;
                }
                else
                {
                    Program.mlogin = Program.mLoginDN;
                    Program.password = Program.passwordDN;
                }
                if (!Program.ConnectDatabase())
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsDatabaseConnectErrorMsg, comboboxEdit.SelectedText));
                }
                else
                {
                    this.DataSet.EnforceConstraints = false;

                    this.taSubject.Connection.ConnectionString = Program.connstr;
                    this.taSubject.Fill(this.DataSet.MONHOC);

                    this.taScore.Connection.ConnectionString = Program.connstr;
                    this.taScore.Fill(this.DataSet.BANGDIEM);

                    this.taTopic.Connection.ConnectionString = Program.connstr;
                    this.taTopic.Fill(this.DataSet.BODE);

                    this.taTeacher_Register.Connection.ConnectionString = Program.connstr;
                    this.taTeacher_Register.Fill(this.DataSet.GIAOVIEN_DANGKY);
                }
            }
        }

        private void gvSubject_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!mode.Equals(ActionMode.Refresh))
            {
                this.position = this.bdsSubject.Position;
            }
        }
    }
}