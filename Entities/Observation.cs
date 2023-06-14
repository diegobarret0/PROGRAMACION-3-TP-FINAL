using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_3_TP_FINAL.Entities
{
    public class Observation
    {
        private DateTime observationDate;
        private string observationDescription;
        private string employeeFile;
        public Observation(DateTime observationDate, string observationDescription, string employeeFile) 
        {
            ob_date = observationDate;
            observation = observationDescription;
            employee_file = employeeFile;
        }

        public DateTime ob_date { 
            get {  return observationDate; } 
            set { observationDate = value; }
        }
        public string observation
        {
            get { return observationDescription; }
            set { observationDescription = value; }
        }
        public string employee_file
        {
            get { return employeeFile; }
            set { employeeFile = value; }
        }
    }
}
