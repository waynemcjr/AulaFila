using AulaFila;

int opcao;
Fila f = new Fila();
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
            if (f.FilaVazia())
            {
                Console.WriteLine("A fila está vazia!");
            }
            else
            {
                Console.WriteLine("A fila não está vazia!");
            }
            break;
        case 2:
            Pessoa pessoa = new Pessoa();

            Console.Write("Informe o nome da pessoa: ");
            pessoa.setNome(Console.ReadLine()!);
            f.InserirPessoa(pessoa);
            break;
        case 3:
            f.RemoverPessoa();
            break;
        case 4:
            Console.WriteLine($"Tamanho da fila: {f.TamanhoFila()}");
            break;
        case 5:
            f.ImprimirFila();
            break;
        default:
            break;
    }
} while (opcao != 6);