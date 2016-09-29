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
    public partial class Form_Geral : Form
    {
        public Form_Geral()
        {
            InitializeComponent();
        }

        private void Form_Geral_Load(object sender, EventArgs e)
        {

            try
            {

                using (SQLiteConnection c = new SQLiteConnection("Data Source=db_app.db;Version=3;"))
                {
                    c.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(
    "SELECT nome,cargo,admissao,administrador,id FROM funcionarios", c))
                    {

                        DataTable table = new DataTable();
                        da.Fill(table);
                        lv_funcionarios.View = View.Details;
                        ListViewItem iItem;

                        lv_funcionarios.Items.Clear();

                        foreach (DataRow row in table.Rows)
                        {
                            iItem = new ListViewItem();
                            for (int i = 0; i < row.ItemArray.Length; i++)
                            {
                                if (i == 0)
                                    iItem.Text = row.ItemArray[i].ToString();
                                else
                                    iItem.SubItems.Add(row.ItemArray[i].ToString());
                            }
                            lv_funcionarios.Items.Add(iItem);
                        }

                    }
                    c.Close();
                }
                
                
            }
            catch(Exception ex)
            { MessageBox.Show(ex.ToString(), "Tela Principal", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void lv_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_funcionarios.SelectedItems.Count == 0) return;
            tb_nome.Text = lv_funcionarios.SelectedItems[0].SubItems[0].Text;
            tb_cargo.Text = lv_funcionarios.SelectedItems[0].SubItems[1].Text;

            if (lv_funcionarios.SelectedItems[0].SubItems[2].Text == "True")
                tb_admissao.Text = "Sim";
            else
                tb_admissao.Text = "Não";

            if (lv_funcionarios.SelectedItems[0].SubItems[3].Text == "True")
                tb_administrador.Text = "Sim";
            else
                tb_administrador.Text = "Não";

            lv_clientes.Items.Clear();

            try
            {

                using (SQLiteConnection c = new SQLiteConnection("Data Source=db_app.db;Version=3;"))
                {
                    c.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(
    $"SELECT nome_fantasia FROM clientes WHERE representante = '{lv_funcionarios.SelectedItems[0].SubItems[4].Text}'", c))
                    {
                        DataTable table = new DataTable();
                        da.Fill(table);
                        lv_funcionarios.View = View.Details;
                        ListViewItem iItem;

                        foreach (DataRow row in table.Rows)
                        {
                            iItem = new ListViewItem();
                            for (int i = 0; i < row.ItemArray.Length; i++)
                            {
                                if (i == 0)
                                    iItem.Text = row.ItemArray[i].ToString();
                                else
                                    iItem.SubItems.Add(row.ItemArray[i].ToString());
                            }
                            lv_clientes.Items.Add(iItem);
                        }
                    }
                    c.Close();
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString(), "Tela Principal", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cadastro_funcionario Form_cd_funcionarios = new Form_cadastro_funcionario(-1);
            Form_cd_funcionarios.ShowDialog();

            Form_Geral_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_cadastro_funcionario Form_cd_funcionario = new Form_cadastro_funcionario(-1);
            Form_cd_funcionario.ShowDialog();
            Form_Geral_Load(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lv_funcionarios.SelectedItems.Count < 1)
            {
                MessageBox.Show("Escolha um funcionário primeiro!", "Tela Geral", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            int id;

            id = Int32.Parse(lv_funcionarios.SelectedItems[0].SubItems[4].Text);
            
            Form_cadastro_funcionario Form_cd_funcionario = new Form_cadastro_funcionario(id);
            Form_cd_funcionario.ShowDialog();
            Form_Geral_Load(sender, e);
        }

        private void btn_exlcuir_Click(object sender, EventArgs e)
        {
            if (lv_funcionarios.SelectedItems.Count < 1)
            {
                MessageBox.Show("Escolha um funcionário primeiro!", "Tela Geral", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir esse funcionário?", "Tela Geral", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resposta == DialogResult.Yes)
            {
                int id;

                id = Int32.Parse(lv_funcionarios.SelectedItems[0].SubItems[4].Text);


                try
                {
                    using (SQLiteConnection c = new SQLiteConnection("Data Source=db_app.db;Version=3;"))
                    {
                        c.Open();
                        using (SQLiteCommand sql_cmd = new SQLiteCommand(
        $"DELETE FROM funcionarios WHERE id = '{id}'", c))
                        {
                            sql_cmd.ExecuteNonQuery();
                            tb_administrador.Text = "";
                            tb_admissao.Text = "";
                            tb_cargo.Text = "";
                            tb_nome.Text = "";
                            lv_clientes.Items.Clear();
                        }

                        using (SQLiteCommand sql_cmd = new SQLiteCommand(
        $"UPDATE clientes SET representante = null WHERE representante = '{id}'", c))
                        {
                            sql_cmd.ExecuteNonQuery();
                        }


                    }

                }
                catch(Exception ex)
                { MessageBox.Show(ex.ToString(), "Tela Principal", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                MessageBox.Show("Funcionário exlcuido com sucesso!", "Tela Geral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form_Geral_Load(sender,e);

            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cadastro_cliente Form = new Form_cadastro_cliente(-1);
            Form.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sobre Form = new Form_Sobre();
            Form.ShowDialog();
        }

        private void visualizarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_clientes Form = new Form_clientes();
            Form.ShowDialog();
        }
    }
}
