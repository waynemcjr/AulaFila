using System.Runtime.InteropServices;
using ExercicioFila;

Fila filaNormal = new Fila();
Fila filaPrioritaria = new Fila();
int opcao, prioritario;

do
{
    Console.WriteLine("\nOpção 1 - Adicionar cliente a fila");
    Console.WriteLine("Opção 2 - Verificar se a fila está vazia");
    Console.WriteLine("Opção 3 - Exibir fila");
    Console.WriteLine("Opção 4 - Atender próximo cliente");
    Console.WriteLine("Opção 5 - Remover o próximo cliente a ser atendido");
    Console.WriteLine("Opção 6 - Sair");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Cliente cliente = new Cliente();

            Console.Write("Informe o nome do cliente: ");
            cliente.setNome(Console.ReadLine()!);
            Console.Write("Informe a idade do cliente: ");
            cliente.setIdade(Convert.ToInt32(Console.ReadLine()));

            do
            {
                Console.Write("Informe se o cliente é prioritário (1 - Sim ou 2 - Não): ");
                prioritario = Convert.ToInt32(Console.ReadLine());
            } while (prioritario != 1 && prioritario != 2);

            if(prioritario == 1)
            {
                //cliente.setPrioritario = true;
                filaPrioritaria.AdicionarClienteNaFila(cliente);
            }
            else
            {
                //cliente.setPrioritario = true;
                filaNormal.AdicionarClienteNaFila(cliente);
            }
                break;
        case 2:
            if(filaNormal.FilaVazia() == true && filaPrioritaria.FilaVazia() == true)
            {
                Console.WriteLine("A fila está vazia!");
            }
            else
            {
                Console.WriteLine("A fila não está vazia");
            }
                break;
        case 3:
            Console.WriteLine("Fila não prioritária: \n");
            filaNormal.MostrarFila();
            Console.WriteLine("\nFila prioritária: \n");
            filaPrioritaria.MostrarFila();
            break;
        case 4:
            if (filaNormal.TamanhoFila() % 3 >= 0 && filaNormal.TamanhoFila() % 3 <=2)
            {
                filaNormal.AtenderCliente();
                Console.WriteLine("Cliente não prioritário atendido!");
            }else{
                filaPrioritaria.AtenderCliente();
                Console.WriteLine("Cliente prioritário atendido!");
            }
                break;
        case 5:
            if (filaNormal.TamanhoFila() % 3 >= 0 && filaNormal.TamanhoFila() % 3 <= 2)
            {
                filaNormal.AtenderCliente();
                Console.WriteLine("Cliente não prioritário removido!");
            }
            else
            {
                filaPrioritaria.AtenderCliente();
                Console.WriteLine("Cliente prioritário removido!");
            }
            break;
        default:
            break;
    }
} while (opcao != 6);

Console.WriteLine("Saindo...");