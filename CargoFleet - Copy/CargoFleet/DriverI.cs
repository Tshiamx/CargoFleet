using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoFleet
{
    public class DriverI
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string VehicleDriven  { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public DriverI()
        {

        }

        public DriverI(string FName, string LName, string Years, string CarDriven, string User, string PassKey)
        {
            Name = FName;
            Surname = LName;
            Age = Years;
            VehicleDriven = CarDriven;
            Username = User;
            Password = PassKey;
        }
    }
}
