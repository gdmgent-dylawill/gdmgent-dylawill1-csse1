using System;

namespace Clients
{
    public class ContactPerson
    {
        /// <summary>
        /// Class for the creation of a contact person.
        /// </summary>
        
        // Fields
        private string name;
        private string familyName; // Surname, family name or last name.
        private Address privateAddress;
        private DateTime dateOfBirth;

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
        public string FamilyName
        {
            get
            {
                return this.familyName;
            }
            set
            {
                this.familyName = value;
            }
        }
        public Address PrivateAddress
        {
            get
            {
                return this.privateAddress;
            }
            set
            {
                this.privateAddress = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            set
            {
                this.dateOfBirth = value;
            }
        }

        // Constructors
        public ContactPerson()
        {}
        public ContactPerson(string name, string fname, Address address, DateTime dateBirth)
        {
            this.Name = name;
            this.FamilyName = fname;
            this.PrivateAddress = address;
            this.DateOfBirth = dateBirth;
        }

        // Methods
    }
}