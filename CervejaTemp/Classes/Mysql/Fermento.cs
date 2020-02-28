using CervejaTemp.Classes.DAL;
using System;
using System.ComponentModel;

namespace CervejaTemp.Classes.Mysql
{
    [DataObject(true)]
    public class Fermento
    {

        private int CodFermento { get; set; }
        private string Nome { get; set; }
        private int Quantidade { get; set; }
        private string Valor { get; set; }
        private string Datafab { get; set; }
        private string Datavenc { get; set; }
        private string Dataentrada { get; set; }
        private string Ebc { get; set; }
        private string Obs { get; set; }


        public Fermento(int codFermento, string nome, int quantidade, string valor, string datafab, string datavenc, string dataentrada, string ebc, string obs)
        {
            CodFermento = codFermento;
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
            Datafab = datafab;
            Datavenc = datavenc;
            Dataentrada = dataentrada;
            Ebc = ebc;
            Obs = obs;

        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO Fermento(";
            Mysql = Mysql + " NOME, QUANTIDADE, VALOR, DATAFAB, DATAVENC, DATAENTRADA, EBC, OBS ";
            Mysql = Mysql + ") ";

            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @NOME, @QUANTIDADE, @VALOR, @DATAFAB, @DATAVENC, @DATAENTRADA, @EBC, @OBS";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODFermento", CodFermento);
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

        public bool Update()
        {
            var db = new DBAcess();
            var Mysql = " UPDATE Fermento ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " NOME = @NOME, QUANTIDADE = @QUANTIDADE, VALOR = @VALOR, DATAFAB = @DATAFAB, DATAVENC = @DATAVENC, ";
            Mysql = Mysql + " DATAENTRADA = @DATAENTRADA, EBC = @EBC, OBS = @OBS";

            Mysql = Mysql = " WHERE CODFermento = @CODFermento";

            db.CommandText = Mysql;

            db.AddParameter("@CODFermento", CodFermento);
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
                db.ExecuteNonQuery();
                return true;
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
