namespace projetoAgendaSolo
{
    partial class frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_entrar = new Button();
            txt_campo_senha = new TextBox();
            groupBox1 = new GroupBox();
            panelUsuario = new Panel();
            txt_campo_usuario = new TextBox();
            panelSenha = new Panel();
            lbl_link_cadastro = new LinkLabel();
            btn_cancelar = new Button();
            groupBox1.SuspendLayout();
            panelUsuario.SuspendLayout();
            panelSenha.SuspendLayout();
            SuspendLayout();
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.FromArgb(128, 255, 128);
            btn_entrar.Enabled = false;
            btn_entrar.Location = new Point(10, 197);
            btn_entrar.Margin = new Padding(3, 2, 3, 2);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(333, 33);
            btn_entrar.TabIndex = 3;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // txt_campo_senha
            // 
            txt_campo_senha.Font = new Font("Segoe UI", 16F);
            txt_campo_senha.Location = new Point(2, 3);
            txt_campo_senha.Margin = new Padding(3, 2, 3, 2);
            txt_campo_senha.Multiline = true;
            txt_campo_senha.Name = "txt_campo_senha";
            txt_campo_senha.PasswordChar = '*';
            txt_campo_senha.PlaceholderText = "Senha";
            txt_campo_senha.Size = new Size(329, 44);
            txt_campo_senha.TabIndex = 1;
            txt_campo_senha.TextChanged += txt_campo_senha_TextChanged;
            txt_campo_senha.KeyPress += txt_campo_senha_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelUsuario);
            groupBox1.Controls.Add(panelSenha);
            groupBox1.Controls.Add(lbl_link_cadastro);
            groupBox1.Controls.Add(btn_cancelar);
            groupBox1.Controls.Add(btn_entrar);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.Location = new Point(158, 20);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(355, 284);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // panelUsuario
            // 
            panelUsuario.Controls.Add(txt_campo_usuario);
            panelUsuario.Location = new Point(10, 52);
            panelUsuario.Margin = new Padding(3, 2, 3, 2);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(333, 52);
            panelUsuario.TabIndex = 5;
            // 
            // txt_campo_usuario
            // 
            txt_campo_usuario.Font = new Font("Segoe UI", 16F);
            txt_campo_usuario.Location = new Point(2, 2);
            txt_campo_usuario.Margin = new Padding(3, 2, 3, 2);
            txt_campo_usuario.Multiline = true;
            txt_campo_usuario.Name = "txt_campo_usuario";
            txt_campo_usuario.PlaceholderText = "Usuario";
            txt_campo_usuario.Size = new Size(329, 48);
            txt_campo_usuario.TabIndex = 0;
            txt_campo_usuario.TextChanged += txt_campo_usuario_TextChanged;
            // 
            // panelSenha
            // 
            panelSenha.Controls.Add(txt_campo_senha);
            panelSenha.Location = new Point(10, 113);
            panelSenha.Margin = new Padding(3, 2, 3, 2);
            panelSenha.Name = "panelSenha";
            panelSenha.Size = new Size(333, 50);
            panelSenha.TabIndex = 4;
            // 
            // lbl_link_cadastro
            // 
            lbl_link_cadastro.ActiveLinkColor = Color.FromArgb(128, 255, 128);
            lbl_link_cadastro.AutoSize = true;
            lbl_link_cadastro.Font = new Font("Segoe UI", 12F);
            lbl_link_cadastro.LinkColor = Color.Black;
            lbl_link_cadastro.Location = new Point(172, 162);
            lbl_link_cadastro.Name = "lbl_link_cadastro";
            lbl_link_cadastro.Size = new Size(156, 21);
            lbl_link_cadastro.TabIndex = 2;
            lbl_link_cadastro.TabStop = true;
            lbl_link_cadastro.Text = "Não possuo cadastro";
            lbl_link_cadastro.LinkClicked += lbl_link_cadastro_LinkClicked;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(255, 128, 128);
            btn_cancelar.Location = new Point(10, 235);
            btn_cancelar.Margin = new Padding(3, 2, 3, 2);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(333, 33);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(700, 338);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Telefônica: Login";
            FormClosed += frm_login_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            panelSenha.ResumeLayout(false);
            panelSenha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_entrar;
        private TextBox txt_campo_senha;
        private GroupBox groupBox1;
        private Button btn_cancelar;
        private LinkLabel lbl_link_cadastro;
        private Panel panelUsuario;
        private TextBox txt_campo_usuario;
        private Panel panelSenha;
    }
}
