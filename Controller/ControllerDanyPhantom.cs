using DP.Context;
using DP.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Controller
{
    internal class ControllerDanyPhantom : IControllerDanyPhantom
    {
        private Conexion conexion = new Conexion();

        public bool Insertar(PhantomModel personaje)
        {
            using (SqlConnection conn = conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_InsertarPersonaje", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    cmd.Parameters.AddWithValue("@Nombre", personaje.Nombre);
                    cmd.Parameters.AddWithValue("@Apodo", personaje.Apodo);
                    cmd.Parameters.AddWithValue("@Raza", personaje.Raza);
                    cmd.Parameters.AddWithValue("@Dueño", personaje.Dueño);
                    cmd.Parameters.AddWithValue("@Personalidad", personaje.Personalidad);
                    cmd.Parameters.AddWithValue("@PrimeraAparicion", personaje.PrimeraAparicion ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ImagenURL", personaje.ImagenURL);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar personaje: " + ex.Message);
                    return false;
                }
            }
        }

        public List<PhantomModel> ObtenerPersonajes()
        {
            List<PhantomModel> personajes = new List<PhantomModel>();
            using (SqlConnection conn = conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    //MessageBox.Show("Conexión abierta correctamente.");
                    SqlCommand cmd = new SqlCommand("sp_GetPersonajes", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personajes.Add(new PhantomModel
                            {
                                ID = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : 0, // Si es null, asigna 0
                                Nombre = reader["Nombre"] != DBNull.Value ? reader["Nombre"].ToString() : null,
                                Apodo = reader["Apodo"] != DBNull.Value ? reader["Apodo"].ToString() : null,
                                Raza = reader["Raza"] != DBNull.Value ? reader["Raza"].ToString() : null,
                                Dueño = reader["Dueño"] != DBNull.Value ? reader["Dueño"].ToString() : null,
                                Personalidad = reader["Personalidad"] != DBNull.Value ? reader["Personalidad"].ToString() : null,
                                PrimeraAparicion = reader["PrimeraAparicion"] != DBNull.Value ? Convert.ToDateTime(reader["PrimeraAparicion"]) : (DateTime?)null,
                                ImagenURL = reader["ImagenURL"] != DBNull.Value ? reader["ImagenURL"].ToString() : null
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los personajes: " + ex.Message);
                }
            }

            return personajes;
        }
    }
}
