using PROGRAMACION_3_TP_FINAL.DataBaseServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using PROGRAMACION_3_TP_FINAL.Services;

namespace PROGRAMACION_3_TP_FINAL.Frm
{
    public partial class frmObservation : Form
    {
        private bool modify = false;
        private string fileNumber = "";
        private DateTime observationDate;
        private string observation = "";
        public frmObservation(string fileNumber)
        {
            InitializeComponent();
            this.fileNumber = fileNumber;
            txtDocket.Enabled = false;
            txtDocket.Text = fileNumber;

            DataGridViewColumn observationDateColumn = new DataGridViewTextBoxColumn();
            observationDateColumn.HeaderText = "Fecha";
            observationDateColumn.DataPropertyName = "ob_date";

            DataGridViewColumn observationColumn = new DataGridViewTextBoxColumn();
            observationColumn.HeaderText = "Observacion";
            observationColumn.DataPropertyName = "observation";

            DataGridViewColumn employeeFileColumn = new DataGridViewTextBoxColumn();
            employeeFileColumn.HeaderText = "Legajo";
            employeeFileColumn.DataPropertyName = "employee_file";

            tblObsservation.Columns.Add(observationDateColumn);
            tblObsservation.Columns.Add(observationColumn);
            tblObsservation.Columns.Add(employeeFileColumn);

            loadDataGreedView();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!modify)
            {
                observationDate = dateObservation.Value;
                observation = txtObservation.Text.Trim();
                //MessageBox.Show(observation);
                fileNumber = txtDocket.Text.Trim();
                string valid = validation(observation);

                if (valid == "")
                {
                    Observation myObservation = new Observation(
                        observationDate,
                        observation,
                        int.Parse(fileNumber)
                    );

                    SqlServer sql = new SqlServer();

                    string sqlQuery = sql.insertRow(myObservation, "dbo.observations");

                    if (sqlQuery == "")
                    {
                        MessageBox.Show("Observacion guardada correctamente");
                        loadDataGreedView();
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
                observationDate = dateObservation.Value;
                string observationAux = txtObservation.Text.Trim();
                fileNumber = txtDocket.Text.Trim();
                string valid = validation(observationAux);

                if (valid == "")
                {
                    Observation myObservation = new Observation(
                        observationDate,
                        observationAux,
                        int.Parse(fileNumber)
                    );

                    SqlServer sql = new SqlServer();

                    string sqlQuery = sql.updateRow(myObservation, "dbo.observations", $"CONVERT(VARCHAR, observation) = '{observation}'");

                    if (sqlQuery == "")
                    {
                        MessageBox.Show("Observacion modificada correctamente");
                        loadDataGreedView();
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
                modify = false;
            }
        }
        private void TblObsservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblObsservation.Rows[e.RowIndex];

                observationDate = DateTime.Parse(row.Cells[0].Value.ToString());
                observation = row.Cells[1].Value.ToString();
                fileNumber = row.Cells[2].Value.ToString();
            }
        }
        private void BtnModify_Click(object sender, EventArgs e)
        {
            dateObservation.Value = observationDate;
            txtObservation.Text = observation;
            modify = true;
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (fileNumber != "")
            {
                SqlServer sql = new SqlServer();
                string sqlQuery = sql.deleteRow("dbo.observations", $"CONVERT(VARCHAR, observation) = '{observation}'");

                if (sqlQuery == "")
                {
                    MessageBox.Show("Observacion eliminada correctamente.");

                    loadDataGreedView();
                }
                else
                {
                    MessageBox.Show($"Error al eliminar observacion:\n{sqlQuery}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una observacion");
            }
        }
        private void clear()
        {
            fileNumber = "";
            observation = "";
        }
        private string validation(string myStr)
        {
            Validation valid = new Validation();
            string errors = "";
            if (!valid.textValidation(myStr)) errors += "Observacion\n";

            return errors;
        }
        private void loadDataGreedView()
        {
            tblObsservation.DataSource = new SqlServer().searchRow(typeof(Observation), "dbo.observations", $"employee_file={fileNumber}");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
