using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_3_TP_FINAL.Entities
{
    public class Employee
    {   
        private string fileNumber;
        private DateTime entryDate;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;
        public Employee(string fileNumber, DateTime entryDate, string firstName, string lastName, string phoneNumber, string email) {
            FileNumber = fileNumber;
            EntryDate = entryDate;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string FileNumber
        {
            get { return fileNumber; }
            set { fileNumber = value; }
        }
        public DateTime EntryDate
        {
            get { return entryDate; }
            set { entryDate = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
