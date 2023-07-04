using PROGRAMACION_3_TP_FINAL.DataBaseServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using PROGRAMACION_3_TP_FINAL.Entities;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMACION_3_TP_FINAL.Frm
{
    public partial class frmAddEmployee : Form
    {
        private string taskId = "";
        private string projectId = "";
        private string employeeFile = "";

        public frmAddEmployee(string taskId, string projectId, string taskName)
        {
            InitializeComponent();
            this.taskId = taskId;
            this.projectId = projectId;

            txbTaskName.Enabled = false;
            txbTaskName.Text = taskName;

            DataGridViewColumn employeeColumn = new DataGridViewTextBoxColumn();
            employeeColumn.HeaderText = "Empleado";
            employeeColumn.DataPropertyName = "employee_file";

            DataGridViewColumn projectColumn = new DataGridViewTextBoxColumn();
            projectColumn.HeaderText = "Proyecto";
            projectColumn.DataPropertyName = "proyect_id";

            DataGridViewColumn taskColumn = new DataGridViewTextBoxColumn();
            taskColumn.HeaderText = "Tarea";
            taskColumn.DataPropertyName = "task_id";

            DataGridViewColumn functionColumn = new DataGridViewTextBoxColumn();
            functionColumn.HeaderText = "Funcion";
            functionColumn.DataPropertyName = "function_id";

            tblEmployees.Columns.Add(employeeColumn);
            tblEmployees.Columns.Add(projectColumn);
            tblEmployees.Columns.Add(taskColumn);
            tblEmployees.Columns.Add(functionColumn);

            loadDataGreedView();

            cbxEmployee.DataSource = new SqlServer().searchRow(typeof(Employee), "dbo.employee", "1=1");
            cbxEmployee.DisplayMember = "file_number";

            cbxFunction.DataSource = new SqlServer().searchRow(typeof(EmployeeFunction), "dbo.employee_function", "1=1");
            cbxFunction.DisplayMember = "description_";
        }

        private void BtnAddFunction_Click(object sender, EventArgs e)
        {
            frmWork frmWork = new frmWork();
            frmWork.Show();
            this.Close();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee = (Employee)cbxEmployee.SelectedItem;
            EmployeeFunction employeeFunction = new EmployeeFunction();
            employeeFunction = (EmployeeFunction)cbxFunction.SelectedItem;
            if (functionsCheck(employeeFunction.id))
            {
                MessageBox.Show("No pueden existir dos empleados con la misma funcion");
                return;
            }

            Work myWork = new Work(
                employee.file_number,
                int.Parse(projectId),
                int.Parse(taskId),
                employeeFunction.id
                );

            SqlServer sql = new SqlServer();

            string sqlQuery = sql.insertRow(myWork, "dbo.work");

            if (sqlQuery == "")
            {
                MessageBox.Show("Empleado añadido correctamente");
                loadDataGreedView();
            }
            else
            {
                MessageBox.Show(sqlQuery);

            }
            employeeFile = "";
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (employeeFile != "")
            {
                SqlServer sql = new SqlServer();
                string sqlQuery = sql.deleteRow("dbo.work", $"employee_file={employeeFile};");

                if (sqlQuery == "")
                {
                    MessageBox.Show("Empleado eliminado de la tarea correctamente.");

                    loadDataGreedView();
                }
                else
                {
                    MessageBox.Show($"Error al eliminar empleado de tarea:\n{sqlQuery}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado");
            }
        }
        private void TblEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblEmployees.Rows[e.RowIndex];

                employeeFile = row.Cells[0].Value.ToString();
            }
        }
        private void loadDataGreedView()
        {
            SqlServer sql = new SqlServer();

            List<object> workList = sql.searchRow(typeof(Work), "dbo.work", $"task_id={taskId};");

            if (workList.Count != 0)
            {
                List<WorkDataGreedView> workDataGreedView = getSourceDataGreedView(workList);
                tblEmployees.DataSource = workDataGreedView;
            }
        }
        private List<WorkDataGreedView> getSourceDataGreedView(List<object> workList)
        {
            List<WorkDataGreedView> myList = new List<WorkDataGreedView>();

            foreach (Work work in workList) 
            {
                WorkDataGreedView myWorkDGW = new WorkDataGreedView();
                SqlServer sql = new SqlServer();

                Employee employee;
                employee = (Employee)sql.searchRow(typeof(Employee), "dbo.employee", $"file_number={work.employee_file};")[0];
                myWorkDGW.employee_file = employee.file_number.ToString();

                Project project;
                project = (Project)sql.searchRow(typeof(Project), "dbo.project", $"id={work.proyect_id};")[0];
                myWorkDGW.proyect_id = project.name_;

                Entities.Task task;
                task = (Entities.Task)sql.searchRow(typeof(Entities.Task), "dbo.task", $"id={work.task_id};")[0];
                myWorkDGW.task_id = task.description_;

                EmployeeFunction employeeFunction;
                employeeFunction = (EmployeeFunction)sql.searchRow(typeof(EmployeeFunction), "dbo.employee_function", $"id={work.function_id};")[0];
                myWorkDGW.function_id = employeeFunction.description_;

                myList.Add(myWorkDGW);
            }

            return myList;
        }
        private bool functionsCheck(int idFunction)
        {
            List<object> workList = new SqlServer().searchRow(typeof(Work), "dbo.work", "1=1;");

            foreach (Work work in workList)
            {
                if(idFunction == work.function_id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
