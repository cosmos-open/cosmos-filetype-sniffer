using System.Collections.Generic;
using Cosmos.Business.Extensions.FileTypeSniffers.Core;

namespace Cosmos.Business.Extensions.FileTypeSniffers
{
    public interface IFileTypeSniffer
    {
        List<string> Match(byte[] data, bool matchAll = false);
        List<string> Match(string filePath, int simpleLength, bool matchAll = false);

        SniffingReadOnlyMetadataStatistics GetMetadataStatistics();
    }
}