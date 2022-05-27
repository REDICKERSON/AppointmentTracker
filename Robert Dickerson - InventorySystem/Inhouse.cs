using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robert_Dickerson___InventorySystem
{
    
    public class Inhouse : Part
    {
        public Inhouse(int partID, string partName, double partPrice, int partInv, int partMin, int partMax, int machineID) : base(partID, partName, partPrice, partInv, partMin, partMax)
        {
            MachineID = machineID;
        }

        public int MachineID
        {
            get;
            private set;
        }


    }
}
