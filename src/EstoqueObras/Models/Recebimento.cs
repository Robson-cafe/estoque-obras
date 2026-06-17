namespace EstoqueObras.Models;

/// <summary>
/// Representa um recebimento de material na obra
/// </summary>
public class Recebimento
{
    public int Id { get; set; }
    
    public int ObraId { get; set; }
    
    public string NumeroNota { get; set; } = string.Empty;
    
    public string Fornecedor { get; set; } = string.Empty;
    
    public DateTime DataRecebimento { get; set; } = DateTime.UtcNow;
    
    public string ResponsavelRecebimento { get; set; } = string.Empty;
    
    public decimal ValorTotal { get; set; }
    
    public string Observacoes { get; set; } = string.Empty;
    
    /// <summary>
    /// Status: Pendente, Recebido, Divergência, Rejeitado
    /// </summary>
    public string Status { get; set; } = "Pendente";
    
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    
    public DateTime? DataSincronizacao { get; set; }
    
    // Relacionamentos
    public Obra? Obra { get; set; }
    
    public ICollection<Item> Itens { get; set; } = new List<Item>();
    
    public ICollection<Foto> Fotos { get; set; } = new List<Foto>();
    
    public ICollection<Divergencia> Divergencias { get; set; } = new List<Divergencia>();
}
