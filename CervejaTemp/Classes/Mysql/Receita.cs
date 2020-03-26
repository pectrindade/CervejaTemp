using CervejaTemp.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;

namespace CervejaTemp.Classes.Mysql
{

    [DataObject(true)]
    public class Receita
    {
        private int Codreceita { get; set; }
        private string Nome { get; set; }
        private string Decricao { get; set; }
        private string Cervejeiro { get; set; }
        private string Estilo { get; set; }
        private int Tipobrassagem { get; set; }

        public Receita(int codreceita, string nome, string decricao, string cervejeiro, string estilo, int tipobrassagem)
        {
            Codreceita = codreceita;
            Nome = nome;
            Decricao = decricao;
            Cervejeiro = cervejeiro;
            Estilo = estilo;
            Tipobrassagem = tipobrassagem;

        }

        public Receita()
        {

        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO receita(";
            Mysql = Mysql + " NOME, DECRICAO, CERVEJEIRO, ESTILO, TIPOBRASSAGEM ";
            Mysql = Mysql + ") ";

            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " NOME, DECRICAO, CERVEJEIRO, ESTILO, TIPOBRASSAGEM ";
            Mysql = Mysql + "); ";

            Mysql = Mysql + " SELECT MAX(CODRECEITA) FROM receita ";

            db.CommandText = Mysql;

            db.AddParameter("@CODRECEITA", Codreceita);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@DECRICAO", Decricao);
            db.AddParameter("@CERVEJEIRO", Cervejeiro);
            db.AddParameter("@ESTILO", Estilo);
            db.AddParameter("@TIPOBRASSAGEM", Tipobrassagem);

            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Update()
        {
            var db = new DBAcess();
            var Mysql = " UPDATE receita ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + "NOME = @NOME, DECRICAO = @DECRICAO, CERVEJEIRO = @CERVEJEIRO, ESTILO = @ESTILO, TIPOBRASSAGEM = @TIPOBRASSAGEM,  ";
           
            Mysql = Mysql + " WHERE CODRECEITA = @CODRECEITA";

            db.CommandText = Mysql;

            db.AddParameter("@CODRECEITA", Codreceita);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@DECRICAO", Decricao);
            db.AddParameter("@CERVEJEIRO", Cervejeiro);
            db.AddParameter("@ESTILO", Estilo);
            db.AddParameter("@TIPOBRASSAGEM", Tipobrassagem);


            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            finally
            {
                db.Dispose();
            }
        }

        public static bool Delete(int Codreceita)
        {
            var db = new DBAcess();
            const string delete = " DELETE FROM receita ";
            const string where = "WHERE CODRECEITA = @CODRECEITA";
            db.CommandText = delete + where;
            db.AddParameter("@CODRECEITA", Codreceita);
            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select()
        {
            var db = new DBAcess();
            var Mysql = " SELECT R.CODRECEITA, R.NOME, R.DECRICAO, R.CERVEJEIRO, R.ESTILO, R.TIPOBRASSAGEM ";
            Mysql = Mysql + " FROM receita R ";
            db.CommandText = Mysql;

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int Codreceita)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM receita ";
            Mysql = Mysql + " WHERE CODRECEITA = @CODRECEITA ";

            db.CommandText = Mysql;
            db.AddParameter("@CODRECEITA", Codreceita);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }
    }
}
