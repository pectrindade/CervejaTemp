﻿using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Xml;

namespace CervejaTemp.Classes.DAL
{


    public class DBAcess : IDisposable
    {
        string nome = Environment.MachineName;


        readonly ConnectionStringSettings _conexao = ConfigurationManager.ConnectionStrings["MySqlLocal"];
        readonly ConnectionStringSettings _conexao2 = ConfigurationManager.ConnectionStrings["MySqlLocal2"];

        readonly ConnectionStringSettings _conExterno = ConfigurationManager.ConnectionStrings["MySqlExterno"];
        readonly ConnectionStringSettings _conExterno2 = ConfigurationManager.ConnectionStrings["MySqlExterno2"];

        private MySqlCommand _cmd = new MySqlCommand();
        private string _strConnectionString = "";
        private bool _handleErrors;
        private string _strLastError = "";
        public CommandType Tipo = CommandType.Text;

        public string Caminho()
        {

            //IniFile meuIniFile = new IniFile();
            //string meuTitulo = meuIniFile.IniReadString("servidor", "server", "local");

            //return meuTitulo;
            return  "";

        }

        public bool CloseConnection()
        {

            try
            {
                var cnn = new MySqlConnection { ConnectionString = _strConnectionString };
                MySqlConnection.ClearPool(cnn);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public DBAcess()
        {
            var objConnectionStringSettings = _conexao;

            try
            {


                _strConnectionString = objConnectionStringSettings.ConnectionString;
                var cnn = new MySqlConnection { ConnectionString = _strConnectionString };
                _cmd.Connection = cnn;
                _cmd.CommandType = Tipo;
                cnn.Close(); cnn.Dispose();
            }
            catch (Exception)
            {
                return;
            }


        }

        private string DefineCaminho()
        {

            string Nome = "";

            string caminhoArquivo = @"C:\sms\Nome.xml";
            XmlTextReader xmlReader = new XmlTextReader(caminhoArquivo);
            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Text:
                        Nome = xmlReader.Value;

                        break;
                }
            }

            //try
            //{

            //    string fileName = Nome;
            //    return fileName;
            //}
            //catch (Exception ex)
            //{
                return "";
            //}
        }

        public DBAcess(CommandType tipo)
        {
            try
            {
                var objConnectionStringSettings = _conexao;
                _strConnectionString = objConnectionStringSettings.ConnectionString;
                var cnn = new MySqlConnection { ConnectionString = _strConnectionString };
                _cmd.Connection = cnn;
                _cmd.CommandType = tipo;
                cnn.Close(); cnn.Dispose();
            }
            catch (Exception)
            {
                return;
            }
        }

        public void TipoMuda(CommandType tipo)
        {
            _cmd.CommandType = tipo;
        }

        public IDataReader ExecuteReader()
        {
            IDataReader reader = null;
            try
            {
                Open();
                reader = _cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                if (_handleErrors)
                    _strLastError = ex.Message;

                else
                    throw;

            }

            return reader;
        }

        public IDataReader ExecuteReader(string commandtext)
        {
            IDataReader reader = null;
            try
            {
                _cmd.CommandText = commandtext;
                reader = ExecuteReader();
            }
            catch (Exception ex)
            {
                if (_handleErrors)
                    _strLastError = ex.Message;
                else
                    throw;
            }

            return reader;
        }

        public object ExecuteScalar()
        {
            object obj = null;
            try
            {
                Open();
                obj = _cmd.ExecuteScalar();
                Close();
            }
            catch (Exception ex)
            {
                if (_handleErrors)
                    _strLastError = ex.Message;
                else
                    throw;
            }


            return obj;
        }

        public object ExecuteScalar(string commandtext)
        {
            object obj = null;
            try
            {
                _cmd.CommandText = commandtext;
                obj = ExecuteScalar();
            }
            catch (Exception ex)
            {
                if (_handleErrors)
                    _strLastError = ex.Message;
                else
                    throw;
            }


            return obj;
        }

        public int ExecuteNonQuery()
        {
            int i = -1;
            try
            {
                Open();
                i = _cmd.ExecuteNonQuery();
                Close();
            }
            catch (Exception ex)
            {
                if (_handleErrors)
                    _strLastError = ex.Message;
                else
                    throw;
            }


            return i;
        }

        public int ExecuteNonQuery(string commandtext)
        {
            int i = -1;
            try
            {
                _cmd.CommandText = commandtext;
                i = ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (_handleErrors)
                    _strLastError = ex.Message;
                else
                    throw;
            }

            return i;
        }

        public DataSet ExecuteDataSet()
        {
            MySqlDataAdapter da = null;
            DataSet ds = null;
            try
            {
                da = new MySqlDataAdapter();
                da.SelectCommand = (MySqlCommand)_cmd;
                ds = new DataSet();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                if (_handleErrors)
                    _strLastError = ex.Message;
                else
                    throw;
            }


            return ds;
        }

        public DataSet ExecuteDataSet(string commandtext)
        {
            DataSet ds = null;
            try
            {
                _cmd.CommandText = commandtext;
                ds = ExecuteDataSet();
            }
            catch (Exception ex)
            {
                if (_handleErrors)
                    _strLastError = ex.Message;
                else
                    throw;
            }

            return ds;
        }

        public DataSet ExecuteDataSet(MySqlCommand commandtext)
        {
            DataSet ds = null;
            try
            {
                _cmd = commandtext;
                ds = ExecuteDataSet();
            }
            catch (Exception ex)
            {
                if (_handleErrors)
                    _strLastError = ex.Message;
                else
                    throw;
            }
            return ds;
        }

        public string CommandText
        {
            get
            {
                return _cmd.CommandText;
            }
            set
            {
                _cmd.CommandText = value;
                _cmd.Parameters.Clear();
            }
        }

        public IDataParameterCollection Parameters
        {
            get
            {
                return _cmd.Parameters;
            }
        }

        public void AddParameter(string paramname, object paramvalue)
        {
            try
            {
                var param = new MySqlParameter(paramname, paramvalue);
                _cmd.Parameters.Add(param);
            }
            catch
            {
                throw;
            }
        }

        public void AddParameter(IDataParameter param)
        {
            _cmd.Parameters.Add(param);
        }


        public string ConnectionString
        {
            get
            {
                return _strConnectionString;
            }
            set
            {
                _strConnectionString = value;
            }
        }

        private void Open()
        {
            _cmd.Connection.Open();
        }

        private void Close()
        {
            _cmd.Connection.Close();
        }

        public bool HandleExceptions
        {
            get
            {
                return _handleErrors;
            }
            set
            {
                _handleErrors = value;
            }
        }

        public string LastError
        {
            get
            {
                return _strLastError;
            }
        }

        public void Dispose()
        {
            //_cmd.Dispose();

            CloseConnection();
        }




    }

}
