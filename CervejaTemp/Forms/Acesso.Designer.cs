namespace CervejaTemp.Forms
{
    partial class Acesso
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
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnloga = new System.Windows.Forms.Button();
            this.btnsai = new System.Windows.Forms.Button();
            this.lblAltera = new System.Windows.Forms.Label();
            this.lblmensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(65, 95);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(170, 20);
            this.txtsenha.TabIndex = 10;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Senha";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(65, 48);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(170, 20);
            this.txtlogin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tela de Login";
            // 
            // btnloga
            // 
            this.btnloga.Location = new System.Drawing.Point(16, 181);
            this.btnloga.Name = "btnloga";
            this.btnloga.Size = new System.Drawing.Size(75, 23);
            this.btnloga.TabIndex = 12;
            this.btnloga.Text = "Logar";
            this.btnloga.UseVisualStyleBackColor = true;
            this.btnloga.Click += new System.EventHandler(this.btnloga_Click);
            // 
            // btnsai
            // 
            this.btnsai.Location = new System.Drawing.Point(160, 181);
            this.btnsai.Name = "btnsai";
            this.btnsai.Size = new System.Drawing.Size(75, 23);
            this.btnsai.TabIndex = 13;
            this.btnsai.Text = "Sair";
            this.btnsai.UseVisualStyleBackColor = true;
            this.btnsai.Click += new System.EventHandler(this.btnsai_Click);
            // 
            // lblAltera
            // 
            this.lblAltera.AutoSize = true;
            this.lblAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltera.Location = new System.Drawing.Point(-1, 148);
            this.lblAltera.Name = "lblAltera";
            this.lblAltera.Size = new System.Drawing.Size(261, 15);
            this.lblAltera.TabIndex = 19;
            this.lblAltera.Text = "Favor usar o login e a senha recem informada.";
            this.lblAltera.Visible = false;
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensagem.ForeColor = System.Drawing.Color.Red;
            this.lblmensagem.Location = new System.Drawing.Point(16, 123);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(197, 20);
            this.lblmensagem.TabIndex = 18;
            this.lblmensagem.Text = "Login ou Senha Incorreto !";
            this.lblmensagem.Visible = false;
            // 
            // Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 218);
            this.ControlBox = false;
            this.Controls.Add(this.lblAltera);
            this.Controls.Add(this.lblmensagem);
            this.Controls.Add(this.btnsai);
            this.Controls.Add(this.btnloga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Acesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Acesso_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnloga;
        private System.Windows.Forms.Button btnsai;
        private System.Windows.Forms.Label lblAltera;
        private System.Windows.Forms.Label lblmensagem;
    }
}