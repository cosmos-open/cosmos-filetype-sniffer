using System;
using System.Collections.Generic;
using CosmosStack.Sniffers;
using CosmosStack.Sniffers.FileTypeSniffers;
using CosmosStack.Sniffers.FileTypeSniffers.Core;
using CosmosStack.Sniffers.FileTypeSniffers.Providers;
using CosmosStack.Sniffers.FileTypeSniffers.Registering;

namespace CosmosStack.Dependency
{
    /// <summary>
    /// Dependency Extensions <br />
    /// 依赖扩展
    /// </summary>
    public static class DependencyExtensions
    {
        /// <summary>
        /// Add FileType Sniffer Support
        /// </summary>
        /// <param name="register"></param>
        /// <param name="configure"></param>
        /// <typeparam name="TRegister"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
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