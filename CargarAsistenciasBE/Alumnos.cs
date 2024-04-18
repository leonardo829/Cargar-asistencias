using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargarAsistenciasBE
{
    public class Alumnos

    {
        public DataTable ListaDT { get; set; } = new DataTable();

        public Alumnos()
        {
            ListaDT.TableName = "ListaAlumnos";
            ListaDT.Columns.Add("Nombredelalumno");
            ListaDT.Columns.Add("Nota");
            ListaDT.Columns.Add("Seguimiento");

            LeerArchivo();            
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists ("Alumnos.xml"))

            {
                ListaDT.ReadXml("Alumnos.xml");
            }

        }
            
        public void InsertAlumno(Alumno aAlumno)
        {
            ListaDT.Rows.Add();//agrego renglon vacio
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["Nombredelalumno"] = aAlumno.Nombredelalumno;
            ListaDT.Rows[NuevoRenglon]["Nota"] = aAlumno.Nota;
            ListaDT.Rows[NuevoRenglon]["Seguimiento"] = aAlumno.Seguimiento;

            ListaDT.WriteXml("Alumnos.xml");



        }


    }
}
