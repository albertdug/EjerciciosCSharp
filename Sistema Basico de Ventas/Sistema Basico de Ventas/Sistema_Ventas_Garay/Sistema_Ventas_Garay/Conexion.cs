using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Sistema_Ventas_Garay
{
    class Conexion
    {
        public static SqlConnection obtenerconexion()
        {
            SqlConnection miconexion = new SqlConnection
            ("Data source=(local);DataBase=garay_ventas;Integrated Security=SSPI");
            miconexion.Open();
            return miconexion;
        }
    }
}
