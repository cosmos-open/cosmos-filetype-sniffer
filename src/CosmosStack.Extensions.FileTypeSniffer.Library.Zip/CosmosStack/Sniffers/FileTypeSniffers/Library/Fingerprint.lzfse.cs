using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("lzfse")]
    [FileTypeHex("62 76 78 32")]
    public class _Lzfse_Fingerprint : IFileTypeFingerprint { }
}