using System.Collections.Generic;

namespace Cosmos.Business.FileTypeSniffers
{
    public interface IFileTypeSniffer
    {
        List<string> Match(byte[] data, bool matchAll = false);
    }
}
