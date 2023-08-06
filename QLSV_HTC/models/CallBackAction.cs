using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN_CSDLPT.constants;

namespace TN_CSDLPT.models
{
    public class CallBackAction
    {
        public Hashtable Reference { get; set; } = new Hashtable();
        public ActionMode BackAction { get; set; }
        public string Query { get; set; }
        //public DataTable Table { get; set; } 

        public CallBackAction()
        {
            this.BackAction = ActionMode.None;
            this.Query = null;
            this.Reference = new Hashtable();
            ///this.Table = null;
        }

        public CallBackAction(ActionMode action, string query)
        {
            this.BackAction = action;
            this.Query = query;
            this.Reference = new Hashtable();
            ///this.Table = null;
        }
        public CallBackAction(ActionMode action, string query, Hashtable hashtable)
        {
            this.BackAction = action;
            this.Query = query;
            this.Reference = hashtable;
            ///this.Table = null;
        }
    }
}
