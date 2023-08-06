using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TN_CSDLPT.constants;
using TN_CSDLPT.models;

namespace TN_CSDLPT.views
{
    public partial class FormTopic : DevExpress.XtraEditors.XtraForm
    {
        //ArrayList undoCommands = new ArrayList();
        BindingList<CallBackAction> callBackActions = null;
        ///BindingList<CallBackAction> callAgainActions = null;
        //CallBackAction action;
        ActionMode mode;
        int position = -1;

        public FormTopic()
        {
            InitializeComponent();
            InitializeCallBackActions();
            //actionModes.AddingNew += new AddingNewEventHandler(listOfParts_AddingNew);
            callBackActions.ListChanged += new ListChangedEventHandler(callBackActions_ListChanged);
            //callAgainActions.ListChanged += new ListChangedEventHandler(callAgainActions_ListChanged);
            bdsTopic.ListChanged += new ListChangedEventHandler(bdsTopic_ListChanged);
        }

        private void FormTopic_Load(object sender, EventArgs e)
        {
            //chỉ có mỗi bảng bộ đề khỏi cần dòng này cũng đc, nhưng thêm vào cho chắc
            DataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.BODE' table. You can move, or remove it, as needed.
            this.taTopic.Fill(this.DataSet.BODE);

            //comboBoxCoSo.DataSource = Program.bds_DanhSachPhanManh;
            //comboBoxCoSo.DisplayMember = "TENCS";
            //comboBoxCoSo.ValueMember = "TENSERVER";
            //comboBoxCoSo.SelectedIndex = Program.indexCoSo;

            if (Program.mGroup == Database.ROLE_SCHOOL)
            {
                barEditItem1.Enabled = true;
            }
            else
            {
                barEditItem1.Enabled = false;
            }

            if (Program.mGroup == Database.ROLE_SCHOOL || Program.mGroup == Database.ROLE_STUDENT)
            {
                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
                {
                    btnNew, btnEdit, btnDelete, btnCommit, btnUndo, btnCancel
                });
            }
            else //mGroup == "GIANGVIEN", "COSO" chỉ có quyền giảng viên mới đc thao tác thêm xóa sửa bộ đề
            {
                FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
                {
                    btnNew, btnEdit, btnDelete
                });

                //Check undoCommands có rỗng không?
                //if (undoCommands.Count > 0)
                //{
                //    btnUndo.Enabled = false;
                //}
                //else
                //{
                //    btnEdit.Enabled = btnDelete.Enabled = false;
                //}
                btnCancel.Enabled = false;

                //vì lúc thêm mã giáo viên lấy từ username (mã gv) bên Program.cs, 
                //và lúc sửa thì k cho sửa mã giáo viên nốt, nên ta disable nó từ đầu
                teTeacherId.Enabled = false;
                seQuestionNo.Enabled = false;
                btnCommit.Enabled = false;

                //load danh sách môn học vào comboBox
                DataTable dt = Program.ExecSqlDataTable("EXEC SP_LAY_DS_MONHOC");
                //comboBoxMaMonHoc.DataSource = dt;
                //comboBoxMaMonHoc.DisplayMember = "MAMH";
                //comboBoxMaMonHoc.DisplayMember = "TENMH";
                //comboBoxMaMonHoc.ValueMember = "MAMH";

                FormUtils.FillComboxBox(cbxSubject, dt, "MAMH");

                cbxAnswer.Properties.Items.Add("A");
                cbxAnswer.Properties.Items.Add("B");
                cbxAnswer.Properties.Items.Add("C");
                cbxAnswer.Properties.Items.Add("D");

                cbxLevel.Properties.Items.Add("A");
                cbxLevel.Properties.Items.Add("B");
                cbxLevel.Properties.Items.Add("C");

