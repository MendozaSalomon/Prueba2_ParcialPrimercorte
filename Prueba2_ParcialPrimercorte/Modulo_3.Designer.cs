
namespace Prueba2_ParcialPrimercorte
{
    partial class Modulo_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Contador = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulo 3- cuenta letras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "El programa permitirá ingresar un frase o palabra y contará cuantas veces esta ca" +
    "da letra. \r\nPor ejemplo, para la frase “HOLA CASA” deberá mostrar como resultado" +
    ": H:1 O:1 L:1 A:3 C:1 S:1";
            // 
            // Contador
            // 
            this.Contador.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Contador.Location = new System.Drawing.Point(307, 237);
            this.Contador.Name = "Contador";
            this.Contador.Size = new System.Drawing.Size(155, 23);
            this.Contador.TabIndex = 2;
            this.Contador.Text = "Contar vocales y letras ";
            this.Contador.UseVisualStyleBackColor = false;
            this.Contador.Click += new System.EventHandler(this.Contador_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(508, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 266);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 76);
            this.textBox2.TabIndex = 4;
            // 
            // Modulo_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::Prueba2_ParcialPrimercorte.Properties.Resources._19;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Contador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modulo_3";
            this.Text = "Modulo_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Contador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}