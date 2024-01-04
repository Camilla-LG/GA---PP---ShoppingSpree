using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA___PP___ShoppingSpree
{
    internal class ClothingItem : InventoryItem, ISellable
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public ClothingItem(string name, int quantity, decimal price, string size, string color )
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Size = size;
            Color = color;
        }

        public decimal CalculateSalePrice()
        {
            return Price * 1.00m;
        }
    }
}
