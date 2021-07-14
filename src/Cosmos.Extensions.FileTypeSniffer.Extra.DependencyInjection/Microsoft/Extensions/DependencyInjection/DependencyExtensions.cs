using System;
using Cosmos.Dependency;
using Cosmos.Sniffers.FileTypeSniffers;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyExtensions
    {
        public static IServiceCollection AddCosmosFileTypeSniffer(this IServiceCollection services, Action<FileTypeSnifferOptions> configure = null)
        {
            using (var register = new MicrosoftProxyRegister(services))
            {
                register.AddFileTypeSniffer(configure);
            }

            return services;
        }
    }
}