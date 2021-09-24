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
    public partial class Modulo_5 : Form
    {
        public Modulo_5()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text.Length);
            String exp;
            bool pangrama = true;
            for (int i = 0; i < n; i++)
            {

                exp = textBox1.Text.Trim();
                for (char ascii = 'A'; ascii <= 'Z'; ascii++)
                {

                    if (!exp.ToUpper().Contains("" + ascii))
                    {
                        pangrama = false;
                    }
                }
            };
            textBox2.Text = (pangrama ? "SI" : "NO");
        }
    }
    
}
