using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Console
{
    interface IAirlineRepository
    {
        void Add(AirlineFlight flight);

        void Delete();

        void Edit();

        void Print();

        void Search();
    }
}
