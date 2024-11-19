namespace projetoAgendaSolo.View
{
    partial class frm_alterar_cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txt_campo_senha = new TextBox();
            btn_excluir = new Button();
            btn_alterar = new Button();
            txt_campo_telefone = new TextBox();
            txt_campo_usuario = new TextBox();
            txt_campo_nome = new TextBox();
            dgv_usuario = new DataGridView();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_usuario).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_campo_senha);
            groupBox1.Controls.Add(btn_excluir);
            groupBox1.Controls.Add(btn_alterar);
            groupBox1.Controls.Add(txt_campo_telefone);
            groupBox1.Controls.Add(txt_campo_usuario);
            groupBox1.Controls.Add(txt_campo_nome);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 416);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar Cadastro";
            // 
            // txt_campo_senha
            // 
            txt_campo_senha.Location = new Point(6, 244);
            txt_campo_senha.Multiline = true;
            txt_campo_senha.Name = "txt_campo_senha";
            txt_campo_senha.PasswordChar = '*';
            txt_campo_senha.PlaceholderText = "Senha";
            txt_campo_senha.Size = new Size(324, 57);
            txt_campo_senha.TabIndex = 2;
            // 
            // btn_excluir
            // 
            btn_excluir.BackColor = Color.FromArgb(255, 128, 128);
            btn_excluir.Font = new Font("Segoe UI", 12F);
            btn_excluir.Location = new Point(6, 374);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(324, 36);
            btn_excluir.TabIndex = 3;
            btn_excluir.Text = "&Excluir";
            btn_excluir.UseVisualStyleBackColor = false;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.BackColor = Color.FromArgb(128, 255, 128);
            btn_alterar.Font = new Font("Segoe UI", 12F);
            btn_alterar.Location = new Point(6, 332);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(324, 36);
            btn_alterar.TabIndex = 2;
            btn_alterar.Text = "&Alterar";
            btn_alterar.UseVisualStyleBackColor = false;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // txt_campo_telefone
            // 
            txt_campo_telefone.Location = new Point(6, 181);
            txt_campo_telefone.Multiline = true;
            txt_campo_telefone.Name = "txt_campo_telefone";
            txt_campo_telefone.PlaceholderText = "Telefone";
            txt_campo_telefone.Size = new Size(324, 57);
            txt_campo_telefone.TabIndex = 2;
            // 
            // txt_campo_usuario
            // 
            txt_campo_usuario.Location = new Point(6, 118);
            txt_campo_usuario.Multiline = true;
            txt_campo_usuario.Name = "txt_campo_usuario";
            txt_campo_usuario.PlaceholderText = "Usuário";
            txt_campo_usuario.Size = new Size(324, 57);
            txt_campo_usuario.TabIndex = 1;
            // 
            // txt_campo_nome
            // 
            txt_campo_nome.Location = new Point(6, 55);
            txt_campo_nome.Multiline = true;
            txt_campo_nome.Name = "txt_campo_nome";
            txt_campo_nome.PlaceholderText = "Nome";
            txt_campo_nome.Size = new Size(324, 57);
            txt_campo_nome.TabIndex = 0;
            // 
            // dgv_usuario
            // 
            dgv_usuario.AllowUserToAddRows = false;
            dgv_usuario.AllowUserToDeleteRows = false;
            dgv_usuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_usuario.Location = new Point(376, 54);
            dgv_usuario.Name = "dgv_usuario";
            dgv_usuario.ReadOnly = true;
            dgv_usuario.RowHeadersWidth = 51;
            dgv_usuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_usuario.Size = new Size(412, 416);
            dgv_usuario.TabIndex = 1;
            dgv_usuario.SelectionChanged += dgv_usuario_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem, voltarToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(75, 24);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(131, 26);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(131, 26);
            voltarToolStripMenuItem.Text = "&Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // frm_alterar_cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 482);
            Controls.Add(dgv_usuario);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_alterar_cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Telefônica: Alterar Cadastro";
            FormClosed += frm_alterar_cadastro_FormClosed;
            Load += frm_alterar_cadastro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_usuario).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_alterar;
        private TextBox txt_campo_telefone;
        private TextBox txt_campo_usuario;
        private TextBox txt_campo_nome;
        private DataGridView dgv_usuario;
        private Button btn_excluir;
        private TextBox txt_campo_senha;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem voltarToolStripMenuItem;
    }
}