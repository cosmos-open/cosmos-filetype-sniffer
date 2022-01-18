using CosmosStack.Sniffers.FileTypeSniffers.Registering;

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("bac")]
    [FileTypeHex("42 41 43 4B 4D 49 4B 45 44 49 53 4B")]
    public class _Bac_Fingerprint : IFileTypeFingerprint { }
}