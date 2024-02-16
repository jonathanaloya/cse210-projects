class Address
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

        // Getters and setters

        public string GetStreetAddress()
        {
            return streetAddress;
        }

        public string GetCity()
        {
            return city;
        }

        public string GetStateProvince()
        {
            return stateProvince;
        }

        public string GetCountry()
        {
            return country;
        }

        public bool IsInUSA()
        {
            return country.Equals("USA");
        }

        public string GetFullAddress()
        {
            return streetAddress + "\n" + city + ", " + stateProvince + "\n" + country;
        }
    }
