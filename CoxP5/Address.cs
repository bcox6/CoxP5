using System;
using System.Collections.Generic;
using System.Text;

namespace CoxP5
{
    class Address
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
