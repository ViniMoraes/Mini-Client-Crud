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
    public partial class Form_clientes : Form
    {
        public Form_clientes()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_clientes_Load(object sender, EventArgs e)
        {
            try
            {

                using (SQLiteConnection c = new SQLiteConnection("Data Source=db_app.db;Version=3;"))
                {
                    c.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(
    "SELECT nome_fantasia,razao_social,contato,representante,id FROM clientes", c))
                    {

                        DataTable table = new DataTable();
                        da.Fill(table);
                        lv_clientes.View = View.Details;
                        ListViewItem iItem;

                        lv_clientes.Items.Clear();

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
            { MessageBox.Show(ex.ToString(), "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void lv_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_clientes.SelectedItems.Count == 0) return;
            tb_razao_social.Text = lv_clientes.SelectedItems[0].SubItems[1].Text;
            tb_nome_fantasia.Text = lv_clientes.SelectedItems[0].SubItems[0].Text;
            tb_contato.Text = lv_clientes.SelectedItems[0].SubItems[2].Text;

            if (lv_clientes.SelectedItems[0].SubItems[3].Text == "")
            {
                tb_representante_atual.Text = "";
            }
            else

            {

                try
                {

                    using (SQLiteConnection c = new SQLiteConnection("Data Source=db_app.db;Version=3;"))
                    {
                        c.Open();
                        using (SQLiteCommand sql_cmd = new SQLiteCommand(
        $"SELECT nome FROM funcionarios WHERE id = '{lv_clientes.SelectedItems[0].SubItems[3].Text}'", c))
                        {
                            tb_representante_atual.Text = sql_cmd.ExecuteScalar().ToString();
                        }
                        c.Close();
                    }

                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString(), "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lv_clientes.SelectedItems.Count < 1)
            {
                MessageBox.Show("Escolha um cliente primeiro!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir esse cliente?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resposta == DialogResult.Yes)
            {
                int id;

                id = Int32.Parse(lv_clientes.SelectedItems[0].SubItems[4].Text);


                try
                {
                    using (SQLiteConnection c = new SQLiteConnection("Data Source=db_app.db;Version=3;"))
                    {
                        c.Open();
                        using (SQLiteCommand sql_cmd = new SQLiteCommand(
        $"DELETE FROM clientes WHERE id = '{id}'", c))
                        {
                            sql_cmd.ExecuteNonQuery();

                            tb_contato.Text = "";
                            tb_nome_fantasia.Text = "";
                            tb_razao_social.Text = "";
                            tb_representante_atual.Text = "";
                        }

                    }

                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString(), "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                MessageBox.Show("Cliente exlcuido com sucesso!", "Tela Geral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form_clientes_Load(sender, e);

            }
            }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (lv_clientes.SelectedItems.Count < 1)
            {
                MessageBox.Show("Escolha um cliente primeiro!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            int id;

            id = Int32.Parse(lv_clientes.SelectedItems[0].SubItems[4].Text);

            Form_cadastro_cliente Form = new Form_cadastro_cliente(id);
            Form.ShowDialog();
            Form_clientes_Load(sender,e);
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_cadastro_cliente Form = new Form_cadastro_cliente(-1);
            Form.ShowDialog();
            Form_clientes_Load(sender, e);
        }
    }
}
