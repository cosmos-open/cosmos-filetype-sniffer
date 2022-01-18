using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("nes")]
    [FileTypeHex("4E 45 53 1A")]
    public class _Nes_Fingerprint : IFileTypeFingerprint { }
}