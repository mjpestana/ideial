using DISgrupo1.Ideial.Model.DAO;
using MySql.Data.MySqlClient;
using System.Data;

namespace DISgrupo1.Ideial.Controller
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
