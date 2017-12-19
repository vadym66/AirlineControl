using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Console
{
    class PassengerRepository : IPassengerRepository
    {
        public List<Passenger> Passengers { get; set; }
        private int _index;

        public PassengerRepository()
        {
            Passengers = new List<Passenger>();
        }

        public void Add(Passenger passenger)
        {
            Passengers.Add(passenger);
            passenger.PassengerID = Passengers.IndexOf(Passengers[_index++]);
            passenger.PassengerID++;
        }

        public void Delete(int ID)
        {
            var item = Passengers.SingleOrDefault(x => x.PassengerID == ID);
            if (item != null)
                Passengers.Remove(item);            
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            foreach (Passenger passenger in Passengers)
            {
                Console.WriteLine($"{passenger.FirstName},{passenger.SecondName},{passenger.PassengerID}");
            }
        }

        public void Search()
        {
            throw new NotImplementedException();
        }

        public void MakeIdBack()
        {
            _index = 0;
            foreach (Passenger passenger in Passengers)
            {                
                passenger.PassengerID = Passengers.IndexOf(Passengers[_index++]);
                passenger.PassengerID++;
            }
        }
    }
}
