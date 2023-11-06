using JwtStore.Core.Contexts.AccountContext.Entities;

namespace JwtStore.Core.Contexts.AccountContext.UseCases.Authenticate.Contract;

public interface IRepository
{
    Task<User?> GetByEmailAsync(string requestEmail, CancellationToken cancellationToken);
}