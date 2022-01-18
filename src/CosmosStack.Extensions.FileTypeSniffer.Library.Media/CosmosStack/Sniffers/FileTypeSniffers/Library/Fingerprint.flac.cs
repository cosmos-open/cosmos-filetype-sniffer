using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("flac")]
    [FileTypeHex("66 4C 61 43")]
    public class _Flac_Fingerprint : IFileTypeFingerprint { }
}