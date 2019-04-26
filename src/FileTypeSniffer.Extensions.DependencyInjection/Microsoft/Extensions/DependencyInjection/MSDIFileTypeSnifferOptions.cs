using System.Collections.Generic;
using Cosmos.Business.FileTypeSniffers.Core;

namespace Microsoft.Extensions.DependencyInjection
{
    // ReSharper disable once InconsistentNaming
    public class MSDIFileTypeSnifferOptions : FileTypeSnifferOptions
    {
        internal IReadOnlyList<ISniffingDescriptorProvider> AdditionalDescriptorProvider => Providers;
    }
}
