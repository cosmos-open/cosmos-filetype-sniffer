using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("zlib")]
    [FileTypeHex("78 01")]
    public class _Zlab_1_Fingerprint : IFileTypeFingerprint { }

    [FileTypeExtensionNames("zlib")]
    [FileTypeHex("78 9c")]
    public class _Zlab_2_Fingerprint : IFileTypeFingerprint { }

    [FileTypeExtensionNames("zlib")]
    [FileTypeHex("78 da")]
    public class _Zlab_3_Fingerprint : IFileTypeFingerprint { }
}