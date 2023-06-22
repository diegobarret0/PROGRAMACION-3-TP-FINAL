using PROGRAMACION_3_TP_FINAL.Entities;
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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee myEmployee = new Employee(
            int.Parse(txtDocket.Text.Trim()),
            dateAmission.Value,
            txtName.Text.Trim(),
            txtLastName.Text.Trim(),
            txtPhone.Text.Trim(),
            txtEmail.Text.Trim()

            );

            SqlServer sql = new SqlServer(); //no entiendo el error

            string sqlQuery = sql.insertRow(myEmployee, "dbo.Employee");

            if (sqlQuery == "")
            {
                MessageBox.Show("Empleado guardado correctamente");
            }
            else
            {
                MessageBox.Show(sqlQuery);
            }
        }
    }
}
