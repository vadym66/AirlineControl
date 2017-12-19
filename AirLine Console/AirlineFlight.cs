using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Console
{
    public class AirlineFlight 
    {
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

        public int AirlineIndex { get; set; }
    }
}
