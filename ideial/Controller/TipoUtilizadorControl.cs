using DISgrupo1.Ideial.Model.DAO;
using MySql.Data.MySqlClient;
using System.Data;

namespace DISgrupo1.Ideial.Controller
{
    class TipoUtilizadorControl
    {

        public static DataTable TipoUtilizador_DataTable()
        {
            TipoUtilizadorDAO tipoUtilizadorDAO = new TipoUtilizadorDAO();
            //var TipiTutilizador_dt = new DataTable();
            //TipiTutilizador_dt = tipoUtilizadorDAO.Cheia_TipoUtilizador();

            DataTable tipoUtilizador_dt = new DataTable();

            MySqlDataReader reader = tipoUtilizadorDAO.SelecionarTodos();

            if (reader.Read())
            {
                tipoUtilizador_dt.Load(reader);
                return tipoUtilizador_dt;
            }

            //return TipiTutilizador_dt;
            return null;
        }

    }
}
