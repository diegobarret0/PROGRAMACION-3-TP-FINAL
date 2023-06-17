using PROGRAMACION_3_TP_FINAL.Entities;
using PROGRAMACION_3_TP_FINAL.DataBaseServices;
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
            Proprietor myProprietor = new Proprietor(
            txtBusinessName.Text.Trim(),
            txtPhone.Text.Trim(),
            txtEmail.Text.Trim(),
            long.Parse(txtCuit.Text.Trim()),
            txtContact.Text.Trim()
            );

            SqlServer sql = new SqlServer();

            string sqlQuery = sql.insertRow(myProprietor, "dbo.proprietor");

            if(sqlQuery == "")
            {
                MessageBox.Show("Proprietario guardado correctamente");
            }
            else
            {
                MessageBox.Show(sqlQuery);
            }

            //MessageBox.Show(myProprietor.ToString());
        }
        
    }
}
