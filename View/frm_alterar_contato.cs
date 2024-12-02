using projetoAgendaSolo.Controller;
using projetoAgendaSolo.VariableGlobal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace projetoAgendaSolo.View
{
    public partial class frm_alterar_contato : Form
    {

        private void verificaCadastroValido()
        {
            //criando uma variavel booleana que faz as verificações de campos obrigatórios 
            bool casoBotaoValido = txt_campo_nome.Text != "" && mtb_telefone.MaskFull && txt_campo_categoria.Text != "";

            //verificando se a variavel criada acima retorna true or false
            if (casoBotaoValido)
            {
                btn_concluir.Enabled = true;
            }
            else
            {
                btn_concluir.Enabled = false;
            }
        }

        private void alterarContato()
        {
            DialogResult resultado = MessageBox.Show(
                    "Você confirma as informações alteradas?",
                    "Alterar Contato",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                AgendaController alterContato = new AgendaController();

                string telefoneFormatado = mtb_telefone.Text;

                bool verificaAlteracao = alterContato.AlterContato(Convert.ToInt32(informationsAlterContato.cod_contato), txt_campo_nome.Text, telefoneFormatado, txt_campo_categoria.Text);

                if (verificaAlteracao)
                {
                    DialogResult mensagemEfetuado = MessageBox.Show("Alteração efetuada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (mensagemEfetuado == DialogResult.OK)
                    {
                        frm_agenda janela_agenda = new frm_agenda();
                        this.Hide();
                        janela_agenda.ShowDialog();
                    }
                }

            }
            else
            {
                MessageBox.Show("ALTERAÇÂO CANCELADA");
                carregarInformacoes();
            }
        }

        public void carregarInformacoes()
        {
            txt_campo_nome.Text = informationsAlterContato.nome;
            mtb_telefone.Text = informationsAlterContato.telefone;
            txt_campo_categoria.Text = informationsAlterContato.categoria;
        }


        public frm_alterar_contato()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            frm_agenda janela_agenda = new frm_agenda();
            this.Hide();
            janela_agenda.ShowDialog();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            alterarContato();
        }

        private void frm_alterar_contato_Load(object sender, EventArgs e)
        {
            carregarInformacoes();
        }

        private void frm_alterar_contato_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txt_campo_nome_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void mtb_telefone_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void txt_campo_categoria_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void btn_concluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                alterarContato();
            }
        }
    }
}
