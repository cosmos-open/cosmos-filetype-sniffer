using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("fh8")]
    [FileTypeHex("41 47 44 33")]
    public class _Fh8_Fingerprint : IFileTypeFingerprint { }
}