using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();
        //esto es para leer data de las tablas
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
            //TRANSACT SQL
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

            //PROCEDIMIENTO
        }

        public void Insertar (string nombre, string desc, string marca, double precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into PRODUCTOS values ('"+nombre+"','"+desc+"','"+marca+"',"+precio+","+stock+"),";
            comando.ExecuteNonQuery();
        }
    }
}
