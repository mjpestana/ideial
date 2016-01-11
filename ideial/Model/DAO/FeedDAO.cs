using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ideial.Model.Entity;
using MySql.Data.MySqlClient;

namespace ideial.Model.DAO
{
    class FeedDAO
    {
        public static MySqlDataReader SelecionarIdeias()
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT * FROM ideia WHERE id_estado = 2");

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static MySqlDataReader SelecionarCampanhas()
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT * FROM campanha");

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static MySqlDataReader SelecionarIdeiasUtiliz(int id)
        {
            try
            {
                MySqlDataReader reader;

                if (id == UserLogged.IdUtilizador)
                {
                    reader =
                        ConexaoDb.SelecionarRegistos("SELECT * FROM ideia WHERE id_utilizador = '" + id + "'");
                }
                else
                {
                    reader =
                        ConexaoDb.SelecionarRegistos("SELECT * FROM ideia WHERE id_utilizador = '" + id + "' AND id_estado = 2");
                }

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static MySqlDataReader SelecionarCampanhasUtiliz(int id)
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT * FROM campanha WHERE id_utilizador = '" + id + "'");

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static MySqlDataReader SelecionarIdeiasDaCampanha(int id)
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT ID FROM ideia WHERE id_campanha = '" + id + "' AND id_estado = 2");

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static MySqlDataReader SelecionarTodosUtilizadores()
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT ID FROM utilizador");

                return reader;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
