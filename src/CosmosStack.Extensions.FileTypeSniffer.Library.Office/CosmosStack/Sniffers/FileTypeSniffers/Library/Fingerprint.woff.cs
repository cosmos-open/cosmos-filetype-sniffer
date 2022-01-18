using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("woff")]
    [FileTypeHex("77 4F 46 46")]
    public class _Woff_Fingerprint : IFileTypeFingerprint { }
}