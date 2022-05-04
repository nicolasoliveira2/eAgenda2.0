namespace eAgenda2._0
{
    partial class ConcluirItens
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
            this.checkedListBoxConcluirItens = new System.Windows.Forms.CheckedListBox();
            this.labelarefaSelecionada = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxConcluirItens
            // 
            this.checkedListBoxConcluirItens.CheckOnClick = true;
            this.checkedListBoxConcluirItens.FormattingEnabled = true;
            this.checkedListBoxConcluirItens.Location = new System.Drawing.Point(12, 27);
            this.checkedListBoxConcluirItens.Name = "checkedListBoxConcluirItens";
            this.checkedListBoxConcluirItens.Size = new System.Drawing.Size(143, 148);
            this.checkedListBoxConcluirItens.TabIndex = 0;
            // 
            // labelarefaSelecionada
            // 
            this.labelarefaSelecionada.AutoSize = true;
            this.labelarefaSelecionada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelarefaSelecionada.Location = new System.Drawing.Point(12, 9);
            this.labelarefaSelecionada.Name = "labelarefaSelecionada";
            this.labelarefaSelecionada.Size = new System.Drawing.Size(138, 15);
            this.labelarefaSelecionada.TabIndex = 1;
            this.labelarefaSelecionada.Text = "[TAREFA SELECIONADA]";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAtualizar.Location = new System.Drawing.Point(12, 197);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(87, 197);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ConcluirItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(167, 232);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.labelarefaSelecionada);
            this.Controls.Add(this.checkedListBoxConcluirItens);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConcluirItens";
            this.Text = "ConcluirItens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxConcluirItens;
        private System.Windows.Forms.Label labelarefaSelecionada;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCancelar;
    }
}