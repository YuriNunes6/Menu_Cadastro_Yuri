using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_Tarefas_Yuri.Model;

namespace Cadastro_Tarefas_Yuri.Controller
{
    public class ControllerFuncionarios
    {
        List<ModelFuncionarios> listaFuncionarios = new List<ModelFuncionarios>();
        public void cadastroFuncionarios(string nomeFuncionario, string cargoFuncionario, string emailFuncionario, int idFuncionario) 
        { 
            if (string.IsNullOrEmpty(nomeFuncionario) || string.IsNullOrEmpty(cargoFuncionario) || string.IsNullOrEmpty(emailFuncionario) || idFuncionario <= 0 ) 
            {
                return;
            }

            ModelFuncionarios funcionarios = new ModelFuncionarios(nomeFuncionario, cargoFuncionario, emailFuncionario, idFuncionario);
            listaFuncionarios.Add(funcionarios);
        }

        internal List<ModelFuncionarios> listarFuncionarios() 
        {
            return listaFuncionarios;
        
        }
    }
}
