using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISgrupo1.Ideial.Utilizadores
{
    public abstract class Funcionario : Utilizador
    {

        public string Departamento { get; set; }
        public string Cargo { get; set; }

    }
}
