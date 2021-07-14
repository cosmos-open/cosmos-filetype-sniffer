using System.Collections.Generic;
using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Core
{
    public static class FileTypeSnifferFactory
    {
        public static FileTypeSniffer Create(List<IFileTypeDescriptor> descriptors, char[] separators = null)
        {
            var sniffer = new FileTypeSniffer();
            foreach (var descriptor in descriptors)
            {
                sniffer.Register(new SniffingMetadata(descriptor, separators));
            }

            return sniffer;
        }
    }
}
