using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAgendaSolo.VariableGlobal
{
    public static class informationsAlterContato
    {

        private static string _nomeContato = null;
        private static string _telefoneContato = null;
        private static string _categoriaContato = null;
        private static string _cod_contato = null;

        public static string nome
        {
            get { return _nomeContato; }
            set
            {
                //value = value.ToUpper();
                _nomeContato = value;
            }

        }

        public static string telefone
        {
            get { return _telefoneContato; }
            set
            {
                //value = value.ToUpper();
                _telefoneContato = value;
            }

        }

        public static string categoria
        {
            get { return _categoriaContato; }
            set
            {
                //value = value.ToUpper();
                _categoriaContato = value;
            }

        }

        public static string cod_contato
        {
            get { return _cod_contato;  }
            set
            {
                _cod_contato = value;
            }
        }

    }
}
