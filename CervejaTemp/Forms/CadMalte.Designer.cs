namespace CervejaTemp.Forms
{
    partial class CadMalte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdatafabricacao = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdatavencimento = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtebc = new System.Windows.Forms.TextBox();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.txtdatacadastro = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnexclui = new System.Windows.Forms.Button();
            this.btnfecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(80, 9);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(71, 20);
            this.txtcodigo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Cadastro";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(80, 44);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(287, 20);
            this.txtnome.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(80, 79);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(71, 20);
            this.txtquantidade.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(296, 79);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(71, 20);
            this.txtpreco.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Preço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kg.";
            // 
            // txtdatafabricacao
            // 
            this.txtdatafabricacao.Location = new System.Drawing.Point(80, 116);
            this.txtdatafabricacao.Mask = "99/99/9999";
            this.txtdatafabricacao.Name = "txtdatafabricacao";
            this.txtdatafabricacao.Size = new System.Drawing.Size(71, 20);
            this.txtdatafabricacao.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fabricação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Vencimento";
            // 
            // txtdatavencimento
            // 
            this.txtdatavencimento.Location = new System.Drawing.Point(296, 113);
            this.txtdatavencimento.Mask = "99/99/9999";
            this.txtdatavencimento.Name = "txtdatavencimento";
            this.txtdatavencimento.Size = new System.Drawing.Size(71, 20);
            this.txtdatavencimento.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "ECB";
            // 
            // txtebc
            // 
            this.txtebc.Location = new System.Drawing.Point(80, 155);
            this.txtebc.Name = "txtebc";
            this.txtebc.Size = new System.Drawing.Size(71, 20);
            this.txtebc.TabIndex = 20;
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(420, 9);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(339, 189);
            this.txtobs.TabIndex = 21;
            // 
            // txtdatacadastro
            // 
            this.txtdatacadastro.Location = new System.Drawing.Point(296, 9);
            this.txtdatacadastro.Mask = "99/99/9999";
            this.txtdatacadastro.Name = "txtdatacadastro";
            this.txtdatacadastro.Size = new System.Drawing.Size(71, 20);
            this.txtdatacadastro.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Obs.";
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.quantidade,
            this.EBC,
            this.obs,
            this.fabricação,
            this.vencimento});
            this.Grid.Location = new System.Drawing.Point(15, 223);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(744, 209);
            this.Grid.TabIndex = 24;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // EBC
            // 
            this.EBC.HeaderText = "EBC";
            this.EBC.Name = "EBC";
            // 
            // obs
            // 
            this.obs.HeaderText = "Observação";
            this.obs.Name = "obs";
            // 
            // fabricação
            // 
            this.fabricação.HeaderText = "Data Fabricação";
            this.fabricação.Name = "fabricação";
            // 
            // vencimento
            // 
            this.vencimento.HeaderText = "Data Vencimento";
            this.vencimento.Name = "vencimento";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(80, 194);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 25;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // btnexclui
            // 
            this.btnexclui.Location = new System.Drawing.Point(171, 194);
            this.btnexclui.Name = "btnexclui";
            this.btnexclui.Size = new System.Drawing.Size(75, 23);
            this.btnexclui.TabIndex = 26;
            this.btnexclui.Text = "Excluir";
            this.btnexclui.UseVisualStyleBackColor = true;
            // 
            // btnfecha
            // 
            this.btnfecha.Location = new System.Drawing.Point(263, 194);
            this.btnfecha.Name = "btnfecha";
            this.btnfecha.Size = new System.Drawing.Size(75, 23);
            this.btnfecha.TabIndex = 27;
            this.btnfecha.Text = "Fechar";
            this.btnfecha.UseVisualStyleBackColor = true;
            this.btnfecha.Click += new System.EventHandler(this.btnfecha_Click);
            // 
            // CadMalte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 443);
            this.Controls.Add(this.btnfecha);
            this.Controls.Add(this.btnexclui);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdatacadastro);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.txtebc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdatavencimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdatafabricacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Name = "CadMalte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadMalte";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtdatafabricacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtdatavencimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtebc;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.MaskedTextBox txtdatacadastro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn EBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricação;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnexclui;
        private System.Windows.Forms.Button btnfecha;
    }
}