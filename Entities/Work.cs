using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_3_TP_FINAL.Entities
{
    public class Work
    {
        private int employeeFile;
        private int projectId;
        private int taskId;
        private int functionId;

        public Work(int employeeFile, int projectId, int taskId, int functionId)
        {
            employee_file = employeeFile;
            proyect_id = projectId;
            task_id = taskId;
            function_id = functionId;
        }
        public Work() { }

        public int employee_file
        {
            get { return employeeFile; }
            set { employeeFile = value; }
        }
        public int proyect_id
        {
            get { return projectId; }
            set { projectId = value; }
        }
        public int task_id
        {
            get { return taskId; }
            set { taskId = value; }
        }
        public int function_id
        {
            get { return functionId; }
            set { functionId = value; }
        }
        public override string ToString()
        {
            return $"Employee File: {employeeFile}, Project ID: {projectId}, Task ID: {taskId}, Function ID: {functionId}";
        }
    }
}
