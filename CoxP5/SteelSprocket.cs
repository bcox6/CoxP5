using System;
using System.Collections.Generic;
using System.Text;

namespace CoxP5
{
    class SteelSprocket : Sprocket
    {
        public SteelSprocket() : base()
        {

        }
        public SteelSprocket(int itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
        {
            Calculate();
        }
        protected override void Calculate()
        {
            Price = 0.05M * NumTeeth * NumItems;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Material: Steel.";
        }
    }
}
