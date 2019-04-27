using System;
using System.Collections.Generic;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Core
{
    public abstract class FileTypeSnifferOptions
    {
        protected List<ISniffingDescriptorProvider> Providers { get; set; }

        protected FileTypeSnifferOptions()
        {
            Providers = new List<ISniffingDescriptorProvider>();
        }
        
        public List<char> Separators { get; set; }

        public void AddProvider<TProvider>(TProvider provider) where TProvider : class, ISniffingDescriptorProvider
        {
            if (provider == null)
                throw new ArgumentNullException(nameof(provider));
            Providers.Add(provider);
        }

        public void AddProvider<TProvider>() where TProvider : class, ISniffingDescriptorProvider, new()
        {
            var provider = new TProvider();
            AddProvider(provider);
        }
    }
}
