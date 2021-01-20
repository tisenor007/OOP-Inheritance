using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class PLayer : GameCharacter
    {
        //public string[] inventory;
        public int score;

        public PLayer()
        {
            name = "GMAN";
            x = 10;
            y = 10;
            health = 100;
            score = 0;
        }
        public new void ShowStats()
        {
            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Health: " + health);
            //Console.WriteLine("Position X: " + x);
            //Console.WriteLine("Position Y: " + y);
            //ShowStats()
            //this.ShowStats();
            base.ShowStats();
            Console.WriteLine("Score: " + score);
            Console.WriteLine();
        }
    }
}
