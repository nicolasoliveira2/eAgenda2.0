using eAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda2._0
{
    public partial class CompromissoForm : Form
    {

        Repositorio<Contato> _repositorioContato;
        Repositorio<Compromisso> _repositorioCompromisso;
        public CompromissoForm(Repositorio<Compromisso> repositorio, Repositorio<Contato> repositorioContato)
        {
            InitializeComponent();
            _repositorioCompromisso = repositorio;
            _repositorioContato = repositorioContato;
            CarregarPassados();
            CarregarFuturos();
        }



        private void btnInserirCompromisso_Click(object sender, EventArgs e)
        {
            CadastroComprimossosForm telaCompromisso = new(new Compromisso(), _repositorioContato!);
            DialogResult res = telaCompromisso.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (!VerificarHorarioValido(telaCompromisso.Compromisso))
                    return;

                string status = _repositorioCompromisso.Inserir(telaCompromisso.Compromisso);

                if (status == "REGISTRO_VALIDO")
                {

                    MessageBox.Show("Compromisso inserido com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (telaCompromisso.Compromisso.Contato != null)
                        telaCompromisso.Compromisso.Contato.EstaEmCompromisso = true;
                }
                else
                    MessageBox.Show($"{status}\nTente novamente", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CarregarPassados();
                CarregarFuturos();
            }
        }

        private void btnEditarCompromisso_Click(object sender, EventArgs e)
        {

            Compromisso? compromissoSelecionado = null;

            if (listBoxCompromissosPassados.SelectedIndex > -1)
            {
                compromissoSelecionado = (Compromisso)listBoxCompromissosPassados.SelectedItem;
            }
            else
            {
                compromissoSelecionado = (Compromisso)listBoxCompromissosFuturos.SelectedItem;
            }

            Compromisso novoCompromisso = new();

            bool temAlgo = VerificarSeTemRegistro(compromissoSelecionado, "Editar");
            if (!temAlgo)
                return;

            novoCompromisso.id = compromissoSelecionado.id;
            novoCompromisso.Assunto = compromissoSelecionado.Assunto;
            novoCompromisso.Local = compromissoSelecionado.Local;
            novoCompromisso.DataCompromisso = compromissoSelecionado.DataCompromisso;
            novoCompromisso.HoraInicio = compromissoSelecionado.HoraInicio;
            novoCompromisso.HoraFim = compromissoSelecionado.HoraFim;

            if(compromissoSelecionado.Contato != null)
            novoCompromisso.Contato = compromissoSelecionado.Contato;

            CadastroComprimossosForm telaCadCompromisso = new(novoCompromisso, _repositorioContato!);

            DialogResult resultado = telaCadCompromisso.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string status = _repositorioCompromisso.Editar(telaCadCompromisso.Compromisso, compromissoSelecionado);
                if (status == "REGISTRO_VALIDO")
                    MessageBox.Show("Compromisso editado com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"{status}\nTente novamente", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                CarregarPassados();

                CarregarFuturos();
            }
        }


        private void btnExcluirCompromisso_Click(object sender, EventArgs e)
        {
            Compromisso? compromissoSelecionado = null;

            if (listBoxCompromissosPassados.SelectedIndex > -1)
            {
                compromissoSelecionado = (Compromisso)listBoxCompromissosPassados.SelectedItem;
            }
            else
            {
                compromissoSelecionado = (Compromisso)listBoxCompromissosFuturos.SelectedItem;
            }


            bool temAlgo = VerificarSeTemRegistro(compromissoSelecionado, "Excluir");
            if (!temAlgo)
                return;

            DialogResult resultado = MessageBox.Show("Excluir compromisso?", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioCompromisso.Excluir(compromissoSelecionado);
                CarregarPassados();
                CarregarFuturos();
            }
        }

        private void CarregarFuturos()
        {
            List<Compromisso> compromissosFuturos = _repositorioCompromisso.FiltrarCompromissos(x => x.DataCompromisso > DateTime.Now);
            listBoxCompromissosFuturos.Items.Clear();
            foreach (Compromisso c in compromissosFuturos)
            {
                listBoxCompromissosFuturos.Items.Add(c);
            }
        }

        private void CarregarPassados()
        {
            List<Compromisso> compromissosPassados = _repositorioCompromisso.FiltrarCompromissos(x => x.DataCompromisso <= DateTime.Now);
            listBoxCompromissosPassados.Items.Clear();
            foreach (Compromisso c in compromissosPassados)
            {
                listBoxCompromissosPassados.Items.Add(c);
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool VerificarSeTemRegistro(Compromisso compromissoSelecionado, string tipo)
        {
            bool temAlgo = _repositorioCompromisso.RegistroExistente();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhum compromisso para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (compromissoSelecionado == null)
            {
                MessageBox.Show($"Selecione um compromisso para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        public bool VerificarHorarioValido(Compromisso compromisso)
        {
            List<Compromisso> _compromisso = _repositorioCompromisso.SelecionarTodos();
            foreach (var horarios in _compromisso)
            {
                if (horarios.DataCompromisso == compromisso.DataCompromisso)
                {
                    if (compromisso.HoraInicio >= horarios.HoraInicio && compromisso.HoraInicio <= horarios.HoraFim ||
                        compromisso.HoraFim <= horarios.HoraInicio && compromisso.HoraFim >= horarios.HoraFim)
                    {
                        MessageBox.Show("Os horários dos compromissos se batem, marcar outro horario", "Horario se batem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        private void btnFiltrarDatas_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxFiltroFim.MaskFull && maskedTextBoxFiltroInicio.MaskFull)
            {

                DateTime comeco = DateTime.Parse(maskedTextBoxFiltroInicio.Text);
                DateTime fim = DateTime.Parse(maskedTextBoxFiltroFim.Text);
                if (fim < comeco && listBoxCompromissosFuturos.Items.Count != 0)
                {
                    List<Compromisso> com = _repositorioCompromisso.FiltrarCompromissos(x => x.DataCompromisso >= comeco, x => x.DataCompromisso <= fim);
                    listBoxCompromissosFuturos.Items.Clear();
                    foreach (var compromisso in com)
                    {
                        listBoxCompromissosFuturos.Items.Add(compromisso);

                    }

                }
                else
                {
                    MessageBox.Show("ERRO!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Os dois campos precisam ser preenchidos!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void listBoxCompromissosFuturos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCompromissosFuturos.SelectedIndex > -1)
            {
                listBoxCompromissosPassados.SelectedIndex = -1;
            }
        }

        private void listBoxCompromissosPassados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCompromissosPassados.SelectedIndex > -1)
            {
                listBoxCompromissosFuturos.SelectedIndex = -1;
            }
        }
    }
}
