using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Models
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>(); 
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock {  get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product() { }

        public Product( string name, decimal price, int inStock, int min, int max)
        {
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            var part = LookupAssociatedPart(partID);
            if (part != null)
            {
                AssociatedParts.Remove(part);
                return true;
            }
            return false;
        }

        public Part? LookupAssociatedPart(int partID)
        {
            foreach (var p in AssociatedParts)
            {
                if (p.PartID == partID)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
