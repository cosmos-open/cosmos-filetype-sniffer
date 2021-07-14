using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("tif,tiff")]
    [FileTypeHex("49 49 2A 00")]
    public class _Tiff_1_Fingerprint : IFileTypeFingerprint { }
    
    [FileTypeExtensionNames("tif,tiff")]
    [FileTypeHex("4D 4D 00 2A")]
    public class _Tiff_2_Fingerprint : IFileTypeFingerprint { }
}