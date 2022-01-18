using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("bmp")]
    [FileTypeHex("42 4D")]
    public class _Bmp_Fingerprint : IFileTypeFingerprint { }
}