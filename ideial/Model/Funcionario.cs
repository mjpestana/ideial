using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISgrupo1.Ideial.Model.Entity
{
    public abstract class Funcionario : Utilizador
    {
        //Atributos da classe Funcionario
        public string Departamento { get; set; }
        public string Cargo { get; set; }

    }
}
