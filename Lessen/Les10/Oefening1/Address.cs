namespace Clients
{
    public class Address
    {
        /// <summary>
        /// Class for the creation of an address.
        /// </summary>
        // Fields
        private AddressType type;
        private string street;
        private string number;
        private string box;
        private string postalCode;
        private string city;

        // Properties
        public AddressType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public string Street
        {
            get
            {
                return this.street;
            }
            set
            {
                this.street = value;
            }
        }
        public string Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
        public string Box
        {
            get
            {
                return this.box;
            }
            set
            {
                this.box = value;
            }
        }
        public string PostalCode
        {
            get
            {
                return this.postalCode;
            }
            set
            {
                this.postalCode = value;
            }
        }
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }

        // Constructors
        public Address()
        {}
        public Address(AddressType type, string street, string number, string box, string postalcode, string city)
        {
            this.Type = type;
            this.Street = street;
            this.Number = number;
            this.Box = box;
            this.PostalCode = postalcode;
            this.City = city;
        }

        // Methods
    }
}