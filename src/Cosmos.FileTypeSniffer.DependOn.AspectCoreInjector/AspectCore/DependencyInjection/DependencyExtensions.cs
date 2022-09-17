using Cosmos.Dependency;
using Cosmos.Sniffers.FileTypeSniffers;

namespace AspectCore.DependencyInjection;

/// <summary>
/// Dependency Extensions <br />
/// 依赖扩展
/// </summary>
public static class DependencyExtensions
{
    /// <summary>
    /// Add CosmosStack FileType Sniffer Support
    /// </summary>
    /// <param name="context"></param>
    /// <param name="configure"></param>
    /// <returns></returns>
    public static IServiceContext AddCosmosFileTypeSniffer(this IServiceContext context, Action<FileTypeSnifferOptions> configure = null)
    {
        using (var register = new AspectCoreProxyRegister(context))
        {
            register.RegisterFileTypeSniffer(configure);
        }

        return context;
    }
}