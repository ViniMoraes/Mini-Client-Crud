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
using Apresentação_DevCoffee.Properties;

namespace Apresentação_DevCoffee
{
    public partial class Form_Inicio : Form
    {
        public Form_Inicio()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {

            try
            {
                bool logar = false;

                using (SQLiteConnection c = new SQLiteConnection("Data Source=db_app.db;Version=3;"))
                {
                    c.Open();
                    using (SQLiteCommand sql_cmd = new SQLiteCommand(
    "SELECT * FROM users WHERE usuario ='" + tb_user.Text + "' and senha ='" + tb_pass.Text + "'", c))
                    {
                        if (sql_cmd.ExecuteReader().HasRows)
                        {

                            // Lembrar usuario
                            if (cb_forgotpass.Checked == true)
                                Settings.Default["Ultimo_Usuario"] = tb_user.Text;
                            else
                                Settings.Default["Ultimo_Usuario"] = "";

                            Settings.Default.Save();

                            logar = true;

                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos!", "Tela de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        sql_cmd.Dispose();
                    }
                }

                if (logar)
                {

                    MessageBox.Show("Logado com sucesso!!!", "Tela de login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Geral Form_Geral = new Form_Geral();

                    // Comando para fechar o form de login

                    this.Hide();
                    Form_Geral.ShowDialog();
                    this.Close();
                }

            }

            catch (Exception ex)
            { MessageBox.Show(ex.ToString(), "Tela de login", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btn_forgotpass_Click(object sender, EventArgs e)
        {
            if (tb_user.Text == "")
            {
                MessageBox.Show("Primeiro digite um login!", "Tela de login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tb_user.Focus();
                return;
            }

            SQLiteConnection sql_conn = new SQLiteConnection(
    "Data Source=db_app.db;Version=3;");

            SQLiteCommand sql_cmd = new SQLiteCommand(
                "SELECT lembrete FROM users WHERE usuario = '" + tb_user.Text + "'", sql_conn);

            try
            {
                sql_conn.Open();

                string lembrete = (string)sql_cmd.ExecuteScalar();

                if (lembrete == null)
                {
                    MessageBox.Show("Esse usuário não possui lembrete de senha!", "Tela de login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"O lembrete de senha do usuário: '{tb_user.Text}' é '{lembrete}'", "Tela de login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


            catch (Exception ex)
            { MessageBox.Show(ex.ToString(), "Tela de login", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            { sql_conn.Close(); }
        }

        private void Form_inicio_Load(object sender, EventArgs e)
        {
            if (Settings.Default.Ultimo_Usuario != "")
            {
                tb_user.Text = Settings.Default["Ultimo_Usuario"].ToString();
                cb_forgotpass.Checked = true;
                tb_pass.Focus();
                tb_pass.TabIndex = 1;
                tb_user.TabStop = false;
            }
            this.AcceptButton = btn_connect;
        }

        private Button btn_connect;
        private Button btn_forgotpass;
        private Label txt_user;
        private Label txt_pass;
        private TextBox tb_user;
        private TextBox tb_pass;
        private CheckBox cb_forgotpass;


        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_connect_Click_1(object sender, EventArgs e)
        {

        }

        private void Form_Inicio_Load_1(object sender, EventArgs e)
        {

        }
    }
}
