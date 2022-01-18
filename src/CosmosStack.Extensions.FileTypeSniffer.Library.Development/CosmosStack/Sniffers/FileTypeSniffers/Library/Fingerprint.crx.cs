using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("crx")]
    [FileTypeHex("43 72 32 34")]
    [FileTypeDescription("Google Chrome extensions file")]
    public class _Crx_Fingerprint : IFileTypeFingerprint { }
}