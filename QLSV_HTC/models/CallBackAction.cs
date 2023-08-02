using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN_CSDLPT.constants;

namespace TN_CSDLPT.models
{
    public class CallBackAction
    {
        public ActionMode BackAction { get; set; }
        public string query { get; set; }
        //public DataTable Table { get; set; } 

        public CallBackAction()
        {
            this.BackAction = ActionMode.None;
            this.query = null;
            ///this.Table = null;
        }

        public CallBackAction(ActionMode action, string query)
        {
            this.BackAction = action;
            this.query = query;
            ///this.Table = null;
        }

        //public CallBackAction(ActionMode action, DataTable table)
        //{
        //    this.BackAction = action;
        //    this.Table = table;
        //}

        //public void FillData(ActionMode action, DataTable table)
        //{
        //    this.BackAction = action;
        //    this.Table = table;
        //}

        //public void Reset()
        //{
        //    this.BackAction = ActionMode.None;
        //    this.Table = null;
        //}

        //public override String ToString()
        //{
        //    return "";
        //}
    }
}
