namespace Apresentação_DevCoffee
{
    partial class Form_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_clientes));
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_representante_atual = new System.Windows.Forms.Label();
            this.txt_contato = new System.Windows.Forms.Label();
            this.txt_nome_fantasia = new System.Windows.Forms.Label();
            this.txt_razao_social = new System.Windows.Forms.Label();
            this.tb_representante_atual = new System.Windows.Forms.TextBox();
            this.tb_contato = new System.Windows.Forms.TextBox();
            this.tb_nome_fantasia = new System.Windows.Forms.TextBox();
            this.tb_razao_social = new System.Windows.Forms.TextBox();
            this.lv_clientes = new System.Windows.Forms.ListView();
            this.Clientes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(269, 224);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(127, 22);
            this.btn_cadastrar.TabIndex = 52;
            this.btn_cadastrar.Text = "&Adicionar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(192, 224);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(71, 22);
            this.btn_cancelar.TabIndex = 51;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(269, 195);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(127, 22);
            this.btn_ok.TabIndex = 50;
            this.btn_ok.Text = "E&ditar";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_representante_atual
            // 
            this.txt_representante_atual.AutoSize = true;
            this.txt_representante_atual.Location = new System.Drawing.Point(188, 153);
            this.txt_representante_atual.Name = "txt_representante_atual";
            this.txt_representante_atual.Size = new System.Drawing.Size(106, 13);
            this.txt_representante_atual.TabIndex = 49;
            this.txt_representante_atual.Text = "Representante atual:";
            // 
            // txt_contato
            // 
            this.txt_contato.AutoSize = true;
            this.txt_contato.Location = new System.Drawing.Point(188, 108);
            this.txt_contato.Name = "txt_contato";
            this.txt_contato.Size = new System.Drawing.Size(47, 13);
            this.txt_contato.TabIndex = 48;
            this.txt_contato.Text = "Contato:";
            // 
            // txt_nome_fantasia
            // 
            this.txt_nome_fantasia.AutoSize = true;
            this.txt_nome_fantasia.Location = new System.Drawing.Point(188, 66);
            this.txt_nome_fantasia.Name = "txt_nome_fantasia";
            this.txt_nome_fantasia.Size = new System.Drawing.Size(81, 13);
            this.txt_nome_fantasia.TabIndex = 47;
            this.txt_nome_fantasia.Text = "Nome Fantasia:";
            // 
            // txt_razao_social
            // 
            this.txt_razao_social.AutoSize = true;
            this.txt_razao_social.Location = new System.Drawing.Point(186, 12);
            this.txt_razao_social.Name = "txt_razao_social";
            this.txt_razao_social.Size = new System.Drawing.Size(73, 13);
            this.txt_razao_social.TabIndex = 46;
            this.txt_razao_social.Text = "Razão Social:";
            // 
            // tb_representante_atual
            // 
            this.tb_representante_atual.Location = new System.Drawing.Point(191, 169);
            this.tb_representante_atual.Name = "tb_representante_atual";
            this.tb_representante_atual.ReadOnly = true;
            this.tb_representante_atual.Size = new System.Drawing.Size(205, 20);
            this.tb_representante_atual.TabIndex = 45;
            // 
            // tb_contato
            // 
            this.tb_contato.Location = new System.Drawing.Point(189, 124);
            this.tb_contato.Name = "tb_contato";
            this.tb_contato.ReadOnly = true;
            this.tb_contato.Size = new System.Drawing.Size(207, 20);
            this.tb_contato.TabIndex = 44;
            // 
            // tb_nome_fantasia
            // 
            this.tb_nome_fantasia.Location = new System.Drawing.Point(189, 82);
            this.tb_nome_fantasia.Name = "tb_nome_fantasia";
            this.tb_nome_fantasia.ReadOnly = true;
            this.tb_nome_fantasia.Size = new System.Drawing.Size(207, 20);
            this.tb_nome_fantasia.TabIndex = 43;
            // 
            // tb_razao_social
            // 
            this.tb_razao_social.Location = new System.Drawing.Point(189, 31);
            this.tb_razao_social.Name = "tb_razao_social";
            this.tb_razao_social.ReadOnly = true;
            this.tb_razao_social.Size = new System.Drawing.Size(207, 20);
            this.tb_razao_social.TabIndex = 42;
            // 
            // lv_clientes
            // 
            this.lv_clientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Clientes});
            this.lv_clientes.Location = new System.Drawing.Point(12, 12);
            this.lv_clientes.Name = "lv_clientes";
            this.lv_clientes.Size = new System.Drawing.Size(168, 234);
            this.lv_clientes.TabIndex = 41;
            this.lv_clientes.UseCompatibleStateImageBehavior = false;
            this.lv_clientes.View = System.Windows.Forms.View.Details;
            this.lv_clientes.SelectedIndexChanged += new System.EventHandler(this.lv_clientes_SelectedIndexChanged);
            // 
            // Clientes
            // 
            this.Clientes.Text = "Clientes";
            this.Clientes.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "&Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_representante_atual);
            this.Controls.Add(this.txt_contato);
            this.Controls.Add(this.txt_nome_fantasia);
            this.Controls.Add(this.txt_razao_social);
            this.Controls.Add(this.tb_representante_atual);
            this.Controls.Add(this.tb_contato);
            this.Controls.Add(this.tb_nome_fantasia);
            this.Controls.Add(this.tb_razao_social);
            this.Controls.Add(this.lv_clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form_clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label txt_representante_atual;
        private System.Windows.Forms.Label txt_contato;
        private System.Windows.Forms.Label txt_nome_fantasia;
        private System.Windows.Forms.Label txt_razao_social;
        private System.Windows.Forms.TextBox tb_representante_atual;
        private System.Windows.Forms.TextBox tb_contato;
        private System.Windows.Forms.TextBox tb_nome_fantasia;
        private System.Windows.Forms.TextBox tb_razao_social;
        private System.Windows.Forms.ListView lv_clientes;
        private System.Windows.Forms.ColumnHeader Clientes;
        private System.Windows.Forms.Button button1;
    }
}