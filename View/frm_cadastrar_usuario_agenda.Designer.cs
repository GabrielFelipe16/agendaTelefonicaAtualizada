namespace projetoAgendaSolo.View
{
    partial class frm_cadastrar_contato_agenda
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
            txt_campo_nome = new TextBox();
            txt_campo_categoria = new TextBox();
            btn_cadastrar = new Button();
            groupBox1 = new GroupBox();
            mtb_telefone = new MaskedTextBox();
            btn_cancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_campo_nome
            // 
            txt_campo_nome.Font = new Font("Segoe UI", 16F);
            txt_campo_nome.Location = new Point(26, 48);
            txt_campo_nome.Multiline = true;
            txt_campo_nome.Name = "txt_campo_nome";
            txt_campo_nome.PlaceholderText = "Nome";
            txt_campo_nome.Size = new Size(186, 55);
            txt_campo_nome.TabIndex = 0;
            txt_campo_nome.TextChanged += txt_campo_nome_TextChanged;
            // 
            // txt_campo_categoria
            // 
            txt_campo_categoria.Font = new Font("Segoe UI", 16F);
            txt_campo_categoria.Location = new Point(26, 145);
            txt_campo_categoria.Multiline = true;
            txt_campo_categoria.Name = "txt_campo_categoria";
            txt_campo_categoria.PlaceholderText = "Categoria";
            txt_campo_categoria.Size = new Size(186, 55);
            txt_campo_categoria.TabIndex = 2;
            txt_campo_categoria.TextChanged += txt_campo_categoria_TextChanged;
            txt_campo_categoria.KeyPress += txt_campo_categoria_KeyPress;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.FromArgb(128, 255, 128);
            btn_cadastrar.Enabled = false;
            btn_cadastrar.Location = new Point(26, 231);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(186, 59);
            btn_cadastrar.TabIndex = 3;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtb_telefone);
            groupBox1.Controls.Add(btn_cancelar);
            groupBox1.Controls.Add(txt_campo_nome);
            groupBox1.Controls.Add(btn_cadastrar);
            groupBox1.Controls.Add(txt_campo_categoria);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.Location = new Point(23, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 361);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de contato";
            // 
            // mtb_telefone
            // 
            mtb_telefone.Location = new Point(26, 107);
            mtb_telefone.Margin = new Padding(3, 2, 3, 2);
            mtb_telefone.Mask = "(00) 00000-0000";
            mtb_telefone.Name = "mtb_telefone";
            mtb_telefone.Size = new Size(186, 36);
            mtb_telefone.TabIndex = 1;
            mtb_telefone.TextChanged += mtb_telefone_TextChanged;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(255, 128, 128);
            btn_cancelar.Location = new Point(26, 296);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(186, 59);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // frm_cadastrar_contato_agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(285, 450);
            Controls.Add(groupBox1);
            Name = "frm_cadastrar_contato_agenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Telefônica: Cadastro de contato";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_campo_nome;
        private TextBox txt_campo_categoria;
        private Button btn_cadastrar;
        private GroupBox groupBox1;
        private Button btn_cancelar;
        private MaskedTextBox mtb_telefone;
    }
}