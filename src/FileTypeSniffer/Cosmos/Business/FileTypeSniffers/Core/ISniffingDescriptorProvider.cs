using System.Collections.Generic;
using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Core
{
    public interface ISniffingDescriptorProvider
    {
        IEnumerable<IFileTypeDescriptor> GetDescriptors();
    }
}
