using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaFila
{
    public class Pessoa
    {

        public string Nome { get; set; }
        public Pessoa Proximo { get; set; }

        public Pessoa()
        {
            this.Proximo = null;
        }

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }
        public string getNome()
        {
            return this.Nome;
        }
    }
}
