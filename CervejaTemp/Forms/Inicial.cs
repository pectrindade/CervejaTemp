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
    public partial class Inicial : Form
    {
        private int childFormNumber = 0;

        public Inicial()
        {
            InitializeComponent();
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

        private void Inicial_Load(object sender, EventArgs e)
        {
            Acesso acesso = new Acesso();
            acesso.ShowDialog();
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
    }
}
