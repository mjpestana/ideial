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
            //var cargo_dt = new DataTable();
            //cargo_dt = cargoDAO.Cheia_Cargo();

            DataTable cargo_dt = new DataTable();

            MySqlDataReader reader = cargoDAO.SelecionarTodos();

            if (reader.Read())
            {
                cargo_dt.Load(reader);
                return cargo_dt;
            }

            //return cargo_dt;
            return null;
        }

    }
}
