using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robert_Dickerson___InventorySystem
{
    
    public class Outsourced : Part
    {
        public Outsourced(int partID, string partName, double partPrice, int partInv, int partMin, int partMax, string companyName) : base(partID, partName, partPrice, partInv, partMin, partMax)
        {
            CompanyName = companyName;
        }

        public string CompanyName
        {
            get;
            private set;
        }


    }
}
