using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("rpm")]
    [FileTypeHex("ed ab ee db")]
    public class _Rpm_Fingerprint : IFileTypeFingerprint { }
}