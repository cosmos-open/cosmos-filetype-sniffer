using Cosmos.Dependency;
using Cosmos.Sniffers.FileTypeSniffers;

namespace Autofac;

/// <summary>
/// Dependency Extensions <br />
/// 依赖扩展
/// </summary>
public static class DependencyExtensions
{
    /// <summary>
    /// Add CosmosStack FileType Sniffer Support
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="configure"></param>
    /// <returns></returns>
    public static ContainerBuilder RegisterCosmosFileTypeSniffer(this ContainerBuilder builder, Action<FileTypeSnifferOptions> configure = null)
    {
        using (var register = new AutofacProxyRegister(builder))
        {
            register.RegisterFileTypeSniffer(configure);
        }

        return builder;
    }
}