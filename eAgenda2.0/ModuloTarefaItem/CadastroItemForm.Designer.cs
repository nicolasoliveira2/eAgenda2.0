namespace eAgenda2._0
{
    partial class CadastroItemForm
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
            this.textBoxNomeItem = new System.Windows.Forms.TextBox();
            this.btnInserirNomeItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxItensTarefa = new System.Windows.Forms.ListBox();
            this.labelTarefaSelecionada = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNomeItem
            // 
            this.textBoxNomeItem.Location = new System.Drawing.Point(106, 51);
            this.textBoxNomeItem.Name = "textBoxNomeItem";
            this.textBoxNomeItem.Size = new System.Drawing.Size(100, 23);
            this.textBoxNomeItem.TabIndex = 0;
            // 
            // btnInserirNomeItem
            // 
            this.btnInserirNomeItem.Location = new System.Drawing.Point(211, 51);
            this.btnInserirNomeItem.Name = "btnInserirNomeItem";
            this.btnInserirNomeItem.Size = new System.Drawing.Size(75, 23);
            this.btnInserirNomeItem.TabIndex = 1;
            this.btnInserirNomeItem.Text = "Inserir";
            this.btnInserirNomeItem.UseVisualStyleBackColor = true;
            this.btnInserirNomeItem.Click += new System.EventHandler(this.btnInserirNomeItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do item";
            // 
            // listBoxItensTarefa
            // 
            this.listBoxItensTarefa.FormattingEnabled = true;
            this.listBoxItensTarefa.ItemHeight = 15;
            this.listBoxItensTarefa.Location = new System.Drawing.Point(7, 80);
            this.listBoxItensTarefa.Name = "listBoxItensTarefa";
            this.listBoxItensTarefa.Size = new System.Drawing.Size(279, 169);
            this.listBoxItensTarefa.TabIndex = 3;
            // 
            // labelTarefaSelecionada
            // 
            this.labelTarefaSelecionada.AutoSize = true;
            this.labelTarefaSelecionada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTarefaSelecionada.Location = new System.Drawing.Point(75, 9);
            this.labelTarefaSelecionada.Name = "labelTarefaSelecionada";
            this.labelTarefaSelecionada.Size = new System.Drawing.Size(138, 15);
            this.labelTarefaSelecionada.TabIndex = 4;
            this.labelTarefaSelecionada.Text = "[TAREFA SELECIONADA]";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(169, 255);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(117, 27);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConcluir.Location = new System.Drawing.Point(29, 255);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(117, 27);
            this.btnConcluir.TabIndex = 6;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            // 
            // CadastroItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(298, 290);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.labelTarefaSelecionada);
            this.Controls.Add(this.listBoxItensTarefa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserirNomeItem);
            this.Controls.Add(this.textBoxNomeItem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroItemForm";
            this.Text = "TelaCadastroItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeItem;
        private System.Windows.Forms.Button btnInserirNomeItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxItensTarefa;
        private System.Windows.Forms.Label labelTarefaSelecionada;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConcluir;
    }
}