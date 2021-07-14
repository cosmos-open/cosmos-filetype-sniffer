using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("ico")]
    [FileTypeHex("00 00 01 00")]
    public class _Ico_Fingerprint : IFileTypeFingerprint { }
}