using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Passenger> passengerListTemp = new List<Passenger>
            {
                new Passenger {FirstName = "Ivan", SecondName = "Petrov", Gender = 'M', Nationality = "Ukraine", NumberOfPassport = "er123123",FlightClass = ServiceFlightClass.economy },
                new Passenger {FirstName = "Ivan", SecondName = "Petrov", Gender = 'M', Nationality = "Ukraine", NumberOfPassport = "er123123",FlightClass = ServiceFlightClass.economy },
                new Passenger {FirstName = "Ivan", SecondName = "Petrov", Gender = 'M', Nationality = "Ukraine", NumberOfPassport = "er123123",FlightClass = ServiceFlightClass.economy }
            };

            AirlineFlight newFLight = new AirlineFlight(passengerListTemp);
            newFLight.OutPutOnConsole();

            

        }
    }
}
