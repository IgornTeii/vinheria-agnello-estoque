using VinheriaAgnello.Models;

namespace VinheriaAgnello.Repositories;

public class VinhoRepository : IVinhoRepository
{
    private readonly List<Vinho> _vinhos = new();

    public void Adicionar(Vinho vinho) => _vinhos.Add(vinho);

    public void Atualizar(Vinho vinho)
    {
        var index = _vinhos.FindIndex(v => v.Id == vinho.Id);
        if (index >= 0) _vinhos[index] = vinho;
    }

    public void Remover(Guid id) => _vinhos.RemoveAll(v => v.Id == id);

    public Vinho? ObterPorId(Guid id) => _vinhos.FirstOrDefault(v => v.Id == id);

    public List<Vinho> ObterTodos() => _vinhos;
}