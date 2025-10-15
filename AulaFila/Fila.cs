using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaFila
{
    public class Fila
    {
        public void CriarFila()
        {
            Pessoa head = null;
            Pessoa tail = head;
        }

        public bool FilaVazia(Pessoa head)
        {
            if (head == null)
                return true;
            else
                return false;
        }

        public void InserirPessoa(Pessoa elemento, Pessoa h, Pessoa t)
        {
            if (FilaVazia(h))
            {
                h = elemento;
                t = elemento;
            }
            else
            {
                t.Proximo = elemento;
                t = elemento;
            }
        }

        public void RemoverPessoa(Pessoa h, Pessoa t)
        {
            if (FilaVazia(h))
                Console.WriteLine("Fila vazia!");
            else
            {
                h = h.Proximo;
                if (h == null)
                    t = null;
            }
        }

        public int TamanhoFila(Pessoa h)
        {
            int contador = 0;
            if (FilaVazia(h))
            {
                return contador;
            }
            else
            {
                Pessoa aux = h;
                do
                {
                    contador++;
                    aux = aux.Proximo;
                } while (aux.Proximo != null);
            }
            return contador;
        }

        public void ImprimirFila(Pessoa h)
        {
            if (FilaVazia(h))
            {
                Console.WriteLine("Fila vazia!");
            }
            else
            {
                Pessoa aux = h;
                while (aux != null)
                {
                    Console.WriteLine(aux.Nome);
                    aux = aux.Proximo;
                }
            }
        }
    }
}