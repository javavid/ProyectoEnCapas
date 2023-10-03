namespace CapaInterfaz
{
    partial class Form2
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
            buttonnuevo = new Button();
            buttoneliminar = new Button();
            buttonguardar = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            checkBox1provedores = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // buttonnuevo
            // 
            buttonnuevo.Location = new Point(75, 329);
            buttonnuevo.Name = "buttonnuevo";
            buttonnuevo.Size = new Size(75, 23);
            buttonnuevo.TabIndex = 2;
            buttonnuevo.Text = "nuevo";
            buttonnuevo.UseVisualStyleBackColor = true;
            // 
            // buttoneliminar
            // 
            buttoneliminar.Location = new Point(186, 329);
            buttoneliminar.Name = "buttoneliminar";
            buttoneliminar.Size = new Size(75, 23);
            buttoneliminar.TabIndex = 3;
            buttoneliminar.Text = "eliminar";
            buttoneliminar.UseVisualStyleBackColor = true;
            // 
            // buttonguardar
            // 
            buttonguardar.Location = new Point(297, 329);
            buttonguardar.Name = "buttonguardar";
            buttonguardar.Size = new Size(75, 23);
            buttonguardar.TabIndex = 4;
            buttonguardar.Text = "guardar";
            buttonguardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 59);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 103);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "apellido";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(131, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 96);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 152);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 8;
            label3.Text = "foto";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(64, 167);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(66, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "seleccionar";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(131, 21);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 21);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 11;
            label4.Text = "id";
            // 
            // checkBox1provedores
            // 
            checkBox1provedores.AutoSize = true;
            checkBox1provedores.Location = new Point(322, 43);
            checkBox1provedores.Name = "checkBox1provedores";
            checkBox1provedores.Size = new Size(85, 19);
            checkBox1provedores.TabIndex = 12;
            checkBox1provedores.Text = "provedores";
            checkBox1provedores.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
            Controls.Add(checkBox1provedores);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonguardar);
            Controls.Add(buttoneliminar);
            Controls.Add(buttonnuevo);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonnuevo;
        private Button buttoneliminar;
        private Button buttonguardar;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private LinkLabel linkLabel1;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private CheckBox checkBox1provedores;
    }
}