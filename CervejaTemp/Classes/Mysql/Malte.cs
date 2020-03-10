using CervejaTemp.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;

namespace CervejaTemp.Classes.Mysql
{
    [DataObject(true)]
    public class Malte
    {

        private int Codmalte { get; set; }
        private string Nome { get; set; }
        private string Quantidade { get; set; }
        private string Valor { get; set; }
        private string Datafab { get; set; }
        private string Datavenc { get; set; }
        private string Dataentrada { get; set; }
        private string Ebc { get; set; }
        private string Obs { get; set; }


        public Malte(int codmalte, string nome, string quantidade, string valor, string datafab, string datavenc, string dataentrada, string ebc, string obs)
        {
            Codmalte = codmalte;
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
            Datafab = datafab;
            Datavenc = datavenc;
            Dataentrada = dataentrada;
            Ebc = ebc;
            Obs = obs;

        }

        public Malte()
        {

        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO malte(";
            Mysql = Mysql + " NOME, QUANTIDADE, VALOR, DATAFAB, DATAVENC, DATAENTRADA, EBC, OBS ";
            Mysql = Mysql + ") ";

            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @NOME, @QUANTIDADE, @VALOR, @DATAFAB, @DATAVENC, @DATAENTRADA, @EBC, @OBS";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODMALTE", Codmalte);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@QUANTIDADE", Convert.ToDecimal(Quantidade));
            db.AddParameter("@VALOR", Convert.ToDecimal(Valor));
            db.AddParameter("@DATAFAB", Convert.ToDateTime(Datafab)); 
            db.AddParameter("@DATAVENC", Convert.ToDateTime(Datavenc));
            db.AddParameter("@DATAENTRADA", Convert.ToDateTime(Dataentrada));
            db.AddParameter("@EBC", Ebc);
            db.AddParameter("@OBS", Obs);
                                            

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
            var Mysql = " UPDATE malte ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " NOME = @NOME, QUANTIDADE = @QUANTIDADE, VALOR = @VALOR, DATAFAB = @DATAFAB, DATAVENC = @DATAVENC, ";
            Mysql = Mysql + " DATAENTRADA = @DATAENTRADA, EBC = @EBC, OBS = @OBS";

            Mysql = Mysql + " WHERE CODMALTE = @CODMALTE";

            db.CommandText = Mysql;

            db.AddParameter("@CODMALTE", Codmalte);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@QUANTIDADE", Convert.ToDecimal(Quantidade));
            db.AddParameter("@VALOR", Convert.ToDecimal(Valor));
            db.AddParameter("@DATAFAB", Convert.ToDateTime(Datafab));
            db.AddParameter("@DATAVENC", Convert.ToDateTime(Datavenc));
            db.AddParameter("@DATAENTRADA", Convert.ToDateTime(Dataentrada));
            db.AddParameter("@EBC", Ebc);
            db.AddParameter("@OBS", Obs);


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

        public static bool Delete(int codmalte)
        {
            var db = new DBAcess();
            const string delete = " DELETE FROM malte ";
            const string where = "WHERE CODMALTE = @CODMALTE";
            db.CommandText = delete + where;
            db.AddParameter("@CODMALTE", codmalte);
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

        public int InsertAccess(int codmalte, string nome, int quantidade, string valor, string datafab, string datavenc, string dataentrada, string ebc, string obs)
        {
            var db = new DBAcessOleDB();

            var Mysql = " INSERT INTO malte(";
            Mysql = Mysql + " NOME, QUANTIDADE, VALOR, DATAFAB, DATAVENC, DATAENTRADA, EBC, OBS ";
            Mysql = Mysql + ") ";

            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @NOME, @QUANTIDADE, @VALOR, @DATAFAB, @DATAVENC, @DATAENTRADA, @EBC, @OBS";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODMALTE", Codmalte);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@QUANTIDADE", Quantidade);
            db.AddParameter("@VALOR", Valor);
            db.AddParameter("@DATAFAB", Convert.ToDateTime(Datafab));
            db.AddParameter("@DATAVENC", Convert.ToDateTime(Datavenc));
            db.AddParameter("@DATAENTRADA", Convert.ToDateTime(Dataentrada));
            db.AddParameter("@EBC", Ebc);
            db.AddParameter("@OBS", Obs);

            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }

        public bool DeleteAccess()
        {
            var db = new DBAcessOleDB();
            const string delete = " DELETE FROM malte ";

            db.CommandText = delete;

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
            var Mysql = " SELECT M.CODMALTE, M.NOME, M.QUANTIDADE, M.VALOR, DATE_FORMAT(M.DATAFAB,'%d/%m/%Y') AS DATAFAB, ";
            Mysql = Mysql + " DATE_FORMAT(M.DATAVENC,'%d/%m/%Y') AS DATAVENC, DATE_FORMAT(M.DATAENTRADA,'%d/%m/%Y') AS DATAENTRADA, ";
            Mysql = Mysql + " M.EBC, M.OBS ";

            Mysql = Mysql + " FROM malte M ";
            db.CommandText = Mysql;

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int codmalte)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM malte ";
            Mysql = Mysql + " WHERE CODMALTE = @CODMALTE ";

            db.CommandText = Mysql;
            db.AddParameter("@CODMALTE", codmalte);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

    }
}
