namespace CapaInterfaz
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
            botonentrar = new Button();
            buttonsalir = new Button();
            textUsuario = new TextBox();
            textContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // botonentrar
            // 
            botonentrar.Location = new Point(77, 357);
            botonentrar.Margin = new Padding(4, 5, 4, 5);
            botonentrar.Name = "botonentrar";
            botonentrar.Size = new Size(107, 38);
            botonentrar.TabIndex = 0;
            botonentrar.Text = "entrar";
            botonentrar.UseVisualStyleBackColor = true;
            botonentrar.Click += botonentrar_Click;
            // 
            // buttonsalir
            // 
            buttonsalir.Location = new Point(463, 357);
            buttonsalir.Margin = new Padding(4, 5, 4, 5);
            buttonsalir.Name = "buttonsalir";
            buttonsalir.Size = new Size(107, 38);
            buttonsalir.TabIndex = 1;
            buttonsalir.Text = "salir";
            buttonsalir.UseVisualStyleBackColor = true;
            buttonsalir.Click += buttonsalir_Click;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(290, 90);
            textUsuario.Margin = new Padding(4, 5, 4, 5);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(278, 31);
            textUsuario.TabIndex = 2;
            // 
            // textContraseña
            // 
            textContraseña.Location = new Point(290, 243);
            textContraseña.Margin = new Padding(4, 5, 4, 5);
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(278, 31);
            textContraseña.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 4;
            label1.Text = "usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 243);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 5;
            label2.Text = "contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 503);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textContraseña);
            Controls.Add(textUsuario);
            Controls.Add(buttonsalir);
            Controls.Add(botonentrar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonentrar;
        private Button buttonsalir;
        private TextBox textUsuario;
        private TextBox textContraseña;
        private Label label1;
        private Label label2;
    }
}