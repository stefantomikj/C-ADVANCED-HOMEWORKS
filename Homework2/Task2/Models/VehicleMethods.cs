using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class VehicleMethods
    {
            public static string Drive(this Vehicle Car)
            {
                return "Driving";
            }
            public static string Wheelie(this Vehicle MotorBike)
            {
                return "Driving on one wheel";
            }

            public static string Sail(this Vehicle Boat)
            {
                return "Sailing";
            }
            public static string Fly(this Vehicle Airplane)
            {
                return "Flying";
            }
        
    }
}
