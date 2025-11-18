using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Models
{
    public class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();
        public static int AutoPartID { get; set; } = 0;
        public static int AutoProductID { get; set; } = 0;


        public static void AddProduct(Product product)
        {
            Products.Add(product);
            product.ProductID = AutoProductID;
            AutoProductID++;
        }

        public static bool RemoveProduct(int productID)
        {
            Product? product = LookupProduct(productID);

            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            return false;
        }

        public static Product? LookupProduct(int productID)
        {
            foreach (var product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }

        public static void UpdateProduct(int index, Product newProduct)
        {
            if (index >= 0 && index < Products.Count)
            {
                Products[index] = newProduct;
            }
        }
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
            part.PartID = AutoPartID;
            AutoPartID++;
        }

        public static bool DeletePart(Part part)
        {
            if (part != null)
            {
                AllParts.Remove(part);
                return true;
            }
            return false;
        }

        public static Part? LookupPart(int partID)
        {
            foreach (var part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public static void UpdatePart(int index, Part newPart)
        {
            if (index >= 0 && index < AllParts.Count)
            {
                AllParts[index] = newPart;
            }
        }
    }
}
