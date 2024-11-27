﻿namespace projetoAgendaSolo.View
{
    partial class frm_alterar_contato
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
            btn_cancelar = new Button();
            btn_concluir = new Button();
            txt_campo_categoria = new TextBox();
            txt_campo_nome = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtb_telefone);
            groupBox1.Controls.Add(btn_cancelar);
            groupBox1.Controls.Add(btn_concluir);
            groupBox1.Controls.Add(txt_campo_categoria);
            groupBox1.Controls.Add(txt_campo_nome);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(320, 491);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar Contato";
            // 
            // mtb_telefone
            // 
            mtb_telefone.Location = new Point(6, 165);
            mtb_telefone.Mask = "(00) 00000-0000";
            mtb_telefone.Name = "mtb_telefone";
            mtb_telefone.Size = new Size(306, 43);
            mtb_telefone.TabIndex = 5;
            mtb_telefone.TextChanged += mtb_telefone_TextChanged;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(255, 128, 128);
            btn_cancelar.Location = new Point(6, 414);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(306, 57);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "&Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_concluir
            // 
            btn_concluir.BackColor = Color.FromArgb(128, 255, 128);
            btn_concluir.Enabled = false;
            btn_concluir.Location = new Point(6, 346);
            btn_concluir.Margin = new Padding(3, 4, 3, 4);
            btn_concluir.Name = "btn_concluir";
            btn_concluir.Size = new Size(306, 60);
            btn_concluir.TabIndex = 3;
            btn_concluir.Text = "&Concluir";
            btn_concluir.UseVisualStyleBackColor = false;
            btn_concluir.Click += btn_alterar_Click;
            // 
            // txt_campo_categoria
            // 
            txt_campo_categoria.Location = new Point(6, 226);
            txt_campo_categoria.Margin = new Padding(3, 4, 3, 4);
            txt_campo_categoria.Multiline = true;
            txt_campo_categoria.Name = "txt_campo_categoria";
            txt_campo_categoria.PlaceholderText = "Categoria";
            txt_campo_categoria.Size = new Size(307, 68);
            txt_campo_categoria.TabIndex = 2;
            txt_campo_categoria.TextChanged += txt_campo_categoria_TextChanged;
            // 
            // txt_campo_nome
            // 
            txt_campo_nome.Location = new Point(6, 76);
            txt_campo_nome.Margin = new Padding(3, 4, 3, 4);
            txt_campo_nome.Multiline = true;
            txt_campo_nome.Name = "txt_campo_nome";
            txt_campo_nome.PlaceholderText = "Nome";
            txt_campo_nome.Size = new Size(306, 69);
            txt_campo_nome.TabIndex = 0;
            txt_campo_nome.TextChanged += txt_campo_nome_TextChanged;
            // 
            // frm_alterar_contato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(350, 512);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_alterar_contato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Telefônica: Alterar Contato";
            FormClosed += frm_alterar_contato_FormClosed;
            Load += frm_alterar_contato_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_cancelar;
        private Button btn_concluir;
        private TextBox txt_campo_categoria;
        private TextBox txt_campo_nome;
        private MaskedTextBox mtb_telefone;
    }
}