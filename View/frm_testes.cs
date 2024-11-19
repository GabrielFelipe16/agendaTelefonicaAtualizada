using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetoAgendaSolo.Controller;
using projetoAgendaSolo.VariableGlobal;

namespace projetoAgendaSolo.View
{
    public partial class frm_testes : Form
    {
        public frm_testes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserSession.usuario = textBox1.Text;
            UserSession.nome = textBox2.Text;
            UserSession.senha = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.usuario);
            MessageBox.Show(UserSession.nome);
            MessageBox.Show(UserSession.senha);
        }

        private void frm_testes_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
