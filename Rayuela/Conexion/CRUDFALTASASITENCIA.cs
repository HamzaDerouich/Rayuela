using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    public class CRUDFALTASASITENCIA
    {
        private string ruta = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";
        private MySqlConnection conexion;
        private MySqlDataReader lector;
        private MySqlCommand comando;

        public CRUDFALTASASITENCIA()
        {
            conexion = new MySqlConnection();
            comando = new MySqlCommand();
        }

        public List<Faltas> Select()
        {
            List<Faltas> falta_asitencia = new List<Faltas>();
            string consulta = "SELECT * FROM faltasasistencia";
            conexion.ConnectionString = ruta;
            conexion.Open();

            using (comando = new MySqlCommand(consulta, conexion))
            {

                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Faltas falta = new Faltas();
                    falta.Indice = (int)lector["Indice"];
                    falta.IdentificadorAlumno1 = (int)lector["IdentificadorAlumno"];
                    falta.Fecha = (DateTime)lector["Fecha"];
                    falta.Modulo = (string)lector["Modulo"];

                    falta_asitencia.Add(falta);
                }

                return falta_asitencia;
            }

           
        }
    }
}
