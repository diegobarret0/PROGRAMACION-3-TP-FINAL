﻿namespace PROGRAMACION_3_TP_FINAL.Frm
{
    partial class frmTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEstimatedHours = new TextBox();
            txtDescription = new TextBox();
            txtRealCost = new TextBox();
            txtEstimatedCost = new TextBox();
            txtRealHours = new TextBox();
            dateFinal = new DateTimePicker();
            txtTaskId = new TextBox();
            tblTask = new DataGridView();
            btnNewTask = new Button();
            btnModify = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAddEmployee = new Button();
            cbxActive = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)tblTask).BeginInit();
            SuspendLayout();
            // 
            // txtEstimatedHours
            // 
            txtEstimatedHours.Location = new Point(183, 35);
            txtEstimatedHours.Name = "txtEstimatedHours";
            txtEstimatedHours.Size = new Size(127, 23);
            txtEstimatedHours.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 141);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(628, 23);
            txtDescription.TabIndex = 2;
            // 
            // txtRealCost
            // 
            txtRealCost.Location = new Point(346, 94);
            txtRealCost.Name = "txtRealCost";
            txtRealCost.Size = new Size(127, 23);
            txtRealCost.TabIndex = 3;
            // 
            // txtEstimatedCost
            // 
            txtEstimatedCost.Location = new Point(346, 35);
            txtEstimatedCost.Name = "txtEstimatedCost";
            txtEstimatedCost.Size = new Size(127, 23);
            txtEstimatedCost.TabIndex = 4;
            // 
            // txtRealHours
            // 
            txtRealHours.Location = new Point(183, 97);
            txtRealHours.Name = "txtRealHours";
            txtRealHours.Size = new Size(127, 23);
            txtRealHours.TabIndex = 5;
            // 
            // dateFinal
            // 
            dateFinal.Location = new Point(513, 70);
            dateFinal.Name = "dateFinal";
            dateFinal.Size = new Size(127, 23);
            dateFinal.TabIndex = 7;
            // 
            // txtTaskId
            // 
            txtTaskId.Location = new Point(12, 35);
            txtTaskId.Name = "txtTaskId";
            txtTaskId.Size = new Size(88, 23);
            txtTaskId.TabIndex = 8;
            // 
            // tblTask
            // 
            tblTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblTask.Location = new Point(12, 230);
            tblTask.Name = "tblTask";
            tblTask.RowTemplate.Height = 25;
            tblTask.Size = new Size(628, 166);
            tblTask.TabIndex = 9;
            tblTask.CellClick += TblTask_CellClick;
            // 
            // btnNewTask
            // 
            btnNewTask.Image = Properties.Resources.agregar_archivo;
            btnNewTask.Location = new Point(12, 176);
            btnNewTask.Name = "btnNewTask";
            btnNewTask.Size = new Size(128, 33);
            btnNewTask.TabIndex = 11;
            btnNewTask.Text = "Nueva Tarea";
            btnNewTask.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNewTask.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            btnModify.Image = Properties.Resources.dibujo;
            btnModify.Location = new Point(334, 176);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(105, 33);
            btnModify.TabIndex = 12;
            btnModify.Text = "Modificar";
            btnModify.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += BtnModify_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.guardar_el_archivo;
            btnSave.Location = new Point(445, 176);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 33);
            btnSave.TabIndex = 13;
            btnSave.Text = "Guardar";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.borrar;
            btnDelete.Location = new Point(547, 176);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 33);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 15;
            label1.Text = "ID Tarea";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 17);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 17;
            label3.Text = "Horas estimadas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 17);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 18;
            label4.Text = "Costo Estimado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 76);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 19;
            label5.Text = "Horas Reales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 76);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 20;
            label6.Text = "Costo Real";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(513, 52);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 21;
            label7.Text = "Fecha Final";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 123);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 22;
            label8.Text = "Descripcion";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Image = Properties.Resources.agregar_usuario;
            btnAddEmployee.ImageAlign = ContentAlignment.BottomCenter;
            btnAddEmployee.Location = new Point(183, 176);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(127, 33);
            btnAddEmployee.TabIndex = 24;
            btnAddEmployee.Text = "Añadir Personal";
            btnAddEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += BtnAddEmployee_Click;
            // 
            // cbxActive
            // 
            cbxActive.AutoSize = true;
            cbxActive.Location = new Point(17, 94);
            cbxActive.Name = "cbxActive";
            cbxActive.Size = new Size(79, 19);
            cbxActive.TabIndex = 27;
            cbxActive.Text = "Finalizado";
            cbxActive.UseVisualStyleBackColor = true;
            cbxActive.Click += CbxActive_Click;
            // 
            // frmTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 412);
            Controls.Add(cbxActive);
            Controls.Add(btnAddEmployee);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnModify);
            Controls.Add(btnNewTask);
            Controls.Add(tblTask);
            Controls.Add(txtTaskId);
            Controls.Add(dateFinal);
            Controls.Add(txtRealHours);
            Controls.Add(txtEstimatedCost);
            Controls.Add(txtRealCost);
            Controls.Add(txtDescription);
            Controls.Add(txtEstimatedHours);
            Name = "frmTask";
            Text = "frmTask";
            ((System.ComponentModel.ISupportInitialize)tblTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEstimatedHours;
        private TextBox txtDescription;
        private TextBox txtRealCost;
        private TextBox txtEstimatedCost;
        private TextBox txtRealHours;
        private DateTimePicker dateFinal;
        private TextBox txtTaskId;
        private DataGridView tblTask;
        private Button btnNewTask;
        private Button btnModify;
        private Button btnSave;
        private Button btnDelete;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnAddEmployee;
        private CheckBox cbxActive;
    }
}