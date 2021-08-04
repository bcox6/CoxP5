using System;
using System.Collections.Generic;
using System.Text;

namespace CoxP5
{
    class AluminumSprocket : Sprocket
    {
        protected override void Calculate()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Material: Aluminum {base.ToString()}";
        }
    }
}
