using System;
using System.Collections.Generic;
using CosmosStack.Sniffers.FileTypeSniffers.Core;

namespace CosmosStack.Sniffers.FileTypeSniffers
{
    /// <summary>
    /// FileType Sniffer Options <br />
    /// 文件类型嗅探器选项
    /// </summary>
    public class FileTypeSnifferOptions
    {
        private readonly List<ISniffingDescriptorProvider> _providers;

        internal IReadOnlyList<ISniffingDescriptorProvider> Providers => _providers;

        public FileTypeSnifferOptions()
        {
            _providers = new List<ISniffingDescriptorProvider>();
        }

        /// <summary>
        /// Separators <br />
        /// 分隔符
        /// </summary>
        public List<char> Separators { get; set; }

        /// <summary>
        /// Add provider <br />
        /// 添加提供者程序
        /// </summary>
        /// <param name="provider"></param>
        /// <typeparam name="TProvider"></typeparam>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddProvider<TProvider>(TProvider provider) where TProvider : class, ISniffingDescriptorProvider
        {
            if (provider is null)
                throw new ArgumentNullException(nameof(provider));
            _providers.Add(provider);
        }

        /// <summary>
        /// Add provider <br />
        /// 添加提供者程序
        /// </summary>
        /// <typeparam name="TProvider"></typeparam>
        public void AddProvider<TProvider>() where TProvider : class, ISniffingDescriptorProvider, new()
        {
            var provider = new TProvider();
            AddProvider(provider);
        }
    }
}