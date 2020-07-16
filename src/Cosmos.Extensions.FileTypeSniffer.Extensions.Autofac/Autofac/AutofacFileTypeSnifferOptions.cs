using System.Collections.Generic;
using Cosmos.FileTypeSniffers.Core;

namespace Autofac
{
    public class AutofacFileTypeSnifferOptions : FileTypeSnifferOptions
    {
        internal IReadOnlyList<ISniffingDescriptorProvider> AdditionalDescriptorProvider => Providers;
    }
}
