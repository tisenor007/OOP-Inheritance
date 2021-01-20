using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class GameCharacter
    {
        public string name;
        public int x;
        public int y;
        public int health;

        public void ShowStats()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Position X: " + x);
            Console.WriteLine("Position Y: " + y);
            
        }


    }
}
