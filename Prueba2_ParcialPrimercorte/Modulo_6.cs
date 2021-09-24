using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2_ParcialPrimercorte
{
    public partial class Modulo_6 : Form
    {

        char[] PalabrasAdivinadas;
        char[] PalabraSeleccionada;
        int Oportunidades;
        char[] Alfabeto;
        String[] Palabras;



        public Modulo_6()
        {
            InitializeComponent();
        }
        public void IniciarJuego()
        {

            flFichasDeJuego.Controls.Clear();
            flFichasDeJuego.Enabled = true;
            Oportunidades = 0;
            Palabras = new string[] { "azul aguamarina", "rosado intenso", "verde claro", "purpura oscuro" };


            Alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();
            Random random = new Random();
            int IndicePalabraSeleccionada = random.Next(0, Palabras.Length);
            PalabraSeleccionada = Palabras[IndicePalabraSeleccionada].ToUpper().ToCharArray();
            PalabrasAdivinadas = PalabraSeleccionada;

            foreach (char LetraAlfabeto in Alfabeto)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = "";
                btnLetra.Text = LetraAlfabeto.ToString();
                btnLetra.Width = 60;
                btnLetra.Height = 40;
                btnLetra.Click += Compara;
                btnLetra.ForeColor = Color.PaleTurquoise;
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                btnLetra.BackColor = Color.BurlyWood;
                btnLetra.Name = LetraAlfabeto.ToString();
                flFichasDeJuego.Controls.Add(btnLetra);




            }
            flPalabra.Controls.Clear();

            for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSeleccionada.Length; IndiceValorLetra++)
            {

                Button Letra = new Button();
                Letra.Tag = PalabraSeleccionada[IndiceValorLetra].ToString();
                Letra.Width = 46;
                Letra.Height = 80;
                Letra.ForeColor = Color.BurlyWood;
                Letra.Text = "_";
                Letra.Font = new Font(Letra.Font.Name, 32, FontStyle.Bold);
                Letra.BackgroundImageLayout = ImageLayout.Center;
                Letra.BackColor = Color.White;
                Letra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Letra.Name = "Adivinado" + IndiceValorLetra.ToString();

                flPalabra.Controls.Add(Letra);

            }
        }

        void Compara(object sender, EventArgs e)
        {

            bool encontrado = false;
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;

            for (int IndiceRevisar = 0; IndiceRevisar < PalabrasAdivinadas.Length; IndiceRevisar++)
            {
                if (PalabrasAdivinadas[IndiceRevisar] == Char.Parse(btn.Text))
                {

                    Button tbx = this.Controls.Find("Adivinado" + IndiceRevisar, true).FirstOrDefault() as Button;

                    tbx.Text = PalabrasAdivinadas[IndiceRevisar].ToString();
                    PalabrasAdivinadas[IndiceRevisar] = '_';
                    encontrado = true;




                }


            }
            bool Ganaste = true;

            for (int indiceAnalizadorGanador = 0; indiceAnalizadorGanador < PalabrasAdivinadas.Length; indiceAnalizadorGanador++)
            {
                if (PalabrasAdivinadas[indiceAnalizadorGanador] != '_')
                {

                    Ganaste = false;
                }


            }


            if (Ganaste)
            {

                MessageBox.Show("ADIVINASTE MUY RAPIDO!");
            }
            if (!encontrado)
            {

                Oportunidades = Oportunidades + 1;


                if (Oportunidades == 7)
                {


                    //lblMensaje.Visible = true;

                    for (int indiceValorLetra = 0; indiceValorLetra < PalabraSeleccionada.Length; indiceValorLetra++)
                    {

                        Button btnLetra = this.Controls.Find("Adivinado" + indiceValorLetra, true).FirstOrDefault() as Button;
                        btnLetra.Text = btnLetra.Tag.ToString();
                    }

                    flFichasDeJuego.Enabled = false;




                }
            }
        }



















       

        private void Modulo_6_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        private void flFichasDeJuego_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            IniciarJuego();
        }
    }
}
