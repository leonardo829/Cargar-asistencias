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
    public partial class Form2 : Form
    {
        Alumno myAlumno = new Alumno();
        public DataTable ListaDT { get; set; } = new DataTable(); 
        
        public Alumnos ListaAlumnos { get; set; } = new Alumnos();
        
        public Form2()
        {
            InitializeComponent();
            DataGridView1.DataSource = ListaAlumnos.ListaDT;

        }



        private void btnCargar_Click(object sender, EventArgs e)
        {
            decimal Verificacion;
            if (!Decimal.TryParse(textBoxNota.Text, out Verificacion))

            {
                errorNota.SetError(textBoxNota, "Ingrese una nota valida");
                return;
            }

            else
            {
                errorNota.SetError(textBoxNota, "");

                MessageBox.Show("Alumno Cargado");


                Alumno alumno = new Alumno();
                alumno.Cargar(textBoxNombreDelAlumno.Text,
                               textBoxApellidoDelAlumno.Text,
                               textBoxNota.Text,
                               textBoxSeguimiento.Text);

                ListaAlumnos.InsertAlumno(alumno);

                DataGridView1.DataSource = ListaAlumnos.ListaDT;
            }
        }
    }
}
