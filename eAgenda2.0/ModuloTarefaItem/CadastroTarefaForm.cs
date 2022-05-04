using eAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda2._0
{
    public partial class CadastroTarefaForm : Form
    {
        Tarefa? _tarefa;

        public CadastroTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();
            _tarefa = tarefa;
            if(tarefa != null)
            {
                textBoxTituloTarefa.Text = tarefa.Titulo;
            }
        }

        public Tarefa Tarefa
        {
            get { return _tarefa!; }
            set { _tarefa = value; }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
           
            _tarefa!.Titulo = textBoxTituloTarefa.Text;
            if (comboBoxPrioridade.SelectedItem == null)
            {
                _tarefa.PrioridadeTarefa = Prioridade.Baixa;
            }
            else
                _tarefa.PrioridadeTarefa = (Prioridade)comboBoxPrioridade.SelectedIndex;
        }
    }
}
