using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using ideial.Controller;
using ideial.Model.DAO;
using ideial.Model.Entity;

namespace ideial.Model.DAO
{
    class FeedDAO
    {

      public DataTable SelecionarIdeia()
        {
            try
            {
                MySqlDataAdapter cc;

                DataSet ideia_ds = new DataSet();

                ConexaoDb conDb = ConexaoDb.GetConexaoDb();
                conDb.FecharConexao();
                                
                string sql = "SELECT ideia.* FROM utilizador INNER JOIN ideia ON utilizador.ID = ideia.id_utilizador WHERE(((utilizador.id_empresa) = " + UserLogged.IdEmpresa + ")) ";

                cc = new MySqlDataAdapter(sql, ConexaoDb.conexaoString);
                cc.Fill(ideia_ds, "ideia_dt");
                return ideia_ds.Tables["ideia_dt"];
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public DataTable SelecionarCampanha()
        {
            try
            {
                MySqlDataAdapter cc;

                DataSet camp_ds = new DataSet();

                ConexaoDb conDb = ConexaoDb.GetConexaoDb();
                conDb.FecharConexao();


                string sql = "SELECT campanha.*, utilizador.id_empresa FROM utilizador INNER JOIN campanha ON utilizador.ID = campanha.id_utilizador WHERE(((utilizador.id_empresa) = " + UserLogged.IdEmpresa + ")) ";

                cc = new MySqlDataAdapter(sql, ConexaoDb.conexaoString);
                cc.Fill(camp_ds, "camp_dt");
                return camp_ds.Tables["camp_dt"];
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
