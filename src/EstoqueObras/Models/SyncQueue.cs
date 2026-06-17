namespace EstoqueObras.Models;

/// <summary>
/// Fila de sincronização para operações offline
/// </summary>
public class SyncQueue
{
    public int Id { get; set; }
    
    public int RecebimentoId { get; set; }
    
    /// <summary>
    /// Status: Pendente, Sincronizado, Erro
    /// </summary>
    public string Status { get; set; } = "Pendente";
    
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    
    public DateTime? DataSincronizacao { get; set; }
    
    public string UltimoErro { get; set; } = string.Empty;
    
    public int TentativasSincronizacao { get; set; } = 0;
}
