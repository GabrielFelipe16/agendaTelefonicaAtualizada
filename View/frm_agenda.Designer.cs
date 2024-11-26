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
            ((System.ComponentModel.ISupportInitialize)dgv_agenda).BeginInit();
            SuspendLayout();
            // 
            // dgv_agenda
            // 
            dgv_agenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_agenda.Location = new Point(120, 18);
            dgv_agenda.Name = "dgv_agenda";
            dgv_agenda.Size = new Size(649, 420);
            dgv_agenda.TabIndex = 0;
            dgv_agenda.SelectionChanged += dgv_agenda_SelectionChanged;
            // 
            // btn_cadastrar_novo
            // 
            btn_cadastrar_novo.Location = new Point(12, 18);
            btn_cadastrar_novo.Name = "btn_cadastrar_novo";
            btn_cadastrar_novo.Size = new Size(90, 51);
            btn_cadastrar_novo.TabIndex = 1;
            btn_cadastrar_novo.Text = "Cadastrar novo";
            btn_cadastrar_novo.UseVisualStyleBackColor = true;
            btn_cadastrar_novo.Click += btn_cadastrar_novo_Click;
            // 
            // btn_alterar_cadastro
            // 
            btn_alterar_cadastro.Location = new Point(12, 209);
            btn_alterar_cadastro.Name = "btn_alterar_cadastro";
            btn_alterar_cadastro.Size = new Size(90, 51);
            btn_alterar_cadastro.TabIndex = 1;
            btn_alterar_cadastro.Text = "Alterar Cadastro";
            btn_alterar_cadastro.UseVisualStyleBackColor = true;
            btn_alterar_cadastro.Click += btn_alterar_cadastro_Click;
            // 
            // btn_excluir_cadastro
            // 
            btn_excluir_cadastro.Location = new Point(12, 387);
            btn_excluir_cadastro.Name = "btn_excluir_cadastro";
            btn_excluir_cadastro.Size = new Size(90, 51);
            btn_excluir_cadastro.TabIndex = 1;
            btn_excluir_cadastro.Text = "Excluir Cadastro";
            btn_excluir_cadastro.UseVisualStyleBackColor = true;
            btn_excluir_cadastro.Click += btn_excluir_cadastro_Click;
            // 
            // frm_agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_excluir_cadastro);
            Controls.Add(btn_alterar_cadastro);
            Controls.Add(btn_cadastrar_novo);
            Controls.Add(dgv_agenda);
            Name = "frm_agenda";
            Text = "Agenda Telefônica";
            Load += frm_agenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_agenda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_agenda;
        private Button btn_cadastrar_novo;
        private Button btn_alterar_cadastro;
        private Button btn_excluir_cadastro;
    }
}