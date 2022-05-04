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
    public partial class CadastroComprimossosForm : Form
    {
        
        Repositorio<Contato> _repositorioContato;
        Compromisso? _compromisso;
        public CadastroComprimossosForm( Compromisso compromissoVazio, Repositorio<Contato> repositorioContato)
        {
            InitializeComponent();
            _compromisso = compromissoVazio;
            _repositorioContato = repositorioContato;

            List<Contato> contatos = _repositorioContato.SelecionarTodos();

            comboBoxContato.Items.Clear();
            foreach (Contato c in contatos)
            {
                comboBoxContato.Items.Add(c);
            }

            if (_compromisso != null)
            {
                TBAssuntoCompromisso.Text = _compromisso.Assunto;
                TBLocarCompromisso.Text = _compromisso.Local;
                maskedTextBoxData.Text = _compromisso.DataCompromisso.ToString();
                maskedTextBoxHoraInicio.Text = _compromisso.HoraInicio.ToString();
                maskedTextBoxHoraFim.Text = _compromisso.HoraFim.ToString();
                if (_compromisso.Contato.RetornarNome() != null)
                    comboBoxContato.Text = _compromisso.Contato.RetornarNome();
            }
        }

        public Compromisso Compromisso
        {
            get { return _compromisso!; }
            set { _compromisso = value; }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            _compromisso!.Assunto = TBAssuntoCompromisso.Text;
            _compromisso.Local = TBLocarCompromisso.Text;
            _compromisso.DataCompromisso = DateTime.Parse(maskedTextBoxData.Text);
            _compromisso.HoraInicio = TimeSpan.Parse(maskedTextBoxHoraInicio.Text);
            _compromisso.HoraFim = TimeSpan.Parse(maskedTextBoxHoraFim.Text);

            comboBoxContato.Items.Insert(0, "(nenhum contato)");
            if (comboBoxContato.SelectedItem == null)
            {
                comboBoxContato.SelectedItem = _compromisso.Contato;
            }
              _compromisso.Contato = (Contato)comboBoxContato.SelectedItem;
               
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
