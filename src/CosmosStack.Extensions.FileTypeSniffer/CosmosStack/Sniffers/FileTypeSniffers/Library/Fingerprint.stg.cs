using CosmosStack.Sniffers.FileTypeSniffers.Registering;

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("stg")]
    [FileTypeHex("4D 49 4C 20")]
    public class _Stg_Fingerprint : IFileTypeFingerprint { }
}