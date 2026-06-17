# Contribuindo para Estoque Obras

Obrigado por considerar contribuir para o **Estoque Obras**! Este documento fornece orientações e instruções.

## Código de Conduta

Este projeto e todos os participantes estão sujeitos ao nosso Código de Conduta. Ao participar, você concorda em cumprir este código.

## Como Contribuir

### 1. Relatar Bugs

Se você encontrou um bug, crie uma issue com:

- **Descrição clara** do problema
- **Passos para reproduzir**
- **Comportamento esperado** vs **comportamento real**
- **Screenshots** (se aplicável)
- **Ambiente**: OS, versão .NET, versão do app

### 2. Sugerir Melhorias

Melhorias são sempre bem-vindas! Crie uma issue descrevendo:

- **Use case**: Por que essa melhoria é útil?
- **Solução proposta**: Como deveria funcionar?
- **Alternativas**: Você considerou outras abordagens?

### 3. Desenvolver Código

#### Setup de Desenvolvimento

```bash
# Clonar repositório
git clone https://github.com/Robson-cafe/estoque-obras.git
cd estoque-obras

# Criar branch de feature
git checkout -b feature/sua-feature

# Instalar workload MAUI
dotnet workload install maui

# Restaurar dependências
dotnet restore
```

#### Padrões de Código

- **Linguagem**: C# (padrões Microsoft)
- **Nomeação**: PascalCase para classes, camelCase para variáveis
- **Comentários**: XML docs para métodos públicos
- **Formatação**: Use `dotnet format` antes de commit

```csharp
/// <summary>
/// Descrição breve do método
/// </summary>
/// <param name="parametro">Descrição do parâmetro</param>
/// <returns>Descrição do retorno</returns>
public async Task<bool> MeuMetodoAsync(string parametro)
{
    // Implementação
}
```

#### Estrutura de Branches

```
main/
├── develop/
│   ├── feature/ISSUE-numero-descricao
│   ├── bugfix/ISSUE-numero-descricao
│   └── refactor/ISSUE-numero-descricao
```

#### Commits

Usar padrão Conventional Commits:

```
feat: adiciona leitura de código de barras
fix: corrige sincronização offline
docs: atualiza README com instruções
tests: adiciona testes para RecebimentoService
refactor: reorganiza estrutura de pastas
chore: atualiza dependências
```

### 4. Pull Requests

1. **Fork** o repositório
2. **Crie uma branch** com nome descritivo
3. **Faça commits** pequenos e bem descritos
4. **Adicione testes** para novas funcionalidades
5. **Atualize documentação** se necessário
6. **Abra um PR** com descrição clara

#### Template de PR

```markdown
## Descrição
Brevemente descreva as mudanças.

## Tipo de Mudança
- [ ] Bug fix
- [ ] Nova funcionalidade
- [ ] Breaking change
- [ ] Atualização de documentação

## Como foi testado?
Descreva os testes realizados.

## Checklist
- [ ] Código segue padrões do projeto
- [ ] Testes adicionados/atualizados
- [ ] Documentação atualizada
- [ ] Sem warnings no build
```

## Processo de Review

1. **Code Review**: Mínimo 1 aprovação
2. **Testes**: Todos devem passar
3. **Coverage**: Manter acima de 80%
4. **CI/CD**: Sem erros em pipeline

## Enviando suas Mudanças

```bash
# Ensure your branch is updated
git pull origin develop

# Format code
dotnet format

# Run tests
dotnet test

# Push
git push origin feature/sua-feature
```

## Dúvidas?

- 📧 Email: suporte@estoqueobrascivil.com
- 💬 Discussões: [GitHub Discussions](https://github.com/Robson-cafe/estoque-obras/discussions)
- 🐛 Issues: [GitHub Issues](https://github.com/Robson-cafe/estoque-obras/issues)

---

**Obrigado por contribuir para melhorar o Estoque Obras!** 🚀
