using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
   public class ConsultasUsuarios
    {
        private Conexion conexion = new Conexion(); 
        SqlDataReader  leer;
        DataTable tabla = new DataTable();
        SqlCommand cm = new SqlCommand();

        public DataTable Mostrar()
        {
            cm.Connection = conexion.Conectar();
            cm.CommandText = "select * from Usuarios";
            leer = cm.ExecuteReader();
            tabla.Load(leer);
            conexion.Desconectar();
            return tabla;
        }

        public void procedimiento( int id , string opcion, string nombre, int edad, string correoElectronico )
        {
            
            cm.Connection = conexion.Conectar();
            cm.CommandText = "spUsuarios";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@id", id);
            cm.Parameters.AddWithValue("@opcion", opcion);
            cm.Parameters.AddWithValue("@nombre", nombre);
            cm.Parameters.AddWithValue("@edad", edad);
            cm.Parameters.AddWithValue("@correoElectronico", correoElectronico);
            cm.ExecuteNonQuery();


            cm.Parameters.Clear();

        }

       

    }
}
