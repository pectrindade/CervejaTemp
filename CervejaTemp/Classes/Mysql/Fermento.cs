using CervejaTemp.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;

namespace CervejaTemp.Classes.Mysql
{
    [DataObject(true)]
    public class Fermento
    {

        private int Codfermento { get; set; }
        private string Nome { get; set; }
        private string Estilofermento { get; set; }
        private string Vencimento { get; set; }
        private string Quantidadeestoque { get; set; }


        public Fermento(int codfermento, string nome, string estilofermento, string vencimento, string quantidadeestoque)
        {
            Codfermento = codfermento;
            Nome = nome;
            Estilofermento = estilofermento;
            Vencimento = vencimento;
            Quantidadeestoque = quantidadeestoque;

        }

        public Fermento()
        {

        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO Fermento(";
            Mysql = Mysql + " NOME, ESTILOFERMENTO, VENCIMENTO, QUANTIDADEESTOQUE ";
            Mysql = Mysql + ") ";

            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @NOME, @ESTILOFERMENTO, @VENCIMENTO, @QUANTIDADEESTOQUE ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODFERMENTO", Codfermento);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@ESTILOFERMENTO", Estilofermento);
            db.AddParameter("@VENCIMENTO", Convert.ToDateTime(Vencimento));
            db.AddParameter("@QUANTIDADEESTOQUE", Convert.ToDecimal(Quantidadeestoque));

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
            var Mysql = " UPDATE Fermento ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " NOME = @NOME, ESTILOFERMENTO = @ESTILOFERMENTO, VENCIMENTO = @VENCIMENTO, QUANTIDADEESTOQUE = @QUANTIDADEESTOQUE ";
           

            Mysql = Mysql = " WHERE CODFERMENTO = @CODFERMENTO";

            db.CommandText = Mysql;

            db.AddParameter("@CODFERMENTO", Codfermento);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@ESTILOFERMENTO", Estilofermento);
            db.AddParameter("@VENCIMENTO", Convert.ToDateTime(Vencimento));
            db.AddParameter("@QUANTIDADEESTOQUE", Convert.ToDecimal(Quantidadeestoque));


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

        public static bool Delete(int Codfermento)
        {
            var db = new DBAcess();
            const string delete = " DELETE FROM Fermento ";
            const string where = "WHERE CODFERMENTO = @CODFERMENTO";
            db.CommandText = delete + where;
            db.AddParameter("@CODFERMENTO", Codfermento);
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
            var Mysql = " SELECT F.CODFERMENTO, F.NOME, F.ESTILOFERMENTO,  DATE_FORMAT(F.VENCIMENTO,'%d/%m/%Y') AS DATAVENC, F.QUANTIDADEESTOQUE ";
            Mysql = Mysql + " FROM fermento F ";

            db.CommandText = Mysql;

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int Codfermento)
        {
            var db = new DBAcess();
            var Mysql = " SELECT F.CODFERMENTO, F.NOME, F.ESTILOFERMENTO,  DATE_FORMAT(F.VENCIMENTO,'%d/%m/%Y') AS DATAVENC, F.QUANTIDADEESTOQUE ";
            Mysql = Mysql + "FROM fermento F ";
            Mysql = Mysql + " WHERE CODFERMENTO = @CODFERMENTO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODFERMENTO", Codfermento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

    }
}
