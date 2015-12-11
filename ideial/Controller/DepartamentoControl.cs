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
            //var Departamento_dt = new DataTable();
            //Departamento_dt = departamentoDAO.Cheia_Departamento();

            DataTable departamento_dt = new DataTable();

            MySqlDataReader reader = departamentoDAO.SelecionarTodos();

            if (reader.Read())
            {
                departamento_dt.Load(reader);
                return departamento_dt;
            }

            //return Departamento_dt;
            return null;
        }

    }
}
