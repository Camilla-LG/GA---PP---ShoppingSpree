using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA___PP___ShoppingSpree
{
    internal class ElectronicItem : InventoryItem, ISellable
    {
        public string InsuranceInfo { get; set; }  

        public ElectronicItem(string name, int quantity, decimal price, string insuranceInfo) 
        { 
            Name = name;
            Quantity = quantity;
            Price = price;
            InsuranceInfo = insuranceInfo;

        }
        public decimal CalculateSalePrice()
        {
            return Price * 1.00m;
        }
    }
}
