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
    public partial class frm_cadastro_categoria : Form
    {
        private void AtualizaDataGrid()
        {
            CategoriaController getCategorias = new CategoriaController();

            DataTable tabela = getCategorias.GetCategorias();

            dgv_Categoria.DataSource = tabela;
        }

        public frm_cadastro_categoria()
        {
            InitializeComponent();
        }

        private void frm_cadastro_categoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login janela_login = new frm_login();
            this.Hide();
            janela_login.ShowDialog();
        }

        private void frm_cadastro_categoria_Load(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CategoriaController cadastroCategoria = new CategoriaController();

            bool resultado = cadastroCategoria.AddCategoria(txt_categoria.Text);

            if (resultado == false)
            {
                DialogResult mensagemErro = MessageBox.Show("Erro ao cadastrar a categoria", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AtualizaDataGrid();

            txt_categoria.Text = "";
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            CategoriaController deleteCategoria = new CategoriaController();

            int categorias = Convert.ToInt32(dgv_Categoria.SelectedRows[0].Cells["Código"].Value);

            bool resultado = deleteCategoria.DropCategoria(categorias);

            if (resultado == false)
            {
                MessageBox.Show("Falhou");
            }

            AtualizaDataGrid();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_menu janela_menu = new frm_menu();
            this.Hide();
            janela_menu.ShowDialog();
        }
    }
}
