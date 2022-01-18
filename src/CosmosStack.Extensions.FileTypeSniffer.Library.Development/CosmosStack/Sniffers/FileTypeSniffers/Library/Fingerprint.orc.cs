using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("orc")]
    [FileTypeHex("4F 52 43")]
    public class _Orc_Fingerprint : IFileTypeFingerprint { }
}