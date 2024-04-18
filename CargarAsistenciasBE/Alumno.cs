using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargarAsistenciasBE
{
    public class Alumno
    {
        public string Nombredelalumno { get; set; }

        public string Apellidodelalumno { get; set; }

        public int Nota { get; set; }
        
        public string Seguimiento { get; set; }

        public void Cargar(string aNombredelalumno,
              string aApellidodelalumno,
              string aNota,
              string aSeguimiento)
        {
            Nombredelalumno = aNombredelalumno;
            Apellidodelalumno = aApellidodelalumno;
            Nota = Convert.ToInt32(aNota); 
            Seguimiento = aSeguimiento;
        }                               
    }
}
