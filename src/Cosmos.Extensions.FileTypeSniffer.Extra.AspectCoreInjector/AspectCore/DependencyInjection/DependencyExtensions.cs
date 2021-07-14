using System;
using Cosmos.Dependency;
using Cosmos.Sniffers.FileTypeSniffers;

namespace AspectCore.DependencyInjection
{
    public static class DependencyExtensions
    {
        public static IServiceContext AddCosmosFileTypeSniffer(this IServiceContext context, Action<FileTypeSnifferOptions> configure = null)
        {
            using (var register = new AspectCoreProxyRegister(context))
            {
                register.AddFileTypeSniffer(configure);
            }

            return context;
        }
    }
}