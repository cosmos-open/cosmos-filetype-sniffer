using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("7z")]
    [FileTypeHex("37 7A BC AF 27 1C")]
    public class _7z_Fingerprint : IFileTypeFingerprint { }
}