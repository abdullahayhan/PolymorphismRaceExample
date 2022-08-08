using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_yarisOrnegi_.models
{
    public class Orc : Chracter 
    {
        Random random = new Random();
        public override int GetSpeed()
        {
            return random.Next(6,12);
        }
    }
}
