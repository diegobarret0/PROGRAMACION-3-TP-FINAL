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
using System.Security.Cryptography.X509Certificates;

namespace PROGRAMACION_3_TP_FINAL.Frm
{
    public partial class frmOwner : Form
    {
        private bool modify = false;
        private string id;
        private string companyName;
        private string phoneNumber;
        private string email;
        private string cuit;
        private string contactPerson;
        public frmOwner()
        {
            InitializeComponent();

            DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "id";

            DataGridViewColumn companyNameColumn = new DataGridViewTextBoxColumn();
            companyNameColumn.HeaderText = "Razon Social";
            companyNameColumn.DataPropertyName = "company_name";

            DataGridViewColumn phoneNumberColumn = new DataGridViewTextBoxColumn();
            phoneNumberColumn.HeaderText = "Numero de telefono";
            phoneNumberColumn.DataPropertyName = "phone_number";

            DataGridViewColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.HeaderText = "Email";
            emailColumn.DataPropertyName = "email";

            DataGridViewColumn cuitColumn = new DataGridViewTextBoxColumn();
            cuitColumn.HeaderText = "CUIT";
            cuitColumn.DataPropertyName = "cuit";

            DataGridViewColumn contactPersonColumn = new DataGridViewTextBoxColumn();
            contactPersonColumn.HeaderText = "Persona de contacto";
            contactPersonColumn.DataPropertyName = "contact_person";

            tblOwner.Columns.Add(idColumn);
            tblOwner.Columns.Add(companyNameColumn);
            tblOwner.Columns.Add(phoneNumberColumn);
            tblOwner.Columns.Add(emailColumn);
            tblOwner.Columns.Add(cuitColumn);
            tblOwner.Columns.Add(contactPersonColumn);

            tblOwner.DataSource = new SqlServer().searchRow(typeof(Proprietor), "dbo.proprietor", "1=1");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmOwner_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!modify)
            {
                companyName = txtBusinessName.Text.Trim();
                cuit = txtCuit.Text.Trim();
                phoneNumber = txtPhone.Text.Trim();
                email = txtEmail.Text.Trim();
                contactPerson = txtContact.Text.Trim();
                string valid = validation(companyName, cuit, phoneNumber, email, contactPerson);

                if (valid == "")
                {
                    Proprietor myProprietor = new Proprietor(
                    companyName,
                    phoneNumber,
                    email,
                    long.Parse(cuit),
                    contactPerson
                    );

                    SqlServer sql = new SqlServer();

                    string sqlQuery = sql.insertRow(myProprietor, "dbo.proprietor");

                    if (sqlQuery == "")
                    {
                        MessageBox.Show("Proprietario guardado correctamente");
                        txtNameOwner.Text = "";
                        txtBusinessName.Text = "";
                        txtPhone.Text = "";
                        txtEmail.Text = "";
                        txtCuit.Text = "";
                        txtContact.Text = "";
                        modify = true;
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
                companyName = txtBusinessName.Text.Trim();
                cuit = txtCuit.Text.Trim();
                phoneNumber = txtPhone.Text.Trim();
                email = txtEmail.Text.Trim();
                contactPerson = txtContact.Text.Trim();
                string valid = validation(companyName, cuit, phoneNumber, email, contactPerson);

                if (valid == "")
                {
                    Proprietor myProprietor = new Proprietor(
                    companyName,
                    phoneNumber,
                    email,
                    long.Parse(cuit),
                    contactPerson
                    );

                    SqlServer sql = new SqlServer();

                    string sqlQuery = sql.updateRow(myProprietor, "dbo.proprietor", $"id={int.Parse(txtNameOwner.Text)};");

                    if (sqlQuery == "")
                    {
                        MessageBox.Show("Proprietario moficado correctamente");
                        txtNameOwner.Text = "";
                        txtBusinessName.Text = "";
                        txtPhone.Text = "";
                        txtEmail.Text = "";
                        txtCuit.Text = "";
                        txtContact.Text = "";
                        modify = false;
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
            tblOwner.DataSource = new SqlServer().searchRow(typeof(Proprietor), "dbo.proprietor", "1=1");
        }
        private string validation(string companyName, string cuit, string phone, string email, string contact)
        {
            Validation valid = new Validation();
            string errors = "";

            if (!valid.textValidation(companyName)) errors += "Razon social\n";
            if (!valid.numericValidation(cuit)) errors += "Ciut\n";
            if (!valid.numericValidation(phone)) errors += "Telefono\n";
            if (!valid.emailValidation(email)) errors += "Email";

            return errors;
        }
        private void TblOwner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblOwner.Rows[e.RowIndex];

                id = row.Cells[0].Value.ToString();
                companyName = row.Cells[1].Value.ToString();
                phoneNumber = row.Cells[2].Value.ToString();
                email = row.Cells[3].Value.ToString();
                cuit = row.Cells[4].Value.ToString();
                contactPerson = row.Cells[5].Value.ToString();
            }
        }
        private void BtnModify_Click(object sender, EventArgs e)
        {
            txtNameOwner.Text = id;
            txtBusinessName.Text = companyName;
            txtPhone.Text = phoneNumber;
            txtEmail.Text = email;
            txtCuit.Text = cuit;
            txtContact.Text = contactPerson;

            modify = true;
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlServer sql = new SqlServer();
            string sqlQuery = sql.deleteRow("dbo.proprietor", $"id={id};");

            if (sqlQuery == "")
            {
                MessageBox.Show("Propietario eliminado correctamente.");
            }
            else
            {
                MessageBox.Show($"Error al eliminar propietario:\n{sqlQuery}");
            }
            tblOwner.DataSource = new SqlServer().searchRow(typeof(Proprietor), "dbo.proprietor", "1=1");
        }
    }
}
