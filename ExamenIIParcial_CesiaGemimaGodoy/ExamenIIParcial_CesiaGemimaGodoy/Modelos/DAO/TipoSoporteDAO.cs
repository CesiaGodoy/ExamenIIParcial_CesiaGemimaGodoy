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
    public class TipoSoporteDAO: Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarNuevoTipoSoporte(TipoSoporte tipo)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TIPO ");
                sql.Append(" VALUES (@TipoSoporte); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@TipoSoporte", SqlDbType.NVarChar, 100).Value = tipo.TipoSoportes;
                comando.ExecuteNonQuery();
                return true;
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public DataTable GetTipoSoporte()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TIPO ");

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

        public bool ActualizarTipoSoporte(TipoSoporte tipo)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE TIPO ");
                sql.Append(" SET TIPOSOPORTE = @TipoSoporte");
                sql.Append(" WHERE IDTIPO = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = tipo.IdTipo;
                comando.Parameters.Add("@TipoSoporte", SqlDbType.NVarChar, 100).Value = tipo.TipoSoportes;
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

        public bool EliminarTipoSoporte(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM TIPO ");
                sql.Append(" WHERE IDTIPO = @Id; ");

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
