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
            personasLista = new ListView();
            dniColumna = new ColumnHeader();
            nombreColumna = new ColumnHeader();
            apellidoColumna = new ColumnHeader();
            edicionGrupo = new GroupBox();
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
            nuevaBoton = new Button();
            borrarBoton = new Button();
            modificarBoton = new Button();
            label8 = new Label();
            textBox6 = new TextBox();
            button6 = new Button();
            listaGrupo = new GroupBox();
            edicionGrupo.SuspendLayout();
            SuspendLayout();
            // 
            // personasLista
            // 
            personasLista.Columns.AddRange(new ColumnHeader[] { dniColumna, nombreColumna, apellidoColumna });
            personasLista.Location = new Point(12, 69);
            personasLista.Name = "personasLista";
            personasLista.Size = new Size(776, 235);
            personasLista.TabIndex = 0;
            personasLista.UseCompatibleStateImageBehavior = false;
            personasLista.View = View.Details;
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
            // edicionGrupo
            // 
            edicionGrupo.Controls.Add(button4);
            edicionGrupo.Controls.Add(button5);
            edicionGrupo.Controls.Add(comboBox1);
            edicionGrupo.Controls.Add(textBox7);
            edicionGrupo.Controls.Add(label7);
            edicionGrupo.Controls.Add(textBox4);
            edicionGrupo.Controls.Add(textBox5);
            edicionGrupo.Controls.Add(label4);
            edicionGrupo.Controls.Add(label5);
            edicionGrupo.Controls.Add(label6);
            edicionGrupo.Controls.Add(textBox3);
            edicionGrupo.Controls.Add(textBox2);
            edicionGrupo.Controls.Add(label3);
            edicionGrupo.Controls.Add(label2);
            edicionGrupo.Controls.Add(textBox1);
            edicionGrupo.Controls.Add(label1);
            edicionGrupo.Enabled = false;
            edicionGrupo.Location = new Point(12, 341);
            edicionGrupo.Name = "edicionGrupo";
            edicionGrupo.Size = new Size(776, 258);
            edicionGrupo.TabIndex = 1;
            edicionGrupo.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(582, 211);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "&Aceptar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(682, 211);
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
            // nuevaBoton
            // 
            nuevaBoton.Location = new Point(694, 310);
            nuevaBoton.Name = "nuevaBoton";
            nuevaBoton.Size = new Size(94, 29);
            nuevaBoton.TabIndex = 2;
            nuevaBoton.Text = "&Nueva";
            nuevaBoton.UseVisualStyleBackColor = true;
            // 
            // borrarBoton
            // 
            borrarBoton.Location = new Point(521, 310);
            borrarBoton.Name = "borrarBoton";
            borrarBoton.Size = new Size(167, 29);
            borrarBoton.TabIndex = 3;
            borrarBoton.Text = "&Borrar seleccionada";
            borrarBoton.UseVisualStyleBackColor = true;
            borrarBoton.Click += borrarBoton_Click;
            // 
            // modificarBoton
            // 
            modificarBoton.Location = new Point(329, 310);
            modificarBoton.Name = "modificarBoton";
            modificarBoton.Size = new Size(186, 29);
            modificarBoton.TabIndex = 4;
            modificarBoton.Text = "&Modificar seleccionada\r\n";
            modificarBoton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(271, 20);
            label8.TabIndex = 5;
            label8.Text = "Busqueda por Apellido / Nombre / DNI";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 32);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(302, 27);
            textBox6.TabIndex = 16;
            // 
            // button6
            // 
            button6.Location = new Point(688, 30);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 17;
            button6.Text = "&Buscar";
            button6.UseVisualStyleBackColor = true;
            // 
            // listaGrupo
            // 
            listaGrupo.Location = new Point(3, 9);
            listaGrupo.Name = "listaGrupo";
            listaGrupo.Size = new Size(794, 341);
            listaGrupo.TabIndex = 18;
            listaGrupo.TabStop = false;
            listaGrupo.Text = "groupBox2";
            // 
            // ABMPersonasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 611);
            Controls.Add(button6);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(modificarBoton);
            Controls.Add(borrarBoton);
            Controls.Add(nuevaBoton);
            Controls.Add(edicionGrupo);
            Controls.Add(personasLista);
            Controls.Add(listaGrupo);
            Name = "ABMPersonasForm";
            Text = "Alta de personas";
            Load += ABMPersonasForm_Load;
            edicionGrupo.ResumeLayout(false);
            edicionGrupo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView personasLista;
        private ColumnHeader dniColumna;
        private ColumnHeader nombreColumna;
        private ColumnHeader apellidoColumna;
        private GroupBox edicionGrupo;
        private Button nuevaBoton;
        private Button borrarBoton;
        private Button modificarBoton;
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
        private Label label8;
        private TextBox textBox6;
        private Button button6;
        private GroupBox listaGrupo;
    }
}
