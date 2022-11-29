using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 1000; i++)
            {
                if (i.IsArmstrong())
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
