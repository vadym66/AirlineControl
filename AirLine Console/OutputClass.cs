using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Console
{
    public class OutputClass
    {
        PassengerRepository passengerRepo = new PassengerRepository();
        AirlineFlightRepository airlineRepo = new AirlineFlightRepository();
        AirlineFlight flightPS456 = new AirlineFlight() { FlightNumber = "PS456" };

        public void SwitchCaseMenuPassenger()
        {


            bool _continue = true;
            while (_continue)
            {
                Console.WriteLine("Please choose your next step:\n\n" +
                    "1.Add Passenger\n" +
                    "2.Delete Passenger\n" +
                    "3.Edit personal detail \n" +
                    "4.Print Current Passengers\n" +
                    "5.Searching//\n" +
                    "6.Exitfrom menu");
                int a = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (a)
                {
                    case 1:

                        Console.WriteLine("you choosed 1 case");

                        passengerRepo.Add(new Passenger
                        {
                            FirstName = "Ivan",
                            SecondName = "Petrov",
                            Gender = 'M',
                            Nationality = "Ukraine",
                            NumberOfPassport = "er123123",
                            FlightClass = ServiceFlightClass.economy
                        });

                        Console.WriteLine("New passenger was succesfully created. Press Enter to choose next step");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Enter the ID of Passenger to Remove from list");
                        int id = int.Parse(Console.ReadLine());
                        passengerRepo.Delete(id);
                        passengerRepo.MakeIdBack();

                        break;
                    case 3:
                        Console.WriteLine("you choosed 3 case");

                        passengerRepo.Edit();

                        break;
                    case 4:
                        Console.Clear();

                        passengerRepo.Print();

                        Console.WriteLine("press Enter to coninue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5: //Searching
                        break;

                    case 6:
                        _continue = false;

                        SwitchCaseMenuMain();

                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException($"should chooes from 1 ==> 5 case");
                }
            }
        }

        public void SwitchCaseMenuFlight()
        {
            Console.WriteLine();
            int a = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (a)
            {
                case 1:
                    Console.WriteLine("Create flight");

                    break;
            }
        }

        public void SwitchCaseMenuMain()
        {
            bool _continue = true;
            while (_continue)
            {
                Console.WriteLine("\tWelcome to the Airline information\n\n" +
                    "Please choose your next step:\n" +
                    "1.Passenger Menu\n" +
                    "2.Flight Menu\n" +
                    "3.Exit from application");
                Console.WriteLine();
                int a = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (a)
                {
                    case 1:
                        SwitchCaseMenuPassenger();
                        break;
                    case 2:
                        SwitchCaseMenuFlight();
                        break;
                    case 3:
                        _continue = false;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException($"should chooes from 1 ==> 5 case");

                }
            }
        }
    }
}