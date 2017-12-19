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
            //var passengerRepo = new PassengerRepository(14);

            //passengerRepo.Add(new Passenger { FirstName = "Ivan", SecondName = "Petrov", Gender = 'M', Nationality = "Ukraine", NumberOfPassport = "er123123", FlightClass = ServiceFlightClass.economy });
            //passengerRepo.Add(new Passenger { FirstName = "Ivan", SecondName = "Petrov", Gender = 'M', Nationality = "Ukraine", NumberOfPassport = "er123123", FlightClass = ServiceFlightClass.economy });
            //passengerRepo.Add(new Passenger { FirstName = "Ivan", SecondName = "Petrov", Gender = 'M', Nationality = "Ukraine", NumberOfPassport = "er123123", FlightClass = ServiceFlightClass.economy });

            //passengerRepo.Print();

            //OutputClass startProgram = new OutputClass();
            //startProgram.SwitchCaseMenuMain();

            PassengerRepository passRepo = new PassengerRepository();
            Passenger passenger1 = new Passenger()
            {
                FirstName = "Ivan",
                SecondName = "Petrov",
                Gender = 'M',
                Nationality = "Ukraine",
                NumberOfPassport = "er123123",
                FlightClass = ServiceFlightClass.economy

            };

            Passenger passenger2 = new Passenger()
            {
                FirstName = "Nikolaty",
                SecondName = "Petrov",
                Gender = 'M',
                Nationality = "Ukraine",
                NumberOfPassport = "er123123",
                FlightClass = ServiceFlightClass.economy
            };

            Passenger passenger3 = new Passenger()
            {
                FirstName = "Petr",
                SecondName = "Petrov",
                Gender = 'M',
                Nationality = "Ukraine",
                NumberOfPassport = "er123123",
                FlightClass = ServiceFlightClass.economy

            };

            passRepo.Add(passenger1);
            passRepo.Add(passenger2);
            passRepo.Add(passenger3);

            foreach (Passenger item in passRepo.Passengers)
            {
                Console.WriteLine(item);
            }

            passRepo.Delete(1);

            Console.WriteLine("==============");

            int _index = 0;

            foreach (Passenger item in passRepo.Passengers)
            {
                item.PassengerID = passRepo.Passengers.IndexOf(passRepo.Passengers[_index++]);
                item.PassengerID++;
            }

            foreach (Passenger item in passRepo.Passengers)
            {
                Console.WriteLine(item);
            }


        }
    }
}
