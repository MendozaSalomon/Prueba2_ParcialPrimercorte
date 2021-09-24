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
    public partial class Modulo_4 : Form
    {
        public Modulo_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contrario holi = new contrario();

            string v = textBox1.Text;

            label1.Text = holi.Invertir(v);
        }
    }
}
