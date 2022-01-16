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
    public partial class FrmAlta : Form
    {
        static FrmAlta frmAlta_instancia;
        Estacionamiento miE;

        /// <summary>
        /// El metodo crea una nueva instancia si el form es null,
        /// si no retorna la instancia.
        /// </summary>
        /// <param name="e">El form instanciado.</param>
        /// <returns></returns>
        public static FrmAlta CrearInstancia(Estacionamiento e)
        {
            if(frmAlta_instancia is null)
            {
                return frmAlta_instancia = new FrmAlta(e);                
            }
            else
            {
                return frmAlta_instancia;
            }
        }

        /// <summary>
        /// El metodo inicializa un Form recibiendo 
        /// un Estacionamiento.
        /// </summary>
        /// <param name="e"></param>
        public FrmAlta(Estacionamiento e)
        {
            InitializeComponent();
            miE = e;

        }

        /// <summary>
        /// El evento agrega los enumerados a los combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbColor.DataSource = Enum.GetValues(typeof(eColores));
            cmbTransm.DataSource = Enum.GetValues(typeof(eTransmision));
        }

        /// <summary>
        /// El evento valida que se ingrese un nombre y agrega un Auto o una Moto segun corresponda,
        /// al estacionamiento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length==0)
            {
                MessageBox.Show("El nombre esta vacio, por favor cargar nuevametne.");               
            }
            else
            {
                if (rdAuto.Checked)
                {
                    Auto auto = new Auto(txtPatenteVehiculo.Text, txtNombre.Text, Convert.ToInt32(txtDni.Text), cmbTransm.Text, cmbColor.Text);
                    if (miE + auto)
                    {
                        MessageBox.Show("El auto fue agregado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("El auto no pudo ser agregado.");
                    }
                }
                else if (rdMoto.Checked)
                {
                    Moto moto = new Moto(txtPatenteVehiculo.Text, txtNombre.Text, Convert.ToInt32(txtDni.Text), Convert.ToInt32(txtCilindrada.Text), cmbColor.Text);
                    if (miE + moto)
                    {
                        MessageBox.Show("La moto fue agregada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("La moto no pudo ser agregada.");
                    }
                }
            }       
        }

        /// <summary>
        /// El Evento setea en null el Form y lo cierra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmAlta_instancia = null; 
            Close();
        }

        /// <summary>
        /// El Evento setea en null el Form y lo cierra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAlta_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAlta_instancia = null;
        }

        /// <summary>
        /// El evento, si se selecciona auto. 
        /// muestra Transmicion y oculta Cilindrada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdAuto_CheckedChanged(object sender, EventArgs e)
        {
            lblCilindrada.Visible =false;
            txtCilindrada.Visible = false;
            cmbTransm.Visible = true;
            lblTransmision.Visible = true;
        }

        /// <summary>
        /// El evento, si se selecciona moto. 
        /// muestra Cilindrara y oculta Transmision. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdMoto_CheckedChanged(object sender, EventArgs e)
        {
            lblCilindrada.Visible = true;
            txtCilindrada.Visible = true;
            cmbTransm.Visible = false;
            lblTransmision.Visible = false;
        }
    }
}
