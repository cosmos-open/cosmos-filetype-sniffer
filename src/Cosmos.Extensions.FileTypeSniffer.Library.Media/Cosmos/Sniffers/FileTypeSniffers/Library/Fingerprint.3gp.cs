using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("3gp")]
    [FileTypeHex("66 74 79 70 33 67")]
    [FileTypeOffset(4)]
    public class _3gp_Fingerprint : IFileTypeFingerprint { }
}