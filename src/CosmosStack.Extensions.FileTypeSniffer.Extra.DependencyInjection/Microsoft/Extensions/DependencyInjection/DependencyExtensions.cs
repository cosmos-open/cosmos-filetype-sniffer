using System;
using CosmosStack.Dependency;
using CosmosStack.Sniffers.FileTypeSniffers;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Dependency Extensions <br />
    /// 依赖扩展
    /// </summary>
    public static class DependencyExtensions
    {
        /// <summary>
        /// Add CosmosStack FileType Sniffer Support
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configure"></param>
        /// <returns></returns>
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