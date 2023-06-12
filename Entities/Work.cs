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
            EmployeeFile = employeeFile;
            ProjectId = projectId;
            TaskId = taskId;
            FunctionId = functionId;
        }

        public int EmployeeFile
        {
            get { return employeeFile; }
            set { employeeFile = value; }
        }
        public int ProjectId
        {
            get { return projectId; }
            set { projectId = value; }
        }
        public int TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }
        public int FunctionId
        {
            get { return functionId; }
            set { functionId = value; }
        }
    }
}
