using System;

namespace finalproject
{
    public class Customer
    {
        public int Id { get; private set; }
        public string First {  get; private set; }
        public string Last { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Zip { get; private set; }
        public string Phone { get; private set; }
        public string PhoneType { get; private set; }

        public Customer(int id, string first, string last, string street, string city, string state, string zip, string phone, string phoneType)
        {
            Id = id;
            First = first ?? throw new ArgumentNullException(nameof(first));
            Last = last ?? throw new ArgumentNullException(nameof(last));
            Street = street ?? throw new ArgumentNullException(nameof(street));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            Zip = zip ?? throw new ArgumentNullException(nameof(zip));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
            PhoneType = phoneType ?? throw new ArgumentNullException(nameof(phoneType));
        }

        public Customer(string first, string last, string street, string city, string state, string zip, string phone, string phoneType)
        {
            First = first ?? throw new ArgumentNullException(nameof(first));
            Last = last ?? throw new ArgumentNullException(nameof(last));
            Street = street ?? throw new ArgumentNullException(nameof(street));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            Zip = zip ?? throw new ArgumentNullException(nameof(zip));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
            PhoneType = phoneType ?? throw new ArgumentNullException(nameof(phoneType));
        }
    }
}