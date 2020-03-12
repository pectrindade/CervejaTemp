using System;
using System.Windows.Forms;

namespace CervejaTemp.Forms
{
    public partial class Inicial : Form
    {
        private int childFormNumber = 0;

        public Inicial()
        {
            InitializeComponent();
        }

        private void Inicial_Load(object sender, EventArgs e)
        {
            Acesso acesso = new Acesso();
            acesso.ShowDialog();
            VerificaAcesso();
        }

        private void VerificaAcesso()
        {
            var codigo = Usuario.Codusuario.ToString();
            

            if (codigo == "")
            {
                Close();

            }
                     

            
        }


        private void MnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MnCIMalte_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is CadMalte)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new CadMalte();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        

        private void MnFCadUsuario_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is CadUsuario)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new CadUsuario();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MnCILupulo_Click(object sender, EventArgs e)
        {

            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is CadLupulo)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new CadLupulo();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MnCIFermento_Click(object sender, EventArgs e)
        {

            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is CadFermento)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new CadFermento();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MnCIAdjuntos_Click(object sender, EventArgs e)
        {

            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is CadAdjunto)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new CadAdjunto();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void editMenu_Click(object sender, EventArgs e)
        {

            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is CadReceita)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new CadReceita();
                tela.MdiParent = this;
                tela.Show();
            }

        }
    }
}
