using VinheriaAgnello.Repositories;
using VinheriaAgnello.Services;

namespace VinheriaAgnello;

internal class Program
{
    static void Main()
    {
        var estoque = new EstoqueService(new VinhoRepository());
        string? opcao;

        do
        {
            Console.WriteLine("\n===== VINHERIA AGNELLO =====");
            Console.WriteLine("1 - Cadastrar vinho");
            Console.WriteLine("2 - Listar vinhos");
            Console.WriteLine("3 - Editar vinho");
            Console.WriteLine("4 - Remover vinho");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": estoque.CadastrarVinho(); break;
                case "2": estoque.ListarVinhos(); break;
                case "3": estoque.EditarVinho(); break;
                case "4": estoque.RemoverVinho(); break;
                case "0": Console.WriteLine("👋 Tchau!"); break;
                default: Console.WriteLine("❌ Opção inválida."); break;
            }
        } while (opcao != "0");
    }
}
