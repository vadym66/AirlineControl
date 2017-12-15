using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine_Console
{
    public class Passenger : IEditing
    {        
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Nationality { get; set; }
        public string NumberOfPassport { get; set; }
        public ServiceFlightClass FlightClass { get; set; }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public Passenger()
        {
            
        }



        public override string ToString()
        {
            return $"{FirstName}\n{SecondName}\n{Nationality}\n{Nationality}\n{NumberOfPassport}\n{FlightClass}\n{Gender}\n\n";
        }

        public void Input()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }
    }

}
