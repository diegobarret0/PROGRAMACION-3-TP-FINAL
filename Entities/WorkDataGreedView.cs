using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_3_TP_FINAL.Entities
{
    internal class WorkDataGreedView
    {
        private string employeeName;
        private string projectName;
        private string taskName;
        private string function;

        public WorkDataGreedView(string employeeFile, string projectId, string taskId, string functionId)
        {
            employee_file = employeeFile;
            proyect_id = projectId;
            task_id = taskId;
            function_id = functionId;
        }
        public WorkDataGreedView() { }

        public string employee_file
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public string proyect_id
        {
            get { return projectName; }
            set { projectName = value; }
        }
        public string task_id
        {
            get { return taskName; }
            set { taskName = value; }
        }
        public string function_id
        {
            get { return function; }
            set { function = value; }
        }
        public override string ToString()
        {
            return $"Employee Name: {employeeName}, Project Name: {projectName}, Task Name: {taskName}, Function: {function}";
        }

    }
}
