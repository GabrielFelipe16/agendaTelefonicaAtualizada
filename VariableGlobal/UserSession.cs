using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAgendaSolo.VariableGlobal
{
    //publico para que todos possam acessar
    //estico para que todos usem a mesma classe
    public static class UserSession
    {
        //as variaveis que irão guardar as informações do usuario logado 
        private static string _usuario = null;
        private static string _senha = null;
        private static string _nome = null;

        //encapsulei a variavel para ter controle
        //o que sera inserido eu pego
        public static string usuario
        {
            get { return _usuario; }
            set
            {
                //value = value.ToUpper();
                _usuario = value;
            }

        }

        public static string senha
        {
            get { return _senha; }
            set
            {
                _senha = value;
            }
        }

        public static string nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
            }
        }
    }
}
