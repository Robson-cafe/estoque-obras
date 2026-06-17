namespace EstoqueObras.Models;

/// <summary>
/// Representa uma foto associada a um recebimento
/// </summary>
public class Foto
{
    public int Id { get; set; }
    
    public int RecebimentoId { get; set; }
    
    public string CaminhoArquivo { get; set; } = string.Empty;
    
    public byte[] DadosImagem { get; set; } = Array.Empty<byte>();
    
    public string Descricao { get; set; } = string.Empty;
    
    public DateTime DataCaptura { get; set; } = DateTime.UtcNow;
    
    // Relacionamentos
    public Recebimento? Recebimento { get; set; }
}
