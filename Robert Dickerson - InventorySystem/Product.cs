using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robert_Dickerson___InventorySystem
{

  
    public class Product
    {
        public static int productCount = 1;       
        public Product(int pID, string pName, double pPrice, int pInv, int pMin, int pMax, BindingList<Part> associatedParts)
        {
            ProductID = pID;
            Name = pName;
            InStock = pInv;
            Price = pPrice;
            Min = pMin;
            Max = pMax;
            this.associatedParts = associatedParts;
        }





        //Product Properties

        /*public BindingList<Part> AssociatedParts
         {
             get;

             private set;
         }*/
        private static BindingList<Part> tempModList = new BindingList<Part>();
        public static BindingList<Part> TempModList
        {
            get { return tempModList; }
            set { tempModList = value; }
        }
        private BindingList<Part> associatedParts = new BindingList<Part>();
        public BindingList<Part> AssociatedParts
        {
            get { return associatedParts; }
            set { associatedParts = value; }
        }

        public int ProductID
        {
            get;

            private set;
        }

        public string Name
        {
            get;

            private set;
        }

        public double Price 
        { 
            get; 
            
            private set; 
        }

        public int InStock
        {
            get;

            private set;
        }

        public int Min
        {
            get;

            private set;
        }

        public int Max
        {
            get;

            private set;
        }

        //Product Methods


        public void addAssociatedPart(Part partID)
        {
            //This method is unused. I took care of this functionality on the AddProduct.button2_Click
        }

        public bool removeAssoicatedPart(int partID)
        {
            return true;
        }

        public Part lookupAssoicatedPart(int partID)
        {
            return null;
        }


    }
}
