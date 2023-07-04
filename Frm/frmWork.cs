using PROGRAMACION_3_TP_FINAL.DataBaseServices;
using PROGRAMACION_3_TP_FINAL.Entities;
using PROGRAMACION_3_TP_FINAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMACION_3_TP_FINAL.Frm
{
    public partial class frmWork : Form
    {
        private string idFunction = "";
        private string description = "";
        public frmWork()
        {
            InitializeComponent();

            DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "id";

            DataGridViewColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.HeaderText = "Descripcion";
            descriptionColumn.DataPropertyName = "description_";

            tblFunctions.DataSource = new SqlServer().searchRow(typeof(EmployeeFunction), "dbo.employee_function", "1=1;");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string description = tbxDescrption.Text.Trim();
            string valid = validation(description);
            if (valid == "")
            {
                EmployeeFunction myEmployeeFunction = new EmployeeFunction(description);

                SqlServer sql = new SqlServer();

                string sqlQuery = sql.insertRow(myEmployeeFunction, "dbo.employee_function");

                if (sqlQuery == "")
                {
                    MessageBox.Show("Funcion guardada correctamente");
                    tbxDescrption.Text = "";
                    idFunction = "";
                    description = "";
                    tblFunctions.DataSource = new SqlServer().searchRow(typeof(EmployeeFunction), "dbo.employee_function", "1=1;");
                }
                else
                {
                    MessageBox.Show(sqlQuery);
                }
            }
            else
            {
                MessageBox.Show($"Por favor ingrese correctamente los siguientes campos:\n{valid}");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idFunction != "")
            {
                SqlServer sql = new SqlServer();
                string sqlQuery = sql.deleteRow("dbo.employee_function", $"id={idFunction};");

                if (sqlQuery == "")
                {
                    MessageBox.Show("Funcion eliminada correctamente.");
                }
                else
                {
                    MessageBox.Show($"Error al eliminar Funcion:\n{sqlQuery}");
                }
                tblFunctions.DataSource = new SqlServer().searchRow(typeof(EmployeeFunction), "dbo.employee_function", "1=1;");
            }
            else
            {
                MessageBox.Show("Seleccione una funcion");
            }
        }
        private void TblFunctions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblFunctions.Rows[e.RowIndex];

                idFunction = row.Cells[0].Value.ToString();
                description = row.Cells[1].Value.ToString();
            }
        }
        private string validation(string myStr)
        {
            string errors = "";

            Validation valid = new Validation();

            if (!valid.textValidation(myStr)) errors += "Descripcion\n";

            return errors;
        }
    }
}
