using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Tarefas_Yuri.Model
{
    internal class ModelTarefa
    {
        public string nomeTarefa;
        public string statusTarefa;
        public string dataTarefa;

        public ModelTarefa(string nomeTarefa, string statusTarefa, string dataTarefa) {
        
            this.nomeTarefa = nomeTarefa;
            this.statusTarefa = statusTarefa;
            this.dataTarefa = dataTarefa;
        }
    }
}
