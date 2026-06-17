namespace EstoqueObras.DTOs;

/// <summary>
/// DTO para transferência de dados de Divergência
/// </summary>
public class DivergenciaDto
{
    public int Id { get; set; }
    
    public string Tipo { get; set; } = string.Empty; // Falta, Excesso, Avaria
    
    public string Descricao { get; set; } = string.Empty;
    
    public decimal Quantidade { get; set; }
    
    public string Unidade { get; set; } = string.Empty;
    
    public decimal ValorPrejuizo { get; set; }
    
    public string Status { get; set; } = "Aberta";
    
    public DateTime DataIdentificacao { get; set; }
}
