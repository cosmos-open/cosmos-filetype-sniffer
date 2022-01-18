using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("cab")]
    [FileTypeHex("4D 53 43 46")]
    public class _Cab_Fingerprint : IFileTypeFingerprint { }
}