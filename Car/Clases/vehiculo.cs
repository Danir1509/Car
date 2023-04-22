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
    class vehiculo
    {
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leerFilas;
        //string operacion
        private int id_vehiculo;
        private string placa;
        private string marca;
        private string tipo_vehiculo;
        private string tipo_transmision;
        private string categoria;
        private string condicion_vehiculo;
        private string capacidad;
        private string consumo_combus;
        private string precio_dia;
        private string anio;
        private string estado;

        public int Id_vehiculo { get => id_vehiculo; set => id_vehiculo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Tipo_vehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }
        public string Tipo_transmision { get => tipo_transmision; set => tipo_transmision = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Condicion_vehiculo { get => condicion_vehiculo; set => condicion_vehiculo = value; }
        public string Capacidad { get => capacidad; set => capacidad = value; }
        public string Consumo_combus { get => consumo_combus; set => consumo_combus = value; }
        public string Precio_dia { get => precio_dia; set => precio_dia = value; }
        public string Anio { get => anio; set => anio = value; }
        public string Estado { get => estado; set => estado = value; }

        public DataTable listarTipoVehiculo()
        {
            DataTable table = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListarVehiculo";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            table.Load(leerFilas);
            leerFilas.Close();
            Conexion.Conectar().Close();
            return table;


        }

        public DataTable listarTipoTransmision()
        {
            DataTable table = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "listarTransmision";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            table.Load(leerFilas);
            leerFilas.Close();
            Conexion.Conectar().Close();
            return table;


        }

        public DataTable listarCategoria()
        {
            DataTable table = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "listarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            table.Load(leerFilas);
            leerFilas.Close();
            Conexion.Conectar().Close();
            return table;


        }

        public DataTable mostrarVehiculos()
        {
            DataTable table = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListarVehiculos";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            table.Load(leerFilas);
            leerFilas.Close();
            Conexion.Conectar().Close();
            return table;

        }

        public DataTable consultaVehiculos()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ConsultaVehiculos";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

        public void insertarVehiculo()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "insertarVehiculos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@placa", placa);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@tipo_vehiculo", tipo_vehiculo);
            comando.Parameters.AddWithValue("@tipo_transmision", tipo_transmision);
            comando.Parameters.AddWithValue("@categoria", Categoria);
            comando.Parameters.AddWithValue("@condicion_vehiculo", condicion_vehiculo);
            comando.Parameters.AddWithValue("@capacidad", capacidad);
            comando.Parameters.AddWithValue("@consumo_combus", consumo_combus);
            comando.Parameters.AddWithValue("@precio_dia", precio_dia);
            comando.Parameters.AddWithValue("@anio", anio);
            comando.Parameters.AddWithValue("@estado", estado);

            comando.ExecuteNonQuery();
            //comando.Parameters.Clear();
        }

        public void editarVehiculo()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "update vehiculo set placa = '" + Placa + "', marca = '" + Marca + "',tipo_vehiculo = '" + Tipo_vehiculo + "', tipo_transmision =  '" + Tipo_transmision + "', categoria = '" + Categoria + "',condicion_vehiculo = '" + Condicion_vehiculo + "', capacidad = '" + Capacidad + "',consumo_combus = '" + Consumo_combus + "',precio_dia = '" + Precio_dia + "',anio = '" + Anio + "', estado = '" + Estado + "' where id_vehiculo = " + Id_vehiculo + "";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            Conexion.Conectar().Close();
        }

        public static bool Eliminar_vehiculo(string id_vehiculo)
        {
            bool Exito = false;

            SqlCommand com = new SqlCommand("Delete vehiculo WHERE id_vehiculo = @id_vehiculo ", Conexion.Conectar());
            com.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);

            try
            {
                com.ExecuteNonQuery();
                Exito = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion" + ex);
            }
            finally
            {
                Conexion.Conectar().Close();
            }
            return Exito;


        }

    }
}
