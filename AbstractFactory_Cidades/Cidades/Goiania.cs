using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Cidades
{
    public class Goiania : ICidade
    {
        public Goiania()
        {
            DataBase dataBase = new DataBase();
            SqlDataReader r = dataBase.ExecuteQuery("SELECT * FROM CIDADE WHERE NOME = 'Goiânia'", true);
            Nome = r["Nome"].ToString();
            NumeroDeHabitantes = (int)r["Numero_Habitantes"];
            Curiosidades = r["Curiosidades"].ToString();
        }

        public string Nome { get; }
        public int NumeroDeHabitantes { get; }
        public string Curiosidades { get; }
    }
}
