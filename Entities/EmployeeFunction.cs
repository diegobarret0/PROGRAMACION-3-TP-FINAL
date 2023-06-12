using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_3_TP_FINAL.Entities
{
    public class EmployeeFunction
    {
        private int id;
        private string description;

        public EmployeeFunction(int id, string description) 
        {
            Id = id;
            Description = description;
        }
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
