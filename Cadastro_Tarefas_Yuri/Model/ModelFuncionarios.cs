using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Tarefas_Yuri.Model
{
    internal class ModelFuncionarios
    {
        public string nomeFuncionario;
        public string cargofuncionario;
        public string emailFuncionario;
        public int idFuncionario;

        public ModelFuncionarios(string nomeFuncionario, string cargoFuncionario, string emailFuncionario, int idFuncionario) {
            this.nomeFuncionario = nomeFuncionario;
            this.cargofuncionario = cargoFuncionario;
            this.emailFuncionario = emailFuncionario;
            this.idFuncionario = idFuncionario;
        
        }
    }
}
