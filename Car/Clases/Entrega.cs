using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Clases
{
    class Entrega
    {

        private SqlCommand comando = new SqlCommand();
        private SqlDataReader listasEntregas;

        private int id_entrega;
        private string kilometraje;
        private string descripestado_entrgea;
        private string descripestado_devolucion;
        private byte[] imagenestado_entrega;
        private byte[] imagenestado_devolucion;
        private string fecha_entrega;
        private string fecha_devolucion;
        private int id_vehiculo;
        private int id_cliente;
        private int id_contrato;
        private int id_empleado;

        public int Id_entrega { get => id_entrega; set => id_entrega = value; }
        public string Kilometraje { get => kilometraje; set => kilometraje = value; }
        public string Descripestado_entrgea { get => descripestado_entrgea; set => descripestado_entrgea = value; }
        public string Descripestado_devolucion { get => descripestado_devolucion; set => descripestado_devolucion = value; }
        public string Fecha_entrega { get => fecha_entrega; set => fecha_entrega = value; }
        public string Fecha_devolucion { get => fecha_devolucion; set => fecha_devolucion = value; }
        public int Id_vehiculo { get => id_vehiculo; set => id_vehiculo = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_contrato { get => id_contrato; set => id_contrato = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public byte[] Imagenestado_entrega { get => imagenestado_entrega; set => imagenestado_entrega = value; }
        public byte[] Imagenestado_devolucion { get => imagenestado_devolucion; set => imagenestado_devolucion = value; }

        public void InsertarEntrega()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "InsertarEntregas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@kilometraje", kilometraje);
            comando.Parameters.AddWithValue("@descripestado_entrega", descripestado_entrgea);
            comando.Parameters.AddWithValue("@descripestado_devolucion", descripestado_devolucion);
            comando.Parameters.AddWithValue("@imagenestado_entrega", Imagenestado_entrega);
            comando.Parameters.AddWithValue("@imagenestado_devolucion", Imagenestado_devolucion);
            comando.Parameters.AddWithValue("@fecha_entrega", fecha_entrega);
            comando.Parameters.AddWithValue("@fecha_devolucion", fecha_devolucion);
            comando.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando.Parameters.AddWithValue("@id_empleado", id_empleado);
            comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            comando.Parameters.AddWithValue("@id_contrato", id_contrato);
            comando.ExecuteNonQuery();

        }

        public void EditarEntrega()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "EditarEntregas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_entrega", id_entrega);
            comando.Parameters.AddWithValue("@kilometraje", kilometraje);
            comando.Parameters.AddWithValue("@descripestado_entrega", descripestado_entrgea);
            comando.Parameters.AddWithValue("@descripestado_devolucion", descripestado_devolucion);
            comando.Parameters.AddWithValue("@imagenestado_entrega", Imagenestado_entrega);
            comando.Parameters.AddWithValue("@imagenestado_devolucion", Imagenestado_devolucion);
            comando.Parameters.AddWithValue("@fecha_entrega", fecha_entrega);
            comando.Parameters.AddWithValue("@fecha_devolucion", fecha_devolucion);
            comando.Parameters.AddWithValue("@id_cliente", id_cliente);
            comando.Parameters.AddWithValue("@id_empleado", id_empleado);
            comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            comando.Parameters.AddWithValue("@id_contrato", id_contrato);

            comando.ExecuteNonQuery();
            Conexion.Conectar().Close();
        }

        public void EliminarEntrgeas()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "EliminarEntregas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_entrega", id_entrega);

            comando.ExecuteNonQuery();
            Conexion.Conectar().Close();
        }

        public DataTable MostrarEntrega()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection("SERVER=Danir;DATABASE=yalexrenta;Integrated security=true"))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand("MostrarEntregas", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        tabla.Load(reader);
                    }
                }
            }

            return tabla;
        }


        public DataTable PlacaVehiculo()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "PlacaVehiculo";
            comando.CommandType = CommandType.StoredProcedure;
            listasEntregas = comando.ExecuteReader();
            tabla.Load(listasEntregas);
            listasEntregas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

        public DataTable NombreCliente()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListadoNombreCliente";
            comando.CommandType = CommandType.StoredProcedure;
            listasEntregas = comando.ExecuteReader();
            tabla.Load(listasEntregas);
            listasEntregas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

        public DataTable NombreEmpleado()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListadoNombreEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            listasEntregas = comando.ExecuteReader();
            tabla.Load(listasEntregas);
            listasEntregas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

        public DataTable IdContrato()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListarContrato";
            comando.CommandType = CommandType.StoredProcedure;
            listasEntregas = comando.ExecuteReader();
            tabla.Load(listasEntregas);
            listasEntregas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

    }
}
