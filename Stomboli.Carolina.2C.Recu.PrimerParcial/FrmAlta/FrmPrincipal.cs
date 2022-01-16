using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmAlta
{
    public partial class FrmPrincipal : Form
    {
        Estacionamiento miE;
        public FrmPrincipal()
        {
            miE = Estacionamiento.InstanciarEstacionamiento("CARO",130,465);
            InitializeComponent();
            // Set the Parent Form of the Child window.
            this.IsMdiContainer = true;
            // Display the new form.
     

        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlta form = FrmAlta.CrearInstancia(miE);

            form.MdiParent = this;
            form.Show();
        }

        private void listarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miE.ToString());
        }
    }
}
