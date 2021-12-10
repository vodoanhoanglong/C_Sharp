using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Exercise
{
    public class DataSetOrder
    {
        public DataSetOrder()
        { }
        public DataSetOrder(string ProductID, string ProductName, string Unit,
            int Quantity, decimal Price)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.Unit = Unit;
            this.Quantity = Quantity;
            this.Price = Price;
        }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
