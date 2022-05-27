using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robert_Dickerson___InventorySystem
{
    public static class Inventory
    {
        private static BindingList<Product> products = new BindingList<Product>();
            
        public static BindingList<Product> Products
        {
            get { return products; }
            private set { products = value; }
        }
        private static BindingList<Part> allParts = new BindingList<Part>();
        public static BindingList<Part> AllParts 
        {
            get { return allParts; }
            set { allParts = value; }
        }

        // Inventory methods section
      
        public static void addProduct(Product product)
        {
            Products.Add(product);
            
        }
        
        public static bool removeProduct(int productID)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (Inventory.Products[i].ProductID == productID)
                {
                    Inventory.Products.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public static Product lookupProduct(int i)
        {
            
            
            
            return null;
        }

        public static void updateProduct(int productID, Product product)
        {
            //this method isn't used, I took care of this all on the Modifyproduct.button2_Click
        }

        public static void addPart(Part part)
        {
                AllParts.Add(part);        
          
        }

        public static void addAssociatedPart(Part part)
        {
            //Product.AssociatedParts.Add(part);
        }
        public static bool deletePart(Part part)
        {
            if (Inventory.AllParts.Contains(part))
            {
                Inventory.AllParts.Remove(part);
                return true;
            }
            
            return false;
                
        }

        public static Part lookupPart(int partID)
        {
            return null;
        }
        public static void updatePart(int index, Part part)
        {
            //this method isn't used, I took care of this all on the Modifypart.button2_Click
        }



    }



}
