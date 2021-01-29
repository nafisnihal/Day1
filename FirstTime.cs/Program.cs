using System;

namespace FirstTime.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            for(int i=5; i>=0; i--)
            {
                for (int k=0; k<=i; k++)
                {
                    Console.Write(" ");
                }
                name += "*";
                Console.Write(name);
                Console.WriteLine();
            }
            
        }
    }
}
