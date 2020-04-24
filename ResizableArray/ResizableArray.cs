using System;
using System.Collections.Generic;
using System.Text;

namespace zad2
{
    class ResizableArray<Type>
    {
        private Type[] array;
        private int size;
        public ResizableArray()
        {
            this.array = new Type[1];
            this.size = 0;
        }
        public Type this[int i]
        {
            get
            {
                if (i <= this.size && i >= 0)
                {
                    return this.array[i];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range, given index: " + i + ", array size: " + this.size);
                }
            }
            set
            {
                if (i > this.size)
                {
                    if (i > this.array.Length)
                    {
                        Array.Resize(ref this.array, i + 1);
                    }
                    this.size = i + 1;
                }
                this.array[i] = value;
            }
        }
        public int Size { get => size; }
        public int Capacity { get => this.array.Length; }
        public void Add(Type elem)
        {
            if (this.size == this.array.Length)
            {
                Array.Resize(ref this.array, this.array.Length * 2);
            }
            this.array[this.size++] = elem;
        }
    }
}
