using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_3_TP_FINAL.Entities
{
    public class EmployeeFunction
    {
        private int id_;
        private string description;

        public EmployeeFunction(int id_, string description) 
        {
            id = id_;
            description_ = description;
        }
        public int id 
        {
            get { return id_; }
            set { id_ = value; }
        }
        public string description_
        {
            get { return description; }
            set { description = value; }
        }
    }
}
