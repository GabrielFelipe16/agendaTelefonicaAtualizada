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
        public frm_cadastrar_contato_agenda()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            AgendaController addContato = new AgendaController();

            bool resultado = addContato.addContato(txt_campo_nome.Text, txt_campo_telefone.Text, txt_campo_categoria.Text);
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            frm_agenda janela_agenda = new frm_agenda();
            this.Hide();
            janela_agenda.ShowDialog();
        }
    }
}
