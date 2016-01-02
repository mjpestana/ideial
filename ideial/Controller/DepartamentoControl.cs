using System.Data;

using ideial.Model.DAO;

namespace ideial.Controller
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
