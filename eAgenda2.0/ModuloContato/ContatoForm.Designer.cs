namespace eAgenda2._0
{
    partial class ContatoForm
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
            this.btnInserirContato = new System.Windows.Forms.Button();
            this.listBoxContatos = new System.Windows.Forms.ListBox();
            this.btnEditarContato = new System.Windows.Forms.Button();
            this.btnExcluirContato = new System.Windows.Forms.Button();
            this.bntSairContato = new System.Windows.Forms.Button();
            this.bntMostrarOrdenado = new System.Windows.Forms.Button();
            this.bntMostrarSemOrdem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInserirContato
            // 
            this.btnInserirContato.Location = new System.Drawing.Point(12, 41);
            this.btnInserirContato.Name = "btnInserirContato";
            this.btnInserirContato.Size = new System.Drawing.Size(85, 45);
            this.btnInserirContato.TabIndex = 0;
            this.btnInserirContato.Text = "Inseir";
            this.btnInserirContato.UseVisualStyleBackColor = true;
            this.btnInserirContato.Click += new System.EventHandler(this.btnInserirContato_Click);
            // 
            // listBoxContatos
            // 
            this.listBoxContatos.FormattingEnabled = true;
            this.listBoxContatos.ItemHeight = 15;
            this.listBoxContatos.Location = new System.Drawing.Point(12, 92);
            this.listBoxContatos.Name = "listBoxContatos";
            this.listBoxContatos.Size = new System.Drawing.Size(594, 229);
            this.listBoxContatos.TabIndex = 1;
            // 
            // btnEditarContato
            // 
            this.btnEditarContato.Location = new System.Drawing.Point(103, 41);
            this.btnEditarContato.Name = "btnEditarContato";
            this.btnEditarContato.Size = new System.Drawing.Size(85, 45);
            this.btnEditarContato.TabIndex = 2;
            this.btnEditarContato.Text = "Editar";
            this.btnEditarContato.UseVisualStyleBackColor = true;
            this.btnEditarContato.Click += new System.EventHandler(this.btnEditarContato_Click);
            // 
            // btnExcluirContato
            // 
            this.btnExcluirContato.Location = new System.Drawing.Point(194, 41);
            this.btnExcluirContato.Name = "btnExcluirContato";
            this.btnExcluirContato.Size = new System.Drawing.Size(85, 45);
            this.btnExcluirContato.TabIndex = 3;
            this.btnExcluirContato.Text = "Excluir";
            this.btnExcluirContato.UseVisualStyleBackColor = true;
            this.btnExcluirContato.Click += new System.EventHandler(this.btnExcluirContato_Click);
            // 
            // bntSairContato
            // 
            this.bntSairContato.ForeColor = System.Drawing.Color.Red;
            this.bntSairContato.Location = new System.Drawing.Point(454, 327);
            this.bntSairContato.Name = "bntSairContato";
            this.bntSairContato.Size = new System.Drawing.Size(152, 23);
            this.bntSairContato.TabIndex = 4;
            this.bntSairContato.Text = "Sair";
            this.bntSairContato.UseVisualStyleBackColor = true;
            this.bntSairContato.Click += new System.EventHandler(this.bntSairContato_Click);
            // 
            // bntMostrarOrdenado
            // 
            this.bntMostrarOrdenado.Location = new System.Drawing.Point(521, 41);
            this.bntMostrarOrdenado.Name = "bntMostrarOrdenado";
            this.bntMostrarOrdenado.Size = new System.Drawing.Size(85, 45);
            this.bntMostrarOrdenado.TabIndex = 5;
            this.bntMostrarOrdenado.Text = "Mostrar Ordenado Por Cargo";
            this.bntMostrarOrdenado.UseVisualStyleBackColor = true;
            this.bntMostrarOrdenado.Click += new System.EventHandler(this.bntMostrarOrdenado_Click);
            // 
            // bntMostrarSemOrdem
            // 
            this.bntMostrarSemOrdem.Location = new System.Drawing.Point(430, 41);
            this.bntMostrarSemOrdem.Name = "bntMostrarSemOrdem";
            this.bntMostrarSemOrdem.Size = new System.Drawing.Size(85, 45);
            this.bntMostrarSemOrdem.TabIndex = 6;
            this.bntMostrarSemOrdem.Text = "Mostrar Sem Ordem";
            this.bntMostrarSemOrdem.UseVisualStyleBackColor = true;
            this.bntMostrarSemOrdem.Click += new System.EventHandler(this.bntMostrarSemOrdem_Click);
            // 
            // ContatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 350);
            this.Controls.Add(this.bntMostrarSemOrdem);
            this.Controls.Add(this.bntMostrarOrdenado);
            this.Controls.Add(this.bntSairContato);
            this.Controls.Add(this.btnExcluirContato);
            this.Controls.Add(this.btnEditarContato);
            this.Controls.Add(this.listBoxContatos);
            this.Controls.Add(this.btnInserirContato);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContatoForm";
            this.Text = "ContatoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInserirContato;
        private System.Windows.Forms.ListBox listBoxContatos;
        private System.Windows.Forms.Button btnEditarContato;
        private System.Windows.Forms.Button btnExcluirContato;
        private System.Windows.Forms.Button bntSairContato;
        private System.Windows.Forms.Button bntMostrarOrdenado;
        private System.Windows.Forms.Button bntMostrarSemOrdem;
    }
}