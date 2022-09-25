using System.Threading.Tasks;

namespace Shared.Infrastructure;

public interface IInitializer
{
    Task InitAsync();
}