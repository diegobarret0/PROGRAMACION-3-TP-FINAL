using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_3_TP_FINAL.Entities
{
    public class Proprietor
    {
        public int id_;
        private string companyName;
        private string phoneNumber;
        private string email_;
        private long cuit_;
        private string contactPerson;

        public Proprietor(int id_,string companyName, string phoneNumber, string email_, long cuit_, string contactPerson)
        {
            id = id_;
            company_name = companyName;
            phone_number = phoneNumber;
            email = email_;
            cuit = cuit_;
            contact_person = contactPerson;
        }
        public Proprietor(string companyName, string phoneNumber, string email_, long cuit_, string contactPerson)
        {
            company_name = companyName;
            phone_number = phoneNumber;
            email = email_;
            cuit = cuit_;
            contact_person = contactPerson;
        }
        public Proprietor() { }

        public int id
        {
            get { return id_; }
            set { id_ = value; }
        }
        public string company_name
        {
            get { return companyName; }
            set { companyName = value; }
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
        public long cuit
        {
            get { return cuit_; }
            set { cuit_ = value; }
        }
        public string contact_person
        {
            get { return contactPerson; }
            set { contactPerson = value; }
        }
        public override string ToString()
        {
            return $"Company Name: {companyName}\nPhone Number: {phoneNumber}\nEmail: {email_}\nCUIT: {cuit_}\nContact Person: {contactPerson}";
        }
    }
}
