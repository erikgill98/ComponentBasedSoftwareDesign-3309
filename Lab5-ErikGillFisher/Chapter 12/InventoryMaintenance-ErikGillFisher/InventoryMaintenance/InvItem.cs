using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{

    //referenced textbook for assignment
    public class InvItem
    {

        private int itemNo;
        private string description;
        private decimal price;

        public InvItem() { }

        //custom constructor
        public InvItem(int itemNo, string description, decimal price)
        {
            this.itemNo = itemNo;
            this.description = description;
            this.price = price;
        }

        //item property
        public int ItemNo
        {
            get
            {
                return itemNo;
            }
            set
            {
                itemNo = value;
            }

        }

        //descrption property
        public string Description
        {

            get
            {
                return description;
            }
            set
            {
                description = value;
            }

        }

        //price property
        public decimal Price
        {

            get
            {
                return price;
            }
            set
            {
                price = value;
            }

        }

        //GetDisplayText Method
        public string GetDisplayText(string sep)
        {
            return itemNo + sep + price.ToString("c") + sep + description;
        }
    }
}
