using Cosmos.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("eddx")]
    [FileTypeHex("50 4B 03 14 00 08")]
    [FileTypeDescription("EDrawMax")]
    public class _Eddx_Fingerprint : IFileTypeFingerprint { }
}