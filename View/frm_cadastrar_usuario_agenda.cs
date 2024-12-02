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
    public partial class frm_cadastrar_contato_agenda : Form
    {

        private void verificaCadastroValido()
        {
            //criando uma variavel booleana que faz as verificações de campos obrigatórios 
            bool casoBotaoValido = txt_campo_nome.Text != "" && mtb_telefone.MaskFull && txt_campo_categoria.Text != "";

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

        private void cadastraContato()
        {
            AgendaController addContato = new AgendaController();

            string telefoneFormatado = mtb_telefone.Text;

            bool resultado = addContato.addContato(txt_campo_nome.Text, telefoneFormatado, txt_campo_categoria.Text);
            if (resultado)
            {
                DialogResult mensagemEfetuado = MessageBox.Show("Cadastro efetuado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (mensagemEfetuado == DialogResult.OK)
                {
                    frm_agenda janela_agenda = new frm_agenda();
                    this.Hide();
                    janela_agenda.ShowDialog();
                }
            }
        }

        public frm_cadastrar_contato_agenda()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            cadastraContato();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            frm_agenda janela_agenda = new frm_agenda();
            this.Hide();
            janela_agenda.ShowDialog();
        }

        private void txt_campo_nome_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void txt_campo_categoria_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void mtb_telefone_TextChanged(object sender, EventArgs e)
        {
            verificaCadastroValido();
        }

        private void txt_campo_categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cadastraContato();
            }
        }
    }
}
