using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Cidades
{
    public class Brasil : FabricaAbstrata
    {
        public Brasil()
        {
            Pais = "Brasil";
        }

        public override List<string> GetListaCidades()
        {
            List<string> listaCidades = new List<string>();
            DataBase dataBase = new DataBase();
            SqlDataReader r = dataBase.ExecuteQuery("SELECT * FROM CIDADE JOIN PAIS ON CIDADE.PAISID = PAIS.ID WHERE PAIS.NOME='Brasil'", true);
            listaCidades.Add((string)r["Nome"]);
            while (r.Read())
            {
                listaCidades.Add((string)r["Nome"]);
            }
            return listaCidades;
        }

        public override ICidade getCidade(string cidade)
        {
            if(cidade.ToUpper() == "GOIÂNIA")
            {
                return new Goiania();
            }
            else if(cidade.ToUpper() == "SÃO PAULO")
            {
                return new SaoPaulo();
            }
            else
            {
                return null;
            }
        }
    }
}
