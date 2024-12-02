using projetoAgendaSolo.Controller;
using projetoAgendaSolo.View;

namespace projetoAgendaSolo
{
    public partial class frm_login : Form
    {
        private void verificaLoginValido()
        {
            //criando uma variavel booleana que faz as verificações de campos obrigatórios 
            bool casoBotaoValido = txt_campo_usuario.Text != ""
               && txt_campo_senha.Text.Length >= 8;

            //verificando se a variavel criada acima retorna true or false
            if (casoBotaoValido)
            {
                btn_entrar.Enabled = true;
            }
            else
            {
                btn_entrar.Enabled = false;
            }
        }

        private void logar()
        {
            UsuarioController loginUsuario = new UsuarioController();

            bool resultado = loginUsuario.ValidaLogin(txt_campo_usuario.Text, txt_campo_senha.Text);
            if (resultado)
            {
                resetaBorda();
                DialogResult mensagemEfetuado = MessageBox.Show("Login efetuado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (mensagemEfetuado == DialogResult.OK)
                {
                    frm_menu janela_menu = new frm_menu();
                    this.Hide();
                    janela_menu.ShowDialog();
                }
            }
            else
            {
                resetaBorda();

                panelUsuario.BorderStyle = BorderStyle.FixedSingle;
                panelSenha.BorderStyle = BorderStyle.FixedSingle;
                panelSenha.BackColor = Color.Red;
                panelUsuario.BackColor = Color.Red;


                MessageBox.Show("Usuário ou senha incorretos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void resetaBorda()
        {
            panelUsuario.BackColor = Color.FromArgb(128, 128, 255);
            panelSenha.BackColor = Color.FromArgb(128, 128, 255);
        }

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbl_link_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_cadastro janela_cadastro = new frm_cadastro();
            this.Hide();
            janela_cadastro.ShowDialog();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void txt_campo_usuario_TextChanged(object sender, EventArgs e)
        {
            panelUsuario.BackColor = Color.FromArgb(128, 128, 255);
            verificaLoginValido();
        }

        private void txt_campo_senha_TextChanged(object sender, EventArgs e)
        {
            panelSenha.BackColor = Color.FromArgb(128, 128, 255);
            verificaLoginValido();
        }

        private void txt_campo_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logar();
            }
        }
    }
}
