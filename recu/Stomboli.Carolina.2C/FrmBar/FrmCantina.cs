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
    public partial class FrmCantina : Form
    {
        public FrmCantina()
        {
            InitializeComponent();
        }

        public string GetCantina
        {
            get
            {
                return this.barra1.Cantina;
            }
        }

        public string GetInforme 
        {
            get
            {
                return ;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbTipo.SelectedValue.ToString(), out tipo); 

            if (btnCerveza.Checked)
            {
                Cerveza c1 = new Cerveza((int)numericUpDown1.Value, (int)numericUpDown2.Value,txtMarca.Text, tipo);
                barra1.AgregarBotella(c1);
            }
            else if (btnAgua.Checked)
            {
                Agua a1 = new Agua((int)numericUpDown1.Value, (int)numericUpDown2.Value, txtMarca.Text);
                barra1.AgregarBotella(a1);
            }
        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
            }
            else
            {
                
                messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
            }           
           
            MessageBox.Show(messageBoxCS.ToString());
        }
    }
}
