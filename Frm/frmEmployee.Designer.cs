﻿namespace PROGRAMACION_3_TP_FINAL.Frm
{
    partial class frmEmployee
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
            txtDocket = new TextBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            dateAmission = new DateTimePicker();
            tblEmployee = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSearch = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnModify = new Button();
            btnNewEmployee = new Button();
            btnObservation = new Button();
            ((System.ComponentModel.ISupportInitialize)tblEmployee).BeginInit();
            SuspendLayout();
            // 
            // txtDocket
            // 
            txtDocket.Location = new Point(12, 35);
            txtDocket.Name = "txtDocket";
            txtDocket.Size = new Size(139, 23);
            txtDocket.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(193, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(238, 23);
            txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(468, 35);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(238, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 104);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(238, 23);
            txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(296, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 23);
            txtEmail.TabIndex = 5;
            // 
            // dateAmission
            // 
            dateAmission.Location = new Point(567, 104);
            dateAmission.Name = "dateAmission";
            dateAmission.Size = new Size(139, 23);
            dateAmission.TabIndex = 6;
            // 
            // tblEmployee
            // 
            tblEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblEmployee.Location = new Point(12, 202);
            tblEmployee.Name = "tblEmployee";
            tblEmployee.RowTemplate.Height = 25;
            tblEmployee.Size = new Size(694, 173);
            tblEmployee.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "Legajo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 17);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 17);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 86);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 11;
            label4.Text = "Celular";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(296, 86);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(567, 86);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 13;
            label6.Text = "Fecha de Ingreso";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 159);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(540, 159);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(631, 159);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(444, 159);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 17;
            btnModify.Text = "Modificar";
            btnModify.UseVisualStyleBackColor = true;
            // 
            // btnNewEmployee
            // 
            btnNewEmployee.Location = new Point(296, 159);
            btnNewEmployee.Name = "btnNewEmployee";
            btnNewEmployee.Size = new Size(113, 23);
            btnNewEmployee.TabIndex = 18;
            btnNewEmployee.Text = "Nuevo Empleado";
            btnNewEmployee.UseVisualStyleBackColor = true;
            // 
            // btnObservation
            // 
            btnObservation.Location = new Point(130, 159);
            btnObservation.Name = "btnObservation";
            btnObservation.Size = new Size(120, 23);
            btnObservation.TabIndex = 19;
            btnObservation.Text = "Añadir Observacion";
            btnObservation.UseVisualStyleBackColor = true;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 388);
            Controls.Add(btnObservation);
            Controls.Add(btnNewEmployee);
            Controls.Add(btnModify);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnSearch);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tblEmployee);
            Controls.Add(dateAmission);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtDocket);
            Name = "frmEmployee";
            Text = "frmEmployee";
            ((System.ComponentModel.ISupportInitialize)tblEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDocket;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private DateTimePicker dateAmission;
        private DataGridView tblEmployee;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSearch;
        private Button btnSave;
        private Button btnDelete;
        private Button btnModify;
        private Button btnNewEmployee;
        private Button btnObservation;
    }
}