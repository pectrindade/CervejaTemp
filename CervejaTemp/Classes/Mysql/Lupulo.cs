﻿using CervejaTemp.Classes.DAL;
using System;
using System.ComponentModel;

namespace CervejaTemp.Classes.Mysql
{
    [DataObject(true)]
    public class Lupulo
    {

        private int CodLupulo { get; set; }
        private string Nome { get; set; }
        private int Quantidade { get; set; }
        private string Valor { get; set; }
        private string Datafab { get; set; }
        private string Datavenc { get; set; }
        private string Dataentrada { get; set; }
        private string Ebc { get; set; }
        private string Obs { get; set; }


        public Lupulo(int codLupulo, string nome, int quantidade, string valor, string datafab, string datavenc, string dataentrada, string ebc, string obs)
        {
            CodLupulo = codLupulo;
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
            var Mysql = " INSERT INTO Lupulo(";
            Mysql = Mysql + " NOME, QUANTIDADE, VALOR, DATAFAB, DATAVENC, DATAENTRADA, EBC, OBS ";
            Mysql = Mysql + ") ";

            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @NOME, @QUANTIDADE, @VALOR, @DATAFAB, @DATAVENC, @DATAENTRADA, @EBC, @OBS";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODLupulo", CodLupulo);
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
            var Mysql = " UPDATE Lupulo ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " NOME = @NOME, QUANTIDADE = @QUANTIDADE, VALOR = @VALOR, DATAFAB = @DATAFAB, DATAVENC = @DATAVENC, ";
            Mysql = Mysql + " DATAENTRADA = @DATAENTRADA, EBC = @EBC, OBS = @OBS";

            Mysql = Mysql = " WHERE CODLupulo = @CODLupulo";

            db.CommandText = Mysql;

            db.AddParameter("@CODLupulo", CodLupulo);
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
