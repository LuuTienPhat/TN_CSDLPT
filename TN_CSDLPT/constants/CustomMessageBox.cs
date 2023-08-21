using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace TN_CSDLPT.constants
{
    public class CustomMessageBox
    {

        public enum Type
        {
            WARNING,
            ERROR,
            INFORMATION,
            QUESTION_WARNING,
            QUESTION_INFORMATION,
            QUESTION_ERROR
        }

        public static DialogResult Show(Type type, string title, string msg)
        {
            DialogResult dialogResult = DialogResult.None;
            switch (type)
            {
                case Type.WARNING:
                    dialogResult =  XtraMessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);                  
                    break;
                case Type.ERROR:
                    dialogResult = XtraMessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Type.INFORMATION:
                    dialogResult = XtraMessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Type.QUESTION_WARNING:
                    dialogResult = XtraMessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    break;
                case Type.QUESTION_INFORMATION:
                    dialogResult = XtraMessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    break;
            }

            return dialogResult;
        }

        public static DialogResult Show(Type type, string msg)
        {
            DialogResult dialogResult = DialogResult.None;
            switch (type)
            {
                case Type.WARNING:
                    dialogResult = XtraMessageBox.Show(msg, Translation._warningTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Type.ERROR:
                    dialogResult = XtraMessageBox.Show(msg, Translation._errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Type.INFORMATION:
                    dialogResult = XtraMessageBox.Show(msg, Translation._infomationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Type.QUESTION_WARNING:
                    dialogResult = XtraMessageBox.Show(msg, Translation._warningTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    break;
                case Type.QUESTION_INFORMATION:
                    dialogResult = XtraMessageBox.Show(msg, Translation._infomationTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    break;
                case Type.QUESTION_ERROR:
                    dialogResult = XtraMessageBox.Show(msg, Translation._errorTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    break;
            }

            return dialogResult;
        }
    }
}
