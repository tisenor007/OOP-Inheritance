using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance....");
            Console.WriteLine();

            PLayer player = new PLayer();
            Enemy enemy = new Enemy();
            //testing public, private and protected
            
            
            player.testpublic = 100; //public works, acts as expected
            //player.testprivate = 100; //private doesn't work, acts as expected
            //player.testprotected = 100;// doesn't work as expected

            player.ShowStats();
            enemy.ShowStats();

            Console.ReadKey(true);
        }
    }
}
