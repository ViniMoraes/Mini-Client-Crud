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
    public partial class Form_add_cliente : Form
    {
        private int v_id = -1;

        public int id
        {
            get { return v_id; }
        }


        public Form_add_cliente()
        {
            InitializeComponent();
        }

        private void Form_add_cliente_Load(object sender, EventArgs e)
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
            { MessageBox.Show(ex.ToString(), "Tela Principal", MessageBoxButtons.OK, MessageBoxIcon.Error); }

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
            using (SQLiteConnection sql_conn = new SQLiteConnection("Data Source=db_app.db;Version=3;"))
            {
                sql_conn.Open();
                using (SQLiteCommand sql_cmd = new SQLiteCommand(
                    $"SELECT nome FROM funcionarios WHERE id = '{lv_clientes.SelectedItems[0].SubItems[3].Text}'", sql_conn))
                {
                    tb_representante_atual.Text = sql_cmd.ExecuteScalar().ToString();
                }
            }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.ToString(), "Tela Principal", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_cadastro_cliente Form_cadastro_cliente = new Form_cadastro_cliente(-1);
            Form_cadastro_cliente.ShowDialog();
            Form_add_cliente_Load(sender, e);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (lv_clientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um cliente!", "Seleção de clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (lv_clientes.SelectedItems[0].SubItems[3].Text != "")
            {
                DialogResult resposta = MessageBox.Show("Esse cliente já tem um representante ao selecioná-lo você trocará seu representante para o funcionário atual. Deseja prosseguir?", "Seleção de clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.No)
                    return;
            }

            v_id = Int32.Parse(lv_clientes.SelectedItems[0].SubItems[4].Text);
            this.Close();
        }
    }
}
