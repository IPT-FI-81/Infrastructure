using System.Threading.Tasks;
using Bijector.Infrastructure.Types.Messages;

namespace Bijector.Infrastructure.Dispatchers
{
    public interface IQueryDispatcher
    {
        Task<TResponse> QueryAsync<TResponse>(IQuery<TResponse> command);
    }
}