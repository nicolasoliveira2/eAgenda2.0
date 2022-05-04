namespace eAgenda2._0
{
    partial class TelaInicial
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
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnCompromisso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContatos
            // 
            this.btnContatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContatos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContatos.Location = new System.Drawing.Point(423, 78);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(154, 65);
            this.btnContatos.TabIndex = 0;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // btnTarefas
            // 
            this.btnTarefas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTarefas.Location = new System.Drawing.Point(103, 78);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(154, 65);
            this.btnTarefas.TabIndex = 1;
            this.btnTarefas.Text = "Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnCompromisso
            // 
            this.btnCompromisso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompromisso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompromisso.Location = new System.Drawing.Point(263, 78);
            this.btnCompromisso.Name = "btnCompromisso";
            this.btnCompromisso.Size = new System.Drawing.Size(154, 65);
            this.btnCompromisso.TabIndex = 2;
            this.btnCompromisso.Text = "Compromisso";
            this.btnCompromisso.UseVisualStyleBackColor = true;
            this.btnCompromisso.Click += new System.EventHandler(this.btnCompromisso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "eAgenda2.0 - Bem Vindo";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompromisso);
            this.Controls.Add(this.btnTarefas);
            this.Controls.Add(this.btnContatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaInicial";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnCompromisso;
        private System.Windows.Forms.Label label1;
    }
}
