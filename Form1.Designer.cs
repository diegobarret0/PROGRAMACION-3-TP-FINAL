namespace PROGRAMACION_3_TP_FINAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProyect = new Button();
            btnEmployee = new Button();
            btnClient = new Button();
            SuspendLayout();
            // 
            // btnProyect
            // 
            btnProyect.Image = Properties.Resources._43598_briefcase_work_icon;
            btnProyect.Location = new Point(276, 52);
            btnProyect.Name = "btnProyect";
            btnProyect.Size = new Size(198, 76);
            btnProyect.TabIndex = 0;
            btnProyect.Text = "Gestor de Proyectos";
            btnProyect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProyect.UseVisualStyleBackColor = true;
            btnProyect.Click += btnProyect_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Image = Properties.Resources._2620522_employee_folder_job_seeker_unemployee_icon;
            btnEmployee.Location = new Point(276, 172);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(198, 79);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "Administrador de Personal";
            btnEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnClient
            // 
            btnClient.Image = Properties.Resources._61816_business_buyers_clients_users_icon;
            btnClient.Location = new Point(276, 303);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(198, 77);
            btnClient.TabIndex = 2;
            btnClient.Text = "Clientes";
            btnClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClient);
            Controls.Add(btnEmployee);
            Controls.Add(btnProyect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProyect;
        private Button btnEmployee;
        private Button btnClient;
    }
}