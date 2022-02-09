using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventoryMaintenance
{
    public static class InvItemDB
    {
        private const string Path = @"..\..\InventoryItems.dat";

        public static List<InvItem> GetItems()
        {
            //binary reader object ot read a single character or an entire field from a binary file
            BinaryReader binaryIn = new BinaryReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the list
            List<InvItem> items = new List<InvItem>();

            // Add code here to read the binary file into the List<InvItem> object.
            while(binaryIn.PeekChar() != -1)
            {
                InvItem item = new InvItem();
                item.ItemNo = binaryIn.ReadInt32();
                item.Description = binaryIn.ReadString();
                item.Price = binaryIn.ReadDecimal();
                items.Add(item);
            }
            binaryIn.Close();

            return items;
        }

        public static void SaveItems(List<InvItem> items)
        {
            // Add code here to write the List<InvItems> object to a text file.
            BinaryWriter binaryOut = new BinaryWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));

            foreach(InvItem item in items)
            {
                binaryOut.Write(item.ItemNo);
                binaryOut.Write(item.Description);
                binaryOut.Write(item.Price);
            }
            binaryOut.Close();
        }
    }
}
