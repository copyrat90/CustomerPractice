using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Customer
    {
        private string lastName;
        private string firstName;
        private DateTime birthday;
        public bool IsQualified { get; private set; }
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
                this.IsQualified = this.Age >= 18;
            }
        }
        


        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Birthday = birthday;
        }


    }
}
