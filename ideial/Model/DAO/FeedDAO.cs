using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ideial.Model.DAO
{
    class FeedDAO
    {
        public static MySqlDataReader SelecionarIdeias()
        {
            try
            {
                MySqlDataReader reader = ConexaoDb.SelecionarRegistos("SELECT * FROM ideia");

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
    }
}
