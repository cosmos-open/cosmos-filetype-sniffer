using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("tar")]
    [FileTypeHex("75 73 74 61 72")]
    [FileTypeOffset(257)]
    public class _Tar_Fingerprint : IFileTypeFingerprint { }
}