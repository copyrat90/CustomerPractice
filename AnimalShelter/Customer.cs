using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Customer
    {
        private string lastName;
        private string firstName;
        private DateTime birthday;
        private bool isQualified;
        public string Address { get; set; }
        public string Description { get; set; }

        public string FullName
        {
            get { return this.firstName + " " + this.lastName; }
        }
        public int Age
        {
            get { return DateTime.Now.Year - this.birthday.Year; }
        }
        public DateTime Birthday
        {
            get { return this.birthday; }
            set
            {
                this.birthday = value;
                this.isQualified = this.Age >= 18;
            }
        }
        public bool IsQualified
        {
            get { return this.isQualified; }
        }


        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Birthday = birthday;
        }


    }
}
