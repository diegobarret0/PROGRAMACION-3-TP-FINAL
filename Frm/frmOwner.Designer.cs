namespace PROGRAMACION_3_TP_FINAL.Frm
{
    partial class frmOwner
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
            txtNameOwner = new TextBox();
            txtBusinessName = new TextBox();
            txtCuit = new TextBox();
            txtPhone = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnModify = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            tblOwner = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tblOwner).BeginInit();
            SuspendLayout();
            // 
            // txtNameOwner
            // 
            txtNameOwner.Location = new Point(12, 44);
            txtNameOwner.Name = "txtNameOwner";
            txtNameOwner.Size = new Size(87, 23);
            txtNameOwner.TabIndex = 0;
            // 
            // txtBusinessName
            // 
            txtBusinessName.Location = new Point(136, 44);
            txtBusinessName.Name = "txtBusinessName";
            txtBusinessName.Size = new Size(176, 23);
            txtBusinessName.TabIndex = 1;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(362, 44);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(300, 23);
            txtCuit.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 115);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 23);
            txtPhone.TabIndex = 3;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(12, 197);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(300, 23);
            txtContact.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(362, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 6;
            label1.Text = "ID Propietario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 26);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 7;
            label2.Text = "Cuit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 26);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 8;
            label3.Text = "Razon Social";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 97);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 9;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 97);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 179);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 11;
            label6.Text = "Persona de Contacto";
            // 
            // btnModify
            // 
            btnModify.Image = Properties.Resources.dibujo;
            btnModify.Location = new Point(362, 188);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(96, 32);
            btnModify.TabIndex = 12;
            btnModify.Text = "Modificar";
            btnModify.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += BtnModify_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.guardar_el_archivo;
            btnSave.Location = new Point(473, 188);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 32);
            btnSave.TabIndex = 13;
            btnSave.Text = "Guardar";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.borrar;
            btnDelete.Location = new Point(574, 188);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 31);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // tblOwner
            // 
            tblOwner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblOwner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblOwner.Location = new Point(12, 243);
            tblOwner.Name = "tblOwner";
            tblOwner.RowTemplate.Height = 25;
            tblOwner.Size = new Size(650, 150);
            tblOwner.TabIndex = 15;
            tblOwner.CellClick += TblOwner_CellClick;
            // 
            // frmOwner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 404);
            Controls.Add(tblOwner);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnModify);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtPhone);
            Controls.Add(txtCuit);
            Controls.Add(txtBusinessName);
            Controls.Add(txtNameOwner);
            Name = "frmOwner";
            Text = "frmOwner";
            Load += frmOwner_Load;
            ((System.ComponentModel.ISupportInitialize)tblOwner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNameOwner;
        private TextBox txtBusinessName;
        private TextBox txtCuit;
        private TextBox txtPhone;
        private TextBox txtContact;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnModify;
        private Button btnSave;
        private Button btnDelete;
        private DataGridView tblOwner;
    }
}