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

namespace VistaForm
{
    public partial class Form1 : Form
    {
        Curso curso;
        Alumno alumno;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor(txtNombre.Text, txtApellido.Text, txtDni.Text);
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            curso = new Curso((short)anioCurso.Value, division, profesor);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(curso is null)
            {
                MessageBox.Show("OK", MessageBoxIcon.Error.ToString());                
            }
            rtbDatos.Text = (string)curso;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cmbDivisionAlumno.DataSource = Enum.GetValues(typeof(Divisiones));
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            alumno = new Alumno(txtNombreAlumno.Text, txtApellidoAlumno.Text, txtLegajo.Text, (short)anioAlumno.Value, division);
        }
    }
}
