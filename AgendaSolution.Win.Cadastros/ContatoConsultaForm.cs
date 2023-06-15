using AgendaSolution.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSolution.Win.Cadastros
{
    public partial class ContatoConsultaForm : Form
    {
        private List<Contato> contatos = new List<Contato>();


        public ContatoConsultaForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void novoButton2_Click(object sender, EventArgs e)
        {
            var newContato = ContatoCadastroForm.Incluir();
            if (newContato != null)
            {
                contatos.Add(newContato);
                ConsultarImpl();
            }
        }

        private void ContatoConsultaForm_Load(object sender, EventArgs e)
        {

        }

        private void consultaButton1_Click(object sender, EventArgs e)
        {

            ConsultarImpl();
        }


        private void ConsultarImpl()
        {
            contatoBindingSource.DataSource = contatos;
            dataGridView1.Refresh();
        }

        private void alterarToolStripButton1_Click(object sender, EventArgs e)
        {
            if (contatos.Count <= 0) return;

            var contato = (Contato)contatoBindingSource.Current;
            ContatoCadastroForm.Alterar(contato);
            ConsultarImpl();

        }
    }
}
