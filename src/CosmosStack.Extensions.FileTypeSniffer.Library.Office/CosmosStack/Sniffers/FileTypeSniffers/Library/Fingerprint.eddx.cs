using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("eddx")]
    [FileTypeHex("50 4B 03 14 00 08")]
    [FileTypeDescription("EDrawMax")]
    public class _Eddx_Fingerprint : IFileTypeFingerprint { }
}