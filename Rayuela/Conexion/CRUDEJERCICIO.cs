using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    internal class CRUDEJERCICIO
    {

        private string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
        private MySqlConnection conexion;
        private MySqlDataReader lector;
        private MySqlCommand comando;

        public CRUDEJERCICIO()
        {
            conexion = new MySqlConnection();
            comando = new MySqlCommand();
        }

        public List<Alumno> Select(string ciclo , int curso)
        {
            List<Alumno> listadoAlumnos = new List<Alumno>();
            string consulta = "SELECT * FROM alumnos a , cursos c WHERE c.Curso = '@curso' " ;

            conexion.ConnectionString = ruta;
            conexion.Open();
            using (comando = new MySqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@curso", curso);


                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Alumno alumno = new Alumno();
                    alumno.Identificador = (string)lector["Identificador"];
                    alumno.Nombre = (string)lector["Nombre"];
                    alumno.Mail = (string)lector["Mail"];
                    alumno.Ciclo = (string)lector["Ciclo"];
                    alumno.Curso = (int)lector["Curso"];
                    alumno.Foto = (string)lector["Foto"];
                    alumno.Activo = (int)lector["Activo"];

                    listadoAlumnos.Add(alumno);
                }

                return listadoAlumnos;
            }

            return listadoAlumnos;
        }

    }
}
