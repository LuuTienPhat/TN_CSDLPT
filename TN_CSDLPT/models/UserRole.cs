using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT.models
{
    public class UserRole
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public UserRole(string text, string Value)
        {
            this.Text = text;
            this.Value = Value;
        }

    }
}
