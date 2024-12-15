using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    public class CRUDCURSOS
    {
        private string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
        private MySqlConnection conexion;
        private MySqlDataReader lector;
        private MySqlCommand comando;
        public CRUDCURSOS() 
        {
            conexion = new MySqlConnection();
            comando = new MySqlCommand();
        }

        public List<Cursos> Select()
        {
            List<Cursos> listadoCursos = new List<Cursos>();
            string consulta = "SELECT * FROM cursos ";
            conexion.ConnectionString = ruta;
            conexion.Open();

            using (comando = new MySqlCommand(consulta, conexion))
            {

                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                   
                    Cursos cursos = new Cursos();
                    cursos.IdCurso = (string)lector["IdCurso"];
                    cursos.NombreCompleto = (string)lector["NombreCompleto"];
                    cursos.Curso = (int)lector["Curso"];
                    cursos.Ciclo = (string)lector["Ciclo"];

                    listadoCursos.Add(cursos);
                }

                return listadoCursos;
            }
        }
    }
}
