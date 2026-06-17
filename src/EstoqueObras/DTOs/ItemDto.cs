namespace EstoqueObras.DTOs;

/// <summary>
/// DTO para transferência de dados de Item
/// </summary>
public class ItemDto
{
    public int Id { get; set; }
    
    public string Descricao { get; set; } = string.Empty;
    
    public string Unidade { get; set; } = string.Empty;
    
    public decimal QuantidadePedida { get; set; }
    
    public decimal QuantidadeRecebida { get; set; }
    
    public decimal PrecoUnitario { get; set; }
    
    public decimal PrecoTotal { get; set; }
    
    public string Status { get; set; } = "OK";
    
    public string Observacoes { get; set; } = string.Empty;
}
