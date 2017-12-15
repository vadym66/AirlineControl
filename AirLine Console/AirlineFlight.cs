using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Console
{
    public class AirlineFlight : AirLineList, IEditing
    {
        public List<Passenger> FlightListPassengers { get; private set; }
        public string FlightNumber { get; set; }
        public DateTime FligtArrival { get; set; }
        public DateTime FligtDepartured { get; set; }
        public string FlightCityArrival { get; set; }
        public string FlightCityDepartured { get; set; }
        public char FlightTerminalArrival { get; set; }
        public char FlightTerminalDepartured { get; set; }
        public char FlightGateArrival { get; set; }
        public char FlightGateDepartured { get; set; }
        public StatusOfFlight FlightStatus { get; set; }

        public AirlineFlight() { }
        public AirlineFlight(List<Passenger> passengers)
        {
            FlightListPassengers = passengers;
        }
        public AirlineFlight(Passenger passenger)
        {
                
        }

        public void Input()
        {
            
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void AddPassengerToFlight(Passenger passenger)
        {
            if (FlightListPassengers.Capacity < 20)
            {
                FlightListPassengers.Add(passenger);
            }
            else
            {
                Console.WriteLine("There is no place on this flight. Try to choose another");
            }
        }
    }
}