                gcInfo.Enabled = false;
            }


        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = ActionMode.Add;
            position = bdsTopic.Position;
            gcInfo.Enabled = true;
            bdsTopic.AddNew();

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh, btnUndo
            });

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            string query = "EXEC SP_LAY_STT_CAUHOI_TIEPTHEO";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(query);
                Program.myReader.Read();
                int nextQuestionNo = Program.myReader.GetInt32(0);
                seQuestionNo.EditValue = nextQuestionNo;
                Program.myReader.Close();
                Program.databaseConnection.Close();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, $"Can't get next question number\n{ex.Message}");
                Program.myReader.Close();
                Program.databaseConnection.Close();
                return;
            }
            //mã giáo viên tạo câu hỏi là mã giáo viên đang đăng nhập
            teTeacherId.Text = Program.username;

            cbxSubject.SelectedIndex = 0;

            cbxAnswer.SelectedIndex = 0;

            cbxLevel.SelectedIndex = 0;

            gcTopic.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {

            string teacherId = FormUtils.GetBindingSourceData(bdsTopic, (int)bdsTopic.Current, "MAGV").Trim();

            if (DoesTeacherAllowToEdit(teacherId))
            {
                mode = ActionMode.Edit;
                position = bdsTopic.Position;

                string subjectId = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "MAMH");
                string level = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "TRINHDO");
                string answer = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "DAP_AN");

                //UI changed
                cbxSubject.SelectedText = subjectId;
                cbxAnswer.SelectedText = answer;
                cbxLevel.SelectedText = level;

                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
                {
                    btnNew, btnEdit, btnDelete, btnExit, btnRefresh
                });

                FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
                {
                    btnCommit, btnCancel
                });

                teTeacherId.Enabled = false;
                gcTopic.Enabled = false;
                gcInfo.Enabled = true;
            }

        }

        private void btnCommit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (mode.Equals(ActionMode.Edit))
            {
                string teacherId = teTeacherId.Text.Trim();

                string questionNo = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "CAUHOI");
                string subjectId = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "MAMH");
                string level = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "TRINHDO");
                string content = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "NOIDUNG");
                string a = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "A");
                string b = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "B");
                string c = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "C");
                string d = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "D");
                string answer = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "DAP_AN");

                string undoQuery = string.Format(Database.SP_UPDATE_TOPIC, questionNo, subjectId, level, content, a, b, c, d, answer, teacherId);
                callBackActions.Add(new CallBackAction(mode, undoQuery));

                //undoCommands.Add(undoQuery);

                if (ValidateInput())
                {

                }

            }
            else if (mode.Equals(ActionMode.Add))
            {
                if (ValidateInput())
                {

                }
            }


        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            string teacherId = FormUtils.GetBindingSourceData(bdsTopic, (int)bdsTopic.Current, "MAGV").Trim();
            if (DoesTeacherAllowToEdit(teacherId))
            {
                mode = ActionMode.Delete;
                //callBackActions.Add(mode);

                DialogResult result = CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING, $"Are you sure to delete this question No {seQuestionNo.Text}");
                if (result.Equals(DialogResult.OK))
                {
                    string questionNo = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "CAUHOI");
                    string subjectId = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "MAMH");
                    string level = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "TRINHDO");
                    string content = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "NOIDUNG");
                    string a = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "A");
                    string b = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "B");
                    string c = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "C");
                    string d = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "D");
                    string answer = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, "DAP_AN");

                    try
                    {
                        string undoQuery = string.Format(Database.SP_INSERT_TOPIC, questionNo, subjectId, level, content, a, b, c, d, answer, teacherId);
                        //undoCommands.Add(undoQuery);
                        callBackActions.Add(new CallBackAction(mode, undoQuery));

                        bdsTopic.RemoveCurrent();
                        taTopic.Connection.ConnectionString = Program.connstr;
                        taTopic.Update(DataSet.BODE);
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show(CustomMessageBox.Type.ERROR, $"Couldn't delete question\n{ex.Message}");
                        taTopic.Update(DataSet.BODE);
                        bdsTopic.Position = bdsTopic.Find("CAUHOI", questionNo);
                        return;
                    }

                    mode = ActionMode.None;

                }
            }
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            string undoQuery = callBackActions[callBackActions.Count - 1].Query;
            try
            {
                Program.myReader = Program.ExecSqlDataReader(undoQuery);
                Program.myReader.Read();

                int affectedId = Program.myReader.GetInt32(0);
                if(affectedId != -1)
                {
                    //int row = gvTopic.LocateByValue("CAUHOI", affectedId);
                    bdsTopic.Position = bdsTopic.Find("CAUHOI", affectedId);
                }
                btnRefresh.PerformClick();
                callBackActions.RemoveAt(callBackActions.Count - 1); //Remove the last action
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, $"Couldn't undo {ex.Message}");
                taTopic.Update(DataSet.BODE);
                Program.myReader.Close();
                Program.databaseConnection.Close();
                return;
            }
        }

        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            // xóa cái dòng được tạo từ bindingSource.addNew khi ấn thêm trên gridview
            if (mode.Equals(ActionMode.Add))
            {
                gvTopic.DeleteRow(gvTopic.FocusedRowHandle);
            }

            bdsTopic.CancelEdit();
            bdsTopic.Position = position;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcInfo.Visible = false;
            gcTopic.Enabled = true;

        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                bdsTopic.EndEdit();
                taTopic.Connection.ConnectionString = Program.connstr;
                taTopic.Fill(DataSet.BODE);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, $"Refresh Error: {ex.Message}");
            }
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnHelp_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void cbxLocation_EditValueChanged(object sender, EventArgs e)
        {
            cbxLocation.Items.Add("CS1");
            cbxLocation.Items.Add("CS2");
        }

        private bool DoesTeacherAllowToEdit(string teacherId)
        {
            bool doesTeacherAllowToEdit = false;
            if (!teacherId.Equals(Program.username))
            {
                doesTeacherAllowToEdit = false;
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    $"Coudn't modify question of other teacher!");
            }
            return doesTeacherAllowToEdit;
        }

        private bool ValidateInput()
        {
            bool isValidated = true;
            if (teQuestion.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Question"));
                isValidated = false;
                return isValidated;
            }

            if (teAnswerA.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Answer A"));
                isValidated = false;
                return isValidated;
            }
            if (teAnswerB.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Answer B"));
                isValidated = false;
                return isValidated;
            }
            if (teAnswerC.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Answer C"));
                isValidated = false;
                return isValidated;
            }
            if (teAnswerD.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Answer D"));
                isValidated = false;
                return isValidated;
            }
            return isValidated;
        }

        private void callBackActions_ListChanged(object sender, ListChangedEventArgs e)
        {
            //MessageBox.Show(e.ListChangedType.ToString());
            if (callBackActions.Count == 0)
            {
                btnUndo.Enabled = false;
            }
            else
            {
                btnUndo.Enabled = true;
            }
        }

        //void callAgainActions_ListChanged(object sender, ListChangedEventArgs e)
        //{
        //    //MessageBox.Show(e.ListChangedType.ToString());
        //    if (callAgainActions.Count == 0)
        //    {
        //        btnUndo.Enabled = false;
        //    }
        //    else
        //    {
        //        btnUndo.Enabled = true;
        //    }
        //}

        void bdsTopic_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (bdsTopic.Count == 0)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void InitializeCallBackActions()
        {
            // Create the new BindingList of Part type.
            callBackActions = new BindingList<CallBackAction>();
            //callAgainActions = new BindingList<CallBackAction>();

            // Allow new parts to be added, but not removed once committed.        
            //actionModes.AllowNew = true;
            //actionModes.AllowRemove = false;

            // Raise ListChanged events when new parts are added.
            callBackActions.RaiseListChangedEvents = true;
            //callAgainActions.RaiseListChangedEvents = true;

            // Do not allow parts to be edited.
            //actionModes.AllowEdit = false;

            // Add a couple of parts to the list.
            //actionModes.Add(new Part("Widget", 1234));
            //actionModes.Add(new Part("Gadget", 5647));
        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            comboBox.SelectedIndex = 0;
            comboBox.EditValue = 5;
            
        }
    }
}

public class NameList : ObservableCollection<PersonName>
{
    public NameList() : base()
    {
        Add(new PersonName("Willa", "Cather"));
        Add(new PersonName("Isak", "Dinesen"));
        Add(new PersonName("Victor", "Hugo"));
        Add(new PersonName("Jules", "Verne"));
    }


}

public class PersonName
{
    private string firstName;
    private string lastName;

    public PersonName(string first, string last)
    {
        this.firstName = first;
        this.lastName = last;
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
}