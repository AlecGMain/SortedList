using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class SortedList
    {
        Node<int> Head;
        public int Count;
        public SortedList(int value)
        {
            Head = new Node<int>(value);
            Count = 1;
        }
        public SortedList()
        {
            Head = new Node<int>();
            Count = 0;
        }
        public void Add(int value)
        {
            if (Count == 0)
            {
                Head.Value = value;
            }
            else
            {
                for (int i = 0; i <= Count; i++)
                {
                    if(i = Count)
                }
            }
        }
    }
}
