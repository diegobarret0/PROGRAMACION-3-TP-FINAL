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
        private string email_;
        public Employee(string fileNumber, DateTime entryDate, string firstName, string lastName, string phoneNumber, string email_) {
            file_number = fileNumber;
            entry_date = entryDate;
            first_name = firstName;
            last_name = lastName;
            phone_number = phoneNumber;
            email = email_;
        }

        public string file_number
        {
            get { return fileNumber; }
            set { fileNumber = value; }
        }
        public DateTime entry_date
        {
            get { return entryDate; }
            set { entryDate = value; }
        }
        public string first_name
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string last_name
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string phone_number
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string email
        {
            get { return email_; }
            set { email_ = value; }
        }
    }
}
