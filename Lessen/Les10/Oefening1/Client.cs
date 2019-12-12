namespace Clients
{
    public class Client
    {
        /// <summary>
        /// Class for the creation of a client.
        /// </summary>
        
        // Fields
        // Ipv datatype met zelfgemaakte objecten werken
        private string name;
        // cp = 1 gekoppeld persoon aan het bedrijf
        // private ContactPerson cp;
        /* Binnen <> aangeven wat er in de list zit, van type ContactPerson
        type List + naam */
        private List<ContactPerson> contactPersons;        
        private string vat;
        // private Address companyAddress;
        /* Binnen <> aangeven wat er in de list zit, van type Address
        type List + naam */
        private List<Address> companyAdresses;
        private string remarks;
        private ClientType type;

        // Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        /*
        public ContactPerson ContactPerson
        {
            get
            {
                return this.cp;
            }
            set
            {
                this.cp = value;
            }
        }
        */
        public List<ContactPerson> contactPersons
        {
            get
            {
                return this.contactPersons;
            }
            set
            {
                this.cp;
            }
        }
        public string Vat
        {
            get
            {
                return this.vat;
            }
            set
            {
                this.vat = value;
            }
        }
        /*
        public Address CompanyAddress
        {
            get
            {
                return this.companyAddress;
            }
            set
            {
                this.companyAddress = value;
            }
        }
        */
        public List<Address> companyAdresses;
        public string Remarks
        {
            get
            {
                return this.remarks;
            }
            set
            {
                this.remarks = value;
            }
        }

        public ClientType Type
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

        // Constructors
        public Client()
        {}
        public Client(string name, List<ContactPerson> contactPersons, string vatnumber, Address address, string remarks, ClientType t)
        {
            this.Name = name;
            // this.ContactPerson = contactPerson;
            this.ContactPersons = contactPersons;
            this.Vat = vatnumber;
            // this.CompanyAddress = address;
            this.CompanyAddresses = addresses;
            this.Remarks = remarks;
            this.Type = type;
        }

        // Methods
    }
}