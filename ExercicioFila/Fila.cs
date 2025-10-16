using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFila
{
    public class Fila
    {

        private Cliente head;
        private Cliente tail;

        public void CriarFila()
        {
            Cliente head = null;
            Cliente tail = head;
        }

        public bool FilaVazia()
        {
            if (head == null)
                return true;
            else
                return false;
        }

        public void AdicionarClienteNaFila(Cliente elemento)
        {
            if (FilaVazia())
            {
                head = elemento;
                tail = elemento;
            }
            else
            {
                tail.Proximo = elemento;
                tail = elemento;
            }
        }

        public void AtenderCliente()
        {
            if (FilaVazia())
                Console.WriteLine("Fila vazia!");
            else
            {
                head = head.Proximo;
                if (head == null)
                    tail = null;
            }
        }

        public int TamanhoFila()
        {
            int contador = 0;
            if (FilaVazia())
            {
                return contador;
            }
            else
            {
                Cliente aux = head;
                while (aux != null)
                {
                    contador++;
                    aux = aux.Proximo;
                }
            }
            return contador;
        }

        public void MostrarFila()
        {
            if (FilaVazia())
            {
                Console.WriteLine("Fila vazia!");
            }
            else
            {
                Cliente aux = head;
                while (aux != null)
                {
                    Console.WriteLine(aux.Nome);
                    aux = aux.Proximo;
                }
            }
        }
    }
}
