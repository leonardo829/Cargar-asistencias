using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CargarAsistenciasBE;

namespace Cargar_asistencias_FE
{
    public partial class Form1 : Form
    {
        Alumno myAlummno = new Alumno();
        int valor;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (textBoxNombreProfesor.Text == "")
            {
                errorNombreProfesor.SetError(textBoxNombreProfesor, "Debe ingresar un nombre");
                textBoxNombreProfesor.Focus();
                return; 
            }
            errorNombreProfesor.SetError(textBoxNombreProfesor, "");


            if (TextBoxNombreMateria.Text == "")
            {
                errorMateria.SetError(TextBoxNombreMateria, "Debe ingresar un nombre");
                TextBoxNombreMateria.Focus();
                return;
            }
            errorMateria.SetError(TextBoxNombreMateria, "");

            if (textBoxNombreInst.Text == "") 
            {
                errorInstitucion.SetError(textBoxNombreInst, "Debe ingresar una institucion");
                textBoxNombreInst.Focus();
                return;

            }
            errorInstitucion.SetError(textBoxNombreInst, "");

            Form2 Formulario2 = new Form2();
            this.Hide();
            Formulario2.Show();
            
        } 


    }
}
