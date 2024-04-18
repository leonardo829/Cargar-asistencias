using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargarAsistenciasBE
{
    public class Usuario
    {

        public string Nombre { get; set; }

        public string Materia { get; set; }

        public string Insitucion { get; set; }

        public void Entrar(string aNombre,
             string aMateria,
             string aInstitucion)
        {
            Nombre = aNombre;
            Materia = aMateria;
            Insitucion = aInstitucion;




        }
    }
}
