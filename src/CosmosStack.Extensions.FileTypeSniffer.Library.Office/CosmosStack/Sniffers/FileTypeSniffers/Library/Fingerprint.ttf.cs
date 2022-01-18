using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("ttf")]
    [FileTypeHex("00 01 00 00 00")]
    public class _Ttf_Fingerprint : IFileTypeFingerprint { }
}