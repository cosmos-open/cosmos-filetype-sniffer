using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("gz,tar.gz")]
    [FileTypeHex("1F 8B")]
    public class _Gz_Fingerprint : IFileTypeFingerprint { }
}