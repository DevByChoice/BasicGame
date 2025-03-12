using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGame
{
    internal class Melee : Enemy
    {
        int ID { get; set; }
        string Name { get; set; }
        float HP { get; set; }
        float Damage { get; set; }
    }
}
