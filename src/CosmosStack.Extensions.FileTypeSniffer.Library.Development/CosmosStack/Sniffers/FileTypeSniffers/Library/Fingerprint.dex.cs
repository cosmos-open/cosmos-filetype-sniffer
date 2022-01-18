using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("dex")]
    [FileTypeHex("64 65 78 0A 30 33 35 00")]
    public class _Dex_Fingerprint : IFileTypeFingerprint { }
}