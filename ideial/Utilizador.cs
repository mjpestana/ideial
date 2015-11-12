using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISgrupo1.Ideial.Utilizadores
{
    public abstract class Utilizador
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        //public string Foto { get; set; }
        public int Visitas { get; set; }
        public int Pontuacao { get; set; }

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
