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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Modulo_1_Click(object sender, EventArgs e)
        {
            Modulo_1 Prueba1 = new Modulo_1();
            Prueba1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo_4 Prueba4 = new Modulo_4();
            Prueba4.Show();
        }

        private void Modulo_2_Click(object sender, EventArgs e)
        {
            Modulo2 Prueba2 = new Modulo2();
            Prueba2.Show();
        }
    }
}
