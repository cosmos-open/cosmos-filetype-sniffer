using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("flif")]
    [FileTypeHex("46 4C 49 46")]
    public class _Flif_Fingerprint : IFileTypeFingerprint { }
}