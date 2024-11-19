using projetoAgendaSolo.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoAgendaSolo.View
{
    public partial class frm_alterar_cadastro : Form
    {
        private void AtualizaDataGrid()
        {
            UsuarioController usuarioController = new UsuarioController();

            DataTable tabela = usuarioController.GetUsuario();

            dgv_usuario.DataSource = tabela;
        }

        public frm_alterar_cadastro()
        {
            InitializeComponent();
        }

        private void frm_alterar_cadastro_Load(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void frm_alterar_cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            UsuarioController updateCadastro = new UsuarioController();

            int usuarioId = Convert.ToInt32(dgv_usuario.SelectedRows[0].Cells["Código"].Value);

            bool resultado = updateCadastro.AlterUser(usuarioId, txt_campo_nome.Text, txt_campo_usuario.Text, txt_campo_telefone.Text, txt_campo_senha.Text);

            if (resultado)
            {
                MessageBox.Show("Cadastro alterado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro");
            }

            AtualizaDataGrid();
        }

        private void dgv_usuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_usuario.SelectedRows.Count > 0)
            {
                string nome = Convert.ToString(dgv_usuario.SelectedRows[0].Cells["Nome"].Value);
                string usuario = Convert.ToString(dgv_usuario.SelectedRows[0].Cells["Usuário"].Value);
                string telefone = Convert.ToString(dgv_usuario.SelectedRows[0].Cells["Telefône"].Value);

                txt_campo_nome.Text = nome;
                txt_campo_usuario.Text = usuario;
                txt_campo_telefone.Text = telefone;
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            UsuarioController deleteUsuario = new UsuarioController();

            int usuario = Convert.ToInt32(dgv_usuario.SelectedRows[0].Cells["Código"].Value);

            bool resultado = deleteUsuario.DropUser(usuario);

            if (resultado == false)
            {
                MessageBox.Show("Falhou");
            }

            AtualizaDataGrid();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login janela_login = new frm_login();
            this.Hide();
            janela_login.ShowDialog();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_menu janela_menu = new frm_menu();
            this.Hide();
            janela_menu.ShowDialog();
        }
    }
}
