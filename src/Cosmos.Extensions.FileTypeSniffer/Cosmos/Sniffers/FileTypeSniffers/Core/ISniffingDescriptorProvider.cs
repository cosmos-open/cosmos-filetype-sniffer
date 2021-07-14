using System.Collections.Generic;
using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Core
{
    public interface ISniffingDescriptorProvider
    {
        IEnumerable<IFileTypeDescriptor> GetDescriptors();
    }
}
