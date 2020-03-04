using CervejaTemp.Classes.Mysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CervejaTemp.Forms
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void btnloga_Click(object sender, EventArgs e)
        {
            Entra();
        }


        private void btnsai_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Entra()
        {
            Usuario.Codusuario = "";
            Usuario.Nomeusuario = "";


            if (txtlogin.Text.Trim() == "")
            {

                txtlogin.Focus();
                return;
            }
            if (txtsenha.Text.Trim() == "")
            {

                txtlogin.Focus();
                txtsenha.Focus();
                return;
            }


            var codigo = Acessos.Acessar(txtlogin.Text, txtsenha.Text);
            if (codigo.Trim() != "")
            {

                var dr = new Acessos(int.Parse(codigo)).Select();
                               
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var codUsuario = dr.GetInt32(dr.GetOrdinal("CODUSUARIO")).ToString();
                        var login = dr.GetString(dr.GetOrdinal("login"));
                        var nome = dr.GetString(dr.GetOrdinal("NOME"));
                        //var email = dr.GetString(dr.GetOrdinal("EMAIL"));

                        Usuario.Codusuario = codUsuario;
                        Usuario.Nomeusuario = nome;

                        this.Close();
                    }
                }
                dr.Dispose();
                dr.Close();




            }
            else
            {
                lblmensagem.Visible = true;
                txtlogin.Text = "";
                txtsenha.Text = "";

                txtlogin.Focus();
            }


        }

        private void Acesso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }
    }
}
