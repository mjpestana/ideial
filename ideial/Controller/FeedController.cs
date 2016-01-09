using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using ideial.Model.DAO;

namespace ideial.Controller
{
    class FeedController
    {

        public static DataTable Ideia_DataTable()
        {
            FeedDAO FeedDAO = new FeedDAO();

            DataTable Ideia_dt = new DataTable();

            Ideia_dt = FeedDAO.SelecionarIdeia();

            return Ideia_dt;
        }

        public static DataTable Camp_DataTable()
        {
            FeedDAO FeedDAO = new FeedDAO();

            DataTable Camp_dt = new DataTable();

            Camp_dt = FeedDAO.SelecionarCampanha();

            return Camp_dt;
        }

    }
}
