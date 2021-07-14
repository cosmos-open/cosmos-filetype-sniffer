using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("flif")]
    [FileTypeHex("46 4C 49 46")]
    public class _Flif_Fingerprint : IFileTypeFingerprint { }
}