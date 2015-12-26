using System.Data;
using ideial.Model.DAO;

namespace ideial.Controller
{
    class CargoControl
    {

        public static DataTable Cargo_DataTable()
        {
            CargoDAO cargoDAO = new CargoDAO();

            DataTable cargo_dt = new DataTable();

            cargo_dt  = cargoDAO.SelecionarTodos();

            return cargo_dt;
        }

    }
}
