using System.Data;
using ideial.Model.DAO;

namespace ideial.Controller
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
