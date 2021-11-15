using ExamenIIParcial_CesiaGemimaGodoy.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIParcial_CesiaGemimaGodoy.Modelos.DAO
{
    public class ClienteDAO: Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarNuevoCliente(Cliente client)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO CLIENTE ");
                sql.Append(" VALUES (@Nombre, @Email, @Direccion); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = client.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = client.Email;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = client.Direccion;
                comando.ExecuteNonQuery();
                return true;
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public DataTable GetClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM CLIENTE ");

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

        public bool ActualizarCliente(Cliente client)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE CLIENTE ");
                sql.Append(" SET NOMBRE = @Nombre, EMAIL = @Email, DIRECCION = @Direccion");
                sql.Append(" WHERE IDCLIENTE = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = client.IdCliente;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = client.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = client.Email;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = client.Direccion;
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

        public bool EliminarCliente(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM CLIENTE ");
                sql.Append(" WHERE IDCLIENTE = @Id; ");

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

