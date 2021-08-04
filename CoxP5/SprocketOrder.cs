using System;
using System.Collections.Generic;
using System.Text;

namespace CoxP5
{
    class SprocketOrder
    {
        private List<Sprocket> items { get; set; }
        public Address Address { get; set; }
        public string CustomerName { get; set; }
        public List<Sprocket> Items { get { return items; } }
        public decimal TotalPrice { get; set; }

        public SprocketOrder():this(new Address(),"",new List<Sprocket>(), 0)
        {

        }
        public SprocketOrder(Address address, string customerName, List<Sprocket> items, decimal totalPrice)
        {
            Address = address;
            CustomerName = customerName;
            this.items = items;
            TotalPrice = totalPrice;
        }

        public void Add()
        {

        }
        public void Calculate()
        {

        }
        public void Remove()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
