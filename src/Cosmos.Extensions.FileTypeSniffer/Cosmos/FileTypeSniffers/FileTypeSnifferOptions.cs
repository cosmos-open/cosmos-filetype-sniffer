using System;
using System.Collections.Generic;
using Cosmos.FileTypeSniffers.Core;

namespace Cosmos.FileTypeSniffers
{
    public class FileTypeSnifferOptions
    {
        private readonly List<ISniffingDescriptorProvider> _providers;

        internal IReadOnlyList<ISniffingDescriptorProvider> Providers => _providers;

        public FileTypeSnifferOptions()
        {
            _providers = new List<ISniffingDescriptorProvider>();
        }

        public List<char> Separators { get; set; }

        public void AddProvider<TProvider>(TProvider provider) where TProvider : class, ISniffingDescriptorProvider
        {
            if (provider is null)
                throw new ArgumentNullException(nameof(provider));
            _providers.Add(provider);
        }

        public void AddProvider<TProvider>() where TProvider : class, ISniffingDescriptorProvider, new()
        {
            var provider = new TProvider();
            AddProvider(provider);
        }
    }
}