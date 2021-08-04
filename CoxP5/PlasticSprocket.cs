using System;
using System.Collections.Generic;
using System.Text;

namespace CoxP5
{
    class PlasticSprocket : Sprocket
    {
        protected override void Calculate()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Material: Plastic {base.ToString()}";
        }
    }
}
