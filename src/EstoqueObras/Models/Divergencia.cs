namespace EstoqueObras.Models;

/// <summary>
/// Representa uma divergência identificada em um recebimento
/// </summary>
public class Divergencia
{
    public int Id { get; set; }
    
    public int RecebimentoId { get; set; }
    
    public string Tipo { get; set; } = string.Empty; // Falta, Excesso, Avaria
    
    public string Descricao { get; set; } = string.Empty;
    
    public decimal Quantidade { get; set; }
    
    public string Unidade { get; set; } = string.Empty;
    
    public decimal ValorPrejuizo { get; set; }
    
    /// <summary>
    /// Status: Aberta, Em Análise, Resolvida, Rejeitada
    /// </summary>
    public string Status { get; set; } = "Aberta";
    
    public DateTime DataIdentificacao { get; set; } = DateTime.UtcNow;
    
    public DateTime? DataResolucao { get; set; }
    
    public string ObservacaoResolucao { get; set; } = string.Empty;
    
    // Relacionamentos
    public Recebimento? Recebimento { get; set; }
}
