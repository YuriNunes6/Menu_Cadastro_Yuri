using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_Tarefas_Yuri.Model;

namespace Cadastro_Tarefas_Yuri.Controller
{
    internal class ControllerTarefa
    {
        List<ModelTarefa> listaModelTarefa = new List<ModelTarefa>();

        public void cadastroTarefas(string nomeTarefa, string statusTarefa, string dataTarefa)
        {
            if (string.IsNullOrEmpty(nomeTarefa) || string.IsNullOrEmpty(statusTarefa) || string.IsNullOrEmpty(dataTarefa) ) 
            {
                return;
            }

            ModelTarefa tarefas = new ModelTarefa(nomeTarefa, statusTarefa, dataTarefa);
            listaModelTarefa.Add(tarefas);
        }

        public List<ModelTarefa> listarTarefas()
        {
            return listaModelTarefa;
        }
    }
}
