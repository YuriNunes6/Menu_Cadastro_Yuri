using Cadastro_Tarefas_Yuri.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cadastro_Tarefas_Yuri.View
{
    public partial class FormFuncionarios : Form
    {
        ControllerFuncionarios controllerFuncionarios = new ControllerFuncionarios();
        DataTable tabelaFuncionarios = new DataTable();

        public FormFuncionarios()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        public void ConfigurarGrid()
        {
            dataGridViewTabelaFuncionario.DataSource = tabelaFuncionarios;
            tabelaFuncionarios.Columns.Add("Nome");
            tabelaFuncionarios.Columns.Add("Cargo");
            tabelaFuncionarios.Columns.Add("Email");
            tabelaFuncionarios.Columns.Add("ID");
            dataGridViewTabelaFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeFuncionario = txtNomeFuncionario.Text;
            string emailFuncionario = txtEmailFuncionario.Text;
            string cargoFuncionario = comboBoxCargoFuncionario.Text;
            int idFuncionario;

            if (string.IsNullOrEmpty(nomeFuncionario) ) 
            {
                MessageBox.Show("É necessário preencher o nome do funcionário para realizar o cadastro");
                return;
            }

            if (string.IsNullOrEmpty(emailFuncionario)) 
            {
                MessageBox.Show("É necessário preencher o email do funcionário para realizar o cadastro");
                return;
            }

            if (string.IsNullOrEmpty(cargoFuncionario)) 
            {
                MessageBox.Show("É necessário preencher o cargo do funcionário para realizar o cadastro");
                return;
            }

            if (!int.TryParse(txtIDFuncionario.Text, out idFuncionario)) 
            {
                MessageBox.Show("Preencha corretamente o ID do funcionário para concluir o cadastro");
                return;
            }

            controllerFuncionarios.cadastroFuncionarios(nomeFuncionario, cargoFuncionario, emailFuncionario, idFuncionario);

            var listagemFuncionarios = controllerFuncionarios.listarFuncionarios();

            tabelaFuncionarios.Rows.Clear();

            foreach (var item in listagemFuncionarios) 
            {
                tabelaFuncionarios.Rows.Add(item.nomeFuncionario, item.cargofuncionario, item.emailFuncionario, item.idFuncionario);
            }

        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormMenu menu = new FormMenu();
            //menu.Show();
        }

        private void cadastrarTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 tarefas = new Form1();
            //tarefas.Show();
        }
    }
}
