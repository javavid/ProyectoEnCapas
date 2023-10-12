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
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupclientes = new GroupBox();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            Fotocliente = new PictureBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            botonNuevo = new Button();
            botonModificar = new Button();
            botonGuardar = new Button();
            botonEliminar = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupclientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Fotocliente).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 131);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1114, 579);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1106, 541);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Proveedores";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupclientes);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1106, 541);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Clientes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupclientes
            // 
            groupclientes.Controls.Add(botonEliminar);
            groupclientes.Controls.Add(botonGuardar);
            groupclientes.Controls.Add(botonModificar);
            groupclientes.Controls.Add(botonNuevo);
            groupclientes.Controls.Add(linkLabel1);
            groupclientes.Controls.Add(label6);
            groupclientes.Controls.Add(label5);
            groupclientes.Controls.Add(textBox5);
            groupclientes.Controls.Add(textBox4);
            groupclientes.Controls.Add(label4);
            groupclientes.Controls.Add(label3);
            groupclientes.Controls.Add(label2);
            groupclientes.Controls.Add(label1);
            groupclientes.Controls.Add(textBox3);
            groupclientes.Controls.Add(textBox2);
            groupclientes.Controls.Add(textBox1);
            groupclientes.Controls.Add(numericUpDown1);
            groupclientes.Controls.Add(Fotocliente);
            groupclientes.Location = new Point(8, 6);
            groupclientes.Name = "groupclientes";
            groupclientes.Size = new Size(538, 525);
            groupclientes.TabIndex = 0;
            groupclientes.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(60, 30);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(120, 25);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "seleccionFoto";
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
            // textBox5
            // 
            textBox5.Location = new Point(301, 381);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(186, 31);
            textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(42, 381);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 31);
            textBox4.TabIndex = 9;
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
            // textBox3
            // 
            textBox3.Location = new Point(301, 293);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 293);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 31);
            textBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(42, 210);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 1;
            // 
            // Fotocliente
            // 
            Fotocliente.Location = new Point(186, 30);
            Fotocliente.Name = "Fotocliente";
            Fotocliente.Size = new Size(150, 149);
            Fotocliente.TabIndex = 0;
            Fotocliente.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1106, 541);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Facturacion";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1106, 541);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Inventario";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // botonNuevo
            // 
            botonNuevo.Location = new Point(42, 433);
            botonNuevo.Name = "botonNuevo";
            botonNuevo.Size = new Size(84, 34);
            botonNuevo.TabIndex = 13;
            botonNuevo.Text = "Nuevo";
            botonNuevo.UseVisualStyleBackColor = true;
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
            // botonGuardar
            // 
            botonGuardar.Location = new Point(301, 433);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(84, 34);
            botonGuardar.TabIndex = 15;
            botonGuardar.Text = "Guardar";
            botonGuardar.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(403, 433);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(84, 34);
            botonEliminar.TabIndex = 16;
            botonEliminar.Text = "Eliminar";
            botonEliminar.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 708);
            Controls.Add(tabControl1);
            Name = "Menu";
            Text = "Menu";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupclientes.ResumeLayout(false);
            groupclientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Fotocliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupclientes;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private PictureBox Fotocliente;
        private Label label6;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label4;
        private Label label3;
        private Label label2;
        private LinkLabel linkLabel1;
        private Button botonEliminar;
        private Button botonGuardar;
        private Button botonModificar;
        private Button botonNuevo;
    }
}