using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Test
{
    class LinkedList
    {
        private class ListItem
        {
            public object Item { get; }
            public ListItem Next { get; set; }
            public ListItem (object o)
            {
            }
            public override string ToString()
            {
                return base.ToString();
            }
        }

        private ListItem firstItem = null;

        private ListItem lastItem = null;

        private int itemCount = 0;
        public object First
        {
            get
            {
                return firstItem;
            }
        }
        public object Last
        {
            get
            {
                return lastItem;
            }
        }
        public int Count
        {
            get
            {
                return itemCount;
            }
        }

        public object Items(int Index)
        {
            return null;
        }
        public void InsertFirst(object o)
        {
            ListItem newFirstItem = new ListItem(o);
            if (itemCount == 0)
            {
                lastItem = newFirstItem;
            }
            else
            {
                newFirstItem.Next = firstItem;
            }
            firstItem = newFirstItem;
        }
        public void InsertLast(object o)
        {
            ListItem newLastItem = new ListItem(o);
            lastItem.Next = newLastItem;
            lastItem = newLastItem;
        }
        public void RemoveAt(int Index)
        {
            return null;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    } 
}
