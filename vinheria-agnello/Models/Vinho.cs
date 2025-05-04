namespace VinheriaAgnello.Models;

public class Vinho
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public int Safra { get; set; }
    public string PaisOrigem { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public int QuantidadeEstoque { get; set; }

    public override string ToString() =>
        $"ID: {Id}\nNome: {Nome}\nTipo: {Tipo}\nSafra: {Safra}\nOrigem: {PaisOrigem}\nPreço: R${Preco:F2}\nEstoque: {QuantidadeEstoque}\n";
}
