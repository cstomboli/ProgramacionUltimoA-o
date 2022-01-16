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

namespace FrmBar
{
    public partial class FrmBar : Form
    {
        public FrmBar()
        {
            InitializeComponent();
        }        

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Espacios espacios = new Espacios(); 
            Cantina c = new Cantina(espacios.CantidadEspacios);
            espacios.ShowDialog();

            /*
            if(this.Edificio + FrmCantina.GetCantidadEspacios)
            {
                FrmCantina.MdiParent = this;
                FrmCantina.Show();
            }
            */
        }
    }
}
