using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Airplane : Vehicle
    {
        public override string DisplayInfo()
        {
            return $"I'm a plane I have couple of wheels :)";
        }
    }
}
