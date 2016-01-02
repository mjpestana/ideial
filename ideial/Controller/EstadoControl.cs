using System.Data;

using ideial.Model.DAO;

namespace ideial.Controller
{
    class EstadoControl
    {
        public static DataTable Estado_DataTable()
        {
            EstadoDAO estadoDAO = new EstadoDAO();
            DataTable estado_dt = new DataTable();
            estado_dt = estadoDAO.SelecionarTodos();

            return estado_dt;
        }
    }
}