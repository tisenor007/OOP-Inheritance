using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class GameCharacter
    {
        public string name;
        public int x;
        public int y;
        public int health;

        
        //can be accessed anywhere
        public int testpublic;
        //can't be accessed anywhere except for main class heiarchy
        private int testprivate;
        //can be only be accessed inside class heirachy
        protected int testprotected;

        
        
        public void ShowStats()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Position X: " + x);
            Console.WriteLine("Position Y: " + y);

            //only will work in class hieracrhy
            testprivate = 100;
            
        }


    }
}
