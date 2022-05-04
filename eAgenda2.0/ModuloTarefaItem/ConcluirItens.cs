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
    public partial class ConcluirItens : Form
    {
        readonly Tarefa _tarefa;
        public ConcluirItens(Tarefa tarefa)
        {
            InitializeComponent();
            _tarefa = tarefa;

            labelarefaSelecionada.Text = _tarefa.Titulo;

            MostrarItensDaTarefa(_tarefa);
        }

        private void MostrarItensDaTarefa(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.Itens)
            {

                checkedListBoxConcluirItens.Items.Add(item);

                if (item.Concluido)
                    checkedListBoxConcluirItens.SetItemChecked(i, true);

                i++;
            }
        }
        public List<Item> ItensConcluidos
        {
            get
            {
                return checkedListBoxConcluirItens.CheckedItems.Cast<Item>().ToList();
            }
        }

        public List<Item> ItensPendentes
        {
            get
            {
                return checkedListBoxConcluirItens.Items.Cast<Item>().Except(ItensConcluidos).ToList();
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
