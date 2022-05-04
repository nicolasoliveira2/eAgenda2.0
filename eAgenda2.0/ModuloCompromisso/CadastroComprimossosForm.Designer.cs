namespace eAgenda2._0
{
    partial class CadastroComprimossosForm
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
            this.comboBoxContato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBAssuntoCompromisso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBLocarCompromisso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxContato
            // 
            this.comboBoxContato.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxContato.FormattingEnabled = true;
            this.comboBoxContato.Items.AddRange(new object[] {
            "(Nenhum Contato)"});
            this.comboBoxContato.Location = new System.Drawing.Point(100, 116);
            this.comboBoxContato.Name = "comboBoxContato";
            this.comboBoxContato.Size = new System.Drawing.Size(120, 23);
            this.comboBoxContato.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assunto:";
            // 
            // TBAssuntoCompromisso
            // 
            this.TBAssuntoCompromisso.Location = new System.Drawing.Point(100, 32);
            this.TBAssuntoCompromisso.Name = "TBAssuntoCompromisso";
            this.TBAssuntoCompromisso.Size = new System.Drawing.Size(100, 23);
            this.TBAssuntoCompromisso.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Local:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Horario incio:";
            // 
            // TBLocarCompromisso
            // 
            this.TBLocarCompromisso.Location = new System.Drawing.Point(100, 61);
            this.TBLocarCompromisso.Name = "TBLocarCompromisso";
            this.TBLocarCompromisso.Size = new System.Drawing.Size(100, 23);
            this.TBLocarCompromisso.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Horario Fim:";
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(100, 90);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxData.TabIndex = 16;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxHoraInicio
            // 
            this.maskedTextBoxHoraInicio.Location = new System.Drawing.Point(100, 145);
            this.maskedTextBoxHoraInicio.Mask = "00:00";
            this.maskedTextBoxHoraInicio.Name = "maskedTextBoxHoraInicio";
            this.maskedTextBoxHoraInicio.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxHoraInicio.TabIndex = 17;
            this.maskedTextBoxHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxHoraFim
            // 
            this.maskedTextBoxHoraFim.Location = new System.Drawing.Point(100, 174);
            this.maskedTextBoxHoraFim.Mask = "00:00";
            this.maskedTextBoxHoraFim.Name = "maskedTextBoxHoraFim";
            this.maskedTextBoxHoraFim.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxHoraFim.TabIndex = 19;
            this.maskedTextBoxHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // btnInserir
            // 
            this.btnInserir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInserir.Location = new System.Drawing.Point(56, 203);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 20;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(163, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CadastroComprimossosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(262, 238);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.maskedTextBoxHoraFim);
            this.Controls.Add(this.maskedTextBoxHoraInicio);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBLocarCompromisso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBAssuntoCompromisso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxContato);
            this.Name = "CadastroComprimossosForm";
            this.Text = "CadastroComprimossosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBAssuntoCompromisso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBLocarCompromisso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraFim;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnCancelar;
    }
}