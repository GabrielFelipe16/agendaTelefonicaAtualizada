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
    public partial class frm_cadastro : Form
    {
        private void verificaCadastroValido()
        {
            //criando uma variavel booleana que faz as verificações de campos obrigatórios 
            bool casoBotaoValido = txt_campo_nome.Text != ""
               && txt_campo_usuario.Text != ""
               && txt_campo_senha.Text.Length >= 8
               && txt_campo_confirma_senha.Text == txt_campo_senha.Text;

            //verificando se a variavel criada acima retorna true or false
            if (casoBotaoValido)
            {
                btn_cadastrar.Enabled = true;
            }
            else
            {
                btn_cadastrar.Enabled = false;
            }
        }

        public frm_cadastro()
        {
            InitializeComponent();
        }

        private void frm_cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            UsuarioController addUsuario = new UsuarioController();

            bool resultado = addUsuario.AddUsuario(txt_campo_nome.Text, txt_campo_usuario.Text, txt_campo_telefone.Text, txt_campo_senha.Text);
            if (resultado)
            {
                DialogResult mensagemEfetuado = MessageBox.Show("Cadastro efetuado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(mensagemEfetuado == DialogResult.OK)
                {
                    frm_menu janela_menu = new frm_menu();
                    this.Hide();
                    janela_menu.ShowDialog();
                }
            }
        }

        private void txt_campo_nome_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void txt_campo_usuario_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void txt_campo_telefone_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void txt_campo_senha_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void txt_campo_confirma_senha_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
