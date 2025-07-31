using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1_C_
{
    internal class ArrayList:Array
    {
        private const int Capacity_Default = 16;
        private const double K = 2.0;

        private double k;
        private int capacity;

        public int Capasity 
        {
            get
            {
                return capacity;
            }
        }

        public ArrayList():base(0)
        {
            k=K;
            this.capacity = capacity>0?capacity:Capacity_Default;
            data=new int[this.capacity];
        }

        public ArrayList(int size, int capacity) : base(size)
        {
            k = K;
            if (capacity < size)
            {
                capacity = size;
            }
            this.capacity = capacity;
            var olddata = data;
            data = new int[capacity];
            for (int i = 0; i < size; i++)
            {
                data[i] = olddata[i];
            }
        }

        public void AddItem(int value)
        {
            if (Size >= capacity)
            {
                int newCapacity = (int)(capacity * k);
                if (newCapacity == capacity)
                {
                    newCapacity++;
                }
                int[] newData = new int[newCapacity];
                for(int i = 0;i<Size;i++)
                {
                    newData[i] = data[i];
                }
                data= newData;
                capacity = newCapacity;
            }
            data[Size] = value;
            Size++;
        }

        public void Shrink()
        {
            if(capacity > Size)
            {
                int[] newData = new int[Size];
                for(int i = 0;i < Size;i++)
                {
                    newData[i]= data[i];
                }
                data = newData;
                capacity=Size;
            }
        }
    }
}
