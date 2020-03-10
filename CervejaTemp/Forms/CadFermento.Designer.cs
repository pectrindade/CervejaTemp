﻿namespace CervejaTemp.Forms
{
    partial class CadFermento
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDesfaz = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstilo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdatavencimento = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListar.Location = new System.Drawing.Point(488, 315);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(59, 23);
            this.btnListar.TabIndex = 184;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnDesfaz
            // 
            this.btnDesfaz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesfaz.Location = new System.Drawing.Point(419, 315);
            this.btnDesfaz.Name = "btnDesfaz";
            this.btnDesfaz.Size = new System.Drawing.Size(59, 23);
            this.btnDesfaz.TabIndex = 183;
            this.btnDesfaz.Text = "Desfaz";
            this.btnDesfaz.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluir.Location = new System.Drawing.Point(354, 315);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(59, 23);
            this.BtnExcluir.TabIndex = 182;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(289, 315);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 23);
            this.btnSalvar.TabIndex = 181;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(224, 315);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 23);
            this.btnFechar.TabIndex = 185;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.estilo,
            this.vencimento,
            this.quantidade});
            this.Grid.Location = new System.Drawing.Point(12, 110);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(749, 199);
            this.Grid.TabIndex = 189;
            this.Grid.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(53, 20);
            this.txtCodigo.TabIndex = 186;
            this.txtCodigo.Text = "0";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(71, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(16, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 187;
            this.label4.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(68, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 188;
            this.label3.Text = "Nome";
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
            this.nome.Width = 220;
            // 
            // estilo
            // 
            this.estilo.HeaderText = "Estilo";
            this.estilo.Name = "estilo";
            this.estilo.Width = 180;
            // 
            // vencimento
            // 
            this.vencimento.HeaderText = "Vencimento";
            this.vencimento.Name = "vencimento";
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(250, 72);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(71, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 203;
            this.label5.Text = "Quantidade";
            // 
            // txtEstilo
            // 
            this.txtEstilo.Location = new System.Drawing.Point(71, 46);
            this.txtEstilo.Name = "txtEstilo";
            this.txtEstilo.Size = new System.Drawing.Size(250, 20);
            this.txtEstilo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 202;
            this.label2.Text = "Estilo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 201;
            this.label7.Text = "Vencimento";
            // 
            // txtdatavencimento
            // 
            this.txtdatavencimento.Location = new System.Drawing.Point(71, 72);
            this.txtdatavencimento.Mask = "99/99/9999";
            this.txtdatavencimento.Name = "txtdatavencimento";
            this.txtdatavencimento.Size = new System.Drawing.Size(71, 20);
            this.txtdatavencimento.TabIndex = 2;
            // 
            // CadFermento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 350);
            this.ControlBox = false;
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstilo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdatavencimento);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDesfaz);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadFermento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadFermento";
            this.Load += new System.EventHandler(this.CadFermento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDesfaz;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn estilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstilo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtdatavencimento;
    }
}