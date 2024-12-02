namespace projetoAgendaSolo.View
{
    partial class frm_cadastro
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
            mtb_telefone = new MaskedTextBox();
            txt_campo_nome = new TextBox();
            btn_cancelar = new Button();
            btn_cadastrar = new Button();
            txt_campo_confirma_senha = new TextBox();
            txt_campo_senha = new TextBox();
            txt_campo_usuario = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtb_telefone);
            groupBox1.Controls.Add(txt_campo_nome);
            groupBox1.Controls.Add(btn_cancelar);
            groupBox1.Controls.Add(btn_cadastrar);
            groupBox1.Controls.Add(txt_campo_confirma_senha);
            groupBox1.Controls.Add(txt_campo_senha);
            groupBox1.Controls.Add(txt_campo_usuario);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(355, 321);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // mtb_telefone
            // 
            mtb_telefone.Location = new Point(10, 121);
            mtb_telefone.Margin = new Padding(3, 2, 3, 2);
            mtb_telefone.Mask = "(00) 00000-0000";
            mtb_telefone.Name = "mtb_telefone";
            mtb_telefone.Size = new Size(334, 36);
            mtb_telefone.TabIndex = 2;
            // 
            // txt_campo_nome
            // 
            txt_campo_nome.Font = new Font("Segoe UI", 16F);
            txt_campo_nome.Location = new Point(10, 40);
            txt_campo_nome.Margin = new Padding(3, 2, 3, 2);
            txt_campo_nome.Multiline = true;
            txt_campo_nome.Name = "txt_campo_nome";
            txt_campo_nome.PlaceholderText = "Nome: João";
            txt_campo_nome.Size = new Size(334, 37);
            txt_campo_nome.TabIndex = 0;
            txt_campo_nome.TextChanged += txt_campo_nome_TextChanged;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(255, 128, 128);
            btn_cancelar.Location = new Point(10, 279);
            btn_cancelar.Margin = new Padding(3, 2, 3, 2);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(333, 33);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.FromArgb(128, 255, 128);
            btn_cadastrar.Enabled = false;
            btn_cadastrar.Location = new Point(10, 242);
            btn_cadastrar.Margin = new Padding(3, 2, 3, 2);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(333, 33);
            btn_cadastrar.TabIndex = 5;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // txt_campo_confirma_senha
            // 
            txt_campo_confirma_senha.Font = new Font("Segoe UI", 16F);
            txt_campo_confirma_senha.Location = new Point(10, 194);
            txt_campo_confirma_senha.Margin = new Padding(3, 2, 3, 2);
            txt_campo_confirma_senha.Multiline = true;
            txt_campo_confirma_senha.Name = "txt_campo_confirma_senha";
            txt_campo_confirma_senha.PasswordChar = '*';
            txt_campo_confirma_senha.PlaceholderText = "Confirmar Senha";
            txt_campo_confirma_senha.Size = new Size(334, 33);
            txt_campo_confirma_senha.TabIndex = 4;
            txt_campo_confirma_senha.TextChanged += txt_campo_confirma_senha_TextChanged;
            txt_campo_confirma_senha.KeyPress += txt_campo_confirma_senha_KeyPress;
            // 
            // txt_campo_senha
            // 
            txt_campo_senha.Font = new Font("Segoe UI", 16F);
            txt_campo_senha.Location = new Point(10, 158);
            txt_campo_senha.Margin = new Padding(3, 2, 3, 2);
            txt_campo_senha.Multiline = true;
            txt_campo_senha.Name = "txt_campo_senha";
            txt_campo_senha.PasswordChar = '*';
            txt_campo_senha.PlaceholderText = "Senha";
            txt_campo_senha.Size = new Size(334, 33);
            txt_campo_senha.TabIndex = 3;
            txt_campo_senha.TextChanged += txt_campo_senha_TextChanged;
            // 
            // txt_campo_usuario
            // 
            txt_campo_usuario.Font = new Font("Segoe UI", 16F);
            txt_campo_usuario.Location = new Point(10, 80);
            txt_campo_usuario.Margin = new Padding(3, 2, 3, 2);
            txt_campo_usuario.Multiline = true;
            txt_campo_usuario.Name = "txt_campo_usuario";
            txt_campo_usuario.PlaceholderText = "Usuario: João123";
            txt_campo_usuario.Size = new Size(334, 37);
            txt_campo_usuario.TabIndex = 1;
            txt_campo_usuario.TextChanged += txt_campo_usuario_TextChanged;
            // 
            // frm_cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(374, 335);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Telefônica: Cadastro";
            FormClosed += frm_cadastro_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_campo_nome;
        private Button btn_cancelar;
        private Button btn_cadastrar;
        private TextBox txt_campo_usuario;
        private TextBox txt_campo_confirma_senha;
        private TextBox txt_campo_senha;
        private MaskedTextBox mtb_telefone;
    }
}