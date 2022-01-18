using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("mlv")]
    [FileTypeHex("4D 4C 56 49")]
    public class _Mlv_Fingerprint : IFileTypeFingerprint { }
}