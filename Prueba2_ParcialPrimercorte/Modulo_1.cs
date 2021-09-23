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
    public partial class Modulo_1 : Form
    {
        public Modulo_1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int Numero1;
            int Numero2;

            Numero1 = Convert.ToInt32(textBox1.Text);
            Numero2 = Convert.ToInt32(textBox2.Text);


            if (Numero1 < Numero2)
            {
                textBox3.Text = Numero1.ToString() + " Es menor que " +
                      Numero2.ToString();
            }
            else
            {
                textBox3.Text = Numero2.ToString() + " Es menor que " +
                   Numero1.ToString();
            };
        }
    }
}
