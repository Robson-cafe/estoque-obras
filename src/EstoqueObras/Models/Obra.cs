namespace EstoqueObras.Models;

/// <summary>
/// Representa uma obra/projeto na construção civil
/// </summary>
public class Obra
{
    public int Id { get; set; }
    
    public string NomeObra { get; set; } = string.Empty;
    
    public string Endereco { get; set; } = string.Empty;
    
    public string Cidade { get; set; } = string.Empty;
    
    public string Estado { get; set; } = string.Empty;
    
    public string Responsavel { get; set; } = string.Empty;
    
    public DateTime DataInicio { get; set; }
    
    public DateTime? DataTerminoPrevisto { get; set; }
    
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    
    public bool Ativa { get; set; } = true;
    
    // Relacionamentos
    public ICollection<Recebimento> Recebimentos { get; set; } = new List<Recebimento>();
}
