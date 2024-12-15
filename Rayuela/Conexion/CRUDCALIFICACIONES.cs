using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    public class CRUDCALIFICACIONES
    {

        private string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
        private MySqlConnection conexion;
        private MySqlDataReader lector;
        private MySqlCommand comando;

        public CRUDCALIFICACIONES()
        {
            conexion = new MySqlConnection();
            comando = new MySqlCommand();
        }

        public List<Calificacion> Select(string identificador)
        {
            List<Calificacion> listadoCalificaciones = new List<Calificacion>();
            string consulta = "SELECT * FROM calificaciones WHERE IdentificadorAlumno = " + identificador ;
            conexion.ConnectionString = ruta;
            conexion.Open();

            using (comando = new MySqlCommand(consulta, conexion))
            {

                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Calificacion calificacion = new Calificacion();
                    calificacion.Indice = (int)lector["Indice"];
                    calificacion.Identificador = (string)lector["IdentificadorAlumno"];
                    calificacion.Modulo = (string)lector["Modulo"];
                    calificacion.Puntos = (int)lector["Puntos"];

                    listadoCalificaciones.Add(calificacion);
                }

                return listadoCalificaciones;
            }

        }

    }
}
