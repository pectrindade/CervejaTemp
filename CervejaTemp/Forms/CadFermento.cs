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
    public partial class CadFermento : Form
    {
        public CadFermento()
        {
            InitializeComponent();
        }

        private void CadFermento_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadFermento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void BuscaFermento()
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Fermento.Select();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (!dr.IsDBNull(dr.GetOrdinal("CODFERMENTO"))) { linhaDados[0] = dr.GetString(dr.GetOrdinal("CODFERMENTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOME"))) { linhaDados[1] = dr.GetString(dr.GetOrdinal("NOME")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("ESTILOFERMENTO"))) { linhaDados[2] = dr.GetString(dr.GetOrdinal("ESTILOFERMENTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DATAVENC"))) { linhaDados[4] = dr.GetString(dr.GetOrdinal("DATAVENC")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("QUANTIDADEESTOQUE"))) { linhaDados[5] = dr.GetString(dr.GetOrdinal("QUANTIDADEESTOQUE")); }

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void btnDesfaz_Click(object sender, EventArgs e)
        {
            Limpatela();
        }

        private void Limpatela()
        {
            txtCodigo.Text = "0";
            txtNome.Text = "";
            txtTipo.Text = "";
            txtAlfaacido.Text = "";
            txtdatavencimento.Text = "";
            txtQuantidade.Text = "";

            BuscaFermento();
            txtNome.Focus();

        }

        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;
            //codigo = int.Parse(txtCodigo.Text.Trim());
            var Nome = txtNome.Text.Trim();
            var Tipo = txtTipo.Text.Trim();
            var AlfaAcido = txtAlfaacido.Text.Trim();
            var vencimento = txtdatavencimento.Text.Trim();
            var Quantidade = txtQuantidade.Text.Trim();


            try
            {
                var m = new Classes.Mysql.Fermento(codigo, Nome, Tipo, AlfaAcido, vencimento, Quantidade);
                if (novo)
                    m.Insert();
                else
                    m.Update();

                MessageBox.Show("Registro Gravado com Sucesso !");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

            Limpatela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "0")
            {

                Gravar(true, 0);

            }
            else
            {

                Gravar(false, int.Parse(txtCodigo.Text.Trim()));

            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                txtCodigo.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                txtNome.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
