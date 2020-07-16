using System.Collections.Generic;
using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Core
{
    public interface ISniffingDescriptorProvider
    {
        IEnumerable<IFileTypeDescriptor> GetDescriptors();
    }
}
