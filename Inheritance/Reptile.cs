using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal 

    {
        public Reptile()
        {

        }

        public bool hasTail { get; set; }

        public string Scales { get; set; }

        public bool isHerbivore { get; set; }

        public string Amphibious { get; set; }
    }
}
