using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car : Vehicle
    {
        public override string DisplayInfo()
        {
            return $"Im a car and i drive on 4 wheels";
        }
    }
}
