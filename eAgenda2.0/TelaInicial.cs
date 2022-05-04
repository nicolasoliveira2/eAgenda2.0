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
    public partial class TelaInicial : Form
    {

        Repositorio<Contato> repositorioContato = new();
        ContatoForm? telaContato;
        Repositorio<Compromisso> repositorioCompromisso = new();
        CompromissoForm? telaCompromisso;
        Repositorio<Tarefa> repositorioTarefa = new();
        TarefaForm? telaTarefa;
        public TelaInicial()
        {
            InitializeComponent();
        }


       

        private void btnContatos_Click(object sender, EventArgs e)
        {
            telaContato = new ContatoForm(repositorioContato);
            telaContato.Show();
        }

        private void btnCompromisso_Click(object sender, EventArgs e)
        {
            telaCompromisso = new CompromissoForm(repositorioCompromisso, repositorioContato);
            telaCompromisso.Show();
        }


        private void btnTarefas_Click(object sender, EventArgs e)
        {
            telaTarefa = new TarefaForm(repositorioTarefa);
            telaTarefa.Show();
        }
    }
}
