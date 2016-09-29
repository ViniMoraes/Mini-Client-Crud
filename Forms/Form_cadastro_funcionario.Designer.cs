namespace Apresentação_DevCoffee
{
    partial class Form_cadastro_funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cadastro_funcionario));
            this.txt_adminisatrador = new System.Windows.Forms.Label();
            this.txt_admissao = new System.Windows.Forms.Label();
            this.txt_cargo = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.Label();
            this.tb_cargo = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nome_fantasia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_clientes = new System.Windows.Forms.Label();
            this.btn_add_cliente = new System.Windows.Forms.Button();
            this.btn_exc_cliente = new System.Windows.Forms.Button();
            this.cb_admissao = new System.Windows.Forms.ComboBox();
            this.cb_administrador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_adminisatrador
            // 
            this.txt_adminisatrador.AutoSize = true;
            this.txt_adminisatrador.Location = new System.Drawing.Point(94, 105);
            this.txt_adminisatrador.Name = "txt_adminisatrador";
            this.txt_adminisatrador.Size = new System.Drawing.Size(73, 13);
            this.txt_adminisatrador.TabIndex = 18;
            this.txt_adminisatrador.Text = "Administrador:";
            // 
            // txt_admissao
            // 
            this.txt_admissao.AutoSize = true;
            this.txt_admissao.Location = new System.Drawing.Point(14, 105);
            this.txt_admissao.Name = "txt_admissao";
            this.txt_admissao.Size = new System.Drawing.Size(55, 13);
            this.txt_admissao.TabIndex = 17;
            this.txt_admissao.Text = "Admissão:";
            // 
            // txt_cargo
            // 
            this.txt_cargo.AutoSize = true;
            this.txt_cargo.Location = new System.Drawing.Point(14, 63);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(38, 13);
            this.txt_cargo.TabIndex = 16;
            this.txt_cargo.Text = "Cargo:";
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Location = new System.Drawing.Point(12, 9);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(38, 13);
            this.txt_nome.TabIndex = 15;
            this.txt_nome.Text = "Nome:";
            // 
            // tb_cargo
            // 
            this.tb_cargo.Location = new System.Drawing.Point(15, 79);
            this.tb_cargo.MaxLength = 50;
            this.tb_cargo.Name = "tb_cargo";
            this.tb_cargo.Size = new System.Drawing.Size(207, 20);
            this.tb_cargo.TabIndex = 12;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(15, 28);
            this.tb_nome.MaxLength = 50;
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(207, 20);
            this.tb_nome.TabIndex = 11;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(345, 180);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 19;
            this.btn_salvar.Text = "&Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(264, 180);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome_fantasia});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(235, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(185, 97);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nome_fantasia
            // 
            this.Nome_fantasia.Text = "Nome Fantasia";
            this.Nome_fantasia.Width = 180;
            // 
            // txt_clientes
            // 
            this.txt_clientes.AutoSize = true;
            this.txt_clientes.Location = new System.Drawing.Point(232, 9);
            this.txt_clientes.Name = "txt_clientes";
            this.txt_clientes.Size = new System.Drawing.Size(47, 13);
            this.txt_clientes.TabIndex = 22;
            this.txt_clientes.Text = "Clientes:";
            // 
            // btn_add_cliente
            // 
            this.btn_add_cliente.Location = new System.Drawing.Point(313, 131);
            this.btn_add_cliente.Name = "btn_add_cliente";
            this.btn_add_cliente.Size = new System.Drawing.Size(107, 23);
            this.btn_add_cliente.TabIndex = 23;
            this.btn_add_cliente.Text = "&Adicionar Cliente";
            this.btn_add_cliente.UseVisualStyleBackColor = true;
            this.btn_add_cliente.Click += new System.EventHandler(this.btn_add_cliente_Click);
            // 
            // btn_exc_cliente
            // 
            this.btn_exc_cliente.Location = new System.Drawing.Point(235, 131);
            this.btn_exc_cliente.Name = "btn_exc_cliente";
            this.btn_exc_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_exc_cliente.TabIndex = 24;
            this.btn_exc_cliente.Text = "&Excluir";
            this.btn_exc_cliente.UseVisualStyleBackColor = true;
            this.btn_exc_cliente.Click += new System.EventHandler(this.btn_exc_cliente_Click);
            // 
            // cb_admissao
            // 
            this.cb_admissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_admissao.FormattingEnabled = true;
            this.cb_admissao.Location = new System.Drawing.Point(15, 121);
            this.cb_admissao.Name = "cb_admissao";
            this.cb_admissao.Size = new System.Drawing.Size(54, 21);
            this.cb_admissao.TabIndex = 25;
            // 
            // cb_administrador
            // 
            this.cb_administrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_administrador.FormattingEnabled = true;
            this.cb_administrador.Location = new System.Drawing.Point(97, 121);
            this.cb_administrador.Name = "cb_administrador";
            this.cb_administrador.Size = new System.Drawing.Size(54, 21);
            this.cb_administrador.TabIndex = 26;
            // 
            // Form_cadastro_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 210);
            this.Controls.Add(this.cb_administrador);
            this.Controls.Add(this.cb_admissao);
            this.Controls.Add(this.btn_exc_cliente);
            this.Controls.Add(this.btn_add_cliente);
            this.Controls.Add(this.txt_clientes);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_adminisatrador);
            this.Controls.Add(this.txt_admissao);
            this.Controls.Add(this.txt_cargo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.tb_cargo);
            this.Controls.Add(this.tb_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_cadastro_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de funcionário";
            this.Load += new System.EventHandler(this.Form_cadastro_funcionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_adminisatrador;
        private System.Windows.Forms.Label txt_admissao;
        private System.Windows.Forms.Label txt_cargo;
        private System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.TextBox tb_cargo;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nome_fantasia;
        private System.Windows.Forms.Label txt_clientes;
        private System.Windows.Forms.Button btn_add_cliente;
        private System.Windows.Forms.Button btn_exc_cliente;
        private System.Windows.Forms.ComboBox cb_admissao;
        private System.Windows.Forms.ComboBox cb_administrador;
    }
}