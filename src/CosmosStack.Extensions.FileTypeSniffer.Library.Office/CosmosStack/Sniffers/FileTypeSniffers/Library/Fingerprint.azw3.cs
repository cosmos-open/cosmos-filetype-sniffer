using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("azw3")]
    [FileTypeHex("00 00 42 4F 4F 4B 4D 4F 42 49")]
    [FileTypeOffset(58)]
    public class _Azw3_Fingerprint : IFileTypeFingerprint { }
}