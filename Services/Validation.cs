using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PROGRAMACION_3_TP_FINAL.Services
{
    public class Validation
    {
        public Validation () { }

        public bool textValidation(String str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            return true;
        }

        public bool decimalValidation(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            if (!Regex.IsMatch(str, @"^-?(([1-9]\d*)|0)(.0*[0-9](0*[0-9])*)?$"))
            {
                return false;
            }

            return true;
        }

        public bool numericValidation(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            if (!Regex.IsMatch(str, @"^\d+$"))
            {
                return false;
            }

            return true;
        }

        public bool emailValidation(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return false;
            }

            return true;
        }
    }
}
