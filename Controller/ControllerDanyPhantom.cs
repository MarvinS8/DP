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
