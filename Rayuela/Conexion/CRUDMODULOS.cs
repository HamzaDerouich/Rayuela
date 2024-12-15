using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    public class CRUDMODULOS
    {
        private string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
        private MySqlConnection conexion;
        private MySqlDataReader lector;
        private MySqlCommand comando;

        public CRUDMODULOS()
        {
            conexion = new MySqlConnection();
            comando = new MySqlCommand();
        }

        public List<Modulos> Select()
        {
            List<Modulos> listado_modulos = new List<Modulos>();
            string consulta = "SELECT * FROM modulos";
            conexion.ConnectionString = ruta;
            conexion.Open();

            using (comando = new MySqlCommand(consulta, conexion))
            {

                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Modulos modulo = new Modulos();
                    modulo.IdModulo = (string)lector["IdModulo"];
                    modulo.Ciclo = (string)lector["Ciclo"];
                    modulo.Curso = (int)lector["Curso"];
                    modulo.NombreCompleto = (string)lector["NombreCompleto"];
                  
                    listado_modulos.Add(modulo);
                }

                return listado_modulos;
            }


        }
    }
}
