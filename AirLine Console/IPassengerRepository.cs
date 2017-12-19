using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Console
{
    interface IPassengerRepository
    {
        void Add(Passenger passenger);
                
        void Delete(int id);

        void Edit();

        void Print();

        void Search();
    }
}
