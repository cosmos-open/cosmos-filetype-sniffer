using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("lz")]
    [FileTypeHex("4C 5A 49 50")]
    [FileTypeDescription("Lzip Compressed File")]
    public class _Lz_Fingerprint : IFileTypeFingerprint { }
}