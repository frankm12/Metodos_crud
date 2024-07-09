using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;


namespace CapaNegocios
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPRod (string nombre, string desc, string marca, double precio, int stock)
        {
            objetoCD.Insertar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }
    }
}
