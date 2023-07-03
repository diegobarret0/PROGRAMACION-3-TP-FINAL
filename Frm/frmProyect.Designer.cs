namespace PROGRAMACION_3_TP_FINAL.Frm
{
    partial class frmProyect
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            txtDocket = new TextBox();
            txtNameProyect = new TextBox();
            txtId = new TextBox();
            textBox6 = new TextBox();
            tblProyect = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnNewProyect = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnSearch = new Button();
            btnTask = new Button();
            btnAddOwner = new Button();
            cmbOwner = new ComboBox();
            proprietorBindingSource = new BindingSource(components);
            proprietorBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)tblProyect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proprietorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proprietorBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 0;
            // 
            // txtDocket
            // 
            txtDocket.Location = new Point(377, 91);
            txtDocket.Name = "txtDocket";
            txtDocket.Size = new Size(269, 23);
            txtDocket.TabIndex = 1;
            // 
            // txtNameProyect
            // 
            txtNameProyect.Location = new Point(191, 25);
            txtNameProyect.Name = "txtNameProyect";
            txtNameProyect.Size = new Size(455, 23);
            txtNameProyect.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(88, 23);
            txtId.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(191, 152);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(154, 23);
            textBox6.TabIndex = 5;
            // 
            // tblProyect
            // 
            tblProyect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblProyect.Location = new Point(12, 260);
            tblProyect.Name = "tblProyect";
            tblProyect.RowTemplate.Height = 25;
            tblProyect.Size = new Size(634, 178);
            tblProyect.TabIndex = 6;
            tblProyect.CellClick += TblProyect_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 7);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre del Proyecto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 9;
            label3.Text = "Costo Estimado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 134);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 10;
            label4.Text = "Tiempo Estimado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 73);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 11;
            label5.Text = "Propietario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(377, 73);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 12;
            label6.Text = "Legajo";
            // 
            // btnNewProyect
            // 
            btnNewProyect.Image = Properties.Resources.proyecto;
            btnNewProyect.Location = new Point(191, 192);
            btnNewProyect.Name = "btnNewProyect";
            btnNewProyect.Size = new Size(129, 33);
            btnNewProyect.TabIndex = 13;
            btnNewProyect.Text = "Nuevo Proyecto\r\n";
            btnNewProyect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNewProyect.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            btnModify.Image = Properties.Resources.dibujo;
            btnModify.Location = new Point(364, 192);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(95, 33);
            btnModify.TabIndex = 14;
            btnModify.Text = "Modificar";
            btnModify.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += BtnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.borrar;
            btnDelete.Location = new Point(559, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 33);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.guardar_el_archivo;
            btnSave.Location = new Point(465, 192);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 33);
            btnSave.TabIndex = 16;
            btnSave.Text = "Guardar";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.search_engine_optimization;
            btnSearch.Location = new Point(12, 192);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 33);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Buscar Proyecto";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnTask
            // 
            btnTask.Image = Properties.Resources.agregar_archivo;
            btnTask.Location = new Point(465, 145);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(75, 30);
            btnTask.TabIndex = 18;
            btnTask.Text = "Tareas";
            btnTask.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += btnTask_Click;
            // 
            // btnAddOwner
            // 
            btnAddOwner.Image = Properties.Resources.agregar_usuario;
            btnAddOwner.Location = new Point(178, 82);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(180, 38);
            btnAddOwner.TabIndex = 0;
            btnAddOwner.Text = "Añadir Nuevo Propietario";
            btnAddOwner.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddOwner.UseVisualStyleBackColor = true;
            btnAddOwner.Click += Propietario_Click;
            // 
            // cmbOwner
            // 
            cmbOwner.FormattingEnabled = true;
            cmbOwner.Location = new Point(12, 91);
            cmbOwner.Name = "cmbOwner";
            cmbOwner.Size = new Size(150, 23);
            cmbOwner.TabIndex = 20;
            // 
            // frmProyect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 450);
            Controls.Add(cmbOwner);
            Controls.Add(btnAddOwner);
            Controls.Add(btnTask);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnNewProyect);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tblProyect);
            Controls.Add(textBox6);
            Controls.Add(txtId);
            Controls.Add(txtNameProyect);
            Controls.Add(txtDocket);
            Controls.Add(textBox1);
            Name = "frmProyect";
            Text = "frmProyect";
            ((System.ComponentModel.ISupportInitialize)tblProyect).EndInit();
            ((System.ComponentModel.ISupportInitialize)proprietorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)proprietorBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtDocket;
        private TextBox txtNameProyect;
        private TextBox txtId;
        private TextBox textBox6;
        private DataGridView tblProyect;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnNewProyect;
        private Button btnModify;
        private Button btnDelete;
        private Button btnSave;
        private Button btnSearch;
        private Button btnTask;
        private Button btnAddOwner;
        private ComboBox cmbOwner;
        private BindingSource proprietorBindingSource;
        private BindingSource proprietorBindingSource1;
    }
}