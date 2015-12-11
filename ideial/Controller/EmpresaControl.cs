using DISgrupo1.Ideial.Model.DAO;
using MySql.Data.MySqlClient;
using System.Data;

namespace DISgrupo1.Ideial.Controller
{
    class EmpresaControl
    {

        //public static DataTable Cheia_Empresa()
        public static DataTable Empresa_DataTable()
        {
            EmpresaDAO empresaDAO = new EmpresaDAO();
            //var empresa_dt = new DataTable();
            //empresa_dt = empresaDAO.Cheia_Empresa();

            DataTable empresa_dt = new DataTable();

            MySqlDataReader reader = empresaDAO.SelecionarTodos();

            if (reader.Read())
            {
                empresa_dt.Load(reader);
                return empresa_dt;
            }

            //return empresa_dt;
            return null;
        }

    }
}
