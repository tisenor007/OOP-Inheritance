using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Enemy : GameCharacter
    {
        //.....

        public Enemy()
        {
            name = "Boss man";
            x = 40;
            y = 40;
            health = 10;

            //testing public, private and protected

            //works as expected
            testpublic = 100;
            //testprivate = 100; //doesn't work, acts as expected
            testprotected = 100; //works as expected 
        }
    }
}
