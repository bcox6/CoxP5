using System;
using System.Collections.Generic;
using System.Text;

namespace CoxP5
{
    class AluminumSprocket : Sprocket
    {
        public AluminumSprocket() : base()
        {

        }
        public AluminumSprocket(int itemID, int numItems, int numTeeth):base(itemID, numItems, numTeeth)
        {
            Calculate();
        }
        protected override void Calculate()
        {
            Price = 0.04M * NumTeeth * NumItems;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Material: Aluminum.";
        }
    }
}
