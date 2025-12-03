using Cadastro_Tarefas_Yuri.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Tarefas_Yuri
{
    public partial class FormMenu : Form
    {
        Form1 formCadastroTarefas = new Form1();
        FormFuncionarios formFuncionarios = new FormFuncionarios();
        
        public FormMenu()
        {
            InitializeComponent();
        }

        private void cadastroTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroTarefas.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFuncionarios.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
