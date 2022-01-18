using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("3g2")]
    [FileTypeHex("66 74 79 70 33 67")]
    [FileTypeOffset(4)]
    public class _3g2_Fingerprint : IFileTypeFingerprint { }
}