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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login janela_login = new frm_login();
            this.Hide();
            janela_login.ShowDialog();
        }

        private void frm_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastro_categoria janela_cadastro_categoria = new frm_cadastro_categoria();
            this.Hide();
            janela_cadastro_categoria.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_alterar_cadastro janela_alterar_cadastro = new frm_alterar_cadastro();
            this.Hide();
            janela_alterar_cadastro.ShowDialog();
        }
    }
}
