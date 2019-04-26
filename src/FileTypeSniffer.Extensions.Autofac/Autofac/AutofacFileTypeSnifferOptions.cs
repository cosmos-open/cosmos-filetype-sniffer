using System.Collections.Generic;
using Cosmos.Business.FileTypeSniffers.Core;

namespace Autofac
{
    public class AutofacFileTypeSnifferOptions : FileTypeSnifferOptions
    {
        internal IReadOnlyList<ISniffingDescriptorProvider> AdditionalDescriptorProvider => Providers;
    }
}
