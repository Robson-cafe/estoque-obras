namespace EstoqueObras.Services;

/// <summary>
/// Interface para serviço de sincronização
/// </summary>
public interface ISyncService
{
    /// <summary>
    /// Sincronizar dados com servidor
    /// </summary>
    Task SincronizarAsync();
    
    /// <summary>
    /// Enfileirar recebimento para sincronização
    /// </summary>
    Task EnfileirarAsync(int recebimentoId);
    
    /// <summary>
    /// Obter status de sincronização
    /// </summary>
    Task<SyncStatusDto> ObterStatusAsync();
}

public class SyncStatusDto
{
    public int PendentesSync { get; set; }
    
    public int ErrosSync { get; set; }
    
    public DateTime? UltimaSincronizacao { get; set; }
}
