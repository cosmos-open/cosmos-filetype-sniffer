using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("lz4")]
    [FileTypeHex("04 22 4D 18")]
    public class _Lz4_Fingerprint : IFileTypeFingerprint { }
}