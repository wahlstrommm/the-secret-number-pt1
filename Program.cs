using System;

namespace Det_hemliga_talet__del_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomerare = new Random(); //random randomerare
            int slump_tal = randomerare.Next(1, 101); // detta ger oss ett tal mellan 1-100 ett slumpmässigt sådant.
            Console.WriteLine(slump_tal); // skriver ut det slumpmässiga talet.
            Console.ReadKey();//så progammet inte stängs ner.
        }
    }
}
