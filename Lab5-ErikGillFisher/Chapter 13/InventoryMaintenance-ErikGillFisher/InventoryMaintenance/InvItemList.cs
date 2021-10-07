using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InvItemList
    {
        //referenced textbook for assignment
        private List<InvItem> invItems;

        //delgeate add
        public delegate void ChangeHandler(InvItemList invItems);
        //event change
        public event ChangeHandler Changed;

        public InvItemList()
        {
            invItems = new List<InvItem>();
        }

        public int Count => invItems.Count;

        /*
        Delete the GetItemByIndex method from the InvItemList class, and replace it with an indexer that receives an int value

        public InvItem GetItemByIndex(int i) => invItems[i];
        */

        //added code
        public InvItem this[int i]
        {
            get
            {
                if (i < 0 || i > invItems.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return invItems[i];
            }
            set
            {
                invItems[i] = value;
                Changed(this);
            }
        }

        //public void Add(InvItem invItem) => invItems.Add(invItem);

        public void Add(int itemNo, string description, decimal price)
        {
            InvItem i = new InvItem(itemNo, description, price);
            invItems.Add(i);
            Changed(this);
        }

        public void Remove(InvItem invItem)
        {
            invItems.Remove(invItem);
            Changed(this);
        }

        public void Fill() => invItems = InvItemDB.GetItems();

        public void Save() => InvItemDB.SaveItems(invItems);

        public void Add(InvItem invItem)
        {
            invItems.Add(invItem);
            Changed(this);
        }

        //+ and - operators
        public static InvItemList operator +(InvItemList i1, InvItem i)
        {
            i1.Add(i);
            return i1;
        }
        public static InvItemList operator -(InvItemList i1, InvItem i)
        {

            i1.Remove(i);
            return i1;

        }
    }
}
