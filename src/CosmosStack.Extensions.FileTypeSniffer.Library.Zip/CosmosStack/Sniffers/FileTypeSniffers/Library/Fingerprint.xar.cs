using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("xar")]
    [FileTypeHex("78 61 72 21")]
    public class _Xar_Fingerprint : IFileTypeFingerprint { }
}