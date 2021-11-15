using ExamenIIParcial_CesiaGemimaGodoy.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIParcial_CesiaGemimaGodoy.Modelos.DAO
{
    public class EstadoDAO: Conexion
    {
        SqlCommand comando = new SqlCommand();


        public bool InsertarNuevoEstado(Estado estado)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ESTADO ");
                sql.Append(" VALUES (@IdEstado, @EstadoTicket, @IdCliente); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdEstado", SqlDbType.Int).Value = estado.IdEstado;
                comando.Parameters.Add("@EstadoTicket", SqlDbType.NVarChar, 80).Value = estado.EstadoTicket;
                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = estado.IdCliente;
                return true;
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public DataTable GetEstados()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM ESTADO ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }
            return dt;
        }

        public bool ActualizarEstado(Estado estado)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ESTADO ");
                sql.Append(" SET ESTADOTICKET = @EstadoTicket  ");
                sql.Append(" WHERE IDESTADO = @IdEstado; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdEstado", SqlDbType.Int).Value = estado.IdEstado;
                comando.Parameters.Add("@EstadoTicket", SqlDbType.NVarChar, 80).Value = estado.EstadoTicket;
                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = estado.IdCliente;
                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();

            }
            catch (Exception ex)
            {
                return modifico;
            }
            return modifico;
        }

        public bool EliminarEstado(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM ESTADO ");
                sql.Append(" WHERE IDESTADO = @IdEstado; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdEstado", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();

            }
            catch (Exception ex)
            {
                return modifico;
            }
            return modifico;
        }
    }
}
