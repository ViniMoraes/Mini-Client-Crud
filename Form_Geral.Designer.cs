namespace Apresentação_DevCoffee
{
    partial class Form_Geral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Geral));
            this.lv_funcionarios = new System.Windows.Forms.ListView();
            this.funcionario_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_cargo = new System.Windows.Forms.TextBox();
            this.tb_admissao = new System.Windows.Forms.TextBox();
            this.tb_administrador = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.Label();
            this.txt_cargo = new System.Windows.Forms.Label();
            this.txt_admissao = new System.Windows.Forms.Label();
            this.txt_adminisatrador = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exlcuir = new System.Windows.Forms.Button();
            this.lv_clientes = new System.Windows.Forms.ListView();
            this.Nome_Fantasia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_funcionarios
            // 
            resources.ApplyResources(this.lv_funcionarios, "lv_funcionarios");
            this.lv_funcionarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.funcionario_nome});
            this.lv_funcionarios.FullRowSelect = true;
            this.lv_funcionarios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_funcionarios.MultiSelect = false;
            this.lv_funcionarios.Name = "lv_funcionarios";
            this.lv_funcionarios.UseCompatibleStateImageBehavior = false;
            this.lv_funcionarios.View = System.Windows.Forms.View.Details;
            this.lv_funcionarios.SelectedIndexChanged += new System.EventHandler(this.lv_clientes_SelectedIndexChanged);
            // 
            // funcionario_nome
            // 
            resources.ApplyResources(this.funcionario_nome, "funcionario_nome");
            // 
            // Nome
            // 
            resources.ApplyResources(this.Nome, "Nome");
            // 
            // Cargo
            // 
            resources.ApplyResources(this.Cargo, "Cargo");
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            resources.ApplyResources(this.aToolStripMenuItem, "aToolStripMenuItem");
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.visualizarClientesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            // 
            // adicionarToolStripMenuItem
            // 
            resources.ApplyResources(this.adicionarToolStripMenuItem, "adicionarToolStripMenuItem");
            this.adicionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionarioToolStripMenuItem});
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            // 
            // clienteToolStripMenuItem
            // 
            resources.ApplyResources(this.clienteToolStripMenuItem, "clienteToolStripMenuItem");
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            resources.ApplyResources(this.funcionarioToolStripMenuItem, "funcionarioToolStripMenuItem");
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // visualizarClientesToolStripMenuItem
            // 
            resources.ApplyResources(this.visualizarClientesToolStripMenuItem, "visualizarClientesToolStripMenuItem");
            this.visualizarClientesToolStripMenuItem.Name = "visualizarClientesToolStripMenuItem";
            this.visualizarClientesToolStripMenuItem.Click += new System.EventHandler(this.visualizarClientesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            resources.ApplyResources(this.sairToolStripMenuItem, "sairToolStripMenuItem");
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            resources.ApplyResources(this.configuraçõesToolStripMenuItem, "configuraçõesToolStripMenuItem");
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            // 
            // sobreToolStripMenuItem
            // 
            resources.ApplyResources(this.sobreToolStripMenuItem, "sobreToolStripMenuItem");
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // tb_nome
            // 
            resources.ApplyResources(this.tb_nome, "tb_nome");
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.ReadOnly = true;
            // 
            // tb_cargo
            // 
            resources.ApplyResources(this.tb_cargo, "tb_cargo");
            this.tb_cargo.Name = "tb_cargo";
            this.tb_cargo.ReadOnly = true;
            // 
            // tb_admissao
            // 
            resources.ApplyResources(this.tb_admissao, "tb_admissao");
            this.tb_admissao.Name = "tb_admissao";
            this.tb_admissao.ReadOnly = true;
            // 
            // tb_administrador
            // 
            resources.ApplyResources(this.tb_administrador, "tb_administrador");
            this.tb_administrador.Name = "tb_administrador";
            this.tb_administrador.ReadOnly = true;
            // 
            // txt_nome
            // 
            resources.ApplyResources(this.txt_nome, "txt_nome");
            this.txt_nome.Name = "txt_nome";
            // 
            // txt_cargo
            // 
            resources.ApplyResources(this.txt_cargo, "txt_cargo");
            this.txt_cargo.Name = "txt_cargo";
            // 
            // txt_admissao
            // 
            resources.ApplyResources(this.txt_admissao, "txt_admissao");
            this.txt_admissao.Name = "txt_admissao";
            // 
            // txt_adminisatrador
            // 
            resources.ApplyResources(this.txt_adminisatrador, "txt_adminisatrador");
            this.txt_adminisatrador.Name = "txt_adminisatrador";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_exlcuir);
            this.groupBox1.Controls.Add(this.lv_clientes);
            this.groupBox1.Controls.Add(this.txt_adminisatrador);
            this.groupBox1.Controls.Add(this.txt_admissao);
            this.groupBox1.Controls.Add(this.txt_cargo);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.tb_administrador);
            this.groupBox1.Controls.Add(this.tb_admissao);
            this.groupBox1.Controls.Add(this.tb_cargo);
            this.groupBox1.Controls.Add(this.tb_nome);
            this.groupBox1.Controls.Add(this.lv_funcionarios);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btn_add
            // 
            resources.ApplyResources(this.btn_add, "btn_add");
            this.btn_add.Name = "btn_add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_editar
            // 
            resources.ApplyResources(this.btn_editar, "btn_editar");
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_exlcuir
            // 
            resources.ApplyResources(this.btn_exlcuir, "btn_exlcuir");
            this.btn_exlcuir.Name = "btn_exlcuir";
            this.btn_exlcuir.UseVisualStyleBackColor = true;
            this.btn_exlcuir.Click += new System.EventHandler(this.btn_exlcuir_Click);
            // 
            // lv_clientes
            // 
            resources.ApplyResources(this.lv_clientes, "lv_clientes");
            this.lv_clientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome_Fantasia});
            this.lv_clientes.FullRowSelect = true;
            this.lv_clientes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_clientes.Name = "lv_clientes";
            this.lv_clientes.UseCompatibleStateImageBehavior = false;
            this.lv_clientes.View = System.Windows.Forms.View.Details;
            // 
            // Nome_Fantasia
            // 
            resources.ApplyResources(this.Nome_Fantasia, "Nome_Fantasia");
            // 
            // Form_Geral
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Geral";
            this.Load += new System.EventHandler(this.Form_Geral_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_funcionarios;
        private System.Windows.Forms.ColumnHeader funcionario_nome;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Cargo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_cargo;
        private System.Windows.Forms.TextBox tb_admissao;
        private System.Windows.Forms.TextBox tb_administrador;
        private System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.Label txt_cargo;
        private System.Windows.Forms.Label txt_admissao;
        private System.Windows.Forms.Label txt_adminisatrador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_clientes;
        private System.Windows.Forms.ColumnHeader Nome_Fantasia;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_exlcuir;
        private System.Windows.Forms.ToolStripMenuItem visualizarClientesToolStripMenuItem;
    }
}