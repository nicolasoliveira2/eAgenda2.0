using System;
using eAgenda.Dominio;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace eAgenda2._0
{
    public partial class ContatoForm : Form
    {
        Repositorio<Contato> _repositorioContato = new();
        public ContatoForm(Repositorio<Contato> repositorio)
        {
            InitializeComponent();
            _repositorioContato = repositorio;
            MostrarContatosNaTela();
        }

        

        private void btnInserirContato_Click(object sender, EventArgs e)
        {
            CadastroContatosForm telaCadContato = new(new Contato());

            DialogResult res = telaCadContato.ShowDialog();

            if (res == DialogResult.OK)
            {
                Contato descriocaCntt = telaCadContato.Contato;
                bool tituloNovo = VerificarExistentente(descriocaCntt);
                if (!tituloNovo)
                    return;

                string status = _repositorioContato.Inserir(telaCadContato.Contato);

                if (status.Trim() == "REGISTRO_VALIDO")
                    MessageBox.Show("Contato cadastrado com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"{status}\nTente novamente", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MostrarContatosNaTela();
            }
        }

        private void btnEditarContato_Click(object sender, EventArgs e)
        {

            Contato contatoSelecionado = (Contato)listBoxContatos.SelectedItem;

            bool temRegistro = VerificarSeTemRegistro(contatoSelecionado, "Editar");
            if (!temRegistro)
                return;

            Contato novoContato = new();

            novoContato.id = contatoSelecionado.id;
            novoContato.Nome = contatoSelecionado.Nome;
            novoContato.Email = contatoSelecionado.Email;
            novoContato.Telefone = contatoSelecionado.Telefone;
            novoContato.Empresa = contatoSelecionado.Empresa;
            novoContato.Cargo = contatoSelecionado.Cargo;

           
            CadastroContatosForm telaCadastro = new(novoContato);

            DialogResult resultado = telaCadastro.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                string status = _repositorioContato.Editar(novoContato, contatoSelecionado);
                if(status == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Contato editado com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MostrarContatosNaTela();
                }
                else
                {
                    MessageBox.Show($"{status}\nTente novamente", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MostrarContatosNaTela();
                }
            }

        }

        private void btnExcluirContato_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listBoxContatos.SelectedItem;

            if (contatoSelecionado.EstaEmCompromisso)
            {
                MessageBox.Show("O contato está presente em um compromisso, não é possível excluir", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool temRegistro = VerificarSeTemRegistro(contatoSelecionado, "Excluir");
            if (!temRegistro)
                return;

            DialogResult resultado = MessageBox.Show("Excluir contato?", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            
            if(resultado == DialogResult.OK)
            {
                _repositorioContato.Excluir(contatoSelecionado);
                MostrarContatosNaTela();
            }
        }

        private void bntMostrarSemOrdem_Click(object sender, EventArgs e)
        {
            MostrarContatosNaTela();
        }

        private void bntMostrarOrdenado_Click(object sender, EventArgs e)
        {
            MostrarContatosNaTelaPorCargo();
        }

        private void MostrarContatosNaTelaPorCargo()
        {
            List<Contato> contatos = _repositorioContato.SelecionarTodos();
            listBoxContatos.Items.Clear();

            foreach (Contato c in contatos)           
               listBoxContatos.Items.Add(c);
            
        }

        private void bntSairContato_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarContatosNaTela()
        {
            List<Contato> contatos = _repositorioContato.SelecionarTodos();
            listBoxContatos.Items.Clear();
            foreach (Contato c in contatos)
            {
                listBoxContatos.Items.Add(c);
            }
        }

        private bool VerificarSeTemRegistro(Contato contatoSelecionado, string tipo)
        {
            bool temAlgo = _repositorioContato.RegistroExistente();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhum contato para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (contatoSelecionado == null)
            {
                MessageBox.Show($"Selecione um contato para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private bool VerificarExistentente(Contato temp)
        {
            List<Contato> todosContatos = _repositorioContato.SelecionarTodos();

            foreach (Contato contatoJaRegistrado in todosContatos)
            {
                if (contatoJaRegistrado.Nome == temp.Nome)
                {
                    MessageBox.Show("O Nome do contato já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (contatoJaRegistrado.Email == temp.Email)
                {
                    MessageBox.Show("O Email do contato já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (contatoJaRegistrado.Telefone == temp.Telefone)
                {
                    MessageBox.Show("O Telefone do contato já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }


    }
}
