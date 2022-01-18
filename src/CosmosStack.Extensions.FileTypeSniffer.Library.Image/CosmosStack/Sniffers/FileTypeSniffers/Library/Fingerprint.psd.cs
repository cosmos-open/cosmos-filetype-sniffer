using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("psd")]
    [FileTypeHex("38 42 50 53")]
    public class _Psd_Fingerprint : IFileTypeFingerprint { }
}