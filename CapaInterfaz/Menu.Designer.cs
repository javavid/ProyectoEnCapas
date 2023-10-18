namespace CapaInterfaz
{
    partial class Menu
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
            tabControl1 = new TabControl();
            proveedores = new TabPage();
            clientes = new TabPage();
            dataGrid = new DataGridView();
            groupclientes = new GroupBox();
            botonEliminar = new Button();
            botonGuardar = new Button();
            botonModificar = new Button();
            botonNuevo = new Button();
            linkFoto = new LinkLabel();
            label6 = new Label();
            label5 = new Label();
            textdireccion = new TextBox();
            textcelular = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textapellido = new TextBox();
            textemail = new TextBox();
            textnombre = new TextBox();
            ID = new NumericUpDown();
            campofoto = new PictureBox();
            facturacion = new TabPage();
            label7 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label14 = new Label();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            inventario = new TabPage();
            panel1 = new Panel();
            label15 = new Label();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            dataGridView1 = new DataGridView();
            textBox18 = new TextBox();
            textBox17 = new TextBox();
            textBox16 = new TextBox();
            textBox15 = new TextBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            tabControl1.SuspendLayout();
            clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            groupclientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)campofoto).BeginInit();
            facturacion.SuspendLayout();
            groupBox1.SuspendLayout();
            inventario.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(proveedores);
            tabControl1.Controls.Add(clientes);
            tabControl1.Controls.Add(facturacion);
            tabControl1.Controls.Add(inventario);
            tabControl1.Location = new Point(0, 131);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1114, 579);
            tabControl1.TabIndex = 0;
            // 
            // proveedores
            // 
            proveedores.Location = new Point(4, 34);
            proveedores.Name = "proveedores";
            proveedores.Padding = new Padding(3);
            proveedores.Size = new Size(1106, 541);
            proveedores.TabIndex = 0;
            proveedores.Text = "Proveedores";
            proveedores.UseVisualStyleBackColor = true;
            // 
            // clientes
            // 
            clientes.Controls.Add(dataGrid);
            clientes.Controls.Add(groupclientes);
            clientes.Location = new Point(4, 34);
            clientes.Name = "clientes";
            clientes.Padding = new Padding(3);
            clientes.Size = new Size(1106, 541);
            clientes.TabIndex = 1;
            clientes.Text = "Clientes";
            clientes.UseVisualStyleBackColor = true;
            clientes.Click += clientes_Click;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(572, 22);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowTemplate.Height = 33;
            dataGrid.Size = new Size(526, 509);
            dataGrid.TabIndex = 1;
            dataGrid.CellDoubleClick += dataGrid_CellDoubleClick;
            // 
            // groupclientes
            // 
            groupclientes.Controls.Add(botonEliminar);
            groupclientes.Controls.Add(botonGuardar);
            groupclientes.Controls.Add(botonModificar);
            groupclientes.Controls.Add(botonNuevo);
            groupclientes.Controls.Add(linkFoto);
            groupclientes.Controls.Add(label6);
            groupclientes.Controls.Add(label5);
            groupclientes.Controls.Add(textdireccion);
            groupclientes.Controls.Add(textcelular);
            groupclientes.Controls.Add(label4);
            groupclientes.Controls.Add(label3);
            groupclientes.Controls.Add(label2);
            groupclientes.Controls.Add(label1);
            groupclientes.Controls.Add(textapellido);
            groupclientes.Controls.Add(textemail);
            groupclientes.Controls.Add(textnombre);
            groupclientes.Controls.Add(ID);
            groupclientes.Controls.Add(campofoto);
            groupclientes.Location = new Point(8, 6);
            groupclientes.Name = "groupclientes";
            groupclientes.Size = new Size(538, 525);
            groupclientes.TabIndex = 0;
            groupclientes.TabStop = false;
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(403, 433);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(84, 34);
            botonEliminar.TabIndex = 16;
            botonEliminar.Text = "Eliminar";
            botonEliminar.UseVisualStyleBackColor = true;
            botonEliminar.Click += botonEliminar_Click;
            // 
            // botonGuardar
            // 
            botonGuardar.Location = new Point(301, 433);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(84, 34);
            botonGuardar.TabIndex = 15;
            botonGuardar.Text = "Guardar";
            botonGuardar.UseVisualStyleBackColor = true;
            botonGuardar.Click += botonGuardar_Click;
            // 
            // botonModificar
            // 
            botonModificar.Location = new Point(138, 433);
            botonModificar.Name = "botonModificar";
            botonModificar.Size = new Size(84, 34);
            botonModificar.TabIndex = 14;
            botonModificar.Text = "Modificar";
            botonModificar.UseVisualStyleBackColor = true;
            // 
            // botonNuevo
            // 
            botonNuevo.Location = new Point(42, 433);
            botonNuevo.Name = "botonNuevo";
            botonNuevo.Size = new Size(84, 34);
            botonNuevo.TabIndex = 13;
            botonNuevo.Text = "Nuevo";
            botonNuevo.UseVisualStyleBackColor = true;
            botonNuevo.Click += botonNuevo_Click;
            // 
            // linkFoto
            // 
            linkFoto.AutoSize = true;
            linkFoto.Location = new Point(60, 30);
            linkFoto.Name = "linkFoto";
            linkFoto.Size = new Size(120, 25);
            linkFoto.TabIndex = 1;
            linkFoto.TabStop = true;
            linkFoto.Text = "seleccionFoto";
            linkFoto.LinkClicked += linkFoto_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 353);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 12;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 353);
            label5.Name = "label5";
            label5.Size = new Size(40, 25);
            label5.TabIndex = 11;
            label5.Text = "Cel:";
            // 
            // textdireccion
            // 
            textdireccion.Location = new Point(301, 381);
            textdireccion.Name = "textdireccion";
            textdireccion.Size = new Size(186, 31);
            textdireccion.TabIndex = 10;
            // 
            // textcelular
            // 
            textcelular.Location = new Point(42, 381);
            textcelular.Name = "textcelular";
            textcelular.Size = new Size(180, 31);
            textcelular.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 265);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 8;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 265);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 182);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 182);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 5;
            label1.Text = "id";
            // 
            // textapellido
            // 
            textapellido.Location = new Point(301, 293);
            textapellido.Name = "textapellido";
            textapellido.Size = new Size(186, 31);
            textapellido.TabIndex = 4;
            // 
            // textemail
            // 
            textemail.Location = new Point(42, 293);
            textemail.Name = "textemail";
            textemail.Size = new Size(180, 31);
            textemail.TabIndex = 3;
            // 
            // textnombre
            // 
            textnombre.Location = new Point(301, 210);
            textnombre.Name = "textnombre";
            textnombre.Size = new Size(186, 31);
            textnombre.TabIndex = 2;
            // 
            // ID
            // 
            ID.Location = new Point(42, 210);
            ID.Name = "ID";
            ID.Size = new Size(180, 31);
            ID.TabIndex = 1;
            // 
            // campofoto
            // 
            campofoto.Location = new Point(186, 30);
            campofoto.Name = "campofoto";
            campofoto.Size = new Size(150, 149);
            campofoto.TabIndex = 0;
            campofoto.TabStop = false;
            // 
            // facturacion
            // 
            facturacion.BackColor = Color.DarkGray;
            facturacion.Controls.Add(label7);
            facturacion.Controls.Add(groupBox1);
            facturacion.Location = new Point(4, 34);
            facturacion.Name = "facturacion";
            facturacion.Padding = new Padding(3);
            facturacion.Size = new Size(1106, 541);
            facturacion.TabIndex = 2;
            facturacion.Text = "Facturacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(275, 8);
            label7.Name = "label7";
            label7.Size = new Size(604, 191);
            label7.TabIndex = 1;
            label7.Text = "Factura";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Location = new Point(8, 202);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1090, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            button3.Location = new Point(961, 279);
            button3.Name = "button3";
            button3.Size = new Size(84, 34);
            button3.TabIndex = 17;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(833, 279);
            button2.Name = "button2";
            button2.Size = new Size(84, 34);
            button2.TabIndex = 16;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(699, 279);
            button1.Name = "button1";
            button1.Size = new Size(84, 34);
            button1.TabIndex = 14;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(460, 201);
            label14.Name = "label14";
            label14.Size = new Size(35, 25);
            label14.TabIndex = 12;
            label14.Text = "tel:";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(460, 229);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(201, 31);
            textBox11.TabIndex = 11;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(44, 229);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(344, 31);
            textBox10.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(571, 201);
            label13.Name = "label13";
            label13.Size = new Size(0, 25);
            label13.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(44, 201);
            label12.Name = "label12";
            label12.Size = new Size(34, 25);
            label12.TabIndex = 8;
            label12.Text = "iva";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(833, 57);
            label11.Name = "label11";
            label11.Size = new Size(48, 25);
            label11.TabIndex = 7;
            label11.Text = "total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(571, 57);
            label10.Name = "label10";
            label10.Size = new Size(82, 25);
            label10.TabIndex = 6;
            label10.Text = "valor Uni";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(308, 57);
            label9.Name = "label9";
            label9.Size = new Size(80, 25);
            label9.TabIndex = 5;
            label9.Text = "cantidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 57);
            label8.Name = "label8";
            label8.Size = new Size(68, 25);
            label8.TabIndex = 4;
            label8.Text = "codigo";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(833, 85);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(212, 31);
            textBox9.TabIndex = 3;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(308, 85);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(212, 31);
            textBox8.TabIndex = 2;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(571, 85);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(212, 31);
            textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(44, 85);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(212, 31);
            textBox6.TabIndex = 0;
            // 
            // inventario
            // 
            inventario.Controls.Add(panel1);
            inventario.Controls.Add(groupBox2);
            inventario.Location = new Point(4, 34);
            inventario.Name = "inventario";
            inventario.Padding = new Padding(3);
            inventario.Size = new Size(1106, 541);
            inventario.TabIndex = 3;
            inventario.Text = "Inventario";
            inventario.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label15);
            panel1.Location = new Point(8, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1090, 129);
            panel1.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Bisque;
            label15.Location = new Point(342, 20);
            label15.Name = "label15";
            label15.Size = new Size(403, 96);
            label15.TabIndex = 0;
            label15.Text = "inventario";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Linen;
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(textBox18);
            groupBox2.Controls.Add(textBox17);
            groupBox2.Controls.Add(textBox16);
            groupBox2.Controls.Add(textBox15);
            groupBox2.Controls.Add(textBox14);
            groupBox2.Controls.Add(textBox13);
            groupBox2.Controls.Add(textBox12);
            groupBox2.Location = new Point(8, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1090, 412);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button6
            // 
            button6.Location = new Point(675, 372);
            button6.Name = "button6";
            button6.Size = new Size(84, 34);
            button6.TabIndex = 18;
            button6.Text = "Eliminar";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(548, 372);
            button5.Name = "button5";
            button5.Size = new Size(84, 34);
            button5.TabIndex = 17;
            button5.Text = "Guardar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(424, 372);
            button4.Name = "button4";
            button4.Size = new Size(84, 34);
            button4.TabIndex = 15;
            button4.Text = "Nuevo";
            button4.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(207, 226);
            label22.Name = "label22";
            label22.Size = new Size(158, 25);
            label22.TabIndex = 14;
            label22.Text = "importe inventario";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(207, 125);
            label21.Name = "label21";
            label21.Size = new Size(61, 25);
            label21.TabIndex = 13;
            label21.Text = "precio";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(207, 40);
            label20.Name = "label20";
            label20.Size = new Size(54, 25);
            label20.TabIndex = 12;
            label20.Text = "stock";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 330);
            label19.Name = "label19";
            label19.Size = new Size(65, 25);
            label19.TabIndex = 11;
            label19.Text = "salidas";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 226);
            label18.Name = "label18";
            label18.Size = new Size(80, 25);
            label18.TabIndex = 10;
            label18.Text = "entradas";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 125);
            label17.Name = "label17";
            label17.Size = new Size(102, 25);
            label17.TabIndex = 9;
            label17.Text = "descripcion";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 40);
            label16.Name = "label16";
            label16.Size = new Size(68, 25);
            label16.TabIndex = 8;
            label16.Text = "codigo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(648, 262);
            dataGridView1.TabIndex = 7;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(6, 153);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(150, 31);
            textBox18.TabIndex = 6;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(6, 254);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(150, 31);
            textBox17.TabIndex = 5;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(6, 358);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(150, 31);
            textBox16.TabIndex = 4;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(207, 68);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(150, 31);
            textBox15.TabIndex = 3;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(207, 153);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(150, 31);
            textBox14.TabIndex = 2;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(207, 254);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(150, 31);
            textBox13.TabIndex = 1;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(6, 68);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(150, 31);
            textBox12.TabIndex = 0;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 708);
            Controls.Add(tabControl1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            tabControl1.ResumeLayout(false);
            clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            groupclientes.ResumeLayout(false);
            groupclientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ID).EndInit();
            ((System.ComponentModel.ISupportInitialize)campofoto).EndInit();
            facturacion.ResumeLayout(false);
            facturacion.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            inventario.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage proveedores;
        private TabPage clientes;
        private TabPage facturacion;
        private TabPage inventario;
        private GroupBox groupclientes;
        private Label label1;
        private TextBox textapellido;
        private TextBox textemail;
        private TextBox textnombre;
        private NumericUpDown ID;
        private PictureBox campofoto;
        private Label label6;
        private Label label5;
        private TextBox textdireccion;
        private TextBox textcelular;
        private Label label4;
        private Label label3;
        private Label label2;
        private LinkLabel linkFoto;
        private Button botonEliminar;
        private Button botonGuardar;
        private Button botonModificar;
        private Button botonNuevo;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBox10;
        private Label label13;
        private Label label12;
        private Label label14;
        private TextBox textBox11;
        private Panel panel1;
        private GroupBox groupBox2;
        private Label label15;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private DataGridView dataGridView1;
        private TextBox textBox18;
        private TextBox textBox17;
        private TextBox textBox16;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox12;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private DataGridView dataGrid;
    }
}