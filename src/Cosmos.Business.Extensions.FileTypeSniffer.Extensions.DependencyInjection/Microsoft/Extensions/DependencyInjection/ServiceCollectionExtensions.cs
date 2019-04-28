using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.FileTypeSniffers;
using Cosmos.Business.Extensions.FileTypeSniffers.Core;
using Cosmos.Business.Extensions.FileTypeSniffers.Providers;
using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddFileTypeSniffer(this IServiceCollection services, Action<MSDIFileTypeSnifferOptions> optionAction = null)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            var options = new MSDIFileTypeSnifferOptions();
            optionAction?.Invoke(options);

            var descriptors = new List<IFileTypeDescriptor>();

            //To Activate default descriptor provider with registrar scanner
            var defaultProvider = new DefaultFileTypeProvider();
            descriptors.AddRange(defaultProvider.GetDescriptors());

            //To Activate custom additional descriptor provider
            foreach (var provider in options.AdditionalDescriptorProvider)
            {
                descriptors.AddRange(provider.GetDescriptors());
            }

            var sniffer = FileTypeSnifferFactory.Create(descriptors, options.Separators?.ToArray() ?? null);
            services.AddSingleton<IFileTypeSniffer>(sniffer);

            return services;
        }
    }
}
