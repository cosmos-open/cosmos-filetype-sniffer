using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("mlv")]
    [FileTypeHex("4D 4C 56 49")]
    public class _Mlv_Fingerprint : IFileTypeFingerprint { }
}