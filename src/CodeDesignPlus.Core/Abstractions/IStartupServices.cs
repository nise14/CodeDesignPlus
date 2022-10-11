using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodeDesignPlus.Core.Abstractions
{
    public interface IStartupServices
    {
        void Initialize(IServiceCollection services, IConfiguration configuration);
    }
}