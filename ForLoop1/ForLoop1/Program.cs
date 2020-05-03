using System;

namespace ForLoop1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int count;
            for (count = 0; count < 5; count = count + 1)
                Console.WriteLine("This is count: " + count);
            Console.WriteLine("Done!");
        }
    }
}

