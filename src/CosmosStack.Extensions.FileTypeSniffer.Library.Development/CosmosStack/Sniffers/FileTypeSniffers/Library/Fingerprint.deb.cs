using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("deb")]
    [FileTypeHex("21 3C 61 72 63 68 3E")]
    public class _Deb_Fingerprint : IFileTypeFingerprint { }
}