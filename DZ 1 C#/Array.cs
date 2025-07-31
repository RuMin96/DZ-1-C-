using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1_C_
{
    internal class Array
    {
        protected int[] data;
        const int size = 10;

        public int Size 
        { 
          get;
          protected set; 
        }

        public Array()
        {
            Size = size;
            data = new int[Size];
        }

        public Array(int n)
        {
           Size = n;
           data = new int[Size];
        }

        public Array(int n, int value)
        {
            Size = n;
            data = new int[Size];
            SetValue(value);
        }

        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write(data[i]+"");
                Console.WriteLine();
            }
        }

        public int GetItem(int index)
        {
          return data[index];
        }

        public int SetItem(int index, int value)
        {
            data[index] = value;
            return value;
        }

        public void SetValue(int value)
        {
            for(int i = 0;i < Size;i++)
            {
                data[i] = value;
            }
        }
    }
}
