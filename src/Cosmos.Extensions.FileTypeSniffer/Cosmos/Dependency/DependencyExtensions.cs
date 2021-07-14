using System;
using System.Collections.Generic;
using Cosmos.Sniffers;
using Cosmos.Sniffers.FileTypeSniffers;
using Cosmos.Sniffers.FileTypeSniffers.Core;
using Cosmos.Sniffers.FileTypeSniffers.Providers;
using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Dependency
{
    public static class DependencyExtensions
    {
        public static TRegister AddFileTypeSniffer<TRegister>(this TRegister register, Action<FileTypeSnifferOptions> configure = null)
            where TRegister : DependencyProxyRegister
        {
            if (register is null)
                throw new ArgumentNullException(nameof(register));

            var options = new FileTypeSnifferOptions();
            configure?.Invoke(options);

            var descriptors = new List<IFileTypeDescriptor>();

            //To Activate default descriptor provider with registrar scanner
            var defaultProvider = new DefaultFileTypeProvider();
            descriptors.AddRange(defaultProvider.GetDescriptors());

            //To Activate custom additional descriptor provider
            foreach (var provider in options.Providers)
            {
                descriptors.AddRange(provider.GetDescriptors());
            }

            var sniffer = FileTypeSnifferFactory.Create(descriptors, options.Separators?.ToArray());

            register.AddSingleton<IFileTypeSniffer, FileTypeSniffer>(sniffer);

            return register;
        }
    }
}