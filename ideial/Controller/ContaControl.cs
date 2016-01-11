using System;
using MySql.Data.MySqlClient;

using ideial.Model.DAO;
using ideial.Model.Entity;

namespace ideial.Controller
{
    class ContaControl
    {
        public static bool EfetuarLogin(string user, string pass)
        {
            ContaDAO contaDAO = new ContaDAO();
            int idConta = contaDAO.VerificarCredencial(user, pass);  //Retorna ID da Conta se credencial for válida

            if (idConta > 0)
            {
                UtilizadorDAO utilizadorDAO = new UtilizadorDAO();
                //Chama o método para selecionar Utilizador por Id
                MySqlDataReader row = utilizadorDAO.SelecionarUtilizadorIdConta(idConta);
                //Atribui os valores encontrados ao objeto UserLogged
                while (row.Read())
                {
                    UserLogged.IdConta = idConta; //atribui o idConta ao objeto UserLogged 
                    UserLogged.User = user; //atribui o user ao objeto UserLogged
                    UserLogged.IdUtilizador = Convert.ToInt32( row["ID"].ToString() );
                    UserLogged.NomeUtilizador = row["nome"].ToString();
                    UserLogged.Email = row["email"].ToString();
                    //UserLogged.Foto = row["foto"].ToString;
                    UserLogged.TipoUtilizador = row["tipoUtilizador"].ToString();
                    UserLogged.IdCargo = Convert.ToInt32( row["id_cargo"].ToString() );
                    UserLogged.IdDepartamento = Convert.ToInt32( row["id_departamento"].ToString() );
                    UserLogged.IdEmpresa = Convert.ToInt32( row["id_empresa"].ToString() );
                }

                return true;
            }
            return false;
        }

    }
}
