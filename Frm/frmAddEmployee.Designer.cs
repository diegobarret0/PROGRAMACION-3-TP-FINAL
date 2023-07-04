namespace PROGRAMACION_3_TP_FINAL.Frm
{
    partial class frmAddEmployee
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
            txbTaskName = new TextBox();
            label2 = new Label();
            cbxEmployee = new ComboBox();
            label3 = new Label();
            cbxFunction = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            tblEmployees = new DataGridView();
            btnAddFunction = new Button();
            ((System.ComponentModel.ISupportInitialize)tblEmployees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Tarea";
            // 
            // txbTaskName
            // 
            txbTaskName.Location = new Point(52, 6);
            txbTaskName.Name = "txbTaskName";
            txbTaskName.Size = new Size(157, 23);
            txbTaskName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Empleado";
            // 
            // cbxEmployee
            // 
            cbxEmployee.FormattingEnabled = true;
            cbxEmployee.Location = new Point(78, 42);
            cbxEmployee.Name = "cbxEmployee";
            cbxEmployee.Size = new Size(121, 23);
            cbxEmployee.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 45);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Funcion";
            // 
            // cbxFunction
            // 
            cbxFunction.FormattingEnabled = true;
            cbxFunction.Location = new Point(279, 42);
            cbxFunction.Name = "cbxFunction";
            cbxFunction.Size = new Size(121, 23);
            cbxFunction.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(420, 41);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(512, 41);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // tblEmployees
            // 
            tblEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblEmployees.Location = new Point(12, 82);
            tblEmployees.Name = "tblEmployees";
            tblEmployees.RowTemplate.Height = 25;
            tblEmployees.Size = new Size(575, 197);
            tblEmployees.TabIndex = 8;
            tblEmployees.CellClick += TblEmployees_CellClick;
            // 
            // btnAddFunction
            // 
            btnAddFunction.Location = new Point(279, 9);
            btnAddFunction.Name = "btnAddFunction";
            btnAddFunction.Size = new Size(101, 23);
            btnAddFunction.TabIndex = 9;
            btnAddFunction.Text = "Añadir funcion";
            btnAddFunction.UseVisualStyleBackColor = true;
            btnAddFunction.Click += BtnAddFunction_Click;
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 299);
            Controls.Add(btnAddFunction);
            Controls.Add(tblEmployees);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(cbxFunction);
            Controls.Add(label3);
            Controls.Add(cbxEmployee);
            Controls.Add(label2);
            Controls.Add(txbTaskName);
            Controls.Add(label1);
            Name = "frmAddEmployee";
            Text = "frmAddEmployee";
            ((System.ComponentModel.ISupportInitialize)tblEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbTaskName;
        private Label label2;
        private ComboBox cbxEmployee;
        private Label label3;
        private ComboBox cbxFunction;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView tblEmployees;
        private Button btnAddFunction;
    }
}