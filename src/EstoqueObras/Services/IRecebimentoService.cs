using EstoqueObras.DTOs;

namespace EstoqueObras.Services;

/// <summary>
/// Interface para serviço de Recebimentos
/// </summary>
public interface IRecebimentoService
{
    /// <summary>
    /// Criar novo recebimento
    /// </summary>
    Task<RecebimentoDto> CriarAsync(RecebimentoDto dto);
    
    /// <summary>
    /// Obter recebimento por ID
    /// </summary>
    Task<RecebimentoDto?> ObterPorIdAsync(int id);
    
    /// <summary>
    /// Listar recebimentos por obra
    /// </summary>
    Task<List<RecebimentoDto>> ListarPorObraAsync(string obraId);
    
    /// <summary>
    /// Atualizar recebimento
    /// </summary>
    Task<RecebimentoDto> AtualizarAsync(RecebimentoDto dto);
    
    /// <summary>
    /// Identificar divergências no recebimento
    /// </summary>
    Task<List<DivergenciaDto>> IdentificarDivergenciasAsync(RecebimentoDto dto);
}
