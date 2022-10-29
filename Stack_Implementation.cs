using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Stack_Implementation
    {
        public class StackImp
        {
            protected int[] data;
            private static int Data_Size = 10;
            int pointer = -1;
            public StackImp(int size)
            {
                this.data = new int[size];
            }
            public Boolean isEmpty()
            {
                return pointer == -1;
            }
            public Boolean isFull()
            {
                return pointer == data.Length - 1;
            }
            public Boolean Push(int item)
            {
                if (isEmpty())
                {
                    return true;
                }
                pointer++;
                data[pointer] = item;
                return true;
            }
            public int Pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack Is Already Empty");
                }
                int removed  = data[pointer];
                pointer--;
                return removed; 
            }
            public int peek()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack Is Already Empty");
                }
                return data.Length - 1;
            }
                        
        }
        static void main(string[] args)
        {
            StackImp st = new StackImp(6);
            st.Push(4);
            st.Push(5);
            st.Push(6);
            st.Push(7);
            st.Push(8);
            st.Push(9);
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
        }
    }
}
