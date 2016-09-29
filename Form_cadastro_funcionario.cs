using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Apresentação_DevCoffee
{
    public partial class Form_cadastro_funcionario : Form
    {

        private int id = -1;

        public Form_cadastro_funcionario(int v_id)
        {
            InitializeComponent();
            id = v_id;
        }


        private void Form_cadastro_funcionario_Load(object sender, EventArgs e)
        {      

            cb_administrador.Items.Add("Não");
            cb_administrador.Items.Add("Sim");          
            cb_admissao.Items.Add("Não");
            cb_admissao.Items.Add("Sim");

            cb_administrador.SelectedIndex = 0;
            cb_admissao.SelectedIndex = 0;

            if (id >= 0)
            {
                SQLiteConnection sql_conn = new SQLiteConnection(
    "Data Source=db_app.db;Version=3;");

                SQLiteCommand sql_cmd = new SQLiteCommand(
 $"SELECT nome,cargo,admissao,administrador FROM funcionarios WHERE id = '{id}'", sql_conn);

                try
                {
                    sql_conn.Open();

                    using (var reader = sql_cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool admissao, administrador;

                            tb_nome.Text = reader.GetString(reader.GetOrdinal("nome"));
                            tb_cargo.Text = reader.GetString(reader.GetOrdinal("cargo"));
                            admissao = reader.GetBoolean(reader.GetOrdinal("admissao"));
                            administrador = reader.GetBoolean(reader.GetOrdinal("administrador"));

                            if (administrador)
                                cb_administrador.SelectedIndex = 1;
                            if (admissao)
                                cb_admissao.SelectedIndex = 1;

                        }
                    }

                }
                catch(Exception ex)
                { MessageBox.Show(ex.ToString(), "Cadastro de funcionários", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally
                { sql_conn.Close(); }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text.Length < 3 || tb_cargo.Text.Length < 3)
            {
                MessageBox.Show("Você não inseriu as informações necessárias!","Cadastro de funcionários",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }


            SQLiteConnection sql_conn = new SQLiteConnection(
                "Data Source=db_app.db;Version=3;");

            int admissao,administrador;

            if (cb_administrador.SelectedIndex == 1)
                administrador = 1;
            else
                administrador = 0;

            if (cb_admissao.SelectedIndex == 1)
                admissao = 1;
            else
                admissao = 0;

            SQLiteCommand sql_cmd = new SQLiteCommand(
    $"INSERT INTO funcionarios(nome,cargo,admissao,administrador) VALUES('{tb_nome.Text}','{tb_cargo.Text}','{admissao}','{administrador}')", sql_conn);

            // Se o id for maior é edição
            if (id >= 0)
                sql_cmd.CommandText = $"UPDATE funcionarios SET nome = '{tb_nome.Text}', cargo = '{tb_cargo.Text}', admissao = '{admissao}',administrador = '{administrador}' WHERE id = '{id}'";

                try
            {
                sql_conn.Open();

                sql_cmd.ExecuteNonQuery();


                if (listView1.Items.Count > 0)
                {
                    int id_aux = id;
                    if (id < 0)
                    {
                        
                        sql_cmd.CommandText = "SELECT last_insert_rowid()";
                        id_aux = Int32.Parse(sql_cmd.ExecuteScalar().ToString());
                    }
                   
                    for (int i =0; i < listView1.Items.Count; i++)
                    {
                        int id_cliente;
                        id_cliente = Int32.Parse( listView1.Items[i].SubItems[1].Text);
                        sql_cmd.CommandText = $"UPDATE clientes SET representante = {id_aux} WHERE id = '{id_cliente}'";
                        sql_cmd.ExecuteNonQuery();
                    }
                    
                }

            }
            catch(Exception ex)
            { MessageBox.Show(ex.ToString(), "Cadastro de funcionários", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            { sql_conn.Close(); }

            if (id < 0)
            { 
            DialogResult resposta = MessageBox.Show("Funcionário Cadastrado com sucesso! Deseja cadastrar outro?", "Cadastro de funcionários", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resposta == DialogResult.Yes)
            {
                tb_nome.Text = "";
                tb_cargo.Text = "";
                cb_administrador.SelectedIndex = 0;
                cb_admissao.SelectedIndex = 0;
                listView1.Items.Clear();
                
                tb_nome.Focus();
            }
            else
                this.Close();
            }
            else
            {
                MessageBox.Show("Funcionário atualizado!", "Cadastro de funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void btn_add_cliente_Click(object sender, EventArgs e)
        {
            Form_add_cliente Form_add_cliente = new Form_add_cliente();
            Form_add_cliente.ShowDialog();

            int id;
            id = Form_add_cliente.id;

            if ( id > 0)
            {

                for (int i = 0; i < listView1.Items.Count; i++)
                    if (id == Int32.Parse(listView1.Items[i].SubItems[1].Text))
                        return;

                try
                {
                    using (SQLiteConnection sql_conn = new SQLiteConnection("Data Source=db_app.db;Version=3;"))
                    {
                        sql_conn.Open();
                        using (SQLiteCommand sql_cmd = new SQLiteCommand(
                            $"SELECT nome_fantasia FROM clientes WHERE id = '{id}'", sql_conn))
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = sql_cmd.ExecuteScalar().ToString();
                            item.SubItems.Add(id.ToString());
                            listView1.Items.Add(item);
                            
                        }
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString(), "Cadastro de funcionários", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
        }

        private void btn_exc_cliente_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selecione pelo menos um cliente!","Cadastro de funcionário",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return;
            }

            listView1.SelectedItems[0].Remove();
        }
    }
    }

