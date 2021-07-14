using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("cab")]
    [FileTypeHex("4D 53 43 46")]
    public class _Cab_Fingerprint : IFileTypeFingerprint { }
}