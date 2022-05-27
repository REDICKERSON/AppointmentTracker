using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robert_Dickerson___InventorySystem
{
   
    public abstract class Part
    {
        //partCount should be used to create a unique part number.
        public static int partCount = 1;

        public Part(int partID, string partName, double partPrice, int partInv, int partMin, int partMax)
        {
            PartID = partID;
            Name = partName;
            InStock = partInv;
            Price = partPrice;
            Min = partMin;
            Max = partMax;

        }




        //Part Properties
        public int PartID
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








    }
}
