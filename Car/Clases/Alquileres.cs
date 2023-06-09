﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Car.Clases;

namespace Car.Clases
{
    class Alquileres
    {
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leerfilas;
        internal string operacion;

        private int id_alquiler;
        private int id_cliente;
        private decimal costoalquiler;
        private string estado;
        private int id_vehiculo;
        private string inicio_alquiler;
        private string finalizacion_alquiler;
        internal int Id_reserva;

        public int Id_alquiler { get => id_alquiler; set => id_alquiler = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public decimal Costoalquiler { get => costoalquiler; set => costoalquiler = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Id_vehiculo { get => id_vehiculo; set => id_vehiculo = value; }
        public string Inicio_alquiler { get => inicio_alquiler; set => inicio_alquiler = value; }
        public string Finalizacion_alquiler { get => finalizacion_alquiler; set => finalizacion_alquiler = value; }
       

        public DataTable ListarClientes()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }


        public DataTable ListarVehiculo()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListarVehiculo";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }


        public DataTable ListarConVehiculo()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListarConVehiculo";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

        public DataTable ListarEstadoAlquiler()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListarEstadoAlquiler";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

        public DataTable ListarAlquileres()
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "ListaAlquileres";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();
            tabla.Load(leerfilas);
            leerfilas.Close();
            Conexion.Conectar().Close();
            return tabla;
        }

        public void insertarAlquiler()
        {

            comando.Connection = Conexion.Conectar();
            comando.CommandText = "InsertarAlquileres";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_cliente", Id_cliente);
            comando.Parameters.AddWithValue("@costoalquiler", costoalquiler);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@id_vehiculo", Id_vehiculo);
            comando.Parameters.AddWithValue("@inicio_alquiler", inicio_alquiler);
            comando.Parameters.AddWithValue("@finalizacion_alquiler", finalizacion_alquiler);
            comando.ExecuteNonQuery();
            //comando.Parameters.Clear();


        }

        public void editarAlquiler()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "update alquileres set id_cliente=" + Id_cliente + ",costoalquiler=" + costoalquiler + ",estado='" + estado + "',id_vehiculo=" + Id_vehiculo + ",inicio_alquiler='" + inicio_alquiler + "',finalizacion_alquiler='" + finalizacion_alquiler + "' where id_alquiler=" + id_alquiler + "";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            Conexion.Conectar().Close();
        }

        public void eliminarAlquiler()
        {
            comando.Connection = Conexion.Conectar();
            comando.CommandText = "delete alquileres where id_alquiler=" + id_alquiler;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            Conexion.Conectar().Close();
        }

    }
}
