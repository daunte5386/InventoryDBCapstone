using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDBApp
{
    class Inventory
    {
        private string make, model, serialNumber;

        public Inventory()
        {
        }

        public Inventory(string ma, string mo, string serNum)
        {
            make = ma;
            model = mo;
            serialNumber = serNum;
        }

        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }

            set
            {
                serialNumber = value;
            }
        }

        public override string ToString()
        {
            return "Computer Make: " + make +
                   "\nComputer Model: " + model +
                   "\nComputer Serial Number: " + serialNumber;
        }
    }
}
