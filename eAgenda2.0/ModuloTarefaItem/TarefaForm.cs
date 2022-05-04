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
    public partial class TarefaForm : Form
    {
        Repositorio<Tarefa> _repositorioTarefa;
        public TarefaForm(Repositorio<Tarefa> repositorio)
        {
            InitializeComponent();
            _repositorioTarefa = repositorio;
            CarregarTarefasNaTela();
        }

        private void btnInserirTarefa_Click(object sender, EventArgs e)
        {
            CadastroTarefaForm telaTarefa = new(new Tarefa());
            DialogResult resultado = telaTarefa.ShowDialog();

            
            if (resultado == DialogResult.OK)
            {
                Tarefa tituloTarefa = telaTarefa.Tarefa;
                bool tituloNovo = VerificarTituloExistentente(tituloTarefa);
                    if (!tituloNovo)
                    return;

                string status = _repositorioTarefa.Inserir(telaTarefa.Tarefa);

                if (status.Trim() == "REGISTRO_VALIDO")
                    MessageBox.Show("Tarefa inserido com sucesso!", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"{status}\nTente novamente", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CarregarTarefasNaTela();
            }
        }

        

        private void btnEditarTarefas_Click(object sender, EventArgs e)
        {
            Tarefa? tarefaSelecionada = null;

            if (listBoxTarefasPendentes.SelectedIndex > -1)
            {
                tarefaSelecionada = (Tarefa)listBoxTarefasPendentes.SelectedItem;
            }
            else
            {
                tarefaSelecionada = (Tarefa)listBoxTarefasConcluidas.SelectedItem;
            }

            Tarefa novaTarefa = new();

            bool temAlgo = VerificarRegistros(tarefaSelecionada, "Excluir");
            if (!temAlgo)
                return;

            novaTarefa.id = tarefaSelecionada.id;
            novaTarefa.Titulo = tarefaSelecionada.Titulo;
            novaTarefa.DataCriacao = tarefaSelecionada.DataCriacao;
            novaTarefa.concluido = tarefaSelecionada.concluido;
  
            CadastroTarefaForm telaTarefa = new(novaTarefa);

            DialogResult resultado = telaTarefa.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                string status = _repositorioTarefa.Editar(novaTarefa, tarefaSelecionada);
                if(status.Trim() == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Tarefa editada com sucesso", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CarregarTarefasNaTela();
                }

                else
                {
                    MessageBox.Show($"{status}\nTente novamente", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CarregarTarefasNaTela();
                }
            }
        }

        private bool VerificarRegistros(Tarefa tarefaSelecionada, string tipo)
        {
            bool temAlgo = _repositorioTarefa.RegistroExistente();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhuma tarefa para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tarefaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma tarefa para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void btnExcluirTarefas_Click(object sender, EventArgs e)
        {
            Tarefa? tarefaSelecionada = null;

            if (listBoxTarefasPendentes.SelectedIndex > -1)
            {
                 tarefaSelecionada = (Tarefa)listBoxTarefasPendentes.SelectedItem;
            }
            else
            { 
                tarefaSelecionada = (Tarefa)listBoxTarefasConcluidas.SelectedItem;
            }

            bool temAlgo = VerificarRegistros(tarefaSelecionada, "Excluir");
            if (!temAlgo)
                return;

            Tarefa tarefasPendentes = (Tarefa)listBoxTarefasPendentes.SelectedItem;
            if (tarefasPendentes != null)
            {
                MessageBox.Show("Você só pode excluir tarefas já concluídas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show("Excluir tarefa?",
                "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioTarefa.Excluir(tarefaSelecionada);
                CarregarTarefasNaTela();
            }
        }

        private void btnInserirItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefasPendentes.SelectedItem;
            CadastroItemForm telaItens = new(tarefaSelecionada);
            DialogResult res = telaItens.ShowDialog();
            if (res == DialogResult.OK)
            {
                tarefaSelecionada.AdicionarItens(telaItens.ItensAdicionados);
                CarregarTarefasNaTela();
            }
        }

        private void btnConcluirItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefasPendentes.SelectedItem;
            ConcluirItens telaConcItens = new(tarefaSelecionada);
            DialogResult resultado = telaConcItens.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                List<Item> itensConcluidos = telaConcItens.ItensConcluidos;

                List<Item> itensPendentes = telaConcItens.ItensPendentes;

                tarefaSelecionada.AtualizarConclusao(itensConcluidos, itensPendentes);
                CarregarTarefasNaTela();
            }

            CarregarTarefasNaTela();
        }

        private void CarregarTarefasNaTela()
        {

            CarregarPendentes();
            CarregarConcluidas();
        }

        private void CarregarPendentes()
        {

            List<Tarefa> tarefasPendentes = _repositorioTarefa.FiltrarCompromissos(x => x.concluido == false).OrderBy(x => x.PrioridadeTarefa).ToList();

            listBoxTarefasPendentes.Items.Clear();
            foreach (var item in tarefasPendentes)
                listBoxTarefasPendentes.Items.Add(item);
        }

        private void CarregarConcluidas()
        {
            List<Tarefa> tarefasConcluidas = _repositorioTarefa.FiltrarCompromissos(x => x.concluido == true).OrderBy(x => x.PrioridadeTarefa).ToList();
            listBoxTarefasConcluidas.Items.Clear();
            foreach (var item in tarefasConcluidas)
                listBoxTarefasConcluidas.Items.Add(item);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool VerificarTituloExistentente(Tarefa temp)
        {
            List<Tarefa> todasTarefas = _repositorioTarefa.SelecionarTodos();

            foreach (Tarefa tarefaJaRegistrada in todasTarefas)
            {
                if (tarefaJaRegistrada.Titulo == temp.Titulo)
                {
                    MessageBox.Show("O titulo da tarefa já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void listBoxTarefasPendentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxTarefasPendentes.SelectedIndex > -1)
            {
                listBoxTarefasConcluidas.SelectedIndex = -1;
            }
        }

        private void listBoxTarefasConcluidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTarefasConcluidas.SelectedIndex > -1)
            {
                listBoxTarefasPendentes.SelectedIndex = -1;
            }
        }
    }
}
