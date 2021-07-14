using System;
using Cosmos.Dependency;
using Cosmos.Sniffers.FileTypeSniffers;

namespace Autofac
{
    public static class DependencyExtensions
    {
        public static ContainerBuilder RegisterCosmosFileTypeSniffer(this ContainerBuilder builder, Action<FileTypeSnifferOptions> configure = null)
        {
            using (var register = new AutofacProxyRegister(builder))
            {
                register.AddFileTypeSniffer(configure);
            }

            return builder;
        }
    }
}