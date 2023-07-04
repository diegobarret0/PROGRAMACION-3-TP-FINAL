using PROGRAMACION_3_TP_FINAL.Entities;
using PROGRAMACION_3_TP_FINAL.DataBaseServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PROGRAMACION_3_TP_FINAL.Frm
{
    public partial class frmEmployee : Form
    {

        private bool modify = false;
        private string fileNumber = "";
        private string dateAdmision = "";
        private string name = "";
        private string lastName = "";
        private string phoneNumber = "";
        private string email = "";

        public frmEmployee()
        {
            InitializeComponent();
            txtDocket.Enabled = false;
            txtSearch.PlaceholderText = "Nombre";

            DataGridViewColumn docketColumn = new DataGridViewTextBoxColumn();
            docketColumn.HeaderText = "Legajo";
            docketColumn.DataPropertyName = "file_number";

            DataGridViewColumn entryDateColumn = new DataGridViewTextBoxColumn();
            entryDateColumn.HeaderText = "Fecha de Ingreso";
            entryDateColumn.DataPropertyName = "entry_date";

            DataGridViewColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Nombre";
            nameColumn.DataPropertyName = "first_name";

            DataGridViewColumn lastNameColumn = new DataGridViewTextBoxColumn();
            lastNameColumn.HeaderText = "Apellido";
            lastNameColumn.DataPropertyName = "last_name";

            DataGridViewColumn phoneColumn = new DataGridViewTextBoxColumn();
            phoneColumn.HeaderText = "Telefono";
            phoneColumn.DataPropertyName = "phone_number";

            DataGridViewColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.HeaderText = "Email";
            emailColumn.DataPropertyName = "email";

            tblEmployee.Columns.Add(docketColumn);
            tblEmployee.Columns.Add(entryDateColumn);
            tblEmployee.Columns.Add(nameColumn);
            tblEmployee.Columns.Add(lastNameColumn);
            tblEmployee.Columns.Add(phoneColumn);
            tblEmployee.Columns.Add(emailColumn);

            viewList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!modify)
            {
                string fileNumber = txtDocket.Text.Trim();
                DateTime entryDate = dateAdmission.Value;
                string firstName = txtName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();
                string valid = validation(fileNumber, firstName, lastName, phone, email);

                if (valid == "")
                {
                    Employee myEmployee = new Employee(
                    int.Parse(fileNumber),
                    entryDate,
                    firstName,
                    lastName,
                    phone,
                    email
                    );

                    SqlServer sql = new SqlServer();

                    string sqlQuery = sql.insertRow(myEmployee, "dbo.Employee");

                    if (sqlQuery == "")
                    {
                        MessageBox.Show("Empleado guardado correctamente");
                        viewList();
                        clear();
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
                modify = false;
            }
            else
            {
                string fileNumber = txtDocket.Text.Trim();
                DateTime entryDate = dateAdmission.Value;
                string firstName = txtName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();
                string valid = validation(fileNumber, firstName, lastName, phone, email);

                if (valid == "")
                {
                    Employee myEmployee = new Employee(
                    int.Parse(fileNumber),
                    entryDate,
                    firstName,
                    lastName,
                    phone,
                    email
                    );

                    SqlServer sql = new SqlServer();

                    string sqlQuery = sql.updateRow(myEmployee, "dbo.employee", $"file_number={int.Parse(txtDocket.Text)};");

                    if (sqlQuery == "")
                    {
                        MessageBox.Show("Empleado moficado correctamente");
                        viewList();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show(sqlQuery);
                    }
                    modify = false;
                }
                else
                {
                    MessageBox.Show($"Por favor ingrese correctamente los siguientes campos:\n{valid}");
                }
            }
        }
        private void tblEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblEmployee.Rows[e.RowIndex];

                fileNumber = row.Cells[0].Value.ToString();
                dateAdmision = row.Cells[1].Value.ToString();
                name = row.Cells[2].Value.ToString();
                lastName = row.Cells[3].Value.ToString();
                phoneNumber = row.Cells[4].Value.ToString();
                email = row.Cells[5].Value.ToString();
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            txtDocket.Text = fileNumber;
            dateAdmission.Value = DateTime.Parse(dateAdmision);
            txtName.Text = name;
            txtLastName.Text = lastName;
            txtPhone.Text = phoneNumber;
            txtEmail.Text = email;

            modify = true;
        }
        private void btnObservation_Click(object sender, EventArgs e)
        {
            if (fileNumber != "")
            {
                frmObservation frmObservation = new Frm.frmObservation(fileNumber);
                frmObservation.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un empleado");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlServer sql = new SqlServer();

            string sqlQuery = sql.deleteRow("dbo.employee", $"file_number={int.Parse(fileNumber)};");

            if (sqlQuery == "")
            {
                MessageBox.Show("Empleado eliminado correctamente");
                viewList();
            }
            else
            {
                MessageBox.Show(sqlQuery);
            }
        }
        private void clear()
        {
            fileNumber = "";
            dateAdmision = "";
            name = "";
            lastName = "";
            phoneNumber = "";
            email = "";
        }
        private void viewList()
        {
            tblEmployee.DataSource = new SqlServer().searchRow(typeof(Employee), "dbo.employee", "1=1");
        }
        private string validation(string fileNumber, string firstName, string lastName, string phone, string email)
        {
            Validation valid = new Validation();
            string errors = "";
            if (!valid.numericValidation(fileNumber)) errors += "Legajo\n";
            if (!valid.textValidation(firstName)) errors += "Nombre\n";
            if (!valid.textValidation(lastName)) errors += "Apellido\n";
            if (!valid.numericValidation(phone)) errors += "Celular\n";
            if (!valid.emailValidation(email)) errors += "Email";

            return errors;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            tblEmployee.DataSource = new SqlServer().searchRow(
                typeof(Employee),
                "dbo.employee",
                $"first_name LIKE '%{txtSearch.Text.Trim()}%'"
                );
        }
        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            txtDocket.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            modify = false;
        }
    }
}
