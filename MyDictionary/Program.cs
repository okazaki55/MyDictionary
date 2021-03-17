using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sozcukler = new MyDictionary<int, string>();
            sozcukler.Add(1, "Elma");
            sozcukler.Add(2, "Armut");
            sozcukler.Add(3, "Portakal");
            sozcukler.Add(4, "Mandalina");
            
            Console.WriteLine(sozcukler.Count);
            sozcukler.Listele();
            
        }
    }
}
