using Cadastro_Tarefas_Yuri.Controller;
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
    public partial class Form1 : Form
    {
        ControllerTarefa controllerTarefas = new ControllerTarefa();
        ControllerFuncionarios controllerFuncionarios = new ControllerFuncionarios();
        DataTable tabelaTarefas = new DataTable();   
        
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        public void ConfigurarGrid()
        {
            dataGridViewTarefas.DataSource = tabelaTarefas;
            tabelaTarefas.Columns.Add("Nome da Tarefa");
            tabelaTarefas.Columns.Add("Status");
            tabelaTarefas.Columns.Add("Data");
            dataGridViewTarefas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nomeTarefa = txtNomeTarefa.Text;
            string statusTarefa = boxStatusTarefa.Text;
            string dataTarefa = dateTimeTarefa.Text;


            if (string.IsNullOrEmpty(nomeTarefa))
            {
                MessageBox.Show("Por favor, preencha o nome da tarefa.");
                return;
            }

            if (string.IsNullOrEmpty(statusTarefa))
            {
                MessageBox.Show("Por favor, preencha o status da tarefa.");
                return;
            }

            if (string.IsNullOrEmpty(dataTarefa))
            {
                MessageBox.Show("Por favor, preencha a data da tarefa.");
                return;
            }

            if (string.IsNullOrEmpty(dataTarefa))
            {
                MessageBox.Show("Por favor, informe o nome do funcionário.");
                return;
            }

            controllerTarefas.cadastroTarefas(nomeTarefa, statusTarefa, dataTarefa);

            var listagem = controllerTarefas.listarTarefas();

            tabelaTarefas.Rows.Clear();

            foreach (var item in listagem)
            {
                tabelaTarefas.Rows.Add(item.nomeTarefa, item.statusTarefa, item.dataTarefa);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cadastrarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void telaInicialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormMenu formMenu_Tarefas = new FormMenu();
            formMenu_Tarefas.Show();
        }

        private void cadastrarFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionarios formFuncionarios_Tarefas = new FormFuncionarios();
            formFuncionarios_Tarefas.Show();
        }
    }
}
