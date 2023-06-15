namespace PROGRAMACION_3_TP_FINAL.Frm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox8 = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(346, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 141);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(628, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(346, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(127, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(513, 35);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(127, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(183, 97);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(127, 23);
            textBox6.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(513, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(127, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(12, 35);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(88, 23);
            textBox8.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(628, 166);
            dataGridView1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(12, 181);
            button2.Name = "button2";
            button2.Size = new Size(102, 23);
            button2.TabIndex = 11;
            button2.Text = "Nueva Tarea";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(334, 181);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(444, 181);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(565, 181);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 14;
            button5.Text = "Eliminar";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 15;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 17);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 16;
            label2.Text = "Numero de Tarea";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 17);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 17;
            label3.Text = "Horas estimadas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(513, 17);
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
            label7.Location = new Point(513, 76);
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
            // button6
            // 
            button6.Location = new Point(183, 181);
            button6.Name = "button6";
            button6.Size = new Size(102, 23);
            button6.TabIndex = 24;
            button6.Text = "Añadir Personal";
            button6.UseVisualStyleBackColor = true;
            // 
            // frmTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 412);
            Controls.Add(button6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox8);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "frmTask";
            Text = "frmTask";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox8;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button6;
    }
}