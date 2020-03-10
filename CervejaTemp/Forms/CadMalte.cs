using CervejaTemp.Classes.Funcoes;
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
    public partial class CadMalte : Form
    {
        public CadMalte()
        {
            InitializeComponent();
        }

        private void CadMalte_Load(object sender, EventArgs e)
        {
            txtdatacadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtcodigo.Text = "0";

            BuscaGrid();

            txtnome.Focus();
        }

        private void btnfecha_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadMalte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() != "")
            {
                BuscaCodigo(int.Parse(txtcodigo.Text));
            }
        }

        private void BuscaCodigo(int codigo)
        {

            var dr = Classes.Mysql.Malte.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODMALTE"));
                    txtdatacadastro.Text = dr.GetString(dr.GetOrdinal("DATAENTRADA"));
                    txtnome.Text = dr.GetString(dr.GetOrdinal("NOME"));
                    txtquantidade.Text = dr.GetString(dr.GetOrdinal("QUANTIDADE"));
                    txtpreco.Text = dr.GetString(dr.GetOrdinal("VALOR"));
                    txtdatafabricacao.Text = dr.GetString(dr.GetOrdinal("DATAFAB"));
                    txtdatavencimento.Text = dr.GetString(dr.GetOrdinal("DATAVENC"));
                    txtebc.Text = dr.GetString(dr.GetOrdinal("EBC"));
                    txtobs.Text = dr.GetString(dr.GetOrdinal("OBS"));

                }

            }

            dr.Close();
            dr.Dispose();

            txtnome.Focus();
        }
        
        private void BuscaGrid()
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[7];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Malte.Select();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (!dr.IsDBNull(dr.GetOrdinal("CODMALTE"))) { linhaDados[0] = dr.GetString(dr.GetOrdinal("CODMALTE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOME"))) { linhaDados[1] = dr.GetString(dr.GetOrdinal("NOME")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("QUANTIDADE"))) { linhaDados[2] = dr.GetString(dr.GetOrdinal("QUANTIDADE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("EBC"))) { linhaDados[3] = dr.GetString(dr.GetOrdinal("EBC")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("OBS"))) { linhaDados[4] = dr.GetString(dr.GetOrdinal("OBS")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DATAFAB"))) { linhaDados[5] = dr.GetString(dr.GetOrdinal("DATAFAB")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DATAVENC"))) { linhaDados[6] = dr.GetString(dr.GetOrdinal("DATAVENC")); }

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void btndesfaz_Click(object sender, EventArgs e)
        {
            Limpatela();
        }

        private void Limpatela()
        {
            txtcodigo.Text = "0";

            txtdatacadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtnome.Text = "";
            txtquantidade.Text = "";
            txtpreco.Text = "";
            txtdatafabricacao.Text = ""; // "__/__/____";
            txtdatavencimento.Text = ""; //"__/__/____";
            txtebc.Text = "";
            txtobs.Text = "";

            txtnome.Focus();

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() == "0")
            {

                Gravar(true, 0);

            }
            else
            {

                Gravar(false, int.Parse(txtcodigo.Text.Trim()));

            }
        }

        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;
            //var codigo = txtcodigo.Text.Trim();
            var dtcadastro = txtdatacadastro.Text.Trim();
            var nome = txtnome.Text.Trim();
            var quantidade = txtquantidade.Text.Trim();
            var preco = txtpreco.Text.Trim();
            var dtfabricacao = txtdatafabricacao.Text.Trim();
            var dtvencimento = txtdatavencimento.Text.Trim();
            var ebc = txtebc.Text.Trim();
            var obs = txtobs.Text.Trim();


            try
            {
                var m = new Classes.Mysql.Malte(codigo, nome, quantidade, preco, dtfabricacao, dtvencimento, dtcadastro, ebc, obs);
                if (novo)
                    m.Insert();
                else
                    m.Update();

                MessageBox.Show("Registro Gravado com Sucesso !");
                BuscaGrid();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

            Limpatela();
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                txtcodigo.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                //txtnome.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }
       
        private void btnListar_Click(object sender, EventArgs e)
        {
            Relatorio();
        }

        private void Relatorio()
        {
            var cria = new CriaArquivo();
            //cria.Cria_CadMalte();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Malte.Select();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var cod = dr.GetString(dr.GetOrdinal("CODCadMalte"));
                    var nome = dr.GetString(dr.GetOrdinal("DESCRICAO"));

                    try
                    {
                        //var m = new Classes.Mysql.Malte(int.Parse(cod), nome);

                        //m.InsertAccess();
                    }
                    catch (Exception erro)
                    {

                    }

                }

            }

            dr.Close();
            dr.Dispose();

            //CHAMA A TELA DE RELATORIO
            //bool open = false;
            //foreach (Form form in this.MdiChildren)
            //{
            //    if (form is RelCadMalte)
            //    {
            //        form.BringToFront();
            //        open = true;
            //    }
            //}
            //if (!open)
            //{
            //    Form tela = new RelCadMalte();
            //    tela.ShowDialog();
            //}

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                txtcodigo.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                BuscaCodigo(int.Parse(txtcodigo.Text));

            }
            catch
            {

            }
        }

        
    }
}
