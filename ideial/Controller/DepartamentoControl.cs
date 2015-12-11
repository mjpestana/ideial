using DISgrupo1.Ideial.Model.DAO;
using MySql.Data.MySqlClient;
using System.Data;

namespace DISgrupo1.Ideial.Controller
{
    class DepartamentoControl
    {

        public static DataTable Departamento_DataTable()
        {
            DepartamentoDAO departamentoDAO = new DepartamentoDAO();

            DataTable departamento_dt = new DataTable();

            departamento_dt = departamentoDAO.SelecionarTodos();

            return departamento_dt;
        }

    }
}
