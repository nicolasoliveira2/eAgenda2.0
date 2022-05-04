using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Dominio
{
    public class Tarefa : EntidadeBase
    {
        private Prioridade _prioridade;

        string titulo;

        private readonly List<Item> itens = new();

        public bool concluido;
        public Tarefa()
        {
            DataCriacao = DateTime.Now;
            DataConclusao = null;
        }

        public string Titulo { get { return titulo; } set { titulo = value; } }
        public double Porcentagem { get; set;  }
        public Prioridade PrioridadeTarefa
        {
            get { return _prioridade; }
            set { _prioridade = value; }
        }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public List<Item> Itens
        {
            get { return itens; }
        }

        public override string ToString()
        {
            decimal percentual = CalcularPercentualConcluisao();

            if (DataConclusao.HasValue)
                return $"ID: {id}, Título: {Titulo}, Prioridade: {PrioridadeTarefa}, {percentual}% Concluido, Data de criação: {DataCriacao},  Conclusão: {DataConclusao}";

            return $"ID: {id}, Título: {Titulo}, Prioridade: {PrioridadeTarefa}, {percentual}% Concluido, Data de criação: {DataCriacao}";
        }

        private decimal CalcularPercentualConcluisao()
        {
            if (itens.Count == 0)
                return 0;

            int qtdConcluidas = Itens.Count(x => x.Concluido);

            var percentualConcluido = (qtdConcluidas / (decimal)Itens.Count()) * 100;

            return Math.Round(percentualConcluido, 2);
        }

        public override string Validar()
        {
            StringBuilder sb = new();

            if (string.IsNullOrEmpty(Titulo))
                sb.AppendLine("Campo Titulo é obrigatorio");
            if (sb.Length == 0)
                sb.AppendLine("REGISTRO_VALIDO");

            return sb.ToString();
        }
        public void AdicionarItens(List<Item> itens)
        {
            foreach (Item item in itens)
            {
                if (!Itens.Exists(x => x.Equals(item)))
                    this.itens.Add(item);
            }
        }

        public void AtualizarConclusao(List<Item> itensConcluidos, List<Item> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                ConcluirItem(item);
            }

            foreach (var item in itensPendentes)
            {
                MarcarPendente(item);
            }
        }

        public void ConcluirItem(Item item)
        {
            Item itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConcluisao();

            if (percentual == 100)
            { 
                  DataConclusao = DateTime.Now;
                concluido = true;
            }

        }

        public void MarcarPendente(Item item)
        {
            Item itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.MarcarPendente();
        }
    }
}
