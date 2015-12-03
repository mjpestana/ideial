using System;

namespace DISgrupo1.Ideial.Model.Entity
{
    public class Gestor : Funcionario, ICriarUtilizador
    {

        public void Criar()
        {

        }

        public void Apagar()
        {

        }

        public Utilizador CriarUtilizador()
        {
            throw new NotImplementedException();
        }
    }
}
