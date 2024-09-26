namespace TomasSampietro.Prototipos.Ejercicio04
{
    partial class ABMPersonasForm
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
            listView1 = new ListView();
            dniColumna = new ColumnHeader();
            nombreColumna = new ColumnHeader();
            apellidoColumna = new ColumnHeader();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { dniColumna, nombreColumna, apellidoColumna });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 201);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // dniColumna
            // 
            dniColumna.Text = "DNI";
            // 
            // nombreColumna
            // 
            nombreColumna.Text = "Nombre";
            // 
            // apellidoColumna
            // 
            apellidoColumna.Text = "Apellido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 254);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 314);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(582, 279);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "&Aceptar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(682, 279);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.Text = "&Cancelar";
            button5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 28);
            comboBox1.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(352, 158);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(82, 27);
            textBox7.TabIndex = 14;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(352, 130);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 13;
            label7.Text = "Cod. Area";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(440, 158);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(322, 27);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(267, 158);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(72, 27);
            textBox5.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 130);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 10;
            label4.Text = "Numero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 130);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 9;
            label5.Text = "Cod. Pais";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 130);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 7;
            label6.Text = "Tipo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(538, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(275, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 27);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 43);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 43);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 43);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // button1
            // 
            button1.Location = new Point(694, 219);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "&Nueva";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(521, 219);
            button2.Name = "button2";
            button2.Size = new Size(167, 29);
            button2.TabIndex = 3;
            button2.Text = "&Borrar seleccionada";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(329, 219);
            button3.Name = "button3";
            button3.Size = new Size(186, 29);
            button3.TabIndex = 4;
            button3.Text = "&Modificar seleccionada\r\n";
            button3.UseVisualStyleBackColor = true;
            // 
            // ABMPersonasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 611);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Name = "ABMPersonasForm";
            Text = "Form1";
            Load += ABMPersonasForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader dniColumna;
        private ColumnHeader nombreColumna;
        private ColumnHeader apellidoColumna;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
    }
}
