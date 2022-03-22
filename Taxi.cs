using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    class Taxi
    {

        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }
        public string DropOffPassenger { get; set; }

        public void TaxiInfo()
            {

                Console.WriteLine("Driver Name : {0} ", DriverName);

                if (OnDuty == true)
                {
                    Console.WriteLine("On Duty : Yes", OnDuty);
                }

                Console.WriteLine("Jumlah penumpang : {0} \n", NumPassenger);
            }

            public void PickUpPassenger()
            {
                Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
            }

            public void DropOffPassanger()
            {
                Console.WriteLine("{0} selesai mengantar penumpang \n", DriverName);
            }
    }
}
