namespace EstoqueObras.Models;

/// <summary>
/// Representa um item específico em um recebimento
/// </summary>
public class Item
{
    public int Id { get; set; }
    
    public int RecebimentoId { get; set; }
    
    public string Descricao { get; set; } = string.Empty;
    
    public string Unidade { get; set; } = string.Empty; // unidade, m², m³, etc
    
    public decimal QuantidadePedida { get; set; }
    
    public decimal QuantidadeRecebida { get; set; }
    
    public decimal PrecoUnitario { get; set; }
    
    public decimal PrecoTotal { get; set; }
    
    /// <summary>
    /// Status: OK, Divergência, Falta, Excesso
    /// </summary>
    public string Status { get; set; } = "OK";
    
    public string Observacoes { get; set; } = string.Empty;
    
    // Relacionamentos
    public Recebimento? Recebimento { get; set; }
}
