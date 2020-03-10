using CervejaTemp.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;

namespace CervejaTemp.Classes.Mysql
{
    [DataObject(true)]
    public class Lupulo
    {

        private int Codlupulo { get; set; }
        private string Nome { get; set; }
        private string Tipolupulo { get; set; }
        private string Alfaacido { get; set; }
        private string Vencimento { get; set; }
        private string Quantidadeestoque { get; set; }


        public Lupulo(int codlupulo, string nome, string tipolupulo, string alfaacido, string vencimento, string quantidadeestoque)
        {
            Codlupulo = codlupulo;
            Nome = nome;
            Tipolupulo = tipolupulo;
            Alfaacido = alfaacido;
            Vencimento = vencimento;
            Quantidadeestoque = quantidadeestoque;

        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO Lupulo(";
            Mysql = Mysql + " NOME, TIPOLUPULO, ALFAACIDO, VENCIMENTO, QUANTIDADEESTOQUE ";
            Mysql = Mysql + ") ";

            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @NOME, @TIPOLUPULO, @ALFAACIDO, @VENCIMENTO, @QUANTIDADEESTOQUE ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODLUPULO", Codlupulo);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@TIPOLUPULO", Tipolupulo);
            db.AddParameter("@ALFAACIDO", Convert.ToDecimal(Alfaacido));
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
            var Mysql = " UPDATE Lupulo ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " NOME = @NOME, TIPOLUPULO = @TIPOLUPULO, ALFAACIDO = @ALFAACIDO, VENCIMENTO = @VENCIMENTO, QUANTIDADEESTOQUE = @QUANTIDADEESTOQUE ";

            Mysql = Mysql + " WHERE CODLUPULO = @CODLUPULO";

            db.CommandText = Mysql;

            db.AddParameter("@CODLUPULO", Codlupulo);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@TIPOLUPULO", Tipolupulo);
            db.AddParameter("@ALFAACIDO", Convert.ToDecimal(Alfaacido));
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

        public static bool Delete(int codlupulo)
        {
            var db = new DBAcess();
            const string delete = " DELETE FROM Lupulo ";
            const string where = "WHERE CODLUPULO = @CODLUPULO";
            db.CommandText = delete + where;
            db.AddParameter("@CODLUPULO", codlupulo);
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
            var Mysql = " SELECT L.CODLUPULO, L.NOME, L.TIPOLUPULO, L.ALFAACIDO, DATE_FORMAT(L.VENCIMENTO,'%d/%m/%Y') AS DATAVENC, L.QUANTIDADEESTOQUE ";
            Mysql = Mysql + " FROM lupulo L ";

            db.CommandText = Mysql;

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int codlupulo)
        {
            var db = new DBAcess();
            var Mysql = " SELECT L.CODLUPULO, L.NOME, L.TIPOLUPULO, L.ALFAACIDO, DATE_FORMAT(L.VENCIMENTO,'%d/%m/%Y') AS DATAVENC, L.QUANTIDADEESTOQUE ";
            Mysql = Mysql + " FROM lupulo L ";
            Mysql = Mysql + " WHERE CODLUPULO = @CODLUPULO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODLUPULO", codlupulo);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }



    }
}
