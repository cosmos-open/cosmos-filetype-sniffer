using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("tbi")]
    [FileTypeHex("00 00 00 00 14 00 00 00")]
    public class _Tbi_Fingerprint : IFileTypeFingerprint { }
}