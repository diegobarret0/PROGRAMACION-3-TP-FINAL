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
            ObservationDate = observationDate;
            ObservationDescription = observationDescription;
            EmployeeFile = employeeFile;
        }

        public DateTime ObservationDate { 
            get {  return observationDate; } 
            set { observationDate = value; }
        }
        public string ObservationDescription
        {
            get { return observationDescription; }
            set { observationDescription = value; }
        }
        public string EmployeeFile
        {
            get { return employeeFile; }
            set { employeeFile = value; }
        }
    }
}
