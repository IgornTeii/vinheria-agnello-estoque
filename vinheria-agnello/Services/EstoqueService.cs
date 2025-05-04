using VinheriaAgnello.Models;
using VinheriaAgnello.Repositories;

namespace VinheriaAgnello.Services;

public class EstoqueService
{
    private readonly IVinhoRepository _repositorio;

    public EstoqueService(IVinhoRepository repositorio)
    {
        _repositorio = repositorio;
    }

    public void CadastrarVinho()
    {
        var vinho = new Vinho();

        Console.Write("Nome: "); vinho.Nome = Console.ReadLine() ?? "";
        Console.Write("Tipo (Tinto/Branco/Rosé): "); vinho.Tipo = Console.ReadLine() ?? "";
        Console.Write("Safra: "); vinho.Safra = int.Parse(Console.ReadLine()!);
        Console.Write("Origem: "); vinho.PaisOrigem = Console.ReadLine() ?? "";
        Console.Write("Preço: R$ "); vinho.Preco = decimal.Parse(Console.ReadLine()!);
        Console.Write("Quantidade: "); vinho.QuantidadeEstoque = int.Parse(Console.ReadLine()!);

        _repositorio.Adicionar(vinho);
        Console.WriteLine("✅ Vinho cadastrado!");
    }

    public void ListarVinhos()
    {
        var vinhos = _repositorio.ObterTodos();
        if (vinhos.Count == 0) Console.WriteLine("📦 Estoque vazio.");
        else vinhos.ForEach(v => Console.WriteLine(v));
    }

    public void EditarVinho()
    {
        Console.Write("ID do vinho: ");
        if (!Guid.TryParse(Console.ReadLine(), out var id)) return;
        var vinho = _repositorio.ObterPorId(id);
        if (vinho == null) { Console.WriteLine("❌ Não encontrado."); return; }

        Console.WriteLine("Deixe vazio para manter o atual.");
        Console.Write($"Nome ({vinho.Nome}): "); var nome = Console.ReadLine();
        Console.Write($"Tipo ({vinho.Tipo}): "); var tipo = Console.ReadLine();
        Console.Write($"Safra ({vinho.Safra}): "); var safraStr = Console.ReadLine();
        Console.Write($"Origem ({vinho.PaisOrigem}): "); var origem = Console.ReadLine();
        Console.Write($"Preço (R${vinho.Preco}): "); var precoStr = Console.ReadLine();
        Console.Write($"Quantidade ({vinho.QuantidadeEstoque}): "); var qtdStr = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(nome)) vinho.Nome = nome;
        if (!string.IsNullOrWhiteSpace(tipo)) vinho.Tipo = tipo;
        if (int.TryParse(safraStr, out var safra)) vinho.Safra = safra;
        if (!string.IsNullOrWhiteSpace(origem)) vinho.PaisOrigem = origem;
        if (decimal.TryParse(precoStr, out var preco)) vinho.Preco = preco;
        if (int.TryParse(qtdStr, out var qtd)) vinho.QuantidadeEstoque = qtd;

        _repositorio.Atualizar(vinho);
        Console.WriteLine("✏️ Atualizado com sucesso!");
    }

    public void RemoverVinho()
    {
        Console.Write("ID para remover: ");
        if (!Guid.TryParse(Console.ReadLine(), out var id)) return;
        _repositorio.Remover(id);
        Console.WriteLine("🗑️ Vinho removido.");
    }
}