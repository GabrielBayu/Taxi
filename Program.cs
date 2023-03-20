using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class program
    {
        static void Main(string[] args)
        {


            Taxi taxi = new Taxi();
            Taxi taxi1 = new Taxi();

            taxi.drivername = "Budi";
            taxi.onduty = true;
            taxi.numpass = 8956977;

            taxi1.drivername = "Joko";
            taxi1.onduty = true;
            taxi1.numpass = 697796;

            taxi.info();
            taxi.ongoing();
            taxi.done();

            taxi1.info();
            taxi1.ongoing();
            taxi1.done();

            Console.ReadKey();
        }
    }
}