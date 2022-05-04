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
    public partial class CadastroContatosForm : Form
    {
        #region Atributos
        private Contato? _contato;
        #endregion

        public CadastroContatosForm(Contato contato)
        {
            InitializeComponent();
            _contato = contato;
            if (contato != null)
            {
                textBoxNomecntt.Text = contato.Nome;
                textBoxEmailcntt.Text = contato.Email;
                textBoxTelefonecntt.Text = contato.Telefone;
                textBoxEmpresacntt.Text = contato.Empresa;
                textBoxCargocntt.Text = contato.Cargo;
            }
        }

        public Contato Contato
        {
            get { return _contato!; }
            set { _contato = value; }
        }


        private void btnInserirCntt_Click_1(object sender, EventArgs e)
        {
            _contato!.Nome = textBoxNomecntt.Text;
            _contato!.Email = textBoxEmailcntt.Text;
            _contato!.Telefone = textBoxTelefonecntt.Text;
            _contato!.Empresa = textBoxEmpresacntt.Text;
            _contato!.Cargo = textBoxCargocntt.Text;
        }

        private void btnCancelarCntt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
