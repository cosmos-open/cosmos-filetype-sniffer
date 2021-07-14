using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("gz,tar.gz")]
    [FileTypeHex("1F 8B")]
    public class _Gz_Fingerprint : IFileTypeFingerprint { }
}