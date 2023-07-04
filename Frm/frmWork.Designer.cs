namespace PROGRAMACION_3_TP_FINAL.Frm
{
    partial class frmWork
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
            btnAdd = new Button();
            tbxDescrption = new TextBox();
            tblFunctions = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)tblFunctions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripcion";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(396, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // tbxDescrption
            // 
            tbxDescrption.Location = new Point(12, 27);
            tbxDescrption.Name = "tbxDescrption";
            tbxDescrption.Size = new Size(378, 23);
            tbxDescrption.TabIndex = 2;
            // 
            // tblFunctions
            // 
            tblFunctions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblFunctions.Location = new Point(12, 56);
            tblFunctions.Name = "tblFunctions";
            tblFunctions.RowTemplate.Height = 25;
            tblFunctions.Size = new Size(776, 246);
            tblFunctions.TabIndex = 3;
            tblFunctions.CellClick += TblFunctions_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(477, 27);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmWork
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 316);
            Controls.Add(btnDelete);
            Controls.Add(tblFunctions);
            Controls.Add(tbxDescrption);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "frmWork";
            Text = "Nueva funcion";
            ((System.ComponentModel.ISupportInitialize)tblFunctions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private TextBox tbxDescrption;
        private DataGridView tblFunctions;
        private Button btnDelete;
    }
}