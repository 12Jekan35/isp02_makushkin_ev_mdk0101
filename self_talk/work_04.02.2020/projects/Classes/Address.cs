using System;

namespace Classes
{
    class Address
    {
        public int MailIndex { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        public string Home { get; set; }
        public int Flat { get; set; }

        public override string ToString()
        {
            string info = $"Mail index: {MailIndex} " +
                          $"City: {City} " +
                          $"Street: {Street} " +
                          $"Home: {Home} " +
                          $"Flat: {Flat}";

            return info;
        }

        public Address(int mailIndex, string city, string street, string home, int flat)
        {
            MailIndex = mailIndex;
            City = city;
            Street = street;
            Home = home;
            Flat = flat;
        }
    }
}
