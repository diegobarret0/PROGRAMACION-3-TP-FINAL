using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_3_TP_FINAL.Entities
{
    public class Proprietor
    {
        private int id;
        private string companyName;
        private string phoneNumber;
        private string email;
        private string cuit;
        private string contactPerson;

        public Proprietor(string companyName, string phoneNumber, string email, string cuit, string contactPerson)
        {
            CompanyName = companyName;
            PhoneNumber = phoneNumber;
            Email = email;
            Cuit = cuit;
            ContactPerson = contactPerson;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
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
        public string Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }
        public string ContactPerson
        {
            get { return contactPerson; }
            set { contactPerson = value; }
        }
    }
}
