using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("webm")]
    [FileTypeHex("1A 45 DF A3")]
    public class _WebM_Fingerprint : IFileTypeFingerprint { }
}