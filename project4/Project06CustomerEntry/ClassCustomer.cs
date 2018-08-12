namespace Project06CustomerEntry
{
    public class ClassCustomer
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string StreeAddress { get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
        public string Phone { get; }

        public ClassCustomer(string firstName, string lastName, string streeAddress, string city, 
                                string state, string zipCode, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            StreeAddress = streeAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
            Phone = phone;
        }
    }
}