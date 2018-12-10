using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AbstractFactory_Cidades
{
    public abstract class FabricaAbstrata
    {
        public string Pais { get; protected set; }
        public static List<string> GetListaDePaises()
        {
            List<string> listaPaises = new List<string>();
            DataBase dataBase = new DataBase();
            SqlDataReader r = dataBase.ExecuteQuery("SELECT * FROM PAIS", true);
            listaPaises.Add((string)r["Nome"]);
            while (r.Read())
            {
                listaPaises.Add((string)r["Nome"]);
            }
            return listaPaises;
        }

        public abstract List<string> GetListaCidades();
        public abstract ICidade getCidade(string cidade);
        public static FabricaAbstrata getPais(string pais)
        {
            if(pais == "Brasil")
            {
                return new Brasil();
            }else if(pais == "Portugal")
            {
                return new Portugal();
            }
            else
            {
                return null;
            }
        }
    }
}
