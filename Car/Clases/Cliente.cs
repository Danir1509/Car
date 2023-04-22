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
    class Cliente
    {
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leerFilas;
        internal string operacion;

        // string operacion;
        private int id_cliente;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string telefono;
        private string correo;
        private string licencia;
        private string dui;
        private string estado;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Licencia { get => licencia; set => licencia = value; }
        public string Dui { get => dui; set => dui = value; }
        public string Estado { get => estado; set => estado = value; }

        
        public void insertarCliente()
        {

            comando.Connection = Conexion.Conectar();
            comando.CommandText = "insertarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando.Parameters.AddWithValue("@nombres", nombres);
            comando.Parameters.AddWithValue("@apellidos", apellidos);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@licencia", licencia);
            comando.Parameters.AddWithValue("@dui", dui);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.ExecuteNonQuery();
            //  comando.Parameters.Clear();


        }

        public void editarCliente()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "update clientes set nombres ='" + nombres + "',apellidos='" + apellidos + "',direccion='" + direccion + "',telefono='" + telefono + "',correo='" + correo + "',licencia='" + licencia + "',dui='" + dui + "',estado='" + estado + "' where id_cliente=" + id_cliente + "";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            Conexion.Conectar().Close();
        }

        public void eliminarCliente()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "delete clientes where id_cliente=" + id_cliente;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            Conexion.Conectar().Close();

        }
        public DataTable mostrarClientes()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "mostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

    }

}
