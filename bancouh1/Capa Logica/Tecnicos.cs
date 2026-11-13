using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace bancouh1.Capa_Logica
{
    public class Tecnicos
    {



        public static int Agregartecnicos(string tecnicoID, string especialidad, string nombre)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Insert into Tecnicos (tecnicoID, especialidad, nombre) values (@tecnicoID,@especialidad,@nombre)", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@tecnicoID", tecnicoID));
                    cmd.Parameters.Add(new SqlParameter("@especialidad", especialidad));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public static int Eliminartecnicos(string tecnicoID)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("delete from Tecnicos where tecnicoID = @tecnicoID", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@tecnicoID", tecnicoID));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public static int Actualizartecnicos(string tecnicoID, string especialidad, string nombre)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("update Tecnicos set especialidad = @especialidad, nombre = @nombre where tecnicoID = @tecnicoID", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@tecnicoID", tecnicoID));
                    cmd.Parameters.Add(new SqlParameter("@especialidad", especialidad));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public CapaDatos.Tecnicos ObtenerTecnico(string tecnicoID)
        {
            // Aquí puedes agregar la lógica para obtener el técnico de la base de datos
            // Por ejemplo, podrías buscar en una lista o en una base de datos y devolver un objeto Tecnicos
            return new CapaDatos.Tecnicos(tecnicoID, "especialidadEjemplo", "nombreEjemplo");
        }

    }
}