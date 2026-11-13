using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace bancouh1.Capa_Logica
{
    public class Equipos_CL
    {



        public static int Agregarequipos(string equipoID, string tipoEquipo, string modelo, string correo)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Insert into Equipos (equipoID, tipoEquipo, modelo, correo) values (@equipoID,@tipoEquipo,@modelo,@correo)", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@equipoID", equipoID));
                    cmd.Parameters.Add(new SqlParameter("@tipoEquipo", tipoEquipo));
                    cmd.Parameters.Add(new SqlParameter("@modelo", modelo));
                    cmd.Parameters.Add(new SqlParameter("@correo", correo));

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

        public static int Eliminarequipos(string equipoID)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("delete from Equipos where equipoID = @equipoID", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@equipoID", equipoID));

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

        public static int Actualizarequipos(string equipoID, string tipoEquipo, string modelo, string correo)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("update Equipos set tipoEquipo = @tipoEquipo, modelo = @modelo, correo = @correo where equipoID = @equipoID", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@equipoID", equipoID));
                    cmd.Parameters.Add(new SqlParameter("@tipoEquipo", tipoEquipo));
                    cmd.Parameters.Add(new SqlParameter("@modelo", modelo));
                    cmd.Parameters.Add(new SqlParameter("@correo", correo));

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

        public CapaDatos.Equipos ObtenerEquipo(string equipoID)
        {
            // Aquí puedes agregar la lógica para obtener el equipo de la base de datos
            // Por ejemplo, podrías buscar en una lista o en una base de datos y devolver un objeto Equipos
            return new CapaDatos.Equipos(equipoID, "tipoEquipoEjemplo", "modeloEjemplo", "correoEjemplo");
        }

    }
}