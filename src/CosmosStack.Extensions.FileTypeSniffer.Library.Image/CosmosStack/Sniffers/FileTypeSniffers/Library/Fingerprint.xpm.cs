using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("xpm")]
    [FileTypeHex("2f 2a 20 58 50 4d 20 2a 2f 0a 73 74 61 74 69 63")]
    public class _Xpm_Fingerprint : IFileTypeFingerprint { }
}