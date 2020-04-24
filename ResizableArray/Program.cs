using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            ResizableArray<int> myArray = new ResizableArray<int>();
            Console.WriteLine("==Filling array==");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Adding element: " + i);
                myArray.Add(i);
                Console.WriteLine("Capacity: " + myArray.Capacity);
                Console.WriteLine("Size: " + myArray.Size);
            }
            myArray[10] = 10;
            myArray[9] = 20;
            for (int i = 0; i < myArray.Size; i++)
            {
                Console.WriteLine("myArray[" + i + "] = " + myArray[i]);
            }
            try
            {
                int tooLargeIndex = myArray[100];
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
           
        }
    }
}
