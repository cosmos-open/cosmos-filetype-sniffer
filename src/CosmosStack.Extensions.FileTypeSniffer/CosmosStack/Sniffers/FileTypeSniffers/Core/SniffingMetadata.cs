using System;
using System.Collections.Generic;
using System.Text;
using CosmosStack.Sniffers.FileTypeSniffers.Registering;

namespace CosmosStack.Sniffers.FileTypeSniffers.Core
{
    /// <summary>
    /// Sniffing Metadata <br />
    /// 嗅探元数据
    /// </summary>
    public class SniffingMetadata
    {
        // ReSharper disable once NotAccessedField.Local
        private readonly int _offset;
        private readonly List<SniffingOffset> _sniffingOffsets;
        private readonly string[] _hex;
        private readonly byte[] _hex2;
        private readonly List<string> _extensionNames;
        private static readonly char[] Separators = { ',', ' ' };

        internal SniffingMetadata(IFileTypeDescriptor descriptor, char[] separators)
        {
            if (descriptor == null)
                throw new ArgumentNullException(nameof(descriptor));

            _extensionNames = descriptor.ResolveExtensionNames(Separators.Join(separators));
            _offset = descriptor.Offset;
            _sniffingOffsets = new List<SniffingOffset>(4);

            if (descriptor.IsComplexMetadata)
            {
                _hex = descriptor.ResolveHex("??", Separators.Join(separators));
                _hex2 = null;
                SniffingOffsetsInitialize();
            }
            else
            {
                _hex = null;
                _hex2 = descriptor.Hex.GetByte();
            }

            IsComplexMetadata = descriptor.IsComplexMetadata;
        }

        private void SniffingOffsetsInitialize()
        {
            var lastCharIsQuestionMark = true;

            var start = 0;

            for (var i = 0; i < _hex.Length + 1; i++)
            {
                int length;
                if (i == _hex.Length)
                {
                    if (!lastCharIsQuestionMark)
                    {
                        length = i - start;
                        _sniffingOffsets.Add(SniffingOffset.Create(_hex, start, length));
                    }

                    break;
                }

                if (_hex[i] == "??")
                {
                    if (!lastCharIsQuestionMark)
                    {
                        length = i - start;
                        _sniffingOffsets.Add(SniffingOffset.Create(_hex, start, length));
                    }

                    lastCharIsQuestionMark = true;
                }
                else
                {
                    if (lastCharIsQuestionMark)
                    {
                        start = i;
                    }

                    lastCharIsQuestionMark = false;
                }
            }
        }

        /// <summary>
        /// Extension name <br />
        /// 扩展名
        /// </summary>
        public IReadOnlyList<string> ExtensionNames => _extensionNames;

        /// <summary>
        /// Gets as Hex <br />
        /// 以十六进制的方式获取
        /// </summary>
        public IReadOnlyList<string> Hex => _hex;

        /// <summary>
        /// Gets as Hex bytes <br />
        /// 以十六进制字节的方式获取
        /// </summary>
        public IReadOnlyList<byte> HexBytes => _hex2;

        /// <summary>
        /// Gets Offsets <br />
        /// 获取偏移量
        /// </summary>
        public IReadOnlyList<SniffingOffset> Offsets => _sniffingOffsets;

        /// <summary>
        /// Is complex metadata <br />
        /// 标记是否为复杂元数据
        /// </summary>
        public bool IsComplexMetadata { get; }

        /// <summary>
        /// Is matched <br />
        /// 是否命中
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool IsMatched(byte[] data)
        {
            foreach (var offset in _sniffingOffsets)
            {
                if (data.Length < offset.Start + offset.Length)
                    return false;
                if (offset.Value == Encoding.ASCII.GetString(data, offset.Start, offset.Length))
                    continue;
                return false;
            }

            return true;
        }
    }
}
