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
    public partial class frm_alterar_categoria : Form
    {
        private void AtualizaDataGrid()
        {
            CategoriaController getCategorias = new CategoriaController();

            DataTable tabela = getCategorias.GetCategorias();

            dgv_categoria.DataSource = tabela;
        }

        public frm_alterar_categoria()
        {
            InitializeComponent();
        }

        private void frm_alterar_cadastro_Load(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void frm_alterar_cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            CategoriaController updateCategoria = new CategoriaController();
            if(txt_campo_categoria.Text.Length <= 0)
            {
                MessageBox.Show("Preencha o campo (Alterar categoria)");
            }
            if (dgv_categoria.SelectedCells.Count <= 0){
                MessageBox.Show("Selecione uma categoria ara ser alterada");
            }
            else
            {
                int categoriaId = Convert.ToInt32(dgv_categoria.SelectedRows[0].Cells["Código"].Value);

                bool resultado = updateCategoria.AlterCategoria(categoriaId, txt_campo_categoria.Text);

                if (resultado)
                {
                    MessageBox.Show("Categoria alterada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro");
                }
            }

            

            AtualizaDataGrid();
        }

        private void dgv_usuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_categoria.SelectedRows.Count > 0)
            {
                string categoria = Convert.ToString(dgv_categoria.SelectedRows[0].Cells["Categoria"].Value);

                txt_campo_categoria.Text = categoria;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login janela_login = new frm_login();
            this.Hide();
            janela_login.ShowDialog();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_menu janela_menu = new frm_menu();
            this.Hide();
            janela_menu.ShowDialog();
        }

        private void dgv_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
