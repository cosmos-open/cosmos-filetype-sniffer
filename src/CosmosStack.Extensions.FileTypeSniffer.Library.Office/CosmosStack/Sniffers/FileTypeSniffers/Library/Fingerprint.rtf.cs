using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("rtf")]
    [FileTypeHex("7B 5C 72 74 66 31")]
    public class _Rtf_Fingerprint : IFileTypeFingerprint { }
}