
namespace Prueba2_ParcialPrimercorte
{
    partial class Modulo_6
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
            this.flPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.flFichasDeJuego = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIniciarJuego = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flPalabra
            // 
            this.flPalabra.Location = new System.Drawing.Point(12, 153);
            this.flPalabra.Name = "flPalabra";
            this.flPalabra.Size = new System.Drawing.Size(870, 63);
            this.flPalabra.TabIndex = 0;
            // 
            // flFichasDeJuego
            // 
            this.flFichasDeJuego.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flFichasDeJuego.Location = new System.Drawing.Point(77, 263);
            this.flFichasDeJuego.Name = "flFichasDeJuego";
            this.flFichasDeJuego.Size = new System.Drawing.Size(696, 274);
            this.flFichasDeJuego.TabIndex = 1;
            this.flFichasDeJuego.Paint += new System.Windows.Forms.PaintEventHandler(this.flFichasDeJuego_Paint);
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarJuego.Location = new System.Drawing.Point(356, 54);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(171, 55);
            this.btnIniciarJuego.TabIndex = 2;
            this.btnIniciarJuego.Text = "INICIAR JUEGO";
            this.btnIniciarJuego.UseVisualStyleBackColor = true;
            this.btnIniciarJuego.Click += new System.EventHandler(this.btnIniciarJuego_Click);
            // 
            // Modulo_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(894, 607);
            this.Controls.Add(this.btnIniciarJuego);
            this.Controls.Add(this.flFichasDeJuego);
            this.Controls.Add(this.flPalabra);
            this.Name = "Modulo_6";
            this.Text = "Modulo_6";
            this.Load += new System.EventHandler(this.Modulo_6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPalabra;
        private System.Windows.Forms.FlowLayoutPanel flFichasDeJuego;
        private System.Windows.Forms.Button btnIniciarJuego;
    }
}