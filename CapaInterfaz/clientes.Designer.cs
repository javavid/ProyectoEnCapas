namespace CapaInterfaz
{
    partial class clientes
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
            textnombre = new TextBox();
            textapellido = new TextBox();
            buttonnuevo = new Button();
            buttoneliminar = new Button();
            buttonguardar = new Button();
            label1 = new Label();
            label2 = new Label();
            campofoto = new PictureBox();
            label3 = new Label();
            linkFoto = new LinkLabel();
            ID = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)campofoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ID).BeginInit();
            SuspendLayout();
            // 
            // textnombre
            // 
            textnombre.Location = new Point(187, 98);
            textnombre.Margin = new Padding(4, 5, 4, 5);
            textnombre.Name = "textnombre";
            textnombre.Size = new Size(141, 31);
            textnombre.TabIndex = 0;
            // 
            // textapellido
            // 
            textapellido.Location = new Point(187, 172);
            textapellido.Margin = new Padding(4, 5, 4, 5);
            textapellido.Name = "textapellido";
            textapellido.Size = new Size(141, 31);
            textapellido.TabIndex = 1;
            // 
            // buttonnuevo
            // 
            buttonnuevo.Location = new Point(107, 548);
            buttonnuevo.Margin = new Padding(4, 5, 4, 5);
            buttonnuevo.Name = "buttonnuevo";
            buttonnuevo.Size = new Size(107, 38);
            buttonnuevo.TabIndex = 2;
            buttonnuevo.Text = "nuevo";
            buttonnuevo.UseVisualStyleBackColor = true;
            buttonnuevo.Click += buttonnuevo_Click;
            // 
            // buttoneliminar
            // 
            buttoneliminar.Location = new Point(266, 548);
            buttoneliminar.Margin = new Padding(4, 5, 4, 5);
            buttoneliminar.Name = "buttoneliminar";
            buttoneliminar.Size = new Size(107, 38);
            buttoneliminar.TabIndex = 3;
            buttoneliminar.Text = "eliminar";
            buttoneliminar.UseVisualStyleBackColor = true;
            // 
            // buttonguardar
            // 
            buttonguardar.Location = new Point(424, 548);
            buttonguardar.Margin = new Padding(4, 5, 4, 5);
            buttonguardar.Name = "buttonguardar";
            buttonguardar.Size = new Size(107, 38);
            buttonguardar.TabIndex = 4;
            buttonguardar.Text = "guardar";
            buttonguardar.UseVisualStyleBackColor = true;
            buttonguardar.Click += buttonguardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 98);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 5;
            label1.Text = "nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 172);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 6;
            label2.Text = "apellido";
            // 
            // campofoto
            // 
            campofoto.Location = new Point(187, 253);
            campofoto.Margin = new Padding(4, 5, 4, 5);
            campofoto.Name = "campofoto";
            campofoto.Size = new Size(143, 160);
            campofoto.TabIndex = 7;
            campofoto.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 253);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 8;
            label3.Text = "foto";
            // 
            // linkFoto
            // 
            linkFoto.AutoSize = true;
            linkFoto.Location = new Point(91, 278);
            linkFoto.Margin = new Padding(4, 0, 4, 0);
            linkFoto.Name = "linkFoto";
            linkFoto.Size = new Size(98, 25);
            linkFoto.TabIndex = 9;
            linkFoto.TabStop = true;
            linkFoto.Text = "seleccionar";
            linkFoto.LinkClicked += linkFoto_LinkClicked;
            // 
            // ID
            // 
            ID.Location = new Point(187, 35);
            ID.Margin = new Padding(4, 5, 4, 5);
            ID.Name = "ID";
            ID.Size = new Size(171, 31);
            ID.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 35);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(27, 25);
            label4.TabIndex = 11;
            label4.Text = "id";
            // 
            // clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 750);
            Controls.Add(label4);
            Controls.Add(ID);
            Controls.Add(linkFoto);
            Controls.Add(label3);
            Controls.Add(campofoto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonguardar);
            Controls.Add(buttoneliminar);
            Controls.Add(buttonnuevo);
            Controls.Add(textapellido);
            Controls.Add(textnombre);
            Margin = new Padding(4, 5, 4, 5);
            Name = "clientes";
            Text = "clientes";
            ((System.ComponentModel.ISupportInitialize)campofoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)ID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textnombre;
        private TextBox textapellido;
        private Button buttonnuevo;
        private Button buttoneliminar;
        private Button buttonguardar;
        private Label label1;
        private Label label2;
        private PictureBox campofoto;
        private Label label3;
        private LinkLabel linkFoto;
        private NumericUpDown ID;
        private Label label4;
    }
}