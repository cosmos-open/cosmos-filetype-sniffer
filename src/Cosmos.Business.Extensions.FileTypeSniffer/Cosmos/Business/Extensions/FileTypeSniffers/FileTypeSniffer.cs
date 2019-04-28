using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.FileTypeSniffers.Core;
using Cosmos.Business.Extensions.FileTypeSniffers.Core.Extensions;

namespace Cosmos.Business.Extensions.FileTypeSniffers
{
    public class FileTypeSniffer : IFileTypeSniffer
    {
        private readonly List<SniffingMetadata> _complexMetadata;
        private readonly SniffingMetadataStatistics _metadataStatistics;
        private SniffingNode _root;

        public FileTypeSniffer()
        {
            _root = new SniffingNode(default, -1)
            {
                Children = new SortedList<byte, SniffingNode>(128)
            };
            _complexMetadata = new List<SniffingMetadata>();
            _metadataStatistics = new SniffingMetadataStatistics();
        }

        public List<string> Match(byte[] data, bool matchAll = false)
        {
            var ret = _root.Match(0, data, matchAll);

            if (matchAll || !ret.Any())
            {
                ret.AddRange(_complexMetadata.Match(data, matchAll));
            }

            return ret.Distinct().ToList();
        }

        internal void Register(SniffingMetadata metadata)
        {
            if (metadata.IsComplexMetadata)
            {
                _complexMetadata.Add(metadata);
                _metadataStatistics.UpdateComplexMetadata(metadata.ExtensionNames.Count);
            }
            else
            {
                _root.Update(metadata.HexBytes, metadata.ExtensionNames, 0);
                _metadataStatistics.UpdateSimpleMetadata(metadata.ExtensionNames.Count);

            }
        }

        public SniffingReadOnlyMetadataStatistics GetMetadataStatistics() => new SniffingReadOnlyMetadataStatistics(_metadataStatistics);
    }
}
