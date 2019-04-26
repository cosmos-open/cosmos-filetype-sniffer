using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.FileTypeSniffers.Core;
using Cosmos.Business.FileTypeSniffers.Core.Extensions;

namespace Cosmos.Business.FileTypeSniffers
{
    public class FileTypeSniffer : IFileTypeSniffer
    {
        private readonly List<SniffingMetadata> _complexMetadata;
        private SniffingNode _root;

        public FileTypeSniffer()
        {
            _root = new SniffingNode(default, -1)
            {
                Children = new SortedList<byte, SniffingNode>(128)
            };
            _complexMetadata = new List<SniffingMetadata>();
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
            }
            else
            {
                _root.Update(metadata.HexBytes, metadata.ExtensionNames, 0);
            }
        }
    }
}
