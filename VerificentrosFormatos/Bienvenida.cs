using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificentrosFormatos
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void impresionMavisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcesamientoMasivo masivo = new ProcesamientoMasivo();
            masivo.Show();
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NuevoVerificentro nuevo = new NuevoVerificentro();
            nuevo.Show();
        }
    }
}