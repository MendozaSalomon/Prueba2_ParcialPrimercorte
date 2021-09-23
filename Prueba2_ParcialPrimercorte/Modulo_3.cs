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
    public partial class Modulo_3 : Form
    {
        public Modulo_3()
        {
            InitializeComponent();
        }

        private void Contador_Click(object sender, EventArgs args)
        {
            string palabra = String.Empty;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            int n = 0;
            int o = 0;
            int p = 0;
            int q = 0;
            int r = 0;
            int s = 0;
            int t = 0;
            int u = 0;
            int v = 0;
            int w = 0;
            int x = 0;
            int y = 0;
            int z = 0;

            palabra = textBox1.Text.ToLower();

            for (int ñ = 0; ñ < palabra.Length; ñ++)
            {

                switch (palabra[ñ])
                {
                    case 'a':
                        a += 1;
                        break;

                    case 'b':
                        b += 1;
                        break;

                    case 'c':
                        c += 1;
                        break;

                    case 'd':
                        d += 1;
                        break;

                    case 'e':
                        e += 1;
                        break;

                    case 'f':
                        f += 1;
                        break;

                    case 'g':
                        g += 1;
                        break;

                    case 'h':
                        h += 1;
                        break;

                    case 'i':
                        i += 1;
                        break;

                    case 'j':
                        j += 1;
                        break;

                    case 'k':
                        k += 1;
                        break;

                    case 'l':
                        l += 1;
                        break;

                    case 'm':
                        m += 1;
                        break;

                    case 'n':
                        n += 1;
                        break;

                    case 'o':
                        o += 1;
                        break;

                    case 'p':
                        p += 1;
                        break;

                    case 'q':
                        q += 1;
                        break;

                    case 'r':
                        r += 1;
                        break;

                    case 's':
                        s += 1;
                        break;

                    case 't':
                        t += 1;
                        break;

                    case 'u':
                        u += 1;
                        break;

                    case 'v':
                        v += 1;
                        break;

                    case 'w':
                        w += 1;
                        break;

                    case 'x':
                        x += 1;
                        break;
                    case 'y':
                        y += 1;
                        break;

                    case 'z':
                        z += 1;
                        break;
                }
            }
            textBox2.Text =

                           "   a:" + a.ToString() + "    b:" + b.ToString() +
                           "    c:" + c.ToString() + "    d:" + d.ToString() +
                           "    e:" + e.ToString() + "    f:" + f.ToString() +
                           "    g:" + g.ToString() + "    h:" + h.ToString() + "\r\n" +
                           "    i:" + i.ToString() + "    j:" + j.ToString() +
                           "    k:" + k.ToString() + "    l:" + l.ToString() +
                           "    m:" + m.ToString() + "    n:" + n.ToString() +
                           "    o:" + o.ToString() + "    p:" + p.ToString() + "\r\n" +
                           "    q:" + q.ToString() + "    r:" + r.ToString() +
                           "    t:" + t.ToString() + "    u:" + u.ToString() +
                           "    v:" + v.ToString() + "    w:" + w.ToString() +
                           "    x:" + x.ToString() + "    y:" + y.ToString() + "\r\n" +
                           "    z:" + z.ToString();
        }
    }
}
