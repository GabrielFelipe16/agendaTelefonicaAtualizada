namespace projetoAgendaSolo.View
{
    partial class frm_alterar_categoria
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
            btn_excluir = new Button();
            btn_alterar = new Button();
            txt_campo_categoria = new TextBox();
            dgv_categoria = new DataGridView();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categoria).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_excluir);
            groupBox1.Controls.Add(btn_alterar);
            groupBox1.Controls.Add(txt_campo_categoria);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.Location = new Point(12, 92);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(294, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar Categoria";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btn_excluir
            // 
            btn_excluir.BackColor = Color.FromArgb(255, 128, 128);
            btn_excluir.Font = new Font("Segoe UI", 12F);
            btn_excluir.Location = new Point(4, 129);
            btn_excluir.Margin = new Padding(3, 2, 3, 2);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(284, 27);
            btn_excluir.TabIndex = 3;
            btn_excluir.Text = "&Excluir";
            btn_excluir.UseVisualStyleBackColor = false;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.BackColor = Color.FromArgb(128, 255, 128);
            btn_alterar.Font = new Font("Segoe UI", 12F);
            btn_alterar.Location = new Point(4, 98);
            btn_alterar.Margin = new Padding(3, 2, 3, 2);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(284, 27);
            btn_alterar.TabIndex = 2;
            btn_alterar.Text = "&Alterar";
            btn_alterar.UseVisualStyleBackColor = false;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // txt_campo_categoria
            // 
            txt_campo_categoria.Location = new Point(4, 50);
            txt_campo_categoria.Margin = new Padding(3, 2, 3, 2);
            txt_campo_categoria.Multiline = true;
            txt_campo_categoria.Name = "txt_campo_categoria";
            txt_campo_categoria.PlaceholderText = "Nome";
            txt_campo_categoria.Size = new Size(284, 44);
            txt_campo_categoria.TabIndex = 0;
            // 
            // dgv_categoria
            // 
            dgv_categoria.AllowUserToAddRows = false;
            dgv_categoria.AllowUserToDeleteRows = false;
            dgv_categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categoria.Location = new Point(329, 40);
            dgv_categoria.Margin = new Padding(3, 2, 3, 2);
            dgv_categoria.Name = "dgv_categoria";
            dgv_categoria.ReadOnly = true;
            dgv_categoria.RowHeadersWidth = 51;
            dgv_categoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_categoria.Size = new Size(360, 312);
            dgv_categoria.TabIndex = 1;
            dgv_categoria.CellContentClick += dgv_usuario_CellContentClick;
            dgv_categoria.SelectionChanged += dgv_usuario_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem, voltarToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(104, 22);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(104, 22);
            voltarToolStripMenuItem.Text = "&Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // frm_alterar_categoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(700, 362);
            Controls.Add(dgv_categoria);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_alterar_categoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Telefônica: Alterar Cadastro";
            FormClosed += frm_alterar_cadastro_FormClosed;
            Load += frm_alterar_cadastro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categoria).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_alterar;
        private TextBox txt_campo_categoria;
        private DataGridView dgv_categoria;
        private Button btn_excluir;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem voltarToolStripMenuItem;
    }
}