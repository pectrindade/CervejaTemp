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

        private void CadMalte_Load(object sender, EventArgs e)
        {
            BuscaCadMalte();


        }

        private void BuscaCadMalte()
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[2];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Malte.Select();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODCadMalte"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("DESCRICAO"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void Grid_CadMalte_DoubleClick(object sender, EventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                //txtCodigo.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                //txtnome.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void Grid_CadMalte_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDesfaz_Click(object sender, EventArgs e)
        {
            Limpatela();
        }

        private void Limpatela()
        {
            //txtCodigo.Text = "0";
            //txtnome.Text = "";

            //BuscaCadMalte();
            //txtnome.Focus();

        }

        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;
            var descricao = txtnome.Text.Trim();


            try
            {
                //var m = new Classes.Mysql.Malte(codigo, descricao);
                //if (novo)
                //    m.Insert();
                //else
                //    m.Update();

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
            if (txtcodigo.Text.Trim() == "0")
            {

                Gravar(true, 0);

            }
            else
            {

                Gravar(false, int.Parse(txtcodigo.Text.Trim()));

            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                txtcodigo.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                txtnome.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            Relatorio();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
