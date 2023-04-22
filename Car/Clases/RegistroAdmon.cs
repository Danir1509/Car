using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Car.Clases
{
    class RegistroAdmon
    {
        private SqlCommand comantools = new SqlCommand();
        private SqlDataReader LeerFilas2;
        internal string operacion2;

        private int id_empleado;
        private string nombre;
        private string usuario;
        private string contrasena;
        private string tipo_empleado;

        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Tipo_empleado { get => tipo_empleado; set => tipo_empleado = value; }

        public void insertarRegistroEmpleados()
        {
            comantools.Connection = Conexion.Conectar();
            comantools.CommandText = "insertarRegistroEmpleados";
            comantools.CommandType = CommandType.StoredProcedure;
            comantools.Parameters.AddWithValue("@nombre", nombre);
            comantools.Parameters.AddWithValue("@usuario", usuario);
            comantools.Parameters.AddWithValue("@contrasena", contrasena);
            comantools.Parameters.AddWithValue("@tipo_empleado", tipo_empleado);
            comantools.ExecuteNonQuery();

        }

        public void editarRegistroAdmon()
        {
            comantools.Connection = Conexion.Conectar();
            comantools.CommandText = "update empleado set nombre ='" + nombre + "',usuario='" + usuario + "',contrasena='" + contrasena + "',tipo_empleado='" + tipo_empleado + "' where id_empleado=" + id_empleado + "";
            comantools.CommandType = CommandType.Text;
            comantools.ExecuteNonQuery();
            Conexion.Conectar().Close();
        }

        public void eliminarRegistroAdmon()
        {
            comantools.Connection = Conexion.Conectar();
            comantools.CommandText = "delete empleado where id_empleado=" + id_empleado;
            comantools.CommandType = CommandType.Text;
            comantools.ExecuteNonQuery();
            Conexion.Conectar().Close();

        }

        public DataTable mostrarRegistroAdmon()
        {
            DataTable tabla1 = new DataTable();
            comantools.Connection = Conexion.Conectar();
            comantools.CommandText = "mostrarRegistroAdmon";
            comantools.CommandType = CommandType.StoredProcedure;
            LeerFilas2 = comantools.ExecuteReader();
            tabla1.Load(LeerFilas2);
            LeerFilas2.Close();
            Conexion.Conectar().Close();
            return tabla1;
        }




    }


}
