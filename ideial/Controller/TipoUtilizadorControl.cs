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

            DataTable tipoUtilizador_dt = new DataTable();

            tipoUtilizador_dt = tipoUtilizadorDAO.SelecionarTodos();

            return tipoUtilizador_dt;
        }

    }
}
