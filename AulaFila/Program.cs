using AulaFila;

int opcao;
Fila f = new Fila();
Pessoa head = new Pessoa();
Pessoa tail = new Pessoa();
Pessoa aux = new Pessoa();
f.CriarFila();

do
{
    Console.WriteLine("\nInforme o que você deseja fazer na fila: ");
    Console.WriteLine("1 - Verificar se a fila está vazia");
    Console.WriteLine("2 - Inserir pessoa");
    Console.WriteLine("3 - Remover pessoa");
    Console.WriteLine("4 - Veirificar tamanho da fila");
    Console.WriteLine("5 - Imprimir Fila");
    Console.WriteLine("6 - Sair");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            if (f.FilaVazia(head))
            {
                Console.WriteLine("A fila não está vazia1");
            }
            else
            {
                Console.WriteLine("A fila está vazia!");
            }
                break;
        case 2:
            Pessoa pessoa = new Pessoa();

            Console.Write("Informe o nome da pessoa: ");
            pessoa.setNome(Console.ReadLine()!);
            f.InserirPessoa(pessoa, tail, head);
            break;
        case 3:
            f.RemoverPessoa(head, tail);
            break;
        case 4:
            Console.WriteLine($"Tamanho da fila: { f.TamanhoFila(head)}");
            break;
        case 5:
            f.ImprimirFila(head);
            break;
        default:
            Console.WriteLine("Informe uma opção válida entre 1 e 6");
            break;
    }
} while (opcao != 6);