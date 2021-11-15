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
    public class TicketSoporteDAO: Conexion
    {
        SqlCommand comando = new SqlCommand();


        public bool InsertarNuevoTicket(Ticket ticket)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TICKET ");
                sql.Append(" VALUES (@Fecha, @Idcliente, @Precio); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Fecha", SqlDbType.Date).Value = ticket.Fecha;
                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = ticket.IdCliente;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = ticket.Precio;
                comando.ExecuteNonQuery();
                return true;
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        

        public DataTable GetTickets()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TICKET ");

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

        public bool ActualizarTicket(Ticket ticket)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE TICKET ");
                sql.Append(" SET FECHA = @Fecha, IDCLIENTE = @IdCliente, PRECIO = @Precio  ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Fecha", SqlDbType.Date).Value = ticket.Fecha;
                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = ticket.IdCliente;
                comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = ticket.Precio;
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

        public bool EliminarTicket(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM Ticket ");
                sql.Append(" WHERE IDTICKET = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
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
