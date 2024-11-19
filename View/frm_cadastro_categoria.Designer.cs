namespace projetoAgendaSolo.View
{
    partial class frm_cadastro_categoria
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
            txt_categoria = new TextBox();
            btn_deletar = new Button();
            btn_cadastrar = new Button();
            dgv_Categoria = new DataGridView();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_categoria);
            groupBox1.Controls.Add(btn_deletar);
            groupBox1.Controls.Add(btn_cadastrar);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.Location = new Point(54, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 345);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro categoria";
            // 
            // txt_categoria
            // 
            txt_categoria.Location = new Point(6, 75);
            txt_categoria.Multiline = true;
            txt_categoria.Name = "txt_categoria";
            txt_categoria.PlaceholderText = "Categoria: Amigo";
            txt_categoria.Size = new Size(296, 86);
            txt_categoria.TabIndex = 2;
            // 
            // btn_deletar
            // 
            btn_deletar.BackColor = Color.FromArgb(255, 128, 128);
            btn_deletar.Location = new Point(6, 297);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(296, 42);
            btn_deletar.TabIndex = 2;
            btn_deletar.Text = "Deletar";
            btn_deletar.UseVisualStyleBackColor = false;
            btn_deletar.Click += btn_deletar_Click;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.FromArgb(128, 255, 128);
            btn_cadastrar.Location = new Point(6, 254);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(296, 42);
            btn_cadastrar.TabIndex = 2;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // dgv_Categoria
            // 
            dgv_Categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categoria.Location = new Point(442, 41);
            dgv_Categoria.Name = "dgv_Categoria";
            dgv_Categoria.ReadOnly = true;
            dgv_Categoria.RowHeadersWidth = 51;
            dgv_Categoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Categoria.Size = new Size(266, 345);
            dgv_Categoria.TabIndex = 1;
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
            sairToolStripMenuItem.Size = new Size(224, 26);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(224, 26);
            voltarToolStripMenuItem.Text = "&Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // frm_cadastro_categoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_Categoria);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_cadastro_categoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Telefônica: Cadastro Categoria";
            FormClosed += frm_cadastro_categoria_FormClosed;
            Load += frm_cadastro_categoria_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_categoria;
        private Button btn_deletar;
        private Button btn_cadastrar;
        private DataGridView dgv_Categoria;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem voltarToolStripMenuItem;
    }
}