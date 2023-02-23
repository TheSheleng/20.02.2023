using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var card = new Card.Card(500, 123123123, "Test Testovich", new DateTime(2030, 12, 12), 1234);
            card.OnNotify += s => Console.WriteLine(s);
            card.SetPin(4321);
            card.TakeOff(300);
            card.TopUp(800);
            Console.WriteLine($"Cash: {card.Cash}");
        }
    }
}
