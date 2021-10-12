using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõne "Hello world!" pikkust length omaduse kasutamata
            string helloW = "Hello world!";
            int charcounter = 0;
            foreach (char c in helloW)
            {
                charcounter++;

            }
            Console.WriteLine($"Lause pikkus {helloW} on {charcounter} sümbolit.");
        }
    }
    
}
