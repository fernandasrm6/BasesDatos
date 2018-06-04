using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCongreso
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas con = new Consultas();
            con.Show();
        }

        private void subprogramasAlmacenadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subprogramas sp = new Subprogramas();
            sp.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulos com = new Articulos();
            com.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
