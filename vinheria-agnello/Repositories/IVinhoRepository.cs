using VinheriaAgnello.Models;

namespace VinheriaAgnello.Repositories;

public interface IVinhoRepository
{
    void Adicionar(Vinho vinho);
    void Atualizar(Vinho vinho);
    void Remover(Guid id);
    Vinho? ObterPorId(Guid id);
    List<Vinho> ObterTodos();
}