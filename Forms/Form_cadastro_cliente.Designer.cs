namespace Apresentação_DevCoffee
{
    partial class Form_cadastro_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cadastro_cliente));
            this.txt_contato = new System.Windows.Forms.Label();
            this.txt_nome_fantasia = new System.Windows.Forms.Label();
            this.txt_razao_social = new System.Windows.Forms.Label();
            this.tb_contato = new System.Windows.Forms.TextBox();
            this.tb_nome_fantasia = new System.Windows.Forms.TextBox();
            this.tb_razao_social = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_contato
            // 
            this.txt_contato.AutoSize = true;
            this.txt_contato.Location = new System.Drawing.Point(12, 90);
            this.txt_contato.Name = "txt_contato";
            this.txt_contato.Size = new System.Drawing.Size(47, 13);
            this.txt_contato.TabIndex = 25;
            this.txt_contato.Text = "Contato:";
            // 
            // txt_nome_fantasia
            // 
            this.txt_nome_fantasia.AutoSize = true;
            this.txt_nome_fantasia.Location = new System.Drawing.Point(12, 51);
            this.txt_nome_fantasia.Name = "txt_nome_fantasia";
            this.txt_nome_fantasia.Size = new System.Drawing.Size(81, 13);
            this.txt_nome_fantasia.TabIndex = 24;
            this.txt_nome_fantasia.Text = "Nome Fantasia:";
            // 
            // txt_razao_social
            // 
            this.txt_razao_social.AutoSize = true;
            this.txt_razao_social.Location = new System.Drawing.Point(12, 12);
            this.txt_razao_social.Name = "txt_razao_social";
            this.txt_razao_social.Size = new System.Drawing.Size(73, 13);
            this.txt_razao_social.TabIndex = 23;
            this.txt_razao_social.Text = "Razão Social:";
            // 
            // tb_contato
            // 
            this.tb_contato.Location = new System.Drawing.Point(15, 106);
            this.tb_contato.MaxLength = 50;
            this.tb_contato.Name = "tb_contato";
            this.tb_contato.Size = new System.Drawing.Size(207, 20);
            this.tb_contato.TabIndex = 21;
            // 
            // tb_nome_fantasia
            // 
            this.tb_nome_fantasia.Location = new System.Drawing.Point(15, 67);
            this.tb_nome_fantasia.MaxLength = 50;
            this.tb_nome_fantasia.Name = "tb_nome_fantasia";
            this.tb_nome_fantasia.Size = new System.Drawing.Size(207, 20);
            this.tb_nome_fantasia.TabIndex = 20;
            // 
            // tb_razao_social
            // 
            this.tb_razao_social.Location = new System.Drawing.Point(15, 28);
            this.tb_razao_social.MaxLength = 50;
            this.tb_razao_social.Name = "tb_razao_social";
            this.tb_razao_social.Size = new System.Drawing.Size(207, 20);
            this.tb_razao_social.TabIndex = 19;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(66, 132);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 28;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(147, 132);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 27;
            this.btn_salvar.Text = "&Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // Form_cadastro_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 161);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_contato);
            this.Controls.Add(this.txt_nome_fantasia);
            this.Controls.Add(this.txt_razao_social);
            this.Controls.Add(this.tb_contato);
            this.Controls.Add(this.tb_nome_fantasia);
            this.Controls.Add(this.tb_razao_social);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_cadastro_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar cliente";
            this.Load += new System.EventHandler(this.Form_cadastro_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_contato;
        private System.Windows.Forms.Label txt_nome_fantasia;
        private System.Windows.Forms.Label txt_razao_social;
        private System.Windows.Forms.TextBox tb_contato;
        private System.Windows.Forms.TextBox tb_nome_fantasia;
        private System.Windows.Forms.TextBox tb_razao_social;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
    }
}