using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
using TN_CSDLPT.report;
using TN_CSDLPT.utils;

namespace TN_CSDLPT.views
{
    public partial class FormReportSubjectGradeSheet : DevExpress.XtraEditors.XtraForm
    {
        public FormReportSubjectGradeSheet()
        {
            InitializeComponent();
        }

        private void FormReportExamResult_Load(object sender, EventArgs e)
        {
            FillTableAdapters();
            Program.FillLocationCombobox(btnLocation, cbxLocation);
            Program.SetDefaultForSeNumberOfExamTimes(seNumberOfExamTimes);

            //chỉ trường mới có quyền xem trên cơ sở khác
            if (Program.mGroup == Database.ROLE_SCHOOL)
            {
                cbxLocation.Enabled = true;
            }
            else
            {
                cbxLocation.Enabled = false;
            }

            FillFormComboBoxes();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string classId = FormUtils.GetBindingSourceData(bdsClass, cbxClass.SelectedIndex, Database.TABLE_CLASS_COL_CLASS_ID).Trim();
            string subjectId = FormUtils.GetBindingSourceData(bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_ID).Trim();
            string numberOfExamTimes = seNumberOfExamTimes.Value.ToString();

            string query = DatabaseUtils.BuildQuery2(Database.SP_REPORT_SUBJECT_GRADE_SHEET_CHECK_SUBJECT_AVAILABLE_FOR_CLASS, new string[]
            {
                classId, subjectId, numberOfExamTimes
            });

            string className;
            string subjectName = FormUtils.GetBindingSourceData(bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_NAME).Trim();

            try
            {
                Program.myReader = Program.ExecSqlDataReader(query);
                Program.myReader.Read();

                classId = Program.myReader.GetString(0).Trim();
                className = Program.myReader.GetString(1).Trim();

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._scoreSheetNotFoundErrorMsg);
                return;
            }
            finally
            {
                Program.CloseSqlDataReader();
            }

            XtraReportSubjectGradeSheet xtraReportSubjectGradeSheet = new XtraReportSubjectGradeSheet(classId, subjectId, int.Parse(numberOfExamTimes));
            //xtraReportBangDiemMonHoc.xrlbTitle.Text = "BẢNG ĐIỂM MÔN " + this.comboBoxMaMonHoc.Text.Trim() + " CỦA LỚP " + tenLop;
            xtraReportSubjectGradeSheet.xrlbClass.Text = string.Format("{0} - {1}", new string[] { classId, className });
            xtraReportSubjectGradeSheet.xrlbNumberOfExamTimes.Text = numberOfExamTimes;

            //xtraReportBangDiemMonHoc.xrLabelNgayThi.Text = DateTime.Now.ToString("dd/MM/yyyy") + "cần hỏi thầy ngày là lấy ngày của gv đăng kí?";
            xtraReportSubjectGradeSheet.xrlbSubject.Text = string.Format("{0} - {1}", new string[] { subjectId, subjectName });
            //xtraReportBangDiemMonHoc.xrLabelLan.Text = this.spinEditLan.Value.ToString();

            ReportPrintTool printTool = new ReportPrintTool(xtraReportSubjectGradeSheet);
            printTool.ShowPreviewDialog();

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                FillTableAdapters();
                FillFormComboBoxes();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsRefreshErrorMsg, ex.Message));
            }

        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboboxEdit = (ComboBoxEdit)sender;
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
                    FillTableAdapters();
                    FillFormComboBoxes();
                }
            }
        }

        private void FillFormComboBoxes()
        {
            FormUtils.FillComboBox(cbxClass, this.bdsClass, new string[] { Database.TABLE_CLASS_COL_CLASS_ID, Database.TABLE_CLASS_COL_CLASS_NAME });
            FormUtils.FillComboBox(cbxSubject, this.bdsSubject, new string[] { Database.TABLE_SUBJECT_COL_SUBJECT_ID, Database.TABLE_SUBJECT_COL_SUBJECT_NAME });
        }

        private void FillTableAdapters()
        {
            DataSet.EnforceConstraints = false;
            this.tableAdapterManager.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Fill(this.DataSet.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.LOP' table. You can move, or remove it, as needed.
            this.taClass.Fill(this.DataSet.LOP);
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}