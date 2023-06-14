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
        private int employeeFile;
        public Observation(DateTime observationDate, string observationDescription, int employeeFile) 
        {
            ob_date = observationDate;
            observation = observationDescription;
            employee_file = employeeFile;
        }
        public Observation() { }

        public DateTime ob_date { 
            get {  return observationDate; } 
            set { observationDate = value; }
        }
        public string observation
        {
            get { return observationDescription; }
            set { observationDescription = value; }
        }
        public int employee_file
        {
            get { return employeeFile; }
            set { employeeFile = value; }
        }
    }
}
