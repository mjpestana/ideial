using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISgrupo1.Ideial.Utilizadores
{
    public abstract class Utilizador
    {

        //Atributos da classe Utilizador
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }
        public int Visitas { get; set; }
        public int Pontuacao { get; set; }

        public string userName { get; set; }
        public string password { get; set; }

        //Métodos da classe Utilizador
        public void Editar()
        {

        }

        public void Classificar()
        {

        }

        public void Visualizar()
        {

        }

    }
}
