using System;
namespace Module9
{
    public class Address
    {

        // fields
        private int _houseNumber;
        private string _streetName;
        private string _city;
        private string _state;
        private int _zip;

        // Constructors
        public Address() { // default no-arg
        
            HouseNumber = 0;
            StreetName = "";
            City = "";
            State = "";
            Zip = 0;

        }

        public Address(int houseNumber, string streetName, string city, string state, int zip)
        {
            HouseNumber = houseNumber;
            StreetName = streetName;
            City = city;
            State = state;
            Zip = zip;
        }
        //Properties with public access to set and get values 
        public int HouseNumber { get => _houseNumber; set => _houseNumber = value; }
        public string StreetName { get => _streetName; set => _streetName = value; }
        public string City { get => _city; set => _city = value; }
        public string State { get => _state; set => _state = value; }
        public int Zip { get => _zip; set => _zip = value; }

    }

}


