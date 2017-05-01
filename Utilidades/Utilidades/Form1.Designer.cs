namespace Utilidades
{
    partial class Form1
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
            this.Selecionar_botao = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nlinha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CnpjInicio = new System.Windows.Forms.TextBox();
            this.CnpjFim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_historico = new System.Windows.Forms.ListView();
            this.Historico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_limpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Selecionar_botao
            // 
            this.Selecionar_botao.Location = new System.Drawing.Point(6, 18);
            this.Selecionar_botao.Name = "Selecionar_botao";
            this.Selecionar_botao.Size = new System.Drawing.Size(129, 23);
            this.Selecionar_botao.TabIndex = 1;
            this.Selecionar_botao.Text = "Selecionar arquivo...";
            this.Selecionar_botao.UseVisualStyleBackColor = true;
            this.Selecionar_botao.Click += new System.EventHandler(this.Selecionar_botao_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nlinha,
            this.nome});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(238, 276);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nlinha
            // 
            this.Nlinha.Text = "N° da linha";
            this.Nlinha.Width = 80;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 153;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.Selecionar_botao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 333);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validar arquivo";
            // 
            // CnpjInicio
            // 
            this.CnpjInicio.Location = new System.Drawing.Point(6, 33);
            this.CnpjInicio.Name = "CnpjInicio";
            this.CnpjInicio.Size = new System.Drawing.Size(124, 20);
            this.CnpjInicio.TabIndex = 4;
            this.CnpjInicio.TextChanged += new System.EventHandler(this.CnpjInicio_TextChanged);
            // 
            // CnpjFim
            // 
            this.CnpjFim.Location = new System.Drawing.Point(6, 73);
            this.CnpjFim.Name = "CnpjFim";
            this.CnpjFim.Size = new System.Drawing.Size(124, 20);
            this.CnpjFim.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Insira o Texto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Texto limpo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CnpjInicio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CnpjFim);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(275, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Limpador de caracteres";
            // 
            // lst_historico
            // 
            this.lst_historico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Historico});
            this.lst_historico.Location = new System.Drawing.Point(275, 127);
            this.lst_historico.Name = "lst_historico";
            this.lst_historico.Size = new System.Drawing.Size(133, 208);
            this.lst_historico.TabIndex = 9;
            this.lst_historico.UseCompatibleStateImageBehavior = false;
            this.lst_historico.View = System.Windows.Forms.View.Details;
            // 
            // Historico
            // 
            this.Historico.Text = "Histórico";
            this.Historico.Width = 128;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(414, 127);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 10;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 347);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lst_historico);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Selecionar_botao;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader Nlinha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CnpjInicio;
        private System.Windows.Forms.TextBox CnpjFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lst_historico;
        private System.Windows.Forms.ColumnHeader Historico;
        private System.Windows.Forms.Button btn_limpar;
    }
}

