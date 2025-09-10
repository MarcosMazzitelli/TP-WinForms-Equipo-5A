using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get {  return lector; }

        }


        public AccesoDatos()
        {                                 //NombreServidor(el punto es genérico) ; NombreBaseDeDatos ; Forma de concetarse(Windows authentication)
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DBM; integrated security=true");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            //comando realiza la acción e inyecta la consulta SQL de tipo texto (recibido por parámetro).
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            //ejecuta el comando (consulta SQL (SELECT)) en la conexion (BD)
            comando.Connection = conexion;
            try
            {
                //se abre la conexion y se realiza la lectura.
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                //ejecuta una acción que no sea de lectura (insert, delete, update)
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion()
        {
            //En caso de haber un lector activo cuando se llama al método, también se cierra junto con la conexión.
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

    }
}
