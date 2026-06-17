namespace EstoqueObras.DTOs;

/// <summary>
/// DTO para transferência de dados de Recebimento
/// </summary>
public class RecebimentoDto
{
    public int Id { get; set; }
    
    public int ObraId { get; set; }
    
    public string NumeroNota { get; set; } = string.Empty;
    
    public string Fornecedor { get; set; } = string.Empty;
    
    public DateTime DataRecebimento { get; set; }
    
    public string ResponsavelRecebimento { get; set; } = string.Empty;
    
    public decimal ValorTotal { get; set; }
    
    public string Observacoes { get; set; } = string.Empty;
    
    public string Status { get; set; } = "Pendente";
    
    public List<ItemDto> Itens { get; set; } = new();
    
    public List<string> FotosBase64 { get; set; } = new();
}
