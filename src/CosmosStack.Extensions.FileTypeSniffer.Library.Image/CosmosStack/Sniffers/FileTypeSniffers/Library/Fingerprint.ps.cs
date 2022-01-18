using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("ps")]
    [FileTypeHex("25 21 50 53")]
    public class _Ps_Fingerprint : IFileTypeFingerprint { }
}