using System.Collections.Generic;

namespace Cosmos.Business.Extensions.FileTypeSniffers
{
    public interface IFileTypeSniffer
    {
        List<string> Match(byte[] data, bool matchAll = false);
    }
}
