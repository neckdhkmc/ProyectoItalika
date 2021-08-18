using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_Usuarios
    {
        private ConsultasUsuarios obj = new ConsultasUsuarios();
        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = obj.Mostrar();
            return tabla;
        }
        public void AgregarProc(string id, string opcion, string nombre, string edad, string correoElectronico)
        { 
            obj.procedimiento(Convert.ToInt32(id), opcion, nombre,Convert.ToInt32(edad), correoElectronico);
        }
      
    }
}
