namespace projetoAgendaSolo.View
{
    partial class frm_agenda
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
            dgv_agenda = new DataGridView();
            btn_cadastrar_novo = new Button();
            btn_alterar_cadastro = new Button();
            btn_excluir_cadastro = new Button();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgv_agenda).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_agenda
            // 
            dgv_agenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_agenda.Location = new Point(250, 46);
            dgv_agenda.Margin = new Padding(3, 4, 3, 4);
            dgv_agenda.Name = "dgv_agenda";
            dgv_agenda.RowHeadersWidth = 51;
            dgv_agenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_agenda.Size = new Size(507, 560);
            dgv_agenda.TabIndex = 0;
            dgv_agenda.SelectionChanged += dgv_agenda_SelectionChanged;
            // 
            // btn_cadastrar_novo
            // 
            btn_cadastrar_novo.BackColor = Color.FromArgb(128, 255, 128);
            btn_cadastrar_novo.Font = new Font("Segoe UI", 16F);
            btn_cadastrar_novo.Location = new Point(12, 46);
            btn_cadastrar_novo.Margin = new Padding(3, 4, 3, 4);
            btn_cadastrar_novo.Name = "btn_cadastrar_novo";
            btn_cadastrar_novo.Size = new Size(217, 68);
            btn_cadastrar_novo.TabIndex = 1;
            btn_cadastrar_novo.Text = "Cadastrar novo";
            btn_cadastrar_novo.UseVisualStyleBackColor = false;
            btn_cadastrar_novo.Click += btn_cadastrar_novo_Click;
            // 
            // btn_alterar_cadastro
            // 
            btn_alterar_cadastro.BackColor = Color.FromArgb(255, 255, 128);
            btn_alterar_cadastro.Font = new Font("Segoe UI", 16F);
            btn_alterar_cadastro.Location = new Point(14, 282);
            btn_alterar_cadastro.Margin = new Padding(3, 4, 3, 4);
            btn_alterar_cadastro.Name = "btn_alterar_cadastro";
            btn_alterar_cadastro.Size = new Size(217, 68);
            btn_alterar_cadastro.TabIndex = 1;
            btn_alterar_cadastro.Text = "Alterar Contato";
            btn_alterar_cadastro.UseVisualStyleBackColor = false;
            btn_alterar_cadastro.Click += btn_alterar_cadastro_Click;
            // 
            // btn_excluir_cadastro
            // 
            btn_excluir_cadastro.BackColor = Color.FromArgb(255, 128, 128);
            btn_excluir_cadastro.Font = new Font("Segoe UI", 16F);
            btn_excluir_cadastro.Location = new Point(14, 538);
            btn_excluir_cadastro.Margin = new Padding(3, 4, 3, 4);
            btn_excluir_cadastro.Name = "btn_excluir_cadastro";
            btn_excluir_cadastro.Size = new Size(217, 68);
            btn_excluir_cadastro.TabIndex = 1;
            btn_excluir_cadastro.Text = "Excluir Contato";
            btn_excluir_cadastro.UseVisualStyleBackColor = false;
            btn_excluir_cadastro.Click += btn_excluir_cadastro_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { voltarToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(75, 24);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(224, 26);
            voltarToolStripMenuItem.Text = "&Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(224, 26);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // frm_agenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(914, 619);
            Controls.Add(btn_excluir_cadastro);
            Controls.Add(btn_alterar_cadastro);
            Controls.Add(btn_cadastrar_novo);
            Controls.Add(dgv_agenda);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_agenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Telefônica";
            FormClosed += frm_agenda_FormClosed;
            Load += frm_agenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_agenda).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_agenda;
        private Button btn_cadastrar_novo;
        private Button btn_alterar_cadastro;
        private Button btn_excluir_cadastro;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}