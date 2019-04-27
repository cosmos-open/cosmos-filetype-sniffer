using System.Collections.Generic;
using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Core
{
    public interface ISniffingDescriptorProvider
    {
        IEnumerable<IFileTypeDescriptor> GetDescriptors();
    }
}
