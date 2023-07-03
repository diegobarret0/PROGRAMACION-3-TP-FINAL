using PROGRAMACION_3_TP_FINAL.DataBaseServices;
using PROGRAMACION_3_TP_FINAL.Entities;
using PROGRAMACION_3_TP_FINAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PROGRAMACION_3_TP_FINAL.Frm
{
    public partial class frmProyect : Form
    {
        private bool modify = false;
        private string id = "";
        private string projectName;
        private string estimatedAmount;
        private string estimatedTime;
        private string proprietorId;
        private string leaderFile;
        public frmProyect()
        {
            InitializeComponent();
            txtId.Enabled = false;
            cbxIsActive.Enabled = false;

            DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "id";

            DataGridViewColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Nombre";
            nameColumn.DataPropertyName = "name_";

            DataGridViewColumn estimatedAmountColumn = new DataGridViewTextBoxColumn();
            estimatedAmountColumn.HeaderText = "Costo estimado";
            estimatedAmountColumn.DataPropertyName = "estimated_amount";

            DataGridViewColumn estimatedCostColumn = new DataGridViewTextBoxColumn();
            estimatedCostColumn.HeaderText = "Costo estimado";
            estimatedCostColumn.DataPropertyName = "estimated_time";

            //Sacar nombre de propietario
            DataGridViewColumn proprietorColumn = new DataGridViewTextBoxColumn();
            proprietorColumn.HeaderText = "Propietario";
            proprietorColumn.DataPropertyName = "proprietor_id";

            DataGridViewColumn leaderColumn = new DataGridViewTextBoxColumn();
            leaderColumn.HeaderText = "Lider del proyecto";
            leaderColumn.DataPropertyName = "leader_file";

            tblProyect.Columns.Add(idColumn);
            tblProyect.Columns.Add(nameColumn);
            tblProyect.Columns.Add(estimatedAmountColumn);
            tblProyect.Columns.Add(estimatedCostColumn);
            tblProyect.Columns.Add(proprietorColumn);
            tblProyect.Columns.Add(leaderColumn);

            cmbOwner.DataSource = new SqlServer().searchRow(typeof(Proprietor), "dbo.proprietor", "1=1");
            cmbOwner.DisplayMember = "company_name";

            tblProyect.DataSource = new SqlServer().searchRow(typeof(Project), "dbo.project", "1=1");
        }
        private void Propietario_Click(object sender, EventArgs e)
        {
            Frm.frmOwner frmOwner = new frmOwner();

            frmOwner.Show();
        }
        private void btnTask_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show($"Seleccione un proyecto");
            }
            else
            {
                Frm.frmTask frmTask = new frmTask(id);
                frmTask.Show();
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!modify)
            {

                leaderFile = txtDocket.Text.Trim();
                projectName = txtNameProyect.Text.Trim();
                estimatedAmount = textBox1.Text.Trim();
                estimatedTime = textBox6.Text.Trim();
                Proprietor myPro = (Proprietor)cmbOwner.SelectedItem;
                proprietorId = myPro.id.ToString();
                string valid = validation(leaderFile, projectName, estimatedAmount, estimatedTime);

                if (valid == "")
                {
                    Project myProject = new Project(
                    projectName,
                    decimal.Parse(estimatedAmount),
                    int.Parse(estimatedTime),
                    int.Parse(proprietorId),
                    int.Parse(leaderFile)
                    );

                    SqlServer sql = new SqlServer();

                    string sqlQuery = sql.insertRow(myProject, "dbo.project");

                    if (sqlQuery == "")
                    {
                        MessageBox.Show("Proyecto guardado correctamente");
                        txtDocket.Text = "";
                        txtNameProyect.Text = "";
                        textBox1.Text = "";
                        textBox6.Text = "";
                        txtId.Text = "";
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
                modify = false;
            }
            else
            {
                leaderFile = txtDocket.Text.Trim();
                projectName = txtNameProyect.Text.Trim();
                estimatedAmount = textBox1.Text.Trim();
                estimatedTime = textBox6.Text.Trim();
                Proprietor myPro = (Proprietor)cmbOwner.SelectedItem;
                proprietorId = myPro.id.ToString();
                string valid = validation(leaderFile, projectName, estimatedAmount, estimatedTime);

                if (valid == "")
                {
                    Project myProject = new Project(
                    projectName,
                    decimal.Parse(estimatedAmount),
                    int.Parse(estimatedTime),
                    int.Parse(proprietorId),
                    int.Parse(leaderFile)
                    );

                    SqlServer sql = new SqlServer();

                    string sqlQuery = sql.updateRow(myProject, "dbo.project", $"id={int.Parse(txtId.Text)};");

                    if (sqlQuery == "")
                    {
                        MessageBox.Show("Proyecto editado correctamente");
                        txtDocket.Text = "";
                        txtNameProyect.Text = "";
                        textBox1.Text = "";
                        textBox6.Text = "";
                        txtId.Text = "";
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
            tblProyect.DataSource = new SqlServer().searchRow(typeof(Project), "dbo.project", "1=1");
        }
        private void TblProyect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblProyect.Rows[e.RowIndex];

                id = row.Cells[0].Value.ToString();
                projectName = row.Cells[1].Value.ToString();
                estimatedAmount = row.Cells[2].Value.ToString();
                estimatedTime = row.Cells[3].Value.ToString();
                proprietorId = row.Cells[4].Value.ToString();
                leaderFile = row.Cells[5].Value.ToString();
            }
        }
        private void BtnModify_Click(object sender, EventArgs e)
        {
            txtId.Text = id;
            txtNameProyect.Text = projectName;
            textBox1.Text = estimatedAmount;
            textBox6.Text = estimatedTime;
            txtDocket.Text = leaderFile;
            //cmbOwner.Text = proprietorId;
            Proprietor myProprietor = new Proprietor();
            List<object> list = new SqlServer().searchRow(typeof(Proprietor), "dbo.proprietor", $"id={proprietorId}");
            myProprietor = (Proprietor)list[0];
            cmbOwner.Text = myProprietor.company_name;

            modify = true;
        }
        private string validation(string leaderFile, string projectName, string estimatedAmount, string estimatedTime)
        {
            Validation valid = new Validation();
            string errors = "";

            if (!valid.numericValidation(leaderFile)) errors += "Legajo\n";
            if (!valid.textValidation(projectName)) errors += "Nombre del proyecto\n";
            if (!valid.decimalValidation(estimatedAmount)) errors += "Costo estimado\n";
            if (!valid.numericValidation(estimatedTime)) errors += "Tiempo estimado";

            return errors;
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlServer sql = new SqlServer();
            string sqlQuery = sql.deleteRow("dbo.project", $"id={id};");

            if (sqlQuery == "")
            {
                MessageBox.Show("Proyecto eliminado correctamente.");
            }
            else
            {
                MessageBox.Show($"Error al eliminar Proyecto:\n{sqlQuery}");
            }
            tblProyect.DataSource = new SqlServer().searchRow(typeof(Project), "dbo.project", "1=1");
        }
    }
}
