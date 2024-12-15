public class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        // Method to check if the customer is in the USA
        public bool IsInUSA()
        {
            return address.IsInUSA();
        }

        // Method to return the customer name and address
        public string GetShippingLabel()
        {
            return $"{name}\n{address.GetFullAddress()}";
        }
    }