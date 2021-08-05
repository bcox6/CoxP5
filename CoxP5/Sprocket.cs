using System;
using System.Collections.Generic;
using System.Text;

namespace CoxP5
{
    public abstract class Sprocket
    {
        private int _itemId { get; set; }
        public decimal Price { get; set; }
        public int ItemID { get { return _itemId; } }
        public int NumTeeth { get; set; }
        public int NumItems { get; set; }
        protected abstract void Calculate();
        public Sprocket():this(0, 0, 0)
        {

        }
        public Sprocket(int itemID, int numItems, int numTeeth)
        {
            _itemId = itemID;
            NumItems = numItems;
            NumTeeth = numTeeth;

        }
        public override string ToString()
        {
            return $"ItemID: {ItemID} Num Items: {NumItems} Num Teeth: {NumTeeth} Total Price: ${Price.ToString("N0")}";
        }


    }
}
