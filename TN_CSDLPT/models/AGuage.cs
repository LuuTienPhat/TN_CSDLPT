using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT.models
{
    public class AGuage
    {
        private float _value;

        public float Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
                this.ValueChanged(this._value);
            }
        }

        public void ValueChanged(float newValue)
        {

        }
    }
}
