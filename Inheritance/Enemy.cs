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
        }
    }
}
