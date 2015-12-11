using DISgrupo1.Ideial.Model.DAO;
using MySql.Data.MySqlClient;
using System.Data;

namespace DISgrupo1.Ideial.Controller
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
