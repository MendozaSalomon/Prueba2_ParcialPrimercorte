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
    public partial class Modulo2 : Form
    {
        public Modulo2()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();
            TrianguloLogic _repository = new TrianguloLogic();

            triangulo.Base = Convert.ToInt32(txtBase.Text);
            triangulo.Altura = Convert.ToInt32(txtAltura.Text);
            txtArea.Text = Convert.ToString(_repository.CalcularArea(triangulo));
        }
    }
}
