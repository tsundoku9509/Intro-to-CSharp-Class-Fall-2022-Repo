using System;
using Module9;

public class House
    {

        // fields 
        private Address _address;
        private int _numberBedrooms;
        private int _numberBathrooms;

        // Constructors
     

        public House(Address address, int numberBathrooms, int numberBedrooms)
        {
            Address = address;
            NumberBathrooms = numberBathrooms;
            NumberBedrooms = numberBedrooms;
        }
        //Properties with public access to set and get values 
        public Address Address { get => _address; set => _address = value; }
        public int NumberBedrooms { get => _numberBedrooms; set => _numberBedrooms = value; }
        public int NumberBathrooms { get => _numberBathrooms; set => _numberBathrooms = value; }

        public override string ToString()
        {
            return ("House at " + Address.ToString() + " has " + NumberBedrooms + " bedrooms and " + NumberBathrooms + " bathrooms.");
        }
    }



