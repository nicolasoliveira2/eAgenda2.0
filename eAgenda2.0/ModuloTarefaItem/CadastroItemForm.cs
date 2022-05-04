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
    public partial class CadastroItemForm : Form
    {
        public Tarefa? _tarefa;
        public List<Item> _itensAdicionados = new List<Item>();
        public CadastroItemForm(Tarefa tarefa)
        {
            InitializeComponent();
            _tarefa = tarefa;
            if (_tarefa != null)
            {
                labelTarefaSelecionada.Text = _tarefa.Titulo;
                foreach (Item item in tarefa.Itens)
                {
                    listBoxItensTarefa.Items.Add(item);
                }
            }
        }
        public List<Item> ItensAdicionados
        {
            get { return _itensAdicionados; }
        }


        private void btnInserirNomeItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNomeItem.Text))
            {
                List<string> titulos = listBoxItensTarefa.Items.Cast<Item>().ToList().Select(x => x.Titulo).ToList();
                if (titulos.Count == 0 || titulos.Contains(textBoxNomeItem.Text) == false)
                {
                    Item itemTarefa = new();

                    itemTarefa.Titulo = textBoxNomeItem.Text;

                    listBoxItensTarefa.Items.Add(itemTarefa);

                    ItensAdicionados.Add(itemTarefa);
                }
                else
                {
                    MessageBox.Show("Não pode inserir itens com o mesmo nome", "Itens",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Não pode inserir itens sem um título", "Itens", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxNomeItem.Clear();
            textBoxNomeItem.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
