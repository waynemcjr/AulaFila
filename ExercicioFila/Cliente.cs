using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFila
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool Prioritario { get; set; }

        public Cliente Proximo { get; set; }

        public Cliente()
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

        public void setIdade(int Idade)
        {
            this.Idade = Idade;
        }

        public int getIdade()
        {
            return this.Idade;
        }

        public void EhPrioritario()
        {
            this.Prioritario = true;
        }

        public bool getPrioritario()
        {
            return this.Prioritario;
        }
    }
}
