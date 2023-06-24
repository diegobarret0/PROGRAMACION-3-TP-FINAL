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

namespace PROGRAMACION_3_TP_FINAL.Frm
{
    public partial class frmOwner : Form
    {
        public frmOwner()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmOwner_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string companyName = txtBusinessName.Text.Trim();
            string ciut = txtCuit.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contact = txtContact.Text.Trim();
            string valid = validation(companyName, ciut, phone, email, contact);

            if (valid == "") { 
                Proprietor myProprietor = new Proprietor(
                companyName,
                phone,
                email,
                long.Parse(ciut),
                contact
                );

                SqlServer sql = new SqlServer();

                string sqlQuery = sql.insertRow(myProprietor, "dbo.proprietor");

                if (sqlQuery == "")
                {
                    MessageBox.Show("Proprietario guardado correctamente");
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
        
    }
}
