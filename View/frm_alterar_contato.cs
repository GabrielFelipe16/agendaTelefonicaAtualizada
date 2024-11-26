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
        public string nome = null;
        public string telefone = null;
        public string categoria = null;

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

        }

        private void frm_alterar_contato_Load(object sender, EventArgs e)
        {
            txt_campo_nome.Text = nome;
            txt_campo_telefone.Text = telefone;
            txt_campo_categoria.Text = categoria;
        }

        private void frm_alterar_contato_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
