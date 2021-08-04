using System;
using System.Collections.Generic;
using System.Text;

namespace CoxP5
{
    abstract class Sprocket
    {
        private decimal _price { get; set; }
        private int _itemId { get; set; }
        public decimal Price { get { return _price; } }
        public int ItemID { get { return _itemId; } }
        public int NumTeeth { get; set; }
        public int NumItems { get; set; }
        protected abstract void Calculate();
        public Sprocket():this(0, 0, 0)
        {

        }
        public Sprocket(int itemID, int numItems, int numTeeth)
        {

        }
        public override string ToString()
        {
            return $"ItemID: {ItemID} Num Items: {NumItems} Num Teeth: {NumTeeth} Total Price: {Price}";
        }

    }
}
