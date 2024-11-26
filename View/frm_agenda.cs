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

        }

        private void dgv_agenda_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_agenda.SelectedRows.Count > 0)
            {
                string nome = Convert.ToString(dgv_agenda.SelectedRows[0].Cells["Nome"].Value);
                string telefone = Convert.ToString(dgv_agenda.SelectedRows[0].Cells["Telefone"].Value);
                string categoria = Convert.ToString(dgv_agenda.SelectedRows[0].Cells["Categoria"].Value);

                
            }
        }
    }
}
