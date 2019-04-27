using System.Collections.Generic;
using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Core
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
