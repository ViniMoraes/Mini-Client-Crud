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
    public partial class Form_cadastro_cliente : Form
    {
        private int id = -1;

        public Form_cadastro_cliente(int v_id)
        {
            InitializeComponent();
            id = v_id;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (tb_contato.Text.Length < 3 || tb_nome_fantasia.Text.Length < 3)
            {
                MessageBox.Show("Você não inseriu as informações necessárias!", "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (SQLiteConnection sql_conn = new SQLiteConnection("Data Source=db_app.db;Version=3;"))
                {
                    sql_conn.Open();
                    using (SQLiteCommand sql_cmd = new SQLiteCommand(
        $"INSERT INTO clientes(razao_social,nome_fantasia,contato) VALUES('{tb_razao_social.Text}','{tb_nome_fantasia.Text}','{tb_contato.Text}')", sql_conn))
                    {
                        if (id >= 0)
                            sql_cmd.CommandText = $"UPDATE clientes SET razao_social = '{tb_razao_social.Text}',nome_fantasia = '{tb_nome_fantasia.Text}',contato = '{tb_contato.Text}' WHERE id = '{id}'";

                        sql_cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString(), "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            MessageBox.Show("Cliente cadastrado!", "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void Form_cadastro_cliente_Load(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                SQLiteConnection sql_conn = new SQLiteConnection(
    "Data Source=db_app.db;Version=3;");

                SQLiteCommand sql_cmd = new SQLiteCommand(
 $"SELECT razao_social,nome_fantasia,contato FROM clientes WHERE id = '{id}'", sql_conn);

                try
                {
                    sql_conn.Open();

                    using (var reader = sql_cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            tb_razao_social.Text = reader.GetString(reader.GetOrdinal("razao_social"));
                            tb_nome_fantasia.Text = reader.GetString(reader.GetOrdinal("nome_fantasia"));
                            tb_contato.Text = reader.GetString(reader.GetOrdinal("contato"));

                        }
                    }

                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString(), "Cadastro de funcionários", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally
                { sql_conn.Close(); }
            }
        }
    }
}
