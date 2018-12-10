using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Cidades
{
    public interface ICidade
    {
        string Nome { get; }
        int NumeroDeHabitantes { get; }
        string Curiosidades { get; }
    }
}
