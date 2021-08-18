using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Datos
{
   public class Conexion
    {
        private SqlConnection conexion = new SqlConnection(@"server=DESKTOP-E505JNB\SQLEXPRESS;database=italikaBD;User ID=sa;Password=Disturbio1");
        public SqlConnection Conectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();

            }
            return conexion;

        }
        public SqlConnection Desconectar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
                
            }
            return conexion;
        }
    }
}
