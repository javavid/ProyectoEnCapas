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
            clientes = new TabPage();
            dataGrid = new DataGridView();
            groupclientes = new GroupBox();
            buttonExcel = new Button();
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
            dataGridfactura = new DataGridView();
            buttoneliminarf = new Button();
            buttonguardarf = new Button();
            buttonuevof = new Button();
            label14 = new Label();
            textelf = new TextBox();
            textivaf = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            texttotalf = new TextBox();
            textcantidadf = new TextBox();
            textvalorunif = new TextBox();
            idcodigof = new TextBox();
            inventario = new TabPage();
            panel1 = new Panel();
            label15 = new Label();
            groupBox2 = new GroupBox();
            textentradasi = new TextBox();
            buttoneliminari = new Button();
            buttonguardari = new Button();
            buttonuevoi = new Button();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            dataGridinventario = new DataGridView();
            textdescripcioni = new TextBox();
            textsalidasi = new TextBox();
            textstocki = new TextBox();
            textprecioi = new TextBox();
            textimporteinventarioi = new TextBox();
            idcodigoinv = new TextBox();
            tabControl1.SuspendLayout();
            clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            groupclientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)campofoto).BeginInit();
            facturacion.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridfactura).BeginInit();
            inventario.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridinventario).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(clientes);
            tabControl1.Controls.Add(facturacion);
            tabControl1.Controls.Add(inventario);
            tabControl1.Location = new Point(0, 131);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1114, 579);
            tabControl1.TabIndex = 0;
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
            groupclientes.Controls.Add(buttonExcel);
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
            // buttonExcel
            // 
            buttonExcel.Location = new Point(171, 485);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(186, 34);
            buttonExcel.TabIndex = 17;
            buttonExcel.Text = "Exportar a Excel";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += buttonExcel_Click;
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
            label7.Location = new Point(14, 8);
            label7.Name = "label7";
            label7.Size = new Size(604, 191);
            label7.TabIndex = 1;
            label7.Text = "Factura";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(dataGridfactura);
            groupBox1.Controls.Add(buttoneliminarf);
            groupBox1.Controls.Add(buttonguardarf);
            groupBox1.Controls.Add(buttonuevof);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(textelf);
            groupBox1.Controls.Add(textivaf);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(texttotalf);
            groupBox1.Controls.Add(textcantidadf);
            groupBox1.Controls.Add(textvalorunif);
            groupBox1.Controls.Add(idcodigof);
            groupBox1.Location = new Point(8, 202);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1090, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridfactura
            // 
            dataGridfactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridfactura.Location = new Point(503, 1);
            dataGridfactura.Name = "dataGridfactura";
            dataGridfactura.RowHeadersWidth = 62;
            dataGridfactura.RowTemplate.Height = 33;
            dataGridfactura.Size = new Size(581, 260);
            dataGridfactura.TabIndex = 20;
            // 
            // buttoneliminarf
            // 
            buttoneliminarf.Location = new Point(961, 279);
            buttoneliminarf.Name = "buttoneliminarf";
            buttoneliminarf.Size = new Size(84, 34);
            buttoneliminarf.TabIndex = 17;
            buttoneliminarf.Text = "Eliminar";
            buttoneliminarf.UseVisualStyleBackColor = true;
            // 
            // buttonguardarf
            // 
            buttonguardarf.Location = new Point(833, 279);
            buttonguardarf.Name = "buttonguardarf";
            buttonguardarf.Size = new Size(84, 34);
            buttonguardarf.TabIndex = 16;
            buttonguardarf.Text = "Guardar";
            buttonguardarf.UseVisualStyleBackColor = true;
            buttonguardarf.Click += buttonguardarf_Click;
            // 
            // buttonuevof
            // 
            buttonuevof.Location = new Point(699, 279);
            buttonuevof.Name = "buttonuevof";
            buttonuevof.Size = new Size(84, 34);
            buttonuevof.TabIndex = 14;
            buttonuevof.Text = "Nuevo";
            buttonuevof.UseVisualStyleBackColor = true;
            buttonuevof.Click += buttonuevof_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(452, 239);
            label14.Name = "label14";
            label14.Size = new Size(35, 25);
            label14.TabIndex = 12;
            label14.Text = "tel:";
            // 
            // textelf
            // 
            textelf.Location = new Point(452, 267);
            textelf.Name = "textelf";
            textelf.Size = new Size(201, 31);
            textelf.TabIndex = 11;
            // 
            // textivaf
            // 
            textivaf.Location = new Point(44, 267);
            textivaf.Name = "textivaf";
            textivaf.Size = new Size(344, 31);
            textivaf.TabIndex = 10;
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
            label12.Location = new Point(44, 239);
            label12.Name = "label12";
            label12.Size = new Size(34, 25);
            label12.TabIndex = 8;
            label12.Text = "iva";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(285, 167);
            label11.Name = "label11";
            label11.Size = new Size(48, 25);
            label11.TabIndex = 7;
            label11.Text = "total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(285, 92);
            label10.Name = "label10";
            label10.Size = new Size(82, 25);
            label10.TabIndex = 6;
            label10.Text = "valor Uni";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 167);
            label9.Name = "label9";
            label9.Size = new Size(80, 25);
            label9.TabIndex = 5;
            label9.Text = "cantidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 92);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 4;
            label8.Text = "idcodigof";
            // 
            // texttotalf
            // 
            texttotalf.Location = new Point(285, 195);
            texttotalf.Name = "texttotalf";
            texttotalf.Size = new Size(212, 31);
            texttotalf.TabIndex = 3;
            // 
            // textcantidadf
            // 
            textcantidadf.Location = new Point(44, 195);
            textcantidadf.Name = "textcantidadf";
            textcantidadf.Size = new Size(212, 31);
            textcantidadf.TabIndex = 2;
            // 
            // textvalorunif
            // 
            textvalorunif.Location = new Point(285, 120);
            textvalorunif.Name = "textvalorunif";
            textvalorunif.Size = new Size(212, 31);
            textvalorunif.TabIndex = 1;
            // 
            // idcodigof
            // 
            idcodigof.Location = new Point(44, 120);
            idcodigof.Name = "idcodigof";
            idcodigof.Size = new Size(212, 31);
            idcodigof.TabIndex = 0;
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
            groupBox2.Controls.Add(textentradasi);
            groupBox2.Controls.Add(buttoneliminari);
            groupBox2.Controls.Add(buttonguardari);
            groupBox2.Controls.Add(buttonuevoi);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(dataGridinventario);
            groupBox2.Controls.Add(textdescripcioni);
            groupBox2.Controls.Add(textsalidasi);
            groupBox2.Controls.Add(textstocki);
            groupBox2.Controls.Add(textprecioi);
            groupBox2.Controls.Add(textimporteinventarioi);
            groupBox2.Controls.Add(idcodigoinv);
            groupBox2.Location = new Point(8, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1090, 412);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // textentradasi
            // 
            textentradasi.Location = new Point(6, 254);
            textentradasi.Name = "textentradasi";
            textentradasi.Size = new Size(150, 31);
            textentradasi.TabIndex = 19;
            // 
            // buttoneliminari
            // 
            buttoneliminari.Location = new Point(675, 372);
            buttoneliminari.Name = "buttoneliminari";
            buttoneliminari.Size = new Size(84, 34);
            buttoneliminari.TabIndex = 18;
            buttoneliminari.Text = "Eliminar";
            buttoneliminari.UseVisualStyleBackColor = true;
            // 
            // buttonguardari
            // 
            buttonguardari.Location = new Point(548, 372);
            buttonguardari.Name = "buttonguardari";
            buttonguardari.Size = new Size(84, 34);
            buttonguardari.TabIndex = 17;
            buttonguardari.Text = "Guardar";
            buttonguardari.UseVisualStyleBackColor = true;
            // 
            // buttonuevoi
            // 
            buttonuevoi.Location = new Point(424, 372);
            buttonuevoi.Name = "buttonuevoi";
            buttonuevoi.Size = new Size(84, 34);
            buttonuevoi.TabIndex = 15;
            buttonuevoi.Text = "Nuevo";
            buttonuevoi.UseVisualStyleBackColor = true;
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
            label17.Location = new Point(0, 125);
            label17.Name = "label17";
            label17.Size = new Size(102, 25);
            label17.TabIndex = 9;
            label17.Text = "descripcion";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(0, 40);
            label16.Name = "label16";
            label16.Size = new Size(106, 25);
            label16.TabIndex = 8;
            label16.Text = "idcodigoinv";
            // 
            // dataGridinventario
            // 
            dataGridinventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridinventario.Location = new Point(363, 30);
            dataGridinventario.Name = "dataGridinventario";
            dataGridinventario.RowHeadersWidth = 62;
            dataGridinventario.RowTemplate.Height = 33;
            dataGridinventario.Size = new Size(709, 325);
            dataGridinventario.TabIndex = 7;
            // 
            // textdescripcioni
            // 
            textdescripcioni.Location = new Point(0, 153);
            textdescripcioni.Name = "textdescripcioni";
            textdescripcioni.Size = new Size(150, 31);
            textdescripcioni.TabIndex = 6;
            // 
            // textsalidasi
            // 
            textsalidasi.Location = new Point(6, 358);
            textsalidasi.Name = "textsalidasi";
            textsalidasi.Size = new Size(150, 31);
            textsalidasi.TabIndex = 4;
            // 
            // textstocki
            // 
            textstocki.Location = new Point(207, 68);
            textstocki.Name = "textstocki";
            textstocki.Size = new Size(150, 31);
            textstocki.TabIndex = 3;
            // 
            // textprecioi
            // 
            textprecioi.Location = new Point(207, 153);
            textprecioi.Name = "textprecioi";
            textprecioi.Size = new Size(150, 31);
            textprecioi.TabIndex = 2;
            // 
            // textimporteinventarioi
            // 
            textimporteinventarioi.Location = new Point(207, 254);
            textimporteinventarioi.Name = "textimporteinventarioi";
            textimporteinventarioi.Size = new Size(150, 31);
            textimporteinventarioi.TabIndex = 1;
            // 
            // idcodigoinv
            // 
            idcodigoinv.Location = new Point(0, 68);
            idcodigoinv.Name = "idcodigoinv";
            idcodigoinv.Size = new Size(150, 31);
            idcodigoinv.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)dataGridfactura).EndInit();
            inventario.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridinventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
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
        private TextBox texttotalf;
        private TextBox textcantidadf;
        private TextBox textvalorunif;
        private TextBox idcodigof;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textivaf;
        private Label label13;
        private Label label12;
        private Label label14;
        private TextBox textelf;
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
        private DataGridView dataGridinventario;
        private TextBox textdescripcioni;
        private TextBox textsalidasi;
        private TextBox textstocki;
        private TextBox textprecioi;
        private TextBox textimporteinventarioi;
        private TextBox idcodigoinv;
        private Button buttoneliminarf;
        private Button buttonguardarf;
        private Button buttonuevof;
        private Button buttoneliminari;
        private Button buttonguardari;
        private Button buttonuevoi;
        private DataGridView dataGrid;
        private TextBox textentradasi;
        private DataGridView dataGridfactura;
        private Button buttonExcel;
    }
}