﻿using PROGRAMACION_3_TP_FINAL.DataBaseServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROGRAMACION_3_TP_FINAL.Frm
{
    public partial class frmTask : Form
    {
        private string idTask;
        private string projectId;
        private bool modify = false;
        private string description;
        private string estimatedHours;
        private string estimatedCost;
        private string actualHours;
        private string actualCost;
        private DateTime endDate;
        public frmTask(string projectId)
        {
            InitializeComponent();
            this.projectId = projectId;

            /*DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "id";*/
            txtTaskId.Enabled = false;
            txtTaskId.Text = this.projectId;

            /*DataGridViewColumn idProyectColumn = new DataGridViewTextBoxColumn();
            idProyectColumn.HeaderText = "ID Proyecto";
            idProyectColumn.DataPropertyName = "proyect_id";*/

            DataGridViewColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.HeaderText = "Descripcion";
            descriptionColumn.DataPropertyName = "description_";

            DataGridViewColumn estimatedHoursColumn = new DataGridViewTextBoxColumn();
            estimatedHoursColumn.HeaderText = "Horas estimadas";
            estimatedHoursColumn.DataPropertyName = "estimated_hours";

            DataGridViewColumn estimatedCostColumn = new DataGridViewTextBoxColumn();
            estimatedCostColumn.HeaderText = "Costo estimado";
            estimatedCostColumn.DataPropertyName = "estimated_cost";

            DataGridViewColumn actualHoursColumn = new DataGridViewTextBoxColumn();
            actualHoursColumn.HeaderText = "Horas reales";
            actualHoursColumn.DataPropertyName = "actual_hours";

            DataGridViewColumn actualCostColumn = new DataGridViewTextBoxColumn();
            actualCostColumn.HeaderText = "Costo real";
            actualCostColumn.DataPropertyName = "actual_cost";

            DataGridViewColumn endDateColumn = new DataGridViewTextBoxColumn();
            endDateColumn.HeaderText = "Fecha final";
            endDateColumn.DataPropertyName = "end_date";

            //tblTask.Columns.Add(idProyectColumn);
            tblTask.Columns.Add(descriptionColumn);
            tblTask.Columns.Add(estimatedHoursColumn);
            tblTask.Columns.Add(estimatedCostColumn);
            tblTask.Columns.Add(actualHoursColumn);
            tblTask.Columns.Add(actualCostColumn);
            tblTask.Columns.Add(endDateColumn);
            tblTask.DataSource = new SqlServer().searchRow(typeof(Entities.Task), "dbo.task", $"proyect_id={projectId};");
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!modify)
            {
                description = txtDescription.Text.Trim();
                estimatedHours = txtEstimatedHours.Text.Trim();
                estimatedCost = txtEstimatedCost.Text.Trim();
                actualHours = txtRealHours.Text.Trim();
                actualCost = txtRealCost.Text.Trim();
                string valid = validation(description, estimatedHours, estimatedCost, actualHours, actualCost);

                if (valid == "")
                {
                    Entities.Task myTask = new Entities.Task(
                        int.Parse(projectId),
                        description,
                        int.Parse(estimatedHours),
                        decimal.Parse(estimatedCost),
                        int.Parse(actualHours),
                        decimal.Parse(actualCost),
                        dateFinal.Value
                    );

                    SqlServer sql = new SqlServer();

                    string sqlQuery = sql.insertRow(myTask, "dbo.task");

                    if (sqlQuery == "")
                    {
                        MessageBox.Show("Tarea guardada correctamente");
                        txtDescription.Text = "";
                        txtEstimatedHours.Text = "";
                        txtEstimatedCost.Text = "";
                        txtRealHours.Text = "";
                        txtRealCost.Text = "";
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
                description = txtDescription.Text.Trim();
                estimatedHours = txtEstimatedHours.Text.Trim();
                estimatedCost = txtEstimatedCost.Text.Trim();
                actualHours = txtRealHours.Text.Trim();
                actualCost = txtRealCost.Text.Trim();
                string valid = validation(description, estimatedHours, estimatedCost, actualHours, actualCost);

                if (valid == "")
                {
                    Entities.Task myTask = new Entities.Task(
                        int.Parse(projectId),
                        description,
                        int.Parse(estimatedHours),
                        decimal.Parse(estimatedCost),
                        int.Parse(actualHours),
                        decimal.Parse(actualCost),
                        dateFinal.Value
                    );

                    SqlServer sql = new SqlServer();

                    string sqlQuery = sql.updateRow(myTask, "dbo.task", $"id={idTask};");

                    if (sqlQuery == "")
                    {
                        MessageBox.Show("Tarea modificada correctamente");
                        txtDescription.Text = "";
                        txtEstimatedHours.Text = "";
                        txtEstimatedCost.Text = "";
                        txtRealHours.Text = "";
                        txtRealCost.Text = "";
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
            tblTask.DataSource = new SqlServer().searchRow(typeof(Entities.Task), "dbo.task", $"proyect_id={projectId}");
        }
        private void BtnModify_Click(object sender, EventArgs e)
        {
            txtDescription.Text = description;
            txtEstimatedHours.Text = estimatedHours;
            txtEstimatedCost.Text = estimatedCost;
            txtRealHours.Text = actualHours;
            txtRealCost.Text = actualCost;
            dateFinal.Value = endDate;

            modify = true;
        }
        private void TblTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = tblTask.Rows[e.RowIndex];

                idTask = row.Cells[0].Value.ToString();
                description = row.Cells[2].Value.ToString();
                estimatedHours = row.Cells[3].Value.ToString();
                estimatedCost = row.Cells[4].Value.ToString();
                actualHours = row.Cells[5].Value.ToString();
                actualCost = row.Cells[6].Value.ToString();
                endDate = DateTime.Parse(row.Cells[7].Value.ToString());
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlServer sql = new SqlServer();
            string sqlQuery = sql.deleteRow("dbo.task", $"id={idTask};");

            if (sqlQuery == "")
            {
                MessageBox.Show("Tarea eliminada correctamente.");
            }
            else
            {
                MessageBox.Show($"Error al eliminar Tarea:\n{sqlQuery}");
            }
            tblTask.DataSource = new SqlServer().searchRow(typeof(Entities.Task), "dbo.task", $"proyect_id={projectId};");
        }
        private string validation(string description, string estimatedHours, string estimatedCost, string actualHours, string actualCost)
        {
            Validation valid = new Validation();
            string errors = "";

            if (!valid.textValidation(description)) errors += "Descripcion\n";
            if (!valid.numericValidation(estimatedHours)) errors += "Horas estimadas\n";
            if (!valid.decimalValidation(estimatedCost)) errors += "Costo estimado\n";
            if (!valid.numericValidation(actualHours)) errors += "Horas reales\n";
            if (!valid.decimalValidation(actualCost)) errors += "Costo real\n";

            return errors;
        }
    }
}
