public class Address
    {
        private string streetAddress;
        private string city;
        private string stateProvince;
        private string country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        // Method to check if the address is in the USA
        public bool IsInNigeria()
        {
            return country == "Nigeria";
        }

        // Method to return the full address as a formatted string
        public string GetFullAddress()
        {
            return $"{streetAddress}\n{city}, {stateProvince}\n{country}";
        }
    }

