namespace EstoqueObras.Services;

/// <summary>
/// Interface para serviço de leitura de QR Code
/// </summary>
public interface IQRCodeService
{
    /// <summary>
    /// Inicia a leitura de QR Code via câmera
    /// </summary>
    Task<string?> LerAsync();
    
    /// <summary>
    /// Valida se o código lido é válido
    /// </summary>
    Task<bool> ValidarCodigoAsync(string codigo);
}
