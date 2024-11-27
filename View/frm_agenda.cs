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
using System.Windows.Forms;

namespace projetoAgendaSolo.View
{
    public partial class frm_agenda : Form
    {
        private void AtualizaDataGrid()
        {
            AgendaController pegaAgenda = new AgendaController();

            DataTable tabela = pegaAgenda.getAgenda();

            dgv_agenda.DataSource = tabela;
        }

        public frm_agenda()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_novo_Click(object sender, EventArgs e)
        {
            frm_cadastrar_contato_agenda janela_cadastrar_contato = new frm_cadastrar_contato_agenda();
            this.Hide();
            janela_cadastrar_contato.ShowDialog();
        }

        private void frm_agenda_Load(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void btn_excluir_cadastro_Click(object sender, EventArgs e)
        {
            AgendaController deleteAgenda = new AgendaController();

            if (dgv_agenda.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione uma linha primeiro");
            }
            else
            {
                int cadastro = Convert.ToInt32(dgv_agenda.SelectedRows[0].Cells["Código"].Value);
                bool resultado = deleteAgenda.deleteAgenda(cadastro);

                if (resultado == false)
                {
                    MessageBox.Show("Falhou");
                }
            }
            AtualizaDataGrid();
        }

        private void btn_alterar_cadastro_Click(object sender, EventArgs e)
        {

            frm_alterar_contato janela_alterar_contato = new frm_alterar_contato();
            this.Hide();
            janela_alterar_contato.ShowDialog();

        }

        private void dgv_agenda_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_agenda.SelectedRows.Count > 0)
            {
                informationsAlterContato.nome = Convert.ToString(dgv_agenda.SelectedRows[0].Cells["Nome"].Value);
                informationsAlterContato.telefone = Convert.ToString(dgv_agenda.SelectedRows[0].Cells["Telefone"].Value);
                informationsAlterContato.categoria = Convert.ToString(dgv_agenda.SelectedRows[0].Cells["Categoria"].Value);
                informationsAlterContato.cod_contato = Convert.ToInt32(dgv_agenda.SelectedRows[0].Cells["Código"].Value);
            }
        }

        private void frm_agenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_menu janela_menu = new frm_menu();
            this.Hide();
            janela_menu.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login janela_login = new frm_login();
            this.Hide();
            janela_login.ShowDialog();
        }
    }
}
