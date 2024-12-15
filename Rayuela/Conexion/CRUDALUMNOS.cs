using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    public class CRUDALUMNOS
    {
        private string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
        private MySqlConnection conexion;
        private MySqlDataReader lector;
        private MySqlCommand comando;

        public CRUDALUMNOS()
        {
            conexion = new MySqlConnection();
            comando = new MySqlCommand();
        }

        public List<Alumno> Select()
        {
            List<Alumno> listadoAlumnos = new List<Alumno>();
            string consulta = "SELECT * FROM alumnos ";
            conexion.ConnectionString = ruta;
            conexion.Open();

            using (comando = new MySqlCommand(consulta,conexion))
            {

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

                    listadoAlumnos.Add( alumno );
                }

                return listadoAlumnos;
            }

            return listadoAlumnos ;
        }

        public int Update(Alumno alumno)
        {
            int filasModificadas = 0;
            string consultaSql = "UPDATE alumnos SET Nombre = @nombre, Mail = @mail, Ciclo = @ciclo, Curso = @curso, Foto = @foto WHERE Identificador = @identificador;";
            conexion.ConnectionString = this.ruta;
            conexion.Open();

            using( comando = new MySqlCommand(consultaSql, conexion))
            {

                comando.Parameters.AddWithValue("@nombre",alumno.Nombre);
                comando.Parameters.AddWithValue("@mail", alumno.Mail);
                comando.Parameters.AddWithValue("@ciclo", alumno.Ciclo);
                comando.Parameters.AddWithValue("@curso", alumno.Curso);
                comando.Parameters.AddWithValue("@foto", alumno.Foto);
                comando.Parameters.AddWithValue("@identificador", alumno.Identificador);


                filasModificadas = comando.ExecuteNonQuery();
            }
    
            return filasModificadas;
        }
    }

}
