using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("png")]
    [FileTypeHex("89,50,4e,47,0d,0a,1a,0a")]
    public class _Png_Fingerprint : IFileTypeFingerprint { }
}
