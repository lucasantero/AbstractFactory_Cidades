using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AbstractFactory_Cidades
{
    public class SaoPaulo : ICidade
    {
        public SaoPaulo()
        {
            DataBase dataBase = new DataBase();
            SqlDataReader r = dataBase.ExecuteQuery("SELECT * FROM CIDADE WHERE NOME = 'São Paulo'", true);
            Nome = r["Nome"].ToString();
            NumeroDeHabitantes = (int)r["Numero_Habitantes"];
            Curiosidades = r["Curiosidades"].ToString();
        }

        public string Nome { get; }
        public int NumeroDeHabitantes { get; }
        public string Curiosidades { get; }
    }
}
