using PROGRAMACION_3_TP_FINAL.DataBaseServices;

namespace PROGRAMACION_3_TP_FINAL.Frm
{
    partial class frmObservation
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
            label1 = new Label();
            label2 = new Label();
            txtObservation = new TextBox();
            txtDocket = new TextBox();
            tblObsservation = new DataGridView();
            btnModify = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            dateObservation = new DateTimePicker();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)tblObsservation).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Legajo del Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 27);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Observaciones";
            // 
            // txtObservation
            // 
            txtObservation.Location = new Point(171, 57);
            txtObservation.Multiline = true;
            txtObservation.Name = "txtObservation";
            txtObservation.Size = new Size(557, 79);
            txtObservation.TabIndex = 2;
            // 
            // txtDocket
            // 
            txtDocket.Location = new Point(12, 57);
            txtDocket.Name = "txtDocket";
            txtDocket.Size = new Size(117, 23);
            txtDocket.TabIndex = 3;
            // 
            // tblObsservation
            // 
            tblObsservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblObsservation.Location = new Point(12, 197);
            tblObsservation.Name = "tblObsservation";
            tblObsservation.RowTemplate.Height = 25;
            tblObsservation.Size = new Size(716, 152);
            tblObsservation.TabIndex = 4;
            tblObsservation.CellClick += TblObsservation_CellClick;
            // 
            // btnModify
            // 
            btnModify.Image = Properties.Resources.dibujo;
            btnModify.Location = new Point(409, 149);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(90, 32);
            btnModify.TabIndex = 5;
            btnModify.Text = "Modificar";
            btnModify.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += BtnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.borrar;
            btnDelete.Location = new Point(627, 149);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 32);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.guardar_el_archivo;
            btnSave.Location = new Point(521, 149);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 32);
            btnSave.TabIndex = 7;
            btnSave.Text = "Guardar";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // dateObservation
            // 
            dateObservation.Format = DateTimePickerFormat.Short;
            dateObservation.Location = new Point(12, 113);
            dateObservation.Name = "dateObservation";
            dateObservation.Size = new Size(139, 23);
            dateObservation.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 9;
            label3.Text = "Fecha";
            // 
            // frmObservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 364);
            Controls.Add(label3);
            Controls.Add(dateObservation);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(tblObsservation);
            Controls.Add(txtDocket);
            Controls.Add(txtObservation);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmObservation";
            Text = "frmObservation";
            ((System.ComponentModel.ISupportInitialize)tblObsservation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtObservation;
        private TextBox txtDocket;
        private DataGridView tblObsservation;
        private Button btnModify;
        private Button btnDelete;
        private Button btnSave;
        private DateTimePicker dateObservation;
        private Label label3;
    }
}