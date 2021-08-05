using System;
using System.Collections.Generic;
using System.Text;

namespace CoxP5
{
    class PlasticSprocket : Sprocket
    {
        public PlasticSprocket() : base()
        {

        }
        public PlasticSprocket(int itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
        {
            Calculate();
        }
        protected override void Calculate()
        {
            Price = (0.02M * NumTeeth) * NumItems;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Material: Plastic.";
        }
    }
}
