using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("class")]
    [FileTypeHex("CA FE BA BE")]
    public class _Class_Fingerprint : IFileTypeFingerprint { }
}