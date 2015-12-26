using System.Data;
using ideial.Model.DAO;

namespace ideial.Controller
{
    class EmpresaControl
    {

        public static DataTable Empresa_DataTable()
        {
            EmpresaDAO empresaDAO = new EmpresaDAO();

            DataTable empresa_dt = new DataTable();

            empresa_dt = empresaDAO.SelecionarTodos();

            return empresa_dt;
        }

    }
}
