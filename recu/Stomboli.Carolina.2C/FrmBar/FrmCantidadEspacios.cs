using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBar
{
    public partial class Espacios : Form
    {
        public Espacios()
        {
            InitializeComponent();
        }      
        
        public short CantidadEspacios 
        {
            get
            {
                return (short)nudCantindad.Value;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Text =DialogResult.Cancel.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            btnAceptar.Text= DialogResult.OK.ToString();
        }

        
    }
}
